
namespace View
{
    partial class FrmCategory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tcGeneral = new System.Windows.Forms.TabControl();
            this.tpList = new System.Windows.Forms.TabPage();
            this.bttSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.dgvcbcSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tpManagement = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lblObligatory = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.iconError = new System.Windows.Forms.ErrorProvider(this.components);
            this.tcGeneral.SuspendLayout();
            this.tpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.tpManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconError)).BeginInit();
            this.SuspendLayout();
            // 
            // tcGeneral
            // 
            this.tcGeneral.Controls.Add(this.tpList);
            this.tcGeneral.Controls.Add(this.tpManagement);
            this.tcGeneral.Location = new System.Drawing.Point(13, 13);
            this.tcGeneral.Name = "tcGeneral";
            this.tcGeneral.SelectedIndex = 0;
            this.tcGeneral.Size = new System.Drawing.Size(775, 425);
            this.tcGeneral.TabIndex = 0;
            // 
            // tpList
            // 
            this.tpList.Controls.Add(this.bttSearch);
            this.tpList.Controls.Add(this.txtSearch);
            this.tpList.Controls.Add(this.lblTotal);
            this.tpList.Controls.Add(this.dgvList);
            this.tpList.Location = new System.Drawing.Point(4, 29);
            this.tpList.Name = "tpList";
            this.tpList.Padding = new System.Windows.Forms.Padding(3);
            this.tpList.Size = new System.Drawing.Size(767, 392);
            this.tpList.TabIndex = 0;
            this.tpList.Text = "List";
            this.tpList.UseVisualStyleBackColor = true;
            // 
            // bttSearch
            // 
            this.bttSearch.Location = new System.Drawing.Point(667, 3);
            this.bttSearch.Name = "bttSearch";
            this.bttSearch.Size = new System.Drawing.Size(94, 29);
            this.bttSearch.TabIndex = 3;
            this.bttSearch.Text = "Search";
            this.bttSearch.UseVisualStyleBackColor = true;
            this.bttSearch.Click += new System.EventHandler(this.bttSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(3, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(658, 27);
            this.txtSearch.TabIndex = 2;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(3, 372);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(45, 20);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total:";
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToOrderColumns = true;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcbcSelect});
            this.dgvList.Location = new System.Drawing.Point(3, 38);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersWidth = 51;
            this.dgvList.RowTemplate.Height = 29;
            this.dgvList.Size = new System.Drawing.Size(758, 331);
            this.dgvList.TabIndex = 0;
            // 
            // dgvcbcSelect
            // 
            this.dgvcbcSelect.HeaderText = "Select";
            this.dgvcbcSelect.MinimumWidth = 6;
            this.dgvcbcSelect.Name = "dgvcbcSelect";
            this.dgvcbcSelect.ReadOnly = true;
            this.dgvcbcSelect.Width = 125;
            // 
            // tpManagement
            // 
            this.tpManagement.Controls.Add(this.btnCancel);
            this.tpManagement.Controls.Add(this.btnInsert);
            this.tpManagement.Controls.Add(this.lblObligatory);
            this.tpManagement.Controls.Add(this.txtId);
            this.tpManagement.Controls.Add(this.lblDescription);
            this.tpManagement.Controls.Add(this.lblName);
            this.tpManagement.Controls.Add(this.txtDescription);
            this.tpManagement.Controls.Add(this.txtName);
            this.tpManagement.Location = new System.Drawing.Point(4, 29);
            this.tpManagement.Name = "tpManagement";
            this.tpManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tpManagement.Size = new System.Drawing.Size(767, 392);
            this.tpManagement.TabIndex = 1;
            this.tpManagement.Text = "Management";
            this.tpManagement.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(223, 252);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 35);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(94, 252);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(123, 35);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lblObligatory
            // 
            this.lblObligatory.AutoSize = true;
            this.lblObligatory.Location = new System.Drawing.Point(94, 217);
            this.lblObligatory.Name = "lblObligatory";
            this.lblObligatory.Size = new System.Drawing.Size(165, 20);
            this.lblObligatory.TabIndex = 5;
            this.lblObligatory.Text = "(*) Fields are obligatory";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(320, 36);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(161, 27);
            this.txtId.TabIndex = 4;
            this.txtId.Visible = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(3, 102);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(85, 20);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 69);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(69, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name (*)";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(94, 99);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(387, 102);
            this.txtDescription.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(94, 69);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(387, 27);
            this.txtName.TabIndex = 0;
            // 
            // iconError
            // 
            this.iconError.ContainerControl = this;
            // 
            // FrmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcGeneral);
            this.Name = "FrmCategory";
            this.Text = "Category";
            this.Load += new System.EventHandler(this.FrmCategory_Load);
            this.tcGeneral.ResumeLayout(false);
            this.tpList.ResumeLayout(false);
            this.tpList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.tpManagement.ResumeLayout(false);
            this.tpManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcGeneral;
        private System.Windows.Forms.TabPage tpList;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvcbcSelect;
        private System.Windows.Forms.TabPage tpManagement;
        private System.Windows.Forms.Button bttSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label lblObligatory;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ErrorProvider iconError;
    }
}