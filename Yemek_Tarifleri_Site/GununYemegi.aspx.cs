using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class GununYemegi : System.Web.UI.Page
{
    SqlSinif bgl = new SqlSinif();
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("select * from Tbl_GununYemegi", bgl.baglanti());
        SqlDataReader oku = cmd.ExecuteReader();
        DataList2.DataSource = oku;
        DataList2.DataBind();
    }
}