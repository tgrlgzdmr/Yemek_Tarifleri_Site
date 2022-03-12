using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class HakkimizdaAdmin : System.Web.UI.Page
{
    SqlSinif bgl = new SqlSinif();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            SqlCommand cmd = new SqlCommand("select * from Tbl_Hakkimizda", bgl.baglanti());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                TextBox1.Text = reader[0].ToString();
            }
            bgl.baglanti().Close();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand cmd1 = new SqlCommand("update Tbl_Hakkimizda set Metin=@p1", bgl.baglanti());
        cmd1.Parameters.AddWithValue("@p1", TextBox1.Text);
        cmd1.ExecuteNonQuery();
        bgl.baglanti().Close();
    }
}