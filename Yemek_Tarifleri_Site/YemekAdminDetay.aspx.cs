using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class YemekAdminDetay : System.Web.UI.Page
{
    SqlSinif bgl = new SqlSinif();
    string id;
    protected void Page_Load(object sender, EventArgs e)
    {
        id=Request.QueryString["Yemekid"];
        if (Page.IsPostBack == false)
        {

            SqlCommand cmd3 = new SqlCommand("select * from Tbl_Kategoriler", bgl.baglanti());
            SqlDataReader dr1 = cmd3.ExecuteReader();
            DrpKategori.DataTextField = "KategoriAd";
            DrpKategori.DataValueField = "Kategoriid";
            DrpKategori.DataSource = dr1;
            DrpKategori.DataBind();


            SqlCommand cmd = new SqlCommand("Select * from Tbl_Yemekler where Yemekid=@p1", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1",id);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                TxtAd.Text=dr[1].ToString();
                TxtMalzeme.Text=dr[2].ToString();
                TxtTarif.Text=dr[3].ToString();
                //Fikon.FileName = dr[4].ToString();
                DrpKategori.Text=dr[7].ToString();
            }
            bgl.baglanti().Close();
        }
    }

    protected void BtnEkle_Click(object sender, EventArgs e)
    {
        SqlCommand cmd2=new SqlCommand("update Tbl_Yemekler set YemekAd=@p1, YemekMalzeme=@p2, YemekTarif=@p3, YemekResim=@p4, Kategoriid=@p5 where Yemekid=@p6",bgl.baglanti());
        cmd2.Parameters.AddWithValue("@p1", TxtAd.Text);
        cmd2.Parameters.AddWithValue("@p2", TxtMalzeme.Text);
        cmd2.Parameters.AddWithValue("@p3", TxtTarif.Text);
        cmd2.Parameters.AddWithValue("@p4", Fikon.FileName);
        cmd2.Parameters.AddWithValue("@p5", DrpKategori.SelectedValue);
        cmd2.Parameters.AddWithValue("@p6", id);
        cmd2.ExecuteNonQuery();
        bgl.baglanti().Close();

    }
}