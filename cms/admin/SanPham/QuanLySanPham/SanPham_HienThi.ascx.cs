using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_SanPham_QuanLySanPham_SanPham_HienThi : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LaySanPham();
        }
    }

    private void LaySanPham()
    {
        string sql = "select * from SanPhamDM ";
        String connection = @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=QuanlyBanHang;Integrated Security=True";
        SqlConnection con = new SqlConnection(connection);
        SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
        DataTable table = new DataTable();
        adapter.Fill(table);
        for (int i = 0; i < table.Rows.Count; i++)
        {
            ltrSanPham.Text += @"
            <tr id='maDong_" + table.Rows[i]["MaSP"] + @"'>
                <td class='cotMa'>" + table.Rows[i]["MaSP"] + @"</td>
                <td class='cotTen'>" + table.Rows[i]["TenSP"] + @"</td>
                <td class='cotAnh'>
                    <img class='anhDaiDien' src='/images/" + table.Rows[i]["HinhAnh"] + @"'/>
                    <img class='anhDaiDienHover'src='/images/" + table.Rows[i]["HinhAnh"] + @"'/>
                </td>
                <td class='cotSoLuong'>" + table.Rows[i]["Soluong"] + @"</td>
               <td class='cotDonGia'>" + table.Rows[i]["Gia"] + @"</td>
                <td class='cotCongCu'>
                    <a href ='javascript:XoaSanPham(" + table.Rows[i]["MaSP"] + @")' class='xoa'  title='Xóa'></a>
                </td>
            </tr>
        ";
        }
    }
}