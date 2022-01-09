using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Uygulama_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //UZUN YAZILAR İÇİN SCROLL BAR
            textLog.ScrollBars = ScrollBars.Both;
        }

        private void scbBtn1_Click(object sender, EventArgs e)
        {
            DialogResult cevap = System.Windows.Forms.MessageBox.Show("Dosya güncellenecek. Emin misiniz ?", "Kayet",
                MessageBoxButtons.AbortRetryIgnore,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            if (cevap == DialogResult.Abort)
            {
                textLog.Text = "Durdur Seçildi.";
            } else
           
            {
                if (cevap == DialogResult.Ignore)
                {
                    textLog.Text = "Yoksay Seçildi.";
                }
                if (cevap == DialogResult.Retry)
                {
                    textLog.Text = "Yeniden dene Seçildi.";
                }
            }
            
        }

        private void scbBtn2_Click(object sender, EventArgs e)
        {  
                DialogResult cevap = System.Windows.Forms.MessageBox.Show("Dosya güncellenecek. Emin misiniz ?", "Kayet",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            if (cevap == DialogResult.Abort)
            {
                textLog.Text = "Durdur Seçildi.";
            }
            else if (cevap == DialogResult.Ignore)
            {
                textLog.Text = "Yoksay Seçildi.";
            }

            else if (cevap == DialogResult.Retry)
            {
               textLog.Text = "Yeniden dene Seçildi.";             
            }

        }
        private void dosyaiceriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyaDialog = new OpenFileDialog();
            dosyaDialog.Title = "Yeni Proje Aç";
            dosyaDialog.Filter = "Word Dosyaları| *.doc; *.docx|" +
                                  "Text Dosyaları| *.txt|Tüm |*.*";
            dosyaDialog.FilterIndex = 2;
            // Txt içeriği olduğu için çoklu seçim kapalı
            dosyaDialog.Multiselect = false;
            DialogResult sonuc = dosyaDialog.ShowDialog();

            if (sonuc == DialogResult.OK)
            {

                textLog.Text = "Dosya seçildi." + dosyaDialog.FileName + Environment.NewLine;
                //UTF-8 lerde sıkıntı yaşanmasın diye eklendi.
                StreamReader sr = new StreamReader(dosyaDialog.FileName, System.Text.Encoding.UTF8, false);
                string icerik = sr.ReadToEnd();
                textLog.Text += icerik;
                sr.Close();
      
            }
            else
            {
                textLog.Text = "Diğer durum oldu.";
            }
        }

        private void dosyaAdıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyaDialog = new OpenFileDialog();
            dosyaDialog.Title = "Yeni Proje Aç";
            dosyaDialog.Filter = "Word Dosyaları| *.doc; *.docx|" +
                                  "Text Dosyaları| *.txt|Tüm |*.*";
            dosyaDialog.FilterIndex = 2;
            dosyaDialog.Multiselect = true;
            DialogResult sonuc = dosyaDialog.ShowDialog();

            if (sonuc == DialogResult.OK)
            {
                string[] dosyaIsimleri = dosyaDialog.FileNames;
                for (int i = 0; i < dosyaIsimleri.Length; i++)
                    textLog.Text += "Dosya seçildi. " + (i + 1) + "'nci dosya ismi: " + dosyaIsimleri[i] + Environment.NewLine;

            }
            else
            {
                textLog.Text = "Diğer durum oldu.";
            }
        }

        private void ayarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAyarlar frmAyr = new FormAyarlar();
            frmAyr.ShowDialog();
            if (frmAyr.uygula)
            {
                textLog.BackColor = frmAyr.selectedColor;
                textLog.Font = frmAyr.selectedFont;
                textLog.Text = "";
            }
            
        }
    }
}
