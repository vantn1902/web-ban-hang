using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Dangki : System.Web.UI.Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    
    protected void btnDangky_Click(object sender, EventArgs e)
    {
        if(IsValid)
        {
            string connection = @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=QuanlyBanHang;Integrated Security=True";
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("insert into Khachhang(TenKH,SDT,Diachi,Email,Matkhau) values(N'" + txtHoten.Text + "','" + txtSdt.Text + "','" + txtDiachi.Text + "','" + txtEmail.Text + "','" + txtPass.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "", "alert('Bạn vừa đăng kí thành công. Bạn có thể đăng nhập với tên và mật khẩu vừa tạo');location.href='/Dangnhap.aspx';", true);
        }



    }

   
}