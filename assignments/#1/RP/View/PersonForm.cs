using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Business;
using System.Windows.Forms;

namespace View
{
    public partial class PersonForm : Form
    {
        public PersonForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshDgvPerson();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string lastname = txtLastname.Text;
            string phone = txtPhone.Text;
            int age = Convert.ToInt32(nupAge.Value);
            BPerson business = new();

            business.Insert(name, lastname, age, phone);
            
            // Once inserted, the data source needs to be refreshed.
            RefreshDgvPerson();
        }

        private void RefreshDgvPerson()
        {
            BindingSource source = new();
            dgvPerson.DataSource = source;
            BPerson business = new();
            source.DataSource = business.List();

            // Resize the DataGridView columns to fit all available space.
            dgvPerson.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
