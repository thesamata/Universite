using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calisma
{
    public partial class Form1 : Form
    {
        Random musaRand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int musaGen = musaRand.Next(10);
            int musaEnt = int.Parse(textBox1.Text);
            if (musaEnt > musaGen)
            {
                MessageBox.Show("Girilen Musa büyük" + musaGen);
            }
            else
            {
                MessageBox.Show("Gen musa büyük" + musaGen);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "Hello")
            {
                button2.Text = "Click me ";
            }
            else
            {
                button2.Text = "Test ";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int total;
            for (total = 0; total < 10; total +=2)
            {
                listBox1.Items.Add(total);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = 0;
            int sayi = 0;
            while (i < 4)
            {
                sayi += 5;
                i++;
                listBox1.Items.Add(sayi);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // While do
            /*  while (i <= 5)
             {
                 Console.WriteLine(i);
                 i++;
             }
            */
            int i = 0;
            do
            {
                listBox2.Items.Add(i);
                i++;
            } while (i <= 5);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            // While to For
            /* while (i < 6)
             {
                 Console.WriteLine(i);
                 i += 3;
             }
             */
            for (int i = 0; i <= 6; i += 3)
            {
                listBox2.Items.Add(i);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label1.BackColor == System.Drawing.Color.DarkRed)
            {
                label1.BackColor = System.Drawing.Color.Blue;
            }
            else
            {
                label1.BackColor = System.Drawing.Color.DarkRed;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //timer1.Start();
            tabControl1.SelectedTab = tabControl1.TabPages[1];
        }

        private void GeneralClick(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            if (clickedButton.Text.Equals("A"))
            {
                MessageBox.Show("Button A is clicked!");

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!listBox3.Items.Contains(textBox3.Text))
            {
                listBox3.Items.Add(textBox3.Text);
            }     
                  

        }

        private void button12_Click(object sender, EventArgs e)
        {
            foreach (Control obj in groupBox8.Controls)
            {
                if (obj is RadioButton)
                {
                    RadioButton radio = obj as RadioButton;
                    if(radio is RadioButton)
                    {
                        if (radio.Checked == true)
                        {
                            MessageBox.Show("asdsad.");
                        }
                        else
                        {
                           
                        }
                    }
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            OpenFileDialog musaFD = new OpenFileDialog();
            musaFD.Multiselect = true;
            DialogResult result = musaFD.ShowDialog();
            if (result == DialogResult.OK)
            {
                string[] dosya = musaFD.FileNames;

                for (int i = 0; i < dosya.Length; i++)
                {
                    if (dosya[i].EndsWith(".txt"))
                    {
                        listBox4.Items.Add(dosya[i]);
                    }
                    else if (dosya[i].EndsWith(".png"))
                    {
                        listBox5.Items.Add(dosya[i]);
                    }
                }
            }
        }
    }
}