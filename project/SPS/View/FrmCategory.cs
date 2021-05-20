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
        private string prevName;
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
                Clear();

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
            dgvList.Columns[3].HeaderText = "Descripcion";
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
            iconError.Clear();

            btnInsert.Visible = true;
            bttUpdate.Visible = false;
            dgvList.Columns[0].Visible = false;
            btnActivate.Visible = false;
            btnDeactivate.Visible = false;
            btnDelete.Visible = false;
            chkSelect.Checked = false;
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

        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Clear();
                bttUpdate.Visible = true;
                btnInsert.Visible = false;
                txtId.Text = Convert.ToString(dgvList.CurrentRow.Cells["ID"].Value);
                prevName = Convert.ToString(dgvList.CurrentRow.Cells["Nombre"].Value);
                txtName.Text = Convert.ToString(dgvList.CurrentRow.Cells["Nombre"].Value);
                txtDescription.Text = Convert.ToString(dgvList.CurrentRow.Cells["Descripcion"].Value);
                tcGeneral.SelectedIndex = 1;

            }
            catch (Exception)
            {
                MessageBox.Show("Select from the name cell.");
            }
        }

        private void bttUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string response = "";

                if (txtName.Text == string.Empty || txtId.Text == string.Empty)
                {
                    ErrorMessage("Some fields have been left empty.");
                    iconError.SetError(txtName, "Enter a name");
                }
                else
                {
                    response = BCategory.Update(Convert.ToInt32(txtId.Text), prevName, 
                        txtName.Text.Trim(), txtDescription.Text);

                    if(response.Equals("Ok"))
                    {
                        OkMessage("Category updated!");
                        Clear();
                        List();
                    }
                    else
                    {
                        ErrorMessage(response);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void chkSelect_CheckedChanged(object sender, EventArgs e)
        {
            if(chkSelect.Checked)
            {
                dgvList.Columns[0].Visible = true;
                btnActivate.Visible = true;
                btnDeactivate.Visible = true;
                btnDelete.Visible = true;
            }
            else
            {
                dgvList.Columns[0].Visible = false;
                btnActivate.Visible = false;
                btnDeactivate.Visible = false;
                btnDelete.Visible = false;
            }
        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dgvList.Columns["dgvcbcSelect"].Index)
            {
                DataGridViewCheckBoxCell chkDelete =
                    (DataGridViewCheckBoxCell)dgvList.Rows[e.RowIndex].Cells["dgvcbcSelect"];
                chkDelete.Value = !Convert.ToBoolean(chkDelete.Value);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult option = MessageBox.Show("Would you like to delete the record(s)?", "Sales system",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if(option == DialogResult.OK)
                {
                    int code = 0; string response = "";

                    foreach (DataGridViewRow row in dgvList.Rows)
                    {
                        if(Convert.ToBoolean(row.Cells[0].Value))
                        {
                            code = Convert.ToInt32(row.Cells[1].Value);
                            response = BCategory.Delete(code);

                            if(response.Equals("Ok"))
                            {
                                OkMessage("File(s) deleted: " + Convert.ToString(row.Cells[2].Value));
                            }
                            else
                            {
                                ErrorMessage(response);
                            }
                        }
                    }

                    List();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult option = MessageBox.Show("Would you like to activate the record(s)?", "Sales system",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (option == DialogResult.OK)
                {
                    int code = 0; string response = "";

                    foreach (DataGridViewRow row in dgvList.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            code = Convert.ToInt32(row.Cells[1].Value);
                            response = BCategory.Activate(code);

                            if (response.Equals("Ok"))
                            {
                                OkMessage("File(s) activated: " + Convert.ToString(row.Cells[2].Value));
                            }
                            else
                            {
                                ErrorMessage(response);
                            }
                        }
                    }

                    List();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult option = MessageBox.Show("Would you like to deactivate the record(s)?", "Sales system",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (option == DialogResult.OK)
                {
                    int code = 0; string response = "";

                    foreach (DataGridViewRow row in dgvList.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            code = Convert.ToInt32(row.Cells[1].Value);
                            response = BCategory.Deactivate(code);

                            if (response.Equals("Ok"))
                            {
                                OkMessage("File(s) deactivated: " + Convert.ToString(row.Cells[2].Value));
                            }
                            else
                            {
                                ErrorMessage(response);
                            }
                        }
                    }

                    List();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
