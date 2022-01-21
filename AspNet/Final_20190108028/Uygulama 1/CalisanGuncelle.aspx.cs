using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_20190108028
{
    public partial class CalisanGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int gelenid = Convert.ToInt32(Request.QueryString["idver"]);
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["idver"] != "")
                {
                    SqlConnection Connect = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                    Connect.Open();
                    string selectQuery = "SELECT Calisan.Adi, Calisan.Soyadi, Calisan.TCKimlikNo, Calisan.Cinsiyet, Calisan.DogumYili, Calisan.BolumID, Calisan.UnvanID, Calisan.BasTarih, Calisan.BitTarih FROM Calisan where id=" + gelenid;
                    SqlCommand Commend = new SqlCommand(selectQuery, Connect);

                    SqlDataReader DataRead = Commend.ExecuteReader();

                    if (DataRead.Read())
                    {
                        txtAd.Text = DataRead["Adi"].ToString();
                        txtSoyad.Text = DataRead["Soyadi"].ToString();
                        txtTC.Text = DataRead["TCKimlikNo"].ToString();
                        RBCinsiyet.SelectedValue = DataRead["Cinsiyet"].ToString();
                        txtDogum.Text = DataRead["DogumYili"].ToString();
                        DdlBolum.SelectedValue = DataRead["BolumID"].ToString();
                        DdlUnvan.Text = DataRead["UnvanID"].ToString();
                        txtBasTrh.Text = Convert.ToDateTime(DataRead["BasTarih"]).ToString("yyyy-MM-dd");
                        if (DataRead["BitTarih"] != DBNull.Value)
                        {
                            txtBtsTrh.Text = Convert.ToDateTime(DataRead["BitTarih"]).ToString("yyyy-MM-dd");
                        }
                    }
                }
            
            }     
        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            int gelenid = Convert.ToInt32(Request.QueryString["idver"]);
            try
            {
                SqlConnection Connect = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                Connect.Open();
                string updateQuery = "UPDATE Calisan SET Adi=@Adi,Soyadi=@Soyadi,TCKimlikNo=@TCKimlikNo,Cinsiyet=@Cinsiyet,DogumYili=@DogumYili,BolumID=@BolumID,UnvanID=@UnvanID,BasTarih=@BasTarih,BitTarih=@BitTarih Where Id=" + gelenid;
                SqlCommand guncelleCMD = new SqlCommand(updateQuery, Connect);
                guncelleCMD.Parameters.AddWithValue("@Adi", txtAd.Text);
                guncelleCMD.Parameters.AddWithValue("@Soyadi", txtSoyad.Text);
                guncelleCMD.Parameters.AddWithValue("@TCKimlikNo", txtTC.Text);
                guncelleCMD.Parameters.AddWithValue("@Cinsiyet", RBCinsiyet.SelectedValue);
                guncelleCMD.Parameters.AddWithValue("@DogumYili", txtDogum.Text);
                guncelleCMD.Parameters.AddWithValue("@BolumID", DdlBolum.SelectedValue);
                guncelleCMD.Parameters.AddWithValue("@UnvanID", DdlUnvan.SelectedValue);
                guncelleCMD.Parameters.AddWithValue("@BasTarih", txtBasTrh.Text);
                if (txtBtsTrh.Text != "")
                {
                    guncelleCMD.Parameters.AddWithValue("@BitTarih", txtBtsTrh.Text);
                }
                else
                {
                    guncelleCMD.Parameters.AddWithValue("@BitTarih", DBNull.Value);
                }
                
                guncelleCMD.ExecuteNonQuery();
                Response.Write("Çalisan veritabanında güncellendi.");

                Connect.Close();

                Response.Redirect("CalisanListe.aspx");
            }
            catch (Exception ex)
            {
                Response.Write("error" + ex.ToString());
            }
        }

        protected void btnSil_Click(object sender, EventArgs e)
        {
            int gelenid = Convert.ToInt32(Request.QueryString["idver"]);
            SqlConnection Connect = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            Connect.Open();
            string deleteQuery = "DELETE FROM Calisan WHERE id=" + gelenid;
            SqlCommand Commend = new SqlCommand(deleteQuery, Connect);
            Commend.ExecuteNonQuery();
            Connect.Close();
            Response.Redirect("CalisanListe.aspx");
        }
    }
}
/*     \   /\
       )  ( ')
      (  /  )
SCB    \(__)|
*/