using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_SanPham_SanPhamLoadControl : System.Web.UI.UserControl
{
    private string modulphu = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["modulphu"] != null)
            modulphu = Request.QueryString["modulphu"];
        switch (modulphu)
        {
            case "DanhMuc":
                plSanPhamLoadControl.Controls.Add(LoadControl("QuanLyDanhMuc/DanhMucLoadControl.ascx"));
                break;

            case "DanhSachSanPham":
                plSanPhamLoadControl.Controls.Add(LoadControl("QuanLySanPham/SanPhamLoadControl.ascx"));
                break;
            default:
                plSanPhamLoadControl.Controls.Add(LoadControl("QuanLyDanhMuc/DanhMucLoadControl.ascx"));
                break;

        }

    }
}
