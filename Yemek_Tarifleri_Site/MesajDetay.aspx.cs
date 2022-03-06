using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class MesajDetay : System.Web.UI.Page
{
    SqlSinif bgl = new SqlSinif();
    string id = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        id=Request.QueryString["Mesajid"];

        SqlCommand cmd = new SqlCommand("select * from Tbl_Mesajlar where Mesajid=@p1",bgl.baglanti());
        cmd.Parameters.AddWithValue("@p1", id);
        SqlDataReader dr = cmd.ExecuteReader();
        while(dr.Read())
        {
            TxtGonderen.Text=dr[1].ToString();
            TxtBaslik.Text=dr[2].ToString();
            TxtMail.Text=dr[3].ToString();
            Txticerik.Text=dr[4].ToString();
            LblTarih.Text=dr[5].ToString();
        }
        bgl.baglanti().Close();


    }
}