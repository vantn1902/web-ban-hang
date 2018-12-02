using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Giohang : System.Web.UI.Page
{
    string stcn = @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=QuanlyBanHang;Integrated Security=True";
    protected void Page_Load(object sender, EventArgs e)
    {
       
        if (Page.IsPostBack)  Response.Redirect("Banhang.aspx");
        if (Request.Cookies["TenDangNhap"] == null)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "", "alert('Bạn phải đăng nhập khi mua hàng');location.href = 'Dangnhap.aspx';", true);
            return;
        }
        //location.href = 'Dangnhap.aspx';
    }
}