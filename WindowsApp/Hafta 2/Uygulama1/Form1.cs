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
    public enum aciliyeTuru { Acil = 0, Normal = 1, Bekleyebilir = 2 }
    public partial class Form1 : Form
    {
        

        List<ToDoItem> Listem = new List<ToDoItem>();
        public Form1()
        {
            InitializeComponent();

            Listem.Add(new ToDoItem("Todo-1 ", "Todo-2 Detay ", DateTime.Today, aciliyeTuru.Acil));
            Listem.Add(new ToDoItem("Todo-2 ", "Todo-2 Detay ", DateTime.Today, aciliyeTuru.Normal));
            Listem.Add(new ToDoItem("Todo-3 ", "Todo-3 Detay ", DateTime.Today, aciliyeTuru.Bekleyebilir));
        }

        private void loadItem2Listbox()
        {
            SCBlistbox1.DataSource = Listem;
            SCBlistbox1.ValueMember = "id";
            SCBlistbox1.DisplayMember = "baslik";
            dataGridView1.DataSource = Listem;

            SCBlistbox2.Items.Clear();
            foreach (var item in Listem)
            {
              
                if (SCBcomboBox1.SelectedIndex == -1)
                {
                    SCBlistbox2.Items.Add(item.baslik);
                    

                }
                else if ((aciliyeTuru)SCBcomboBox1.SelectedItem == item.tur)
                {
                    SCBlistbox2.Items.Add(item.baslik);
                }
                
            }
                
   
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            loadItem2Listbox();
            SCBcomboBox1.DataSource = Enum.GetValues(typeof(aciliyeTuru));
        }

        private void SCBcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadItem2Listbox();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
