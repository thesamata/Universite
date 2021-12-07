using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DatabaseOp
{
    public partial class Vendor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                btnEkle.Visible = true;
                btnAra.Visible = true;
                btnGuncelle.Visible = false;
                btnGuncelleId.Visible = false;
                btnSil.Visible = false;
            }
        }

        private void Sifirla()
        {
            txtVName.Text = "";
            txtVAddress.Text = "";
            DropDownList1.SelectedValue = "0";
            txtVPhone.Text = "";
            txtVCode.Text = "";
            btnEkle.Visible = true;
            btnAra.Visible = true;
            btnGuncelle.Visible = false;
            btnGuncelleId.Visible = false;
            btnSil.Visible = false;
            txtVCode.Enabled = true;

        }
        protected void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                //connection
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString);
                //SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ETicaret.mdf;Integrated Security=True");
                conn.Open();

                //SQL statement hazırlığı
                string insertQuery = "INSERT INTO Vendor (VendorName, VendorAddress, CityID, VendorPhone, VendorCode) VALUES (@Ad, @Adres, @il, @tel, @vcode)";
                SqlCommand cmd1 = new SqlCommand(insertQuery, conn);
                cmd1.Parameters.AddWithValue("@Ad", txtVName.Text);
                cmd1.Parameters.AddWithValue("@Adres", txtVAddress.Text);
                cmd1.Parameters.AddWithValue("@il", DropDownList1.SelectedValue);
                cmd1.Parameters.AddWithValue("@tel", txtVPhone.Text);
                cmd1.Parameters.AddWithValue("@vcode", txtVCode.Text);

                //Execution – SQL cümlesi çalıştırma
                cmd1.ExecuteNonQuery();
                GridView1.DataBind();
                Response.Write("Kullanıcı veritabanına eklendi.");
                conn.Close();
                Sifirla();

            }
            catch (Exception ex)
            {
                Response.Write("error" + ex.ToString());
            }

        }

        protected void btnAra_Click(object sender, EventArgs e)
        {
            if (txtVCode.Text == "")
            {
                Response.Write("Lütfen aramak istediğiniz satıcı kodunu giriniz.");
            }
            else
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString);
                conn.Open();
                try
                {
                    //SQL statement hazırlığı
                    string checkvendor = "SELECT * FROM Vendor WHERE VendorCode='" + txtVCode.Text + "'";
                    SqlCommand cmd = new SqlCommand(checkvendor, conn);
                    //Execution
                    SqlDataReader dataReader = cmd.ExecuteReader();

                    if (dataReader.Read())
                    {
                        txtVName.Text = dataReader.GetValue(1).ToString();
                        txtVAddress.Text = dataReader.GetValue(2).ToString();
                        DropDownList1.SelectedValue = dataReader.GetValue(3).ToString();
                        txtVPhone.Text = dataReader.GetValue(4).ToString();
                        ViewState["id"] = dataReader.GetValue(0).ToString();

                        btnEkle.Visible = false;
                        btnAra.Visible = true;
                        btnGuncelle.Visible = true;
                        btnGuncelleId.Visible = true;
                        btnSil.Visible = true;
                        txtVCode.Enabled = false;

                        Response.Write("ViewState = " + ViewState["id"]);
                    }
                    else
                    {
                        Response.Write("Kayıt bulunamadı.");
                    }

                    dataReader.Close();
                    cmd.Dispose();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Response.Write("error" + ex.ToString());
                }
            }
        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection
                (ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString);
                conn.Open();
                string updateQuery = "UPDATE Vendor SET VendorName=@Ad,VendorAddress=@Adres,CityID=@il,VendorPhone=@tel WHERE VendorCode=@vcode";
                SqlCommand cmd1 = new SqlCommand(updateQuery, conn);
                cmd1.Parameters.AddWithValue("@Ad", txtVName.Text);
                cmd1.Parameters.AddWithValue("@Adres", txtVAddress.Text);
                cmd1.Parameters.AddWithValue("@il", DropDownList1.SelectedValue);
                cmd1.Parameters.AddWithValue("@tel", txtVPhone.Text);
                cmd1.Parameters.AddWithValue("@vcode", txtVCode.Text);
                cmd1.ExecuteNonQuery();
                GridView1.DataBind();
                Response.Write("Satıcı veritabanında güncellendi.");
                conn.Close();
                Sifirla();
            }
            catch (Exception ex)
            {
                Response.Write("error" + ex.ToString());
            }

        }

        protected void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString);
                conn.Open();
                string deleteQuery = "DELETE Vendor WHERE VendorCode=@vcode";
                SqlCommand cmd3 = new SqlCommand(deleteQuery, conn);

                cmd3.Parameters.AddWithValue("@vcode", txtVCode.Text);
                cmd3.ExecuteNonQuery();
                GridView1.DataBind();

                Response.Write("Satıcı veritabanından silindi.");
                conn.Close();

                Sifirla();
            }
            catch (Exception ex)
            {
                Response.Write("error" + ex.ToString());
            }

        }

        protected void btnGuncelleId_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection
                (ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString);
                conn.Open();
                string updateQuery = "UPDATE Vendor SET VendorName=@Ad,VendorAddress=@Adres,CityID=@il,VendorPhone=@tel WHERE Id=@Id";
                SqlCommand cmd1 = new SqlCommand(updateQuery, conn);
                cmd1.Parameters.AddWithValue("@Ad", txtVName.Text);
                cmd1.Parameters.AddWithValue("@Adres", txtVAddress.Text);
                cmd1.Parameters.AddWithValue("@il", DropDownList1.SelectedValue);
                cmd1.Parameters.AddWithValue("@tel", txtVPhone.Text);
                cmd1.Parameters.AddWithValue("@Id", ViewState["id"]);
                cmd1.ExecuteNonQuery();
                GridView1.DataBind();
                Response.Write("Satıcı veritabanında güncellendi.");
                conn.Close();
                Sifirla();
            }
            catch (Exception ex)
            {
                Response.Write("error" + ex.ToString());
            }
        }
    }
}