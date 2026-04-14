using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainZak1
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
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Add some text", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                string task = textBox1.Text;
                listBox1.Items.Add(task);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(listBox1.Text))
            {
                MessageBox.Show("выбери дело из списка", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            
        }
    }
}
