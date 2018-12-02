using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DanhSachSanPham : System.Web.UI.Page
{
    string stcn = @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=QuanlyBanHang;Integrated Security=True";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack) return;
        string q = "";
        if (Context.Items["ml"] == null) q = "select * from SanPhamDM";
        else
        {
            string maloai = Context.Items["ml"].ToString();
            q = "select * from SanPhamDM where MaDM ='" + maloai + "'";
        }
        try
        {
            SqlDataAdapter da = new SqlDataAdapter(q, stcn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            /*this.DataList2.DataSource = dt;
            this.DataList2.DataBind();*/
        }
        catch (SqlException ex)
        {
            Response.Write(ex.Message);
        }
    }


    
    protected void lbtGia_Click(object sender, EventArgs e)
    {
        string mahang = ((LinkButton)sender).CommandArgument;
        Context.Items["mh"] = mahang;
        Response.Redirect("ChiTietSanPham.aspx");
    }

    protected void lbtMuahang_Click(object sender, EventArgs e)
    {
        Response.Redirect("Dangnhap.aspx");
    }

    protected void imgHinhAnh_Click(object sender, ImageClickEventArgs e)
    {
        string mahang = ((ImageButton)sender).CommandArgument;
        Context.Items["mh"] = mahang;
        Response.Redirect("ChiTietSanPham.aspx");
    }

    protected void lbtTenSP_Click(object sender, EventArgs e)
    {
        string mahang = ((LinkButton)sender).CommandArgument;
        Context.Items["mh"] = mahang;
        Response.Redirect("ChiTietSanPham.aspx");
    }
}