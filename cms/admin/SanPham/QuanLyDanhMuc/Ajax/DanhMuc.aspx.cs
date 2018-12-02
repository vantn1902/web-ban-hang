using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_SanPham_QuanLyDanhMuc_Ajax_DanhMuc : System.Web.UI.Page
{
    string thaotac = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        //Code kiểm tra đăng nhập
        //Code thao tác dưới
        if (Request.Params["ThaoTac"] != null)
            thaotac = Request.Params["ThaoTac"];
        switch(thaotac)
        {
            case "XoaDanhMuc":
                XoaDanhMuc();
                break;
        }
    }

    private void XoaDanhMuc()
    {
        string MaDM = "";
        if (Request.Params["MaDM"] != null)
            MaDM = Request.Params["MaDM"];
        //Code xóa
        String connection = @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=QuanlyBanHang;Integrated Security=True";
        SqlConnection con = new SqlConnection(connection);
        SqlCommand cmd = new SqlCommand("delete from DanhMuc  where MaDM='" + MaDM + "'", con);
        con.Open(); // mo ket noi
        cmd.ExecuteNonQuery(); // thuc thi
        con.Close();
        
        //Trả về thông báo
        Response.Write("1");
    }
}