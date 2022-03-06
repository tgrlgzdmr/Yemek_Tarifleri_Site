using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class YorumDetay : System.Web.UI.Page
{

    SqlSinif bgl = new SqlSinif();
    string id = "";
    //string yemek = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        id=Request.QueryString["Yorumid"];

        SqlCommand cmd = new SqlCommand("select YorumAdSoyad, YorumMail,Yorumicerik,YemekAd from Tbl_Yorumlar inner join Tbl_Yemekler on Tbl_Yorumlar.Yemekid=Tbl_Yemekler.Yemekid where Yorumid=@p1",bgl.baglanti());
        cmd.Parameters.AddWithValue("@p1", id);
        SqlDataReader dr = cmd.ExecuteReader();
        while(dr.Read())
        {
            TxtAdSoyad.Text=dr[0].ToString();
            TxtMail.Text=dr[1].ToString();
            Txticerik.Text=dr[2].ToString();
            TxtYemek.Text=dr[3].ToString();
            //yemek=dr[6].ToString();
        }
        bgl.baglanti().Close();

        //SqlCommand cmd1 = new SqlCommand("Select YemekAd from Tbl_Yemekler where Yemekid=@p2", bgl.baglanti());
        //cmd1.Parameters.AddWithValue("@p2", yemek);
        //SqlDataReader dr1 = cmd1.ExecuteReader();
        //while( dr1.Read())
        //{
        //    TxtYemek.Text=dr1[0].ToString();
        //}
        //bgl.baglanti().Close();

    }

    protected void BtnOnay_Click(object sender, EventArgs e)
    {
        SqlCommand cmd1 = new SqlCommand("update Tbl_Yorumlar set YorumOnay=1 where Yorumid=@p1", bgl.baglanti());
        cmd1.Parameters.AddWithValue("@p1", id);
        cmd1.ExecuteNonQuery();
        bgl.baglanti().Close();
    }
}