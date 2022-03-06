using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Yorumlar : System.Web.UI.Page
{
    SqlSinif bgl = new SqlSinif();
    protected void Page_Load(object sender, EventArgs e)
    {
        Panel2.Visible = false;
        Panel4.Visible = false;
        SqlCommand cmd = new SqlCommand("select * from Tbl_Yorumlar where YorumOnay=1",bgl.baglanti());
        SqlDataReader dr = cmd.ExecuteReader();
        DataList1.DataSource=dr;
        DataList1.DataBind();

        SqlCommand cmd1 = new SqlCommand("select * from Tbl_Yorumlar where YorumOnay=0", bgl.baglanti());
        SqlDataReader dr1 = cmd1.ExecuteReader();
        DataList2.DataSource=dr1;
        DataList2.DataBind();
        

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