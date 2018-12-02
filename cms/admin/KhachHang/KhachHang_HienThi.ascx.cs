using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_KhachHang_KhachHang_HienThi : System.Web.UI.UserControl
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
        string sql = "select * from Khachhang ";
        String connection = @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=QuanlyBanHang;Integrated Security=True";
        SqlConnection con = new SqlConnection(connection);
        SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
        DataTable table = new DataTable();
        adapter.Fill(table);
        for (int i = 0; i < table.Rows.Count; i++)
        {
            ltrKhachHang.Text += @"
                <tr id='maDong_" + table.Rows[i]["ID"] + @"'>
                    <td class='cotMa'>" + table.Rows[i]["ID"] + @"</td>
                    <td class='cotTen'>" + table.Rows[i]["TenKH"] + @"</td>
                     <td class='cotAnh'>" + table.Rows[i]["Diachi"] + @"</td>
                    <td class='cotThuTu'>" + table.Rows[i]["SDT"] + @"</td>
                    <td class='cotEmail'>" + table.Rows[i]["Email"] + @"</td>
                </tr>
            ";
        }
    }
}