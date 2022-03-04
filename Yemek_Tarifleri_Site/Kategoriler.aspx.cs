using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Kategoriler : System.Web.UI.Page
{
    SqlSinif bgl = new SqlSinif();
    string id = "";
    string islem = "";
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Page.IsPostBack==false )
        {
            
            id =Request.QueryString["Kategoriid"];
            islem = Request.QueryString["islem"];
        }

        SqlCommand cmd = new SqlCommand("Select * from Tbl_Kategoriler", bgl.baglanti());
        SqlDataReader oku = cmd.ExecuteReader();
        DataList1.DataSource = oku;
        DataList1.DataBind();


        Panel2.Visible = false;
        Panel4.Visible = false;

        if(islem=="sil")
        {
            SqlCommand cmd1 = new SqlCommand("delete from Tbl_Kategoriler where Kategoriid=@p1",bgl.baglanti());
            cmd1.Parameters.AddWithValue("@p1", id);
            cmd1.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Panel2.Visible=true;
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
        SqlCommand cmd1 = new SqlCommand("insert into Tbl_Kategoriler (KategoriAd,KategoriResim) values (@p1,@p2)", bgl.baglanti());
        cmd1.Parameters.AddWithValue("@p1", TxtAd.Text);
        cmd1.Parameters.AddWithValue("@p2", Fikon.FileName);
        cmd1.ExecuteNonQuery();
        bgl.baglanti().Close();
    }
}