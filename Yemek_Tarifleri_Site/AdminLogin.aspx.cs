using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class AdminLogin : System.Web.UI.Page
{
    SqlSinif bgl = new SqlSinif();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BtnGiris_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("Select * from Tbl_Admin where Ad=@p1 and Sifre=@p2",bgl.baglanti());
        cmd.Parameters.AddWithValue("@p1",TxtKAd.Text);
        cmd.Parameters.AddWithValue("@p2", TxtSifre.Text);
        SqlDataReader dr = cmd.ExecuteReader();
        if(dr.Read())
        {
            Response.Redirect("Kategoriler.aspx");
        }
        else
        {
            Response.Write("Hatalı Kullanıcı Adı Veya Şifre");
        }
    }
}