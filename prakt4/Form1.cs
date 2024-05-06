using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace prakt4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Hashtable ht = new Hashtable();
                ht.Add("001", textBox1.Text);
                ICollection keys = ht.Keys;
                foreach (string k in keys)
                {
                    listBox1.Items.Add(ht[k]);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                Hashtable ht = new Hashtable();
                ht.Add("1", textBox2.Text);
                ICollection keys = ht.Keys;
                foreach (string k in keys)
                {
                    listBox1.Items.Add(ht[k]);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (true)
            {
                listBox1.SelectedIndex = listBox1.FindString(textBox3.Text);
            }
            else MessageBox.Show("Исполнитель не найден", "Ошибка", MessageBoxButtons.OK);
        }
    }
}
