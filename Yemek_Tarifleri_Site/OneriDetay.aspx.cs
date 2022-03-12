using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class OneriDetay : System.Web.UI.Page
{
    SqlSinif bgl = new SqlSinif();
    string id = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        
        SqlCommand cmd3 = new SqlCommand("select * from Tbl_Kategoriler", bgl.baglanti());
        SqlDataReader dr1 = cmd3.ExecuteReader();
        DropDownList1.DataTextField = "KategoriAd";
        DropDownList1.DataValueField = "Kategoriid";
        DropDownList1.DataSource = dr1;
        DropDownList1.DataBind();

        id = Request.QueryString["Tarifid"];
        SqlCommand cmd = new SqlCommand("Select * from Tbl_Tarifler where Tarifid=@p1", bgl.baglanti());
        cmd.Parameters.AddWithValue("@p1", id);
        SqlDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            TxtAd.Text = dr[1].ToString();
            TxtMalzeme.Text = dr[2].ToString();
            TxtYapilis.Text = dr[3].ToString();
            //Fikon.Attributes = dr[4].ToString();
            TxtSahip.Text = dr[5].ToString();
            TxtMail.Text = dr[6].ToString();
        }
        bgl.baglanti().Close();
        
    }

    protected void BtnEkle_Click(object sender, EventArgs e)
    {
        SqlCommand cmd1 = new SqlCommand("insert into Tbl_Yemekler (YemekAd,YemekMalzeme,YemekTarif,YemekResim,Kategoriid) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
        cmd1.Parameters.AddWithValue("@p1", TxtAd.Text);
        cmd1.Parameters.AddWithValue("@p2", TxtMalzeme.Text);
        cmd1.Parameters.AddWithValue("@p3", TxtYapilis.Text);
        cmd1.Parameters.AddWithValue("@p4", Fikon.FileName);
        cmd1.Parameters.AddWithValue("@p5", DropDownList1.SelectedValue);
        cmd1.ExecuteNonQuery();
        bgl.baglanti().Close();

        SqlCommand cmd2 = new SqlCommand("update Tbl_Tarifler set TarifDurum=1 where Tarifid=@p5", bgl.baglanti());
        cmd2.Parameters.AddWithValue("@p5", id);
        cmd2.ExecuteNonQuery();
        bgl.baglanti().Close();

        SqlCommand cmd4 = new SqlCommand("Update Tbl_Kategoriler set KategoriAdet=(select count(Tbl_Yemekler.YemekAd) from Tbl_Yemekler where Tbl_Yemekler.Kategoriid=@p6) where Kategoriid=@p7", bgl.baglanti());
        cmd4.Parameters.AddWithValue("@p6", DropDownList1.SelectedValue);
        cmd4.Parameters.AddWithValue("@p7", DropDownList1.SelectedValue);
        cmd4.ExecuteNonQuery();
        bgl.baglanti().Close();


    }
}