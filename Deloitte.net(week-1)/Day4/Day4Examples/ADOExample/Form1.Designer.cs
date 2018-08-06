namespace ADOExample
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblMembership = new System.Windows.Forms.Label();
            this.lblShoppingPreference = new System.Windows.Forms.Label();
            this.lblCOD = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.cbgender = new System.Windows.Forms.ComboBox();
            this.rbpaid = new System.Windows.Forms.RadioButton();
            this.rbfree = new System.Windows.Forms.RadioButton();
            this.clbshop = new System.Windows.Forms.CheckedListBox();
            this.cbcod = new System.Windows.Forms.CheckBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnregister = new System.Windows.Forms.Button();
            this.btnselect = new System.Windows.Forms.Button();
            this.lbselect = new System.Windows.Forms.ListBox();
            this.cbID = new System.Windows.Forms.ComboBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.trainingDBDataSet = new ADOExample.TrainingDBDataSet();
            this.resgisterShoppingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resgisterShoppingTableAdapter = new ADOExample.TrainingDBDataSetTableAdapters.ResgisterShoppingTableAdapter();
            this.btnupdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resgisterShoppingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(180, 116);
            this.lblName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(98, 19);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Enter Name";
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(180, 179);
            this.lblGender.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(113, 19);
            this.lblGender.TabIndex = 1;
            this.lblGender.Text = "Select gender";
            // 
            // lblMembership
            // 
            this.lblMembership.AutoSize = true;
            this.lblMembership.Location = new System.Drawing.Point(180, 252);
            this.lblMembership.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMembership.Name = "lblMembership";
            this.lblMembership.Size = new System.Drawing.Size(155, 19);
            this.lblMembership.TabIndex = 2;
            this.lblMembership.Text = "Select membership";
            // 
            // lblShoppingPreference
            // 
            this.lblShoppingPreference.AutoSize = true;
            this.lblShoppingPreference.Location = new System.Drawing.Point(180, 322);
            this.lblShoppingPreference.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblShoppingPreference.Name = "lblShoppingPreference";
            this.lblShoppingPreference.Size = new System.Drawing.Size(216, 19);
            this.lblShoppingPreference.TabIndex = 3;
            this.lblShoppingPreference.Text = "Select Shopping preference";
            // 
            // lblCOD
            // 
            this.lblCOD.AutoSize = true;
            this.lblCOD.Location = new System.Drawing.Point(180, 401);
            this.lblCOD.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCOD.Name = "lblCOD";
            this.lblCOD.Size = new System.Drawing.Size(102, 19);
            this.lblCOD.TabIndex = 4;
            this.lblCOD.Text = "Prefer COD?";
            this.lblCOD.Click += new System.EventHandler(this.lblCOD_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(180, 453);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(128, 19);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Enter Password";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(367, 116);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 26);
            this.txtname.TabIndex = 6;
            // 
            // cbgender
            // 
            this.cbgender.FormattingEnabled = true;
            this.cbgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbgender.Location = new System.Drawing.Point(367, 176);
            this.cbgender.Name = "cbgender";
            this.cbgender.Size = new System.Drawing.Size(121, 26);
            this.cbgender.TabIndex = 7;
            // 
            // rbpaid
            // 
            this.rbpaid.AutoSize = true;
            this.rbpaid.Location = new System.Drawing.Point(400, 252);
            this.rbpaid.Name = "rbpaid";
            this.rbpaid.Size = new System.Drawing.Size(59, 23);
            this.rbpaid.TabIndex = 8;
            this.rbpaid.TabStop = true;
            this.rbpaid.Text = "paid";
            this.rbpaid.UseVisualStyleBackColor = true;
            // 
            // rbfree
            // 
            this.rbfree.AutoSize = true;
            this.rbfree.Location = new System.Drawing.Point(578, 252);
            this.rbfree.Name = "rbfree";
            this.rbfree.Size = new System.Drawing.Size(56, 23);
            this.rbfree.TabIndex = 9;
            this.rbfree.TabStop = true;
            this.rbfree.Text = "free";
            this.rbfree.UseVisualStyleBackColor = true;
            // 
            // clbshop
            // 
            this.clbshop.FormattingEnabled = true;
            this.clbshop.Items.AddRange(new object[] {
            "watches",
            "laptops",
            "mobiles",
            "clothes",
            "travelsbags"});
            this.clbshop.Location = new System.Drawing.Point(424, 286);
            this.clbshop.Name = "clbshop";
            this.clbshop.Size = new System.Drawing.Size(242, 109);
            this.clbshop.TabIndex = 10;
            // 
            // cbcod
            // 
            this.cbcod.AutoSize = true;
            this.cbcod.Location = new System.Drawing.Point(386, 401);
            this.cbcod.Name = "cbcod";
            this.cbcod.Size = new System.Drawing.Size(71, 23);
            this.cbcod.TabIndex = 11;
            this.cbcod.Text = "COD?";
            this.cbcod.UseVisualStyleBackColor = true;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(424, 453);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(100, 26);
            this.txtpassword.TabIndex = 12;
            // 
            // btnregister
            // 
            this.btnregister.Location = new System.Drawing.Point(260, 516);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(90, 40);
            this.btnregister.TabIndex = 13;
            this.btnregister.Text = "Register";
            this.btnregister.UseVisualStyleBackColor = true;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // btnselect
            // 
            this.btnselect.Location = new System.Drawing.Point(392, 516);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(96, 40);
            this.btnselect.TabIndex = 14;
            this.btnselect.Text = "Select";
            this.btnselect.UseVisualStyleBackColor = true;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // lbselect
            // 
            this.lbselect.FormattingEnabled = true;
            this.lbselect.ItemHeight = 18;
            this.lbselect.Location = new System.Drawing.Point(636, 35);
            this.lbselect.Name = "lbselect";
            this.lbselect.Size = new System.Drawing.Size(263, 148);
            this.lbselect.TabIndex = 15;
            // 
            // cbID
            // 
            this.cbID.DataSource = this.resgisterShoppingBindingSource;
            this.cbID.DisplayMember = "Name";
            this.cbID.FormattingEnabled = true;
            this.cbID.Location = new System.Drawing.Point(367, 75);
            this.cbID.Name = "cbID";
            this.cbID.Size = new System.Drawing.Size(121, 26);
            this.cbID.TabIndex = 16;
            this.cbID.ValueMember = "Id";
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(559, 516);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(89, 32);
            this.btndelete.TabIndex = 17;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
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
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(719, 516);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(112, 32);
            this.btnupdate.TabIndex = 18;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(962, 568);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.cbID);
            this.Controls.Add(this.lbselect);
            this.Controls.Add(this.btnselect);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.cbcod);
            this.Controls.Add(this.clbshop);
            this.Controls.Add(this.rbfree);
            this.Controls.Add(this.rbpaid);
            this.Controls.Add(this.cbgender);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblCOD);
            this.Controls.Add(this.lblShoppingPreference);
            this.Controls.Add(this.lblMembership);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Registration form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trainingDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resgisterShoppingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblMembership;
        private System.Windows.Forms.Label lblShoppingPreference;
        private System.Windows.Forms.Label lblCOD;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.ComboBox cbgender;
        private System.Windows.Forms.RadioButton rbpaid;
        private System.Windows.Forms.RadioButton rbfree;
        private System.Windows.Forms.CheckedListBox clbshop;
        private System.Windows.Forms.CheckBox cbcod;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.ListBox lbselect;
        private System.Windows.Forms.ComboBox cbID;
        private System.Windows.Forms.Button btndelete;
        private TrainingDBDataSet trainingDBDataSet;
        private System.Windows.Forms.BindingSource resgisterShoppingBindingSource;
        private TrainingDBDataSetTableAdapters.ResgisterShoppingTableAdapter resgisterShoppingTableAdapter;
        private System.Windows.Forms.Button btnupdate;
    }
}

