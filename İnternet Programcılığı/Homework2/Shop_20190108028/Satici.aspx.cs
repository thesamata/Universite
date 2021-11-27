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
    public partial class Satici : System.Web.UI.Page
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
                string insertQuery = "INSERT INTO Satici(SaticiAdi, SaticiAdres, SehirID, Telefon, Email) VALUES (@SaticiAdi, @SaticiAdres, @SehirID, @Telefon, @Email)";
                SqlCommand cmd1 = new SqlCommand(insertQuery, conn);
                cmd1.Parameters.AddWithValue("@SaticiAdi", txtSaticiAdi.Text);
                cmd1.Parameters.AddWithValue("@SaticiAdres", txtSaticiAdres.Text);
                cmd1.Parameters.AddWithValue("@SehirID", ddlSehir.SelectedValue);
                cmd1.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                cmd1.Parameters.AddWithValue("@Email", txtEmail.Text);


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
