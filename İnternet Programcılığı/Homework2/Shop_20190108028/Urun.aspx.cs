using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/*     \   /\
       )  ( ')
      (  /  )
SCB    \(__)|
*/

namespace Shop_20190108028
{
    public partial class Urun : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                //Connection
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                conn.Open();
                // SQL statement hazırlığı
                string insertQuery = "INSERT INTO Urun(UrunAdi, UrunKodu, SaticiID, BirimFiyat, StokAdedi, Aciklama) VALUES (@UrunAdi, @UrunKodu, @SaticiID, @BirimFiyat, @StokAdedi, @Aciklama)";
                SqlCommand cmd1 = new SqlCommand(insertQuery, conn);
                cmd1.Parameters.AddWithValue("@UrunAdi", txtUrunAdi.Text);
                cmd1.Parameters.AddWithValue("@UrunKodu", txtUrunKodu.Text);
                cmd1.Parameters.AddWithValue("@SaticiID", ddlSatici.SelectedValue);
                cmd1.Parameters.AddWithValue("@BirimFiyat", txtBirimFiyat.Text);
                cmd1.Parameters.AddWithValue("@StokAdedi", txtStok.Text);
                cmd1.Parameters.AddWithValue("@Aciklama", txtAciklama.Text);

                cmd1.ExecuteNonQuery();

                Response.Write("Kullanıcı veritabanına eklendi.");
                conn.Close();
            }
            catch (Exception ex)
            {
                Response.Write("Error :" + ex.ToString());
            }
        }
    }
}