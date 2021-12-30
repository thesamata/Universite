using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Proje_SCB
{
    public partial class Detay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int gelenid = Convert.ToInt32(Request.QueryString["idver"]);

            SqlConnection Connect = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringSCB"].ConnectionString);
            string selectQuery = "SELECT Basvuru.Id, Basvuru.AdSoyad, Basvuru.Cinsiyet, Basvuru.UyrukId, Basvuru.DogumTarihi, Basvuru.Email, Basvuru.Telefon, Basvuru.EgitimDurumu, Basvuru.BasvuruSonucu, Basvuru.OzgecmisDosyaAd FROM Basvuru where id=" + gelenid;
            SqlCommand Commend = new SqlCommand(selectQuery, Connect);
            SqlDataAdapter sqlDat = new SqlDataAdapter(Commend);
            DataTable dataTab = new DataTable();
            sqlDat.Fill (dataTab);
            Repeater.DataSource = dataTab;
            Repeater.DataBind();
        }

        protected void veriUpdate_Click(object sender, EventArgs e)
        {
            int gelenid = Convert.ToInt32(Request.QueryString["idver"]);

            try
            {
                //Connection
                SqlConnection Connect = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringSCB"].ConnectionString);
                if (Connect.State == ConnectionState.Closed)
                {
                    Connect.Open();
                }

                // SQL statement hazırlığı
                string updateQuery = "UPDATE Basvuru SET BasvuruSonucu=@BasvuruSonucu WHERE Id=" + gelenid;
                SqlCommand Commend2 = new SqlCommand(updateQuery, Connect);
                Commend2
                    .Parameters
                    .AddWithValue("@BasvuruSonucu", sonucRB.SelectedValue);
                Commend2.ExecuteNonQuery();
                Connect.Close();
                Response.Write("<script>alert('Başarılı güncellendi.')</script>");
                Response.Redirect("InsanKaynaklari.aspx");
            }
            catch (Exception ex)
            {
                Response.Write("Error :" + ex.ToString());
            }
        }

        protected void Dowloand_File(object sender, EventArgs e)
        {
            int gelenid = Convert.ToInt32(Request.QueryString["idver"]);
            SqlConnection Connect = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringSCB"].ConnectionString);
            if (Connect.State == ConnectionState.Closed)
            {
                Connect.Open();
            }
            string selectQuery = "SELECT OzgecmisDosyaAd FROM Basvuru where id=" + gelenid;
            SqlCommand Commend3 = new SqlCommand(selectQuery, Connect);
            SqlDataReader dr = Commend3.ExecuteReader();
            while (dr.Read())
            {
                Response.Clear();
                Response.ContentType = "application/octet-stream";
                Response.AddHeader("Content-Disposition", "attachment; filename=" + dr["OzgecmisDosyaAd"].ToString());
                Response.TransmitFile(dr["OzgecmisDosyaAd"].ToString());
                Response.End();
                Connect.Close();              
            }
        }
    }
}
/*     \   /\
       )  ( ')
      (  /  )
SCB    \(__)|
*/
