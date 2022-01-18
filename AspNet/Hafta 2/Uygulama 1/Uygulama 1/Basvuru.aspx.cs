using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Week3
{
    public partial class Basvuru : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                btnGonder.Enabled = false;
        }

        protected void btnFileUpload_Click(object sender, EventArgs e)
        {
            string file_prefix = Server.MapPath("~/uploads/CV" + "_" + txAdSoyad.Text + "_" + DateTime.Now.ToString("ddMyyMhhmmss") + "_");
            Label1.Text = file_prefix;

            if (fupCV.HasFile)
                fupCV.SaveAs(file_prefix + fupCV.FileName);
            else
                Label1.Text = "Lütfen önce dosya seçiniz.";
        }

        protected void cbKabul_CheckedChanged(object sender, EventArgs e)
        {
            if (cbKabul.Checked)
                btnGonder.Enabled = true;
            else
                btnGonder.Enabled = false;
        }

        protected void btnGonder_Click(object sender, EventArgs e)
        {
            string adsoyad = txAdSoyad.Text;
            string hitap;
            if (rbCinsiyetK.Checked)
                hitap = " Hanım";
            else if (rbCinsiyetE.Checked)
                hitap = " Bey";
            else
                hitap = "";

            Label1.Text = "Mesajınız gönderildi, " + adsoyad + hitap;
        }
    }
}