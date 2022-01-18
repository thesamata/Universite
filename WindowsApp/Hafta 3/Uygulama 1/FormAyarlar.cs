using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_1
{
    public partial class FormAyarlar : Form
    {
        public Color selectedColor;
        public Font selectedFont;
        public bool uygula;
        public FormAyarlar()
        {
            InitializeComponent();
        }

        private void scbBtn1_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            DialogResult dr = cd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                 selectedColor = cd.Color;
                 previewColor.BackColor = selectedColor;
            }
        }

        private void scbBtn2_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            DialogResult fdCvp = fd.ShowDialog();
            if (fdCvp == DialogResult.OK)
            {
                selectedFont = fd.Font;
                previewFont.Font = selectedFont;

            }
        }

        private void uygulaTlStripBtn_Click(object sender, EventArgs e)
        {
            uygula = true;
            this.Close();
        }

        private void vazgecTlStripBtn_Click(object sender, EventArgs e)
        {
            uygula = false;
            this.Close();
        }
    }
}
