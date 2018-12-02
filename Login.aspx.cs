using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void lbtDangNhap_Click(object sender, EventArgs e)
    {
        string sql = "select * from Dangky where TenDN='{0}' and MatKhau='{1}'";
        sql = String.Format(sql, tbTenDangNhap.Text, tbMatKhau.Text);
        String connection = @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=QuanlyBanHang;Integrated Security=True";

        SqlConnection con = new SqlConnection(connection);

        SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
        DataTable table = new DataTable();
        adapter.Fill(table);
        if (table.Rows.Count == 0)
        {
            ltrThongBao.Text = "Đăng nhập không thành công";
        }
        else
        {
            Session["DangNhap"] = "1";
            Session["TenDangNhap"] = table.Rows[0]["TenDayDu"];
            Response.Redirect("Admin.aspx");
        }
    }

   
}