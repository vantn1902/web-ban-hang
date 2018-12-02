using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Banhang : System.Web.UI.Page
{
    String connection = @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=QuanlyBanHang;Integrated Security=True";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack) return;
        if (Session["DangNhap"] != null && Session["DangNhap"].ToString() == "1")
        {
            return;
        }
        else
        {
            Response.Redirect("Giohang.aspx");
        }
        ltrTenDangNhap.Text = Session["TenKH"].ToString();
        string ten = Request.Cookies[" DangNhap"].Value;
        try
        {
            string q = "select MaSP,TenSP,Soluong,DonGia,Soluong*DonGia as Thanhtien from Giohang,SanPhamDM where SanPhamDM.MaSP = DanhMucHang=MaSp";
            SqlDataAdapter da = new SqlDataAdapter(q, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.GridView1.DataSource = dt; this.GridView1.DataBind();
            double tong = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                double thanhtien = double.Parse(dt.Rows[i]["Thanhtien"].ToString());
                tong = tong + thanhtien;
            }
            this.Label1.Text = "Tổng Thành Tiền: " + tong + " đồng";
        }
        catch (SqlException ex)
        {
            Response.Write(ex.Message);
        }

    }

    protected void lbtDangXuat_Click(object sender, EventArgs e)
    {
        Session["DangNhap"] = null;
        Session["TenDangNhap"] = null;
        Response.Redirect("Default.aspx");
    }
    /*string ten = Request.Cookies["TenDangNhap"].Value;
        try
        {
            string q = "select MaSP,TenSP,Soluong,DonGia, Soluong*DonGia AS Thanhtien from Giohang,Khachhang where Giohang.MaKH=Khachhang.ID and TenKH = '" + ten + "'";
    SqlDataAdapter da = new SqlDataAdapter(q, stcn);
    DataTable dt = new DataTable();
    da.Fill(dt);
            this.GridView1.DataSource = dt; this.GridView1.DataBind();
            double tong = 0;
            for (int i = 0; i<dt.Rows.Count; i++)
            {
                double thanhtien = double.Parse(dt.Rows[i]["ThanhTien"].ToString());
    tong = tong + thanhtien;
            }
            this.Label1.Text = "Tổng Thành Tiền: " + tong + " đồng";
        }
        catch (SqlException ex)
        {
            Response.Write(ex.Message);
        }*/
}