namespace DisconnectedExample
{
    partial class Form1
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
            this.btnselect = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnxml = new System.Windows.Forms.Button();
            this.dgselect = new System.Windows.Forms.DataGridView();
            this.lbxml = new System.Windows.Forms.ListBox();
            this.l = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btncallsp = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.trainingDBDataSet = new DisconnectedExample.TrainingDBDataSet();
            this.resgisterShoppingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resgisterShoppingTableAdapter = new DisconnectedExample.TrainingDBDataSetTableAdapters.ResgisterShoppingTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membershipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shoppingPreferenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgselect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resgisterShoppingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnselect
            // 
            this.btnselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnselect.Location = new System.Drawing.Point(135, 43);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(99, 33);
            this.btnselect.TabIndex = 0;
            this.btnselect.Text = "select";
            this.btnselect.UseVisualStyleBackColor = true;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(309, 42);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(106, 34);
            this.btnupdate.TabIndex = 1;
            this.btnupdate.Text = "update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnxml
            // 
            this.btnxml.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxml.Location = new System.Drawing.Point(493, 42);
            this.btnxml.Name = "btnxml";
            this.btnxml.Size = new System.Drawing.Size(103, 34);
            this.btnxml.TabIndex = 2;
            this.btnxml.Text = "showXML";
            this.btnxml.UseVisualStyleBackColor = true;
            this.btnxml.Click += new System.EventHandler(this.btnxml_Click);
            // 
            // dgselect
            // 
            this.dgselect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgselect.Location = new System.Drawing.Point(135, 140);
            this.dgselect.Name = "dgselect";
            this.dgselect.Size = new System.Drawing.Size(604, 190);
            this.dgselect.TabIndex = 3;
            // 
            // lbxml
            // 
            this.lbxml.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxml.FormattingEnabled = true;
            this.lbxml.ItemHeight = 20;
            this.lbxml.Location = new System.Drawing.Point(835, 171);
            this.lbxml.Name = "lbxml";
            this.lbxml.Size = new System.Drawing.Size(322, 384);
            this.lbxml.TabIndex = 4;
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(884, 78);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(44, 13);
            this.l.TabIndex = 5;
            this.l.Text = "Enter Id";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(982, 78);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 6;
            // 
            // btncallsp
            // 
            this.btncallsp.Location = new System.Drawing.Point(1155, 74);
            this.btncallsp.Name = "btncallsp";
            this.btncallsp.Size = new System.Drawing.Size(75, 23);
            this.btncallsp.TabIndex = 7;
            this.btncallsp.Text = "CallSP";
            this.btncallsp.UseVisualStyleBackColor = true;
            this.btncallsp.Click += new System.EventHandler(this.btncallsp_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.membershipDataGridViewTextBoxColumn,
            this.shoppingPreferenceDataGridViewTextBoxColumn,
            this.cODDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.resgisterShoppingBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(135, 392);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(604, 185);
            this.dataGridView1.TabIndex = 8;
            // 
            // trainingDBDataSet
            // 
            this.trainingDBDataSet.DataSetName = "TrainingDBDataSet";
            this.trainingDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resgisterShoppingBindingSource
            // 
            this.resgisterShoppingBindingSource.DataMember = "ResgisterShopping";
            this.resgisterShoppingBindingSource.DataSource = this.trainingDBDataSet;
            // 
            // resgisterShoppingTableAdapter
            // 
            this.resgisterShoppingTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // membershipDataGridViewTextBoxColumn
            // 
            this.membershipDataGridViewTextBoxColumn.DataPropertyName = "Membership";
            this.membershipDataGridViewTextBoxColumn.HeaderText = "Membership";
            this.membershipDataGridViewTextBoxColumn.Name = "membershipDataGridViewTextBoxColumn";
            // 
            // shoppingPreferenceDataGridViewTextBoxColumn
            // 
            this.shoppingPreferenceDataGridViewTextBoxColumn.DataPropertyName = "ShoppingPreference";
            this.shoppingPreferenceDataGridViewTextBoxColumn.HeaderText = "ShoppingPreference";
            this.shoppingPreferenceDataGridViewTextBoxColumn.Name = "shoppingPreferenceDataGridViewTextBoxColumn";
            // 
            // cODDataGridViewTextBoxColumn
            // 
            this.cODDataGridViewTextBoxColumn.DataPropertyName = "COD";
            this.cODDataGridViewTextBoxColumn.HeaderText = "COD";
            this.cODDataGridViewTextBoxColumn.Name = "cODDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 614);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btncallsp);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.l);
            this.Controls.Add(this.lbxml);
            this.Controls.Add(this.dgselect);
            this.Controls.Add(this.btnxml);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnselect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgselect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resgisterShoppingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnxml;
        private System.Windows.Forms.DataGridView dgselect;
        private System.Windows.Forms.ListBox lbxml;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btncallsp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TrainingDBDataSet trainingDBDataSet;
        private System.Windows.Forms.BindingSource resgisterShoppingBindingSource;
        private TrainingDBDataSetTableAdapters.ResgisterShoppingTableAdapter resgisterShoppingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn membershipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shoppingPreferenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
    }
}

