using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class GununYemegiAdmin : System.Web.UI.Page
{
    SqlSinif bgl = new SqlSinif();
    string islem = "";
    string id = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        Panel2.Visible = false;
        Panel4.Visible = false;
        if (Page.IsPostBack == false)
        {

            
            islem = Request.QueryString["islem"];
            id= Request.QueryString["Yemekid"];
            

            
        }

        SqlCommand cmd1 = new SqlCommand("select * from Tbl_Yemekler where Durum=1",bgl.baglanti());
        SqlDataReader dr = cmd1.ExecuteReader();
        DataList1.DataSource = dr;
        DataList1.DataBind();


        SqlCommand cmd2 = new SqlCommand("select * from Tbl_Yemekler where Durum=0", bgl.baglanti());
        SqlDataReader dr2 = cmd2.ExecuteReader();
        DataList2.DataSource = dr2;
        DataList2.DataBind();


        if (islem == "guncelle")
        {
            SqlCommand cmd = new SqlCommand("update Tbl_Yemekler set Durum=1 where Yemekid=@p1",bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1",id);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();

            SqlCommand cmd3 = new SqlCommand("update Tbl_Yemekler set Durum=0 where Yemekid!=@p2", bgl.baglanti());
            cmd3.Parameters.AddWithValue("@p2", id);
            cmd3.ExecuteNonQuery();
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
}