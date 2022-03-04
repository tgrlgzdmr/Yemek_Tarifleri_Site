using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Iletisim : System.Web.UI.Page
{
    SqlSinif bgl = new SqlSinif();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BtnGonder_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("insert into Tbl_Mesajlar (MesajGonderen, MesajBaslik, MesajMail, Mesajicerik) values (@p1,@p2,@p3,@p4)",bgl.baglanti());
        cmd.Parameters.AddWithValue("@p1", TxtAdSoyad.Text);
        cmd.Parameters.AddWithValue("@p2", TxtKonu.Text);
        cmd.Parameters.AddWithValue("@p3", TxtMail.Text);
        cmd.Parameters.AddWithValue("@p4", TxtMesaj.Text);
        cmd.ExecuteNonQuery();
        bgl.baglanti().Close();
    }
}