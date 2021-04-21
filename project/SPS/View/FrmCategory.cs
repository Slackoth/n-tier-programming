using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;

namespace View
{
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {
            List();
        }

        private void List()
        {
            try
            {
                dgvList.DataSource = BCategory.List();
                
                DgvFormat();

                lblTotal.Text = "Total records: " + Convert.ToString(dgvList.Rows.Count);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
            }
        }

        private void DgvFormat()
        {
            dgvList.Columns[0].Visible = false;
            dgvList.Columns[1].Visible = false;
            dgvList.Columns[2].Width = 150;
            dgvList.Columns[3].Width = 400;
            dgvList.Columns[3].HeaderText = "Description";
            dgvList.Columns[4].Width = 100;
        }

        private void bttSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            try
            {
                dgvList.DataSource = BCategory.Search(txtSearch.Text);

                DgvFormat();

                lblTotal.Text = "Total records: " + Convert.ToString(dgvList.Rows.Count);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
            }
        }

        private void Clear()
        {
            txtSearch.Clear();
            txtName.Clear();
            txtId.Clear();
            txtDescription.Clear();
            btnInsert.Visible = true;
            iconError.Clear();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                string result = "";

                if (txtName.Text == string.Empty)
                {
                    ErrorMessage("Obligatory fields need to be filled.");
                    iconError.SetError(txtName, "Enter a name for the catagory.");
                }
                else
                {
                    // Trim() deletes white spaces at the beggining and at the end.
                    result = BCategory.Insert(txtName.Text.Trim(), txtDescription.Text.Trim());

                    if (result.Equals("Ok"))
                    {
                        OkMessage("Category inserted.");
                        Clear();
                        List();
                    }
                    else
                        ErrorMessage("Category not inserted");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void ErrorMessage(string message)
        {
            MessageBox.Show(message, "Sales & Purchases System", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OkMessage(string message)
        {
            MessageBox.Show(message, "Sales & Purchases System", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
            tcGeneral.SelectedIndex = 0;
        }
    }
}
