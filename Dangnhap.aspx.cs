using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Dangnhap : System.Web.UI.Page
{
    String connection = @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=QuanlyBanHang;Integrated Security=True";
    protected void Page_Load(object sender, EventArgs e)
    {

    }
   
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //Kiểm tra database
        string sql = "select * from Khachhang where TenKH='{0}' and Matkhau='{1}'";
        sql = String.Format(sql, txtMaKH.Text, txtMatkhau.Text);
        String connection = @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=QuanlyBanHang;Integrated Security=True";

        SqlConnection con = new SqlConnection(connection);

        SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
        DataTable table = new DataTable();
        adapter.Fill(table);
        if (table.Rows.Count == 0)
        {
            Label1.Text = "Đăng nhập không thành công";
        }
        else
        {
            //Label1.Text = "Đăng nhập thành công. Chào: " + table.Rows[0]["TenKH"];
           Session["DangNhap"] = "1";
            Session["TenDangNhap"] = table.Rows[0]["TenKH"];
          
            Response.Redirect("Banhang.aspx");
        }
        /*string ten = this.txtMaKH.Text;
        string mk = this.txtMatkhau.Text;
        string sql = "select * from Khachhang where TenKH= '" + ten + "' and Matkhau='" + mk + "'";
        DataTable tb = new DataTable();
        try
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            da.Fill(tb);
        }
        catch(SqlException err)
        {
            Response.Write(err.Message);
        }
        if(tb.Rows.Count!=0)
        {
            Response.Cookies["TenDangNhap"].Value = ten;
            Label1.Text = "Đăng nhập thành công. Chào: " + tb.Rows[0]["TenKH"];
           // Server.Transfer("Default.aspx");
        }
        else
        {
            this.Label1.Text = "Tên đăng nhập hay mật khẩu không đúng!";
        }*/
    }
}