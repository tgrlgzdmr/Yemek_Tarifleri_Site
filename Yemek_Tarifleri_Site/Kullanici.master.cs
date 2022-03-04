using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Kullanici : System.Web.UI.MasterPage
{
    SqlSinif bgl = new SqlSinif();
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("select * from Tbl_Kategoriler",bgl.baglanti());
        SqlDataReader oku = cmd.ExecuteReader();
        DataList1.DataSource = oku;
        DataList1.DataBind();
    }
}
