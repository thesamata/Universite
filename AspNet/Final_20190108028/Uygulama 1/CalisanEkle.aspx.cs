using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_20190108028
{
    public partial class CalisanEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnKayit_Click(object sender, EventArgs e)
        {
            try
            {
                //Connection
                SqlConnection Connect = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                if (Connect.State == ConnectionState.Closed)
                {
                    Connect.Open();
                }
                string insertQuery =
                    " INSERT INTO Calisan(Adi, Soyadi, TCKimlikNo, Cinsiyet, DogumYili, BolumID, UnvanID, BasTarih, BitTarih)" +
                     "VALUES(@Adi, @Soyadi, @TCKimlikNo, @Cinsiyet, @DogumYili, @BolumID, @UnvanID, @BasTarih, @BitTarih)";

                SqlCommand basvuruCMD = new SqlCommand(insertQuery, Connect);
                basvuruCMD.Parameters.AddWithValue("@Adi", txtAd.Text);
                basvuruCMD.Parameters.AddWithValue("@Soyadi", txtSoyad.Text);
                basvuruCMD.Parameters.AddWithValue("@TCKimlikNo", txtTC.Text.ToString());
                basvuruCMD.Parameters.AddWithValue("@Cinsiyet", RBCinsiyet.SelectedValue);
                basvuruCMD.Parameters.AddWithValue("@DogumYili", txtDogum.Text);
                basvuruCMD.Parameters.AddWithValue("@BolumID", DdlBolum.SelectedValue);
                basvuruCMD.Parameters.AddWithValue("@UnvanID", DdlUnvan.SelectedValue);
                basvuruCMD.Parameters.AddWithValue("@BasTarih", txtBasTrh.Text);
                if (txtBtsTrh.Text != "")
                {
                    basvuruCMD.Parameters.AddWithValue("@BitTarih", txtBtsTrh.Text);
                }
                else
                {
                    basvuruCMD.Parameters.AddWithValue("@BitTarih", DBNull.Value);
                }
                
                basvuruCMD.ExecuteNonQuery();

                Response.Write("<script>alert('Kullanıcı veritabanına eklendi')</script>");
                Connect.Close();
            }
            catch (Exception ex)
            {
                Response.Write("Error :" + ex.ToString());

            }
           
        }
    }
}
/*     \   /\
       )  ( ')
      (  /  )
SCB    \(__)|
*/