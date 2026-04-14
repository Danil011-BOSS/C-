using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ZakDan2
{
    public partial class Form1 : Form
    {
        private List<Contact> contacts; //поля
        private string dataFile = "contactData.dat";
        public Form1()//конструктор
        {
            InitializeComponent();
            contacts = new List<Contact>();
            loadContacts();
            UpdateContactsList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateContactsList();
        }

        private void loadContacts() //Пользовательская функция
        {
            try
            {
                if (File.Exists(dataFile)) // При помощи класса File проверяем существует ли файл с данными
                {
                    using (StreamReader reader = new StreamReader(dataFile)) // читает файл в потоке
                    {
                        while (!reader.EndOfStream)
                        {
                            string[] data = reader.ReadLine().Split('|');
                            if (data.Length >= 5)
                            {
                                Contact contact = new Contact();
                                contact.FirstName = data[0];
                                contact.LastName = data[1];
                                contact.Email = data[2];
                                contact.PhoneNumber = data[3];
                                contact.BirthDate = DateTime.Parse(data[4]);
                                contact.Category = data[5];
                                contacts.Add(contact);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки контакта : {ex.Message}");
            }
        }
        private void SaveContacts()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(dataFile))
                {
                    foreach (Contact contact in contacts)
                    {
                        writer.WriteLine(
                            $"{contact.FirstName}|" +
                            $"{contact.LastName}|" +
                            $"{contact.Email}|" +
                            $"{contact.PhoneNumber}|" +
                            $"{contact.BirthDate:yyyy-MM-dd}|" +
                            $"{contact.Category}"
                            );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ошибка с сохранением контактов : {ex.Message}");
            }
        }
        private void UpdateContactsList()
        {
            listBox1.Items.Clear();
            var filterContacts = contacts.AsEnumerable();//перебираем
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                string search = textBox1.Text.ToLower();
                filterContacts = filterContacts.Where
                    (
                    c => c.FirstName.ToLower().Contains(search) ||
                    c.LastName.ToLower().Contains(search) ||
                    c.PhoneNumber.ToLower().Contains(search)
                    );
            }
            if(comboBox1.SelectedIndex > 0)
            {
                string category = comboBox1.Text;
                filterContacts = filterContacts.Where
                    (
                    c => c.Category == category
                    );
            }
            filterContacts = filterContacts.OrderBy(c => c.LastName);
            foreach (Contact contact in filterContacts)
            {
                listBox1.Items.Add(contact);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveContacts();
        }

        private void button5_Click(object sender, EventArgs e)//delete
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show($"Выберите контакт для удаления!");
                return;
            }
            if (MessageBox.Show("Удалить контакт?","Подтверждение",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes) {
                Contact selectedContact = listBox1.SelectedItem as Contact;
                contacts.Remove(selectedContact);
                UpdateContactsList();

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateContactsList();
                SaveContacts();
                // ------
                MessageBox.Show(
                    "Все контакты сохранены!",
                    "Успех!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
            catch
            {
                MessageBox.Show(
                                    "Произошла ошибка",
                                    "Предупреждение!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation
                                    );
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            comboBox1.SelectedIndex = -1;
            UpdateContactsList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Form2 form2 = new Form2())
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    contacts.Add(form2.ContactR);
                    UpdateContactsList();

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите контакт для редактирования!");
                return;
            }
            Contact selectedContact = listBox1.SelectedItem as Contact;
            int index = contacts.IndexOf(selectedContact);
            using (Form2 form2 = new Form2(selectedContact))
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    contacts[index] = form2.ContactR;
                    UpdateContactsList();
                }
            }
        }
    }
}
