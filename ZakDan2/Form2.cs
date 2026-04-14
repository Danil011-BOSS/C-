using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZakDan2
{
    public partial class Form2 : Form
    {
        private Contact contactR;
        public Contact ContactR { get => contactR; private set => contactR = value; }
        public Form2(Contact contact = null)
        {
            InitializeComponent();

            comboBox1.Items.AddRange(
                new string[] {
                    "Друзья", "Семья", "Работа", "Учеба", "Другое"
                }
                );
            if (contact == null)
            {
                ContactR = new Contact();
                Text = "Добавить контакт";
            }
            else
            {
                ContactR = contact;
                Text = "Редактировать контакт";
                FillForm();
            }
        }
        private void FillForm()
        {
            textBox1.Text = ContactR.FirstName;
            textBox2.Text = ContactR.LastName;
            textBox3.Text = ContactR.Email;
            textBox4.Text = ContactR.PhoneNumber;
            dateTimePicker1.Value = ContactR.BirthDate;
            comboBox1.Text = ContactR.Category;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContactR.FirstName = textBox1.Text;
            ContactR.LastName = textBox2.Text;
            ContactR.Email = textBox3.Text;
            ContactR.PhoneNumber = textBox4.Text;
            ContactR.BirthDate = dateTimePicker1.Value;
            ContactR.Category = comboBox1.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
