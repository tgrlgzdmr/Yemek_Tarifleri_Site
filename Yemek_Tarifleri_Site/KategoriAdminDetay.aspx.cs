using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class KategoriAdminDetay : System.Web.UI.Page
{
    SqlSinif bgl = new SqlSinif();
    string id;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        id= Request.QueryString["Kategoriid"];
        if (Page.IsPostBack == false)
        {
            

            SqlCommand cmd = new SqlCommand("select * from Tbl_Kategoriler where Kategoriid=@p1", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", id);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                TxtAd.Text = dr[1].ToString();
                TxtAdet.Text = dr[2].ToString();
            }
            bgl.baglanti().Close();
        }
    }

    protected void BtnGuncel_Click(object sender, EventArgs e)
    {
        id = Request.QueryString["Kategoriid"];
        SqlCommand cmd1 = new SqlCommand("update Tbl_Kategoriler set KategoriAd=@p1,KategoriAdet=@p2, KategoriResim=@p3 where Kategoriid=@p4", bgl.baglanti());
        cmd1.Parameters.AddWithValue("@p1", TxtAd.Text);
        cmd1.Parameters.AddWithValue("@p2", TxtAdet.Text);
        cmd1.Parameters.AddWithValue("@p3", Fikon.FileName);
        cmd1.Parameters.AddWithValue("@p4", id);
        cmd1.ExecuteNonQuery();
        bgl.baglanti().Close();
    }
    
}