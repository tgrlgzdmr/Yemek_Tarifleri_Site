using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    SqlSinif bgl = new SqlSinif();
    string yemekid = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        yemekid = Request.QueryString["Yemekid"];
        SqlCommand cmd = new SqlCommand("Select YemekAd from Tbl_Yemekler where Yemekid=@p1",bgl.baglanti());
        cmd.Parameters.AddWithValue("@p1", yemekid);
        SqlDataReader dr = cmd.ExecuteReader();
        while(dr.Read())
        {
            Label3.Text=dr[0].ToString();
        }
        bgl.baglanti().Close();


        SqlCommand cmd2 = new SqlCommand("select * from Tbl_Yorumlar where Yemekid=@p1 and YorumOnay=1",bgl.baglanti());
        cmd2.Parameters.AddWithValue("@p1",yemekid);
        SqlDataReader oku = cmd2.ExecuteReader();
        DataList2.DataSource = oku;
        DataList2.DataBind();

    }

    protected void BtnYorum_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("insert into Tbl_Yorumlar (YorumAdSoyad, YorumMail, Yorumicerik, Yemekid) values (@p1, @p2, @p3, @p4)", bgl.baglanti());
        cmd.Parameters.AddWithValue("@p1", TxtAdSoyad.Text);
        cmd.Parameters.AddWithValue("@p2", TxtMail.Text);
        cmd.Parameters.AddWithValue("@p3", TxtYorum.Text);
        cmd.Parameters.AddWithValue("@p4", yemekid);
        cmd.ExecuteNonQuery();
        bgl.baglanti().Close();

    }
}