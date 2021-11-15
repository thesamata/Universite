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
            /*if (!Page.IsPostBack)
                btnGonder.Enabled = false;*/
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            //İlçe kullanıcının gördüğü (display) değer
            //Label1.Text = ddlIlce.SelectedItem.Text;

            //İlçe ID
            //Label1.Text = ddlIlce.SelectedItem.Value;
            //Label1.Text = ddlIlce.SelectedValue;

            //İlçe listesinde kaçıcı eleman
            //Label1.Text = ddlIlce.SelectedIndex.ToString();

            //İlçe listesinin eleman sayısı
            //Label1.Text = ddlIlce.Items.Count.ToString();

            //İlçe listesinin belli bir elemanının değeri
            //Label1.Text = ddlIlce.Items[0].Value + " " + ddlIlce.Items[0].Text;

            //İlçe listesinin seçilme kontrolü
            /*if (ddlSehir.Items[1].Selected)
                Label1.Text = "Başkentimiz";
            else
                Label1.Text = ddlSehir.SelectedItem.Text;*/

            //Radio button list ya da checkbox listte seçim yapılmış mı?
            /*if (rblCinsiyet.SelectedIndex == -1)
                Label1.Text = "Cinsiyet seçilmedi";
            else
                Label1.Text = rblCinsiyet.SelectedItem.Text;*/

            //CheckboxList'te seçilen değerleri erişme
            int elemansayisi = cblDiller.Items.Count - 1;

            for (int i = 0;i <= elemansayisi; i++)
            {
                if (cblDiller.Items[i].Selected)
                    Label1.Text += cblDiller.Items[i].Text + " ";
            }

        }
    }
}