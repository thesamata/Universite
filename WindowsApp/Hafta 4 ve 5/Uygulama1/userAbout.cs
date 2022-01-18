using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama1
{
    public partial class UserAbout : Form
    {
        public string userKad = "";

        public int bestCountmatch1;

        public int bestCountmatch2;

        public int bestCountmath1;

        public int bestCountmath2;

        public int countMathgame;

        public int countMatchgame;

        public UserAbout()
        {
            InitializeComponent();
        }

        private void UserAbout_Load(object sender, EventArgs e)
        {
            label2.Text = userKad;
            label9.Text = countMatchgame.ToString();
            label10.Text = countMathgame.ToString();

            label7.Text = bestCountmatch1.ToString();

            if (bestCountmatch1 > bestCountmatch2)
                label6.Text = bestCountmatch1.ToString();
            else
                label6.Text = bestCountmatch2.ToString();

            if (bestCountmath1 > bestCountmath2)
                label7.Text = bestCountmath1.ToString();
            else
                label7.Text = bestCountmath2.ToString();
        }
    }
}
