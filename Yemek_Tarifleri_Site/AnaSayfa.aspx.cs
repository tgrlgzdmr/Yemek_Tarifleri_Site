using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class AnaSayfa : System.Web.UI.Page
{
    SqlSinif bgl = new SqlSinif();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("select * from Tbl_Yemekler", bgl.baglanti());
        SqlDataReader oku = cmd.ExecuteReader();
        DataList2.DataSource = oku;
        DataList2.DataBind();

        //SqlCommand cmd2 = new SqlCommand("Select Kategoriid from Tbl_Yemekler", bgl.baglanti());
        //SqlDataReader oku2 = cmd.ExecuteReader();
        //while (oku2.Read())
        //{
        //    x = oku2[0].ToString();
        //}

        //bgl.baglanti().Close();



        //SqlCommand cmd1 = new SqlCommand("Select KategoriAd from Tbl_Kategoriler where Kategoriid=@p1", bgl.baglanti());
        //cmd1.Parameters.AddWithValue("@p1", x);
       
        //SqlDataReader dr = cmd1.ExecuteReader();
        //DataList2.DataSource = dr;
        //DataList2.DataBind();

        //SqlDataReader oku1 = cmd.ExecuteReader();
        //DataList2.DataSource = oku;
        //DataList2.DataBind();
    }
}