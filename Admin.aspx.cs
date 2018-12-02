using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["DangNhap"]!=null && Session["DangNhap"].ToString()=="1")
        {
            
        }
        else
        {
            Response.Redirect("Login.aspx");
        }
        if (!IsPostBack)
            ltrTenDangNhap.Text = Session["TenDangNhap"].ToString();
    }

    protected void lbtDangXuat_Click(object sender, EventArgs e)
    {
        //Xóa các session đã lưu
        Session["DangNhap"] = null;
        Session["TenDangNhap"] = null;
        //đẩy về trang login
        Response.Redirect("Login.aspx");
    }
}