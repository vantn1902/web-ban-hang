using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_SanPham_QuanLyDanhMuc_DanhMuc_HienThi : System.Web.UI.UserControl
{
    string madmcha = "0";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["madmcha"] != null)
            madmcha = Request.QueryString["madmcha"];
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
        for (int i = 0; i < table.Rows.Count; i++)
        {
            ltrDanhMuc.Text += @"
            <tr id='maDong_" + table.Rows[i]["MaDM"] + @"'>
                <td class='cotMa'>" + table.Rows[i]["MaDM"]+ @"</td>
                <td class='cotTen'>" + table.Rows[i]["TenDM"] + @"</td>
                <td class='cotAnh'>
                    <img class='anhDaiDien' src='images/anhloai/" + table.Rows[i]["AnhDaiDien"] + @"'/>
                    <img class='anhDaiDienHover'src='images/anhloai/" + table.Rows[i]["AnhDaiDien"] + @"'/>
                </td>
                <td class='cotThuTu'>" + table.Rows[i]["ThuTu"] + @"</td>
                <td class='cotCongCu'>
                    <a href ='javascript:XoaDanhMuc(" + table.Rows[i]["MaDM"]+@")' class='xoa'  title='Xóa'></a>
                </td>
            </tr>
        ";
        }
    }
}