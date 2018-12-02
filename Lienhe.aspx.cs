using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Lienhe : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnGui_Click(object sender, EventArgs e)
    {
        String connection = @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=QuanlyBanHang;Integrated Security=True";
        SqlConnection con = new SqlConnection(connection);
        SqlCommand cmd = new SqlCommand("insert into Lienhe(TenKH,Email,Tieude,Noidung) values('" + txtHoten.Text + "','" + txtEmail.Text + "','" + txtTieude.Text + "','" + txtNoidung.Text + "')", con);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
    }
}