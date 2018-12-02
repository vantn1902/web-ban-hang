using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_TaiKhoan_TaiKhoan_ThemMoi : System.Web.UI.UserControl
{
    private string thaotac = "";
    private string id = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["thaotac"] != null)
            thaotac = Request.QueryString["thaotac"];
        if (Request.QueryString["id"] != null)
            id = Request.QueryString["id"];
        if (!IsPostBack)
        {

            LayQuyenDangNhap();

            HienThiThongTin(id);
        }
    }

    private void HienThiThongTin(string id)
    {
        if (thaotac == "ChinhSua")
        {
            btThemMoi.Text = "Chỉnh Sửa";
            cbThemNhieuDanhMuc.Visible = false;
            tbTenDangNhap.Enabled = false;

            string sql = "select * from Dangky ";
            String connection = @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=QuanlyBanHang;Integrated Security=True";
            SqlConnection con = new SqlConnection(connection);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                ddlQuyenDangNhap.SelectedValue = table.Rows[0]["MaQuyen"].ToString();
                tbTenDangNhap.Text = table.Rows[0]["TenDN"].ToString();
                tbEmail.Text = table.Rows[0]["Email"].ToString();
                tbDiaChi.Text = table.Rows[0]["Diachi"].ToString();
                tbHoTen.Text = table.Rows[0]["TenDayDu"].ToString();
                tbNgaySinh.Text = table.Rows[0]["NgaySinh"].ToString();

                //lưu lại mật khẩu cũ vào trường ẩn để lấy lại khi ko cập nhật mật khẩu mới
                hdMatKhauCu.Value = table.Rows[0]["MatKhau"].ToString();
                // bỏ yêu cầu bắt buộc nhập mật khẩu khi cập nhật
              
            }
        }

        else
        {
            btThemMoi.Text = "Thêm Mới";
            cbThemNhieuDanhMuc.Visible = true;
        }

    }


    private void LayQuyenDangNhap()
    {
        string sql = "select * from Phanquyen ";
        String connection = @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=QuanlyBanHang;Integrated Security=True";
        SqlConnection con = new SqlConnection(connection);
        SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
        DataTable table = new DataTable();
        adapter.Fill(table);
        ddlQuyenDangNhap.Items.Clear();
        for (int i = 0; i < table.Rows.Count; i++)
        {
            ddlQuyenDangNhap.Items.Add(new ListItem(table.Rows[i]["TenQuyen"].ToString(), table.Rows[i]["MaQuyen"].ToString()));

        }
    }

    protected void btThemMoi_Click(object sender, EventArgs e)
    {
        if (thaotac == "ThemMoi")
        {
            #region code nút thêm mới

            String connection = @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=QuanlyBanHang;Integrated Security=True";
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("insert into Dangky(TenDN,MatKhau,Email,DiaChi,TenDayDu,NgaySinh,MaQuyen) values(N'" + tbTenDangNhap.Text + "','" + tbMatKhau.Text + "','" + tbEmail.Text + "','" + tbDiaChi.Text + "','" + tbHoTen.Text + "','" + tbNgaySinh.Text + "','" + ddlQuyenDangNhap.SelectedValue.ToString() + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            ltrThongBao.Text = "<div class='thongBaoTaoThanhCong' style='color:#ff006e;font-size:16px;padding-bottom:20px;text-align:center;font-weight:bold'>Đã tạo tài khoản: " + tbTenDangNhap.Text + "</div>";

            if (cbThemNhieuDanhMuc.Checked)
            {
                //viết code xử lý xóa mục đã nhập để người dùng nhập danh mục tiếp theo
                ResetControl();
            }

            else
            {
                //đẩy trang về trang danh sách các damnh mục đã tạo

                Response.Redirect("Admin.aspx?modul=TaiKhoan&modulphu=DanhSachTaiKhoan");
            }
            #endregion
        }
        else
        {
            #region code nút chỉnh sửa

            //Mã hóa mật khẩu trước khi thêm vào database
            String connection = @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=QuanlyBanHang;Integrated Security=True";
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("update Dangky set MaQuyen='" + ddlQuyenDangNhap.SelectedValue.ToString() + "',MatKhau=" + tbMatKhau.Text + ",Email='" + tbEmail.Text + "',Diachi='" + tbDiaChi.Text + "',TenDayDu='" + tbHoTen.Text + "',NgaySinh='" + tbNgaySinh.Text + "'  where TenDN='" + tbTenDangNhap.Text + "'", con);
            con.Open(); // mo ket noi
            cmd.ExecuteNonQuery(); // thuc thi
            con.Close();

            //đẩy trang về trang danh sách các damnh mục đã tạo
            Response.Redirect("Admin.aspx?modul=TaiKhoan&modulphu=DanhSachTaiKhoan");

            #endregion
        }
    }

    private void ResetControl()
    {
        tbTenDangNhap.Text = "";
        tbMatKhau.Text = "";
        tbEmail.Text = "";
        tbDiaChi.Text = "";
        tbHoTen.Text = "";
        tbNgaySinh.Text = "";
    }

    protected void btHuy_Click(object sender, EventArgs e)
    {
        ResetControl();
    }
}