using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class Yemekler : System.Web.UI.Page
{
    SqlSinif bgl = new SqlSinif();
    string id = "";
    string islem = "";
    string sayi;
    string kate;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if(Page.IsPostBack==false)
        {
            
            id =Request.QueryString["Yemekid"];
            islem = Request.QueryString["islem"];
            kate = Request.QueryString["Kategoriid"];
            
            //Kategori Listesi
            SqlCommand cmd3 = new SqlCommand("select * from Tbl_Kategoriler", bgl.baglanti());
            SqlDataReader dr = cmd3.ExecuteReader();
            DrpKategori.DataTextField = "KategoriAd";
            DrpKategori.DataValueField = "Kategoriid";
            DrpKategori.DataSource = dr;
            DrpKategori.DataBind();
        }

        

        //Yemekler
        SqlCommand cmd = new SqlCommand("Select * from Tbl_Yemekler",bgl.baglanti());
        SqlDataReader oku = cmd.ExecuteReader();
        DataList1.DataSource = oku;
        DataList1.DataBind();


        Panel2.Visible = false;
        Panel4.Visible = false;

        if(islem=="sil")
        {
            SqlCommand cmd7 = new SqlCommand("Select Kategoriid from Tbl_Yemekler where Yemekid=@p2", bgl.baglanti());
            cmd7.Parameters.AddWithValue("@p2", id);
            SqlDataReader kat = cmd7.ExecuteReader();
            while (kat.Read())
            {
                kate = kat[0].ToString();
            }
            bgl.baglanti().Close();

            SqlCommand cmd4 = new SqlCommand("delete from Tbl_Yemekler where Yemekid=@p1", bgl.baglanti());
            cmd4.Parameters.AddWithValue("@p1",id);
            cmd4.ExecuteNonQuery();
            bgl.baglanti().Close();

            

            SqlCommand cmd1 = new SqlCommand("select count(*) from Tbl_Yemekler where Kategoriid=@p6", bgl.baglanti());
            cmd1.Parameters.AddWithValue("@p6", kate);
            SqlDataReader say = cmd1.ExecuteReader();
            while (say.Read())
            {
                sayi = say[0].ToString();
            }
            bgl.baglanti().Close();

            SqlCommand cmd5 = new SqlCommand("update Tbl_Kategoriler set KategoriAdet=@p7 where Kategoriid=@p8", bgl.baglanti());
            cmd5.Parameters.AddWithValue("@p7", sayi);
            cmd5.Parameters.AddWithValue("@p8", kate);
            cmd5.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Panel2.Visible = true;

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Panel2.Visible = false;
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Panel4.Visible = true;
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Panel4.Visible = false;
    }

    protected void BtnEkle_Click(object sender, EventArgs e)
    {
        SqlCommand cmd2 = new SqlCommand("insert into Tbl_Yemekler (YemekAd, YemekMalzeme, YemekTarif, YemekResim, Kategoriid) values (@p1, @p2, @p3, @p4, @p5)", bgl.baglanti());
        cmd2.Parameters.AddWithValue("@p1",TxtAd.Text);
        cmd2.Parameters.AddWithValue("@p2",TxtMalzeme.Text);
        cmd2.Parameters.AddWithValue("@p3",TxtTarif.Text);
        cmd2.Parameters.AddWithValue("@p4",Fikon.FileName);
        cmd2.Parameters.AddWithValue("@p5",DrpKategori.SelectedValue);
        cmd2.ExecuteNonQuery();
        bgl.baglanti().Close();

        SqlCommand cmd1 = new SqlCommand("select count(*) from Tbl_Yemekler where Kategoriid=@p6",bgl.baglanti());
        cmd1.Parameters.AddWithValue("@p6", DrpKategori.SelectedValue);
        SqlDataReader say = cmd1.ExecuteReader();
        while(say.Read())
        {
            sayi = say[0].ToString();
        }
        bgl.baglanti().Close();

        SqlCommand cmd5 = new SqlCommand("update Tbl_Kategoriler set KategoriAdet=@p7 where Kategoriid=@p8", bgl.baglanti());
        cmd5.Parameters.AddWithValue("@p7", sayi);
        cmd5.Parameters.AddWithValue("@p8", DrpKategori.SelectedValue);
        cmd5.ExecuteNonQuery();
        bgl.baglanti().Close();

    }
}