using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_TaiKhoan_TaiKhoan_HienThi : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            LayTaiKhoan();
    }

    private void LayTaiKhoan()
    {
        string sql = "select * from Dangky ";
        String connection = @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=QuanlyBanHang;Integrated Security=True";
        SqlConnection con = new SqlConnection(connection);
        SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
        DataTable table = new DataTable();
        adapter.Fill(table);
        for (int i = 0; i < table.Rows.Count; i++)
        {
            ltrTaiKhoan.Text += @"
           <tr id='maDong_" + table.Rows[i]["TenDN"] + @"'>
               <td class='cotTenDK'>" + table.Rows[i]["TenDN"] + @"</td>
               <td class='cotEmail'>" + table.Rows[i]["Email"] + @"</td>
               <td class='cotDiaChia'>" + table.Rows[i]["DiaChi"] + @"</td>
               <td class='cotHoTen'>" + table.Rows[i]["TenDayDu"] + @"</td>
               <td class='cotNgaySinh'>" + table.Rows[i]["NgaySinh"] + @"</td>
               <td class='cotCongCu'>
                   <a href=javascript:XoaTaiKhoan('" + table.Rows[i]["TenDN"] + @"') class='xoa' title='Xóa'></a>
               </td>
       </tr>
";
        }
    }
}