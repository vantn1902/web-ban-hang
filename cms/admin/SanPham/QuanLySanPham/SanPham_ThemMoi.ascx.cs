using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_SanPham_QuanLySanPham_SanPham_ThemMoi : System.Web.UI.UserControl
{

    protected void Page_Load(object sender, EventArgs e)
    {

      if (!IsPostBack)
       {
           LayDanhMucCha();
       }

    }

    private void LayDanhMucCha()
    {
        string sql = "select * from DanhMucHang ";
        String connection = @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=QuanlyBanHang;Integrated Security=True";
        SqlConnection con = new SqlConnection(connection);
        SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
        DataTable table = new DataTable();
        adapter.Fill(table);
        ddlDanhMucCha.Items.Clear();


        for (int i = 0; i < table.Rows.Count; i++)
        {
            ddlDanhMucCha.Items.Add(new ListItem(table.Rows[i]["TenDM"].ToString(), table.Rows[i]["MaDM"].ToString()));
           
        }

    }


    protected void btThemMoi_Click1(object sender, EventArgs e)
    {
        if (flAnhDaiDien.FileContent.Length > 0)
        {
            if (flAnhDaiDien.FileName.EndsWith(".jpg") || flAnhDaiDien.FileName.EndsWith(".png") || flAnhDaiDien.FileName.EndsWith(".gif"))
            {
                flAnhDaiDien.SaveAs(Server.MapPath("images/AnhSP/") + flAnhDaiDien.FileName);
            }
            String connection = @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=QuanlyBanHang;Integrated Security=True";
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("insert into SanPhamDM(TenSP,HinhAnh,Mota,Soluong,Gia,MaDM) values(N'" + tbTenSanPham.Text + "','" + flAnhDaiDien.FileName + "','" + tbMoTa.Text + "','" + tbSoLuong.Text + "','" + tbGiaBan.Text + "','" + ddlDanhMucCha.SelectedValue.ToString() + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            
            ltrThongBao.Text = "<div class='thongBaoTaoThanhCong'>Đã tạo sản phẩm : " + tbTenSanPham.Text + "</div>";
            if (cbThemNhieuDanhMuc.Checked)
            {
                //Code xử lí xóa để dùng nhập danh mục tiếp theo
                ResetControl();
            }
            else
            {
                //Đẩy trang đã tạo
                Response.Redirect("/Admin.aspx?modul=SanPham&modulphu=DanhSachSanPham");
            }

        }
    }
    protected void btHuy_Click1(object sender, EventArgs e)
    {
        ResetControl();
    }


    private void ResetControl()
    {
        tbTenSanPham.Text = "";
        tbSoLuong.Text = "";
        tbGiaBan.Text = "";
        tbMoTa.Text = "";
    }
}