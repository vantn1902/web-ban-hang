using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ChiTietSanPham : System.Web.UI.Page
{
    String connection = @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=QuanlyBanHang;Integrated Security=True";
    protected void Page_Load(object sender, EventArgs e)
    {

    }



    protected void btnMua_Click(object sender, EventArgs e)
    {
        Button mua = (Button)sender;
        string mahang = mua.CommandArgument.ToString();
        DataListItem item = (DataListItem)mua.Parent;
        string soluong = ((TextBox)item.FindControl("TextBox1")).Text;
        if (Request.Cookies["tendangnhap"] == null) return;
        string ten = Request.Cookies["tendangnhap"].Value;
        SqlConnection con = null;
        try
        {
            con = new SqlConnection(connection);
            con.Open();
            string query = "select * from donhang where tendangnhap = '" + ten + "' and mahang = '" + mahang + "'";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                reader.Close();
                command = new SqlCommand("update donhang set soluong = soluong +" + soluong + "where tendangnhap = '" + ten + "'and mahang = '" + mahang + "'", con);
            }
            else
            {
                reader.Close();
                command = new SqlCommand("insert into donhang(tendangnhap,mahang,soluong) values ('" + ten + "','" + mahang + "'," + soluong + ")", con);
            }
            command.ExecuteNonQuery();
        }
        catch (SqlException err)
        {
            Response.Write(err.Message);
        }
        finally { con.Close(); }
    }
}