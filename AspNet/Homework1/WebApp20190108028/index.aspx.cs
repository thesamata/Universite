using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp20190108028
{
    public partial class index : System.Web.UI.Page
    {
        /* 
         Bu ödev Şafak Can Bav Ve Musa Kartal Tarafından hazırlandı.
         Yazılımsal olarak her şey aynı ama tasarımlarımız farklı.
        */
        protected void Page_Load(object sender, EventArgs e)
        {
            lblAskr.Visible = false;
            RdaskrBtn.Visible = false;
            UniLbl.Visible = false;
            DdUni.Visible = false;
            LiseLbl.Visible = false;
            DdlLise.Visible = false;
            if (CBDevam.Checked)
            {
                RqfBtsTrh.Enabled = true;
            }
            else
            {
                RqfBtsTrh.Enabled = false;
            }
            if (DdlEgtm.SelectedValue == "1")
            {
                RqfLise.Enabled = true;
                RqfUni.Enabled = false;
            }
            else if (DdlEgtm.SelectedValue == "2")
            {
                RqfLise.Enabled = false;
                RqfUni.Enabled = true;
            }
        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (KvkCB.Checked)
            {
                gndBtn.Enabled = true;
                gndBtn.Text = "Gönder";
            }
            else
            {
                gndBtn.Enabled = false;
                gndBtn.Text = "Deaktif";
            }
        }

        protected void RdCnsBtn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RdCnsBtn.SelectedValue == "E")
            {
                lblAskr.Visible = true;
                RdaskrBtn.Visible = true;
            }
        }

        protected void CBDevam_CheckedChanged(object sender, EventArgs e)
        {
        }

        protected void gndBtn_Click(object sender, EventArgs e)
        {
            string file_prefix =
                Server
                    .MapPath("~/uploads/" +
                    DateTime.Now.ToString("dd_M_yyyy_hh_mm_"));

            if (FUBlg.HasFile)
            {
                FUBlg.SaveAs(file_prefix + FUBlg.FileName);
                LblBlg.Text = "Başarılı şekilde yüklendi.";
            }
            else
                LblBlg.Text = "Lütfen önce dosya seçiniz.";
        }

        protected void DdlEgtm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DdlEgtm.SelectedValue == "1")
            {
                LiseLbl.Visible = true;
                DdlLise.Visible = true;
            }
            else if (DdlEgtm.SelectedValue == "2")
            {
                UniLbl.Visible = true;
                DdUni.Visible = true;
            }
        }
    }
}
