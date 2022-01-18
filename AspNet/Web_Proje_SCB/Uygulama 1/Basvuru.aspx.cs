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
    public partial class Basvuru : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["MyCookieFile"] !=null)
            {
                HttpCookie MyCookie = Request.Cookies["MyCookieFile"];
                txtAdSoyad.Text = MyCookie["Adsoyad"];
            }
            uniAdiLbl.Visible = false;
            DdlUni.Visible = false;
            LiseLbl.Visible = false;
            DdlLise.Visible = false;

            if (DdlEgitmDurum.SelectedValue == "L")
            {
                RqfUni.Enabled = false;
                RqfLise.Enabled = true;

                LiseLbl.Visible = true;
                DdlLise.Visible = true;
            }
            else if (DdlEgitmDurum.SelectedValue == "U")
            {
                RqfUni.Enabled = true;
                RqfLise.Enabled = false;

                uniAdiLbl.Visible = true;
                DdlUni.Visible = true;
            }
            if (devamCB.Checked)
            {
                RqfBtsTrh.Enabled = true;
            }
            else
            {
                RqfBtsTrh.Enabled = false;
            }
        }

        protected void GonderButton_Click(object sender, EventArgs e)
        {
            HttpCookie MyCookie = new HttpCookie("MyCookieFile");
            MyCookie["Adsoyad"] = txtAdSoyad.Text;
            Response.Cookies.Add(MyCookie);
            string file_prefix = Server.MapPath("~/uploads/" + DateTime.Now.ToString("dd_M_yyyy_hh_mm_"));
            try
            {
                //Connection
                SqlConnection Connect = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringSCB"].ConnectionString);
                if (Connect.State == ConnectionState.Closed)
                {
                    Connect.Open();
                }

                // SQL statement hazırlığı
                string insertQuery =
                    "INSERT INTO Basvuru(AdSoyad, Cinsiyet, UyrukId, DogumTarihi, SehirId, Email, Telefon, Aciklama, EgitimDurumu, EgitimBasTarih, EgitimBitTari, DevamDurumu, LiseAdi, UnvAdi, OzgecmisDosyaAd ,BasvuruSonucu) " +
                        "VALUES(@AdSoyad, @Cinsiyet, @UyrukId, @DogumTarihi, @SehirId, @Email, @Telefon, @Aciklama, @EgitimDurumu, @EgitimBasTarih, @EgitimBitTari, @DevamDurumu, @LiseAdi, @UnvAdi, @OzgecmisDosyaAd, @BasvuruSonucu)";

                SqlCommand cmd1 = new SqlCommand(insertQuery, Connect);

                cmd1.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
                cmd1.Parameters.AddWithValue("@Cinsiyet", CinsiyetRB.SelectedValue);
                cmd1.Parameters.AddWithValue("@UyrukId", DdlUyruk.SelectedValue);
                cmd1.Parameters.AddWithValue("@DogumTarihi", Convert.ToDateTime(txtDgmTrh.Text.ToString()));
                cmd1.Parameters.AddWithValue("@SehirId", Ddlil.SelectedValue);
                cmd1.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd1.Parameters.AddWithValue("@Telefon", txtTelNo.Text);
                cmd1.Parameters.AddWithValue("@Aciklama", txtKariyer.Text);
                cmd1.Parameters.AddWithValue("@EgitimDurumu", DdlEgitmDurum.SelectedValue);
                cmd1.Parameters.AddWithValue("@EgitimBasTarih", Convert.ToDateTime(TxtBsTrh.Text.ToString()));        
                if (devamCB.Checked)
                {
                    cmd1.Parameters.AddWithValue("@DevamDurumu", "D");
                    cmd1.Parameters.AddWithValue("@EgitimBitTari", Convert.ToDateTime(TxtBtsTrh.Text.ToString()));
                }
                else
                {
                    cmd1.Parameters.AddWithValue("@DevamDurumu", DBNull.Value);
                    cmd1.Parameters.AddWithValue("@EgitimBitTari", DBNull.Value);
                }
                if (DdlEgitmDurum.SelectedValue == "L")
                {
                    cmd1.Parameters.AddWithValue("@LiseAdi", DdlLise.SelectedValue);
                    cmd1.Parameters.AddWithValue("@UnvAdi", DBNull.Value);
                }
                else if (DdlEgitmDurum.SelectedValue == "U")
                {
                    cmd1.Parameters.AddWithValue("@LiseAdi", DBNull.Value);
                    cmd1.Parameters.AddWithValue("@UnvAdi", DdlUni.SelectedValue);
                }
                if (FUBlg.HasFile)
                {
                    FUBlg.SaveAs(file_prefix + FUBlg.FileName);
                    cmd1.Parameters.AddWithValue("@OzgecmisDosyaAd", file_prefix + FUBlg.FileName);
                }
                else
                {
                    cmd1.Parameters.AddWithValue("@OzgecmisDosyaAd", DBNull.Value);
                }

                cmd1.Parameters.AddWithValue("@BasvuruSonucu", DBNull.Value);
                cmd1.ExecuteNonQuery();
                Response.Write("<script>alert('Kullanıcı veritabanına eklendi')</script>");
                Connect.Close();
            }
            catch (Exception ex)
            {
               Response.Write("Error :" + ex.ToString());
            }
        }

        protected void kktcCB_CheckedChanged(object sender, EventArgs e)
        {
            if (kktcCB.Checked)
            {
                GonderButton.Enabled = true;
                GonderButton.Text = "Gönder";
            }
            else
            {
                GonderButton.Enabled = false;
                GonderButton.Text = "Deaktif";
            }
        }
    }
}
/*     \   /\
       )  ( ')
      (  /  )
SCB    \(__)|
*/
