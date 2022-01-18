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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Admin" && textBox2.Text == "123")
            {
                MessageBox.Show("Giriş Başarılı");
            }
            else
            {
                Form2 frm = new Form2();
                frm.Show();
            }
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {

            if (label1.Text == "Kullanıcı Adı")
            {
                label1.Text = "Asasdasd";
            }
            else if (label1.Text == "Asasdasd")
            {
                label1.Text = "Kullanıcı Adı";
            }
        }
    }
}
