namespace Problem1
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
            this.lbselect = new System.Windows.Forms.ListBox();
            this.btfind = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.btupdate = new System.Windows.Forms.Button();
            this.btselect = new System.Windows.Forms.Button();
            this.btaddnew = new System.Windows.Forms.Button();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtaddr = new System.Windows.Forms.TextBox();
            this.cmbsem = new System.Windows.Forms.ComboBox();
            this.cmbcourse = new System.Windows.Forms.ComboBox();
            this.cmbdept = new System.Windows.Forms.ComboBox();
            this.rbfemale = new System.Windows.Forms.RadioButton();
            this.rbmale = new System.Windows.Forms.RadioButton();
            this.dtTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtroll = new System.Windows.Forms.TextBox();
            this.lbphone = new System.Windows.Forms.Label();
            this.lbaddr = new System.Windows.Forms.Label();
            this.lbsem = new System.Windows.Forms.Label();
            this.lbcourse = new System.Windows.Forms.Label();
            this.lbdept = new System.Windows.Forms.Label();
            this.lbgender = new System.Windows.Forms.Label();
            this.lbdate = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.lbroll = new System.Windows.Forms.Label();
            this.lbstudentprof = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbselect
            // 
            this.lbselect.FormattingEnabled = true;
            this.lbselect.Location = new System.Drawing.Point(444, 194);
            this.lbselect.Name = "lbselect";
            this.lbselect.Size = new System.Drawing.Size(246, 212);
            this.lbselect.TabIndex = 51;
            // 
            // btfind
            // 
            this.btfind.BackColor = System.Drawing.Color.Aqua;
            this.btfind.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btfind.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btfind.Location = new System.Drawing.Point(428, 149);
            this.btfind.Name = "btfind";
            this.btfind.Size = new System.Drawing.Size(75, 23);
            this.btfind.TabIndex = 50;
            this.btfind.Text = "FIND";
            this.btfind.UseVisualStyleBackColor = false;
            this.btfind.Click += new System.EventHandler(this.btfind_Click);
            // 
            // btdelete
            // 
            this.btdelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btdelete.Location = new System.Drawing.Point(539, 450);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(75, 23);
            this.btdelete.TabIndex = 49;
            this.btdelete.Text = "DELETE";
            this.btdelete.UseVisualStyleBackColor = false;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // btupdate
            // 
            this.btupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btupdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btupdate.Location = new System.Drawing.Point(399, 450);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(75, 23);
            this.btupdate.TabIndex = 48;
            this.btupdate.Text = "UPDATE";
            this.btupdate.UseVisualStyleBackColor = false;
            this.btupdate.Click += new System.EventHandler(this.btupdate_Click);
            // 
            // btselect
            // 
            this.btselect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btselect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btselect.Location = new System.Drawing.Point(215, 451);
            this.btselect.Name = "btselect";
            this.btselect.Size = new System.Drawing.Size(75, 23);
            this.btselect.TabIndex = 47;
            this.btselect.Text = "SELECT";
            this.btselect.UseVisualStyleBackColor = false;
            this.btselect.Click += new System.EventHandler(this.btselect_Click);
            // 
            // btaddnew
            // 
            this.btaddnew.BackColor = System.Drawing.Color.Aqua;
            this.btaddnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btaddnew.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btaddnew.Location = new System.Drawing.Point(62, 452);
            this.btaddnew.Name = "btaddnew";
            this.btaddnew.Size = new System.Drawing.Size(75, 23);
            this.btaddnew.TabIndex = 46;
            this.btaddnew.Text = "ADDNEW";
            this.btaddnew.UseVisualStyleBackColor = false;
            this.btaddnew.Click += new System.EventHandler(this.btaddnew_Click);
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(205, 386);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(200, 20);
            this.txtphone.TabIndex = 45;
            // 
            // txtaddr
            // 
            this.txtaddr.Location = new System.Drawing.Point(205, 356);
            this.txtaddr.Name = "txtaddr";
            this.txtaddr.Size = new System.Drawing.Size(200, 20);
            this.txtaddr.TabIndex = 44;
            // 
            // cmbsem
            // 
            this.cmbsem.FormattingEnabled = true;
            this.cmbsem.Items.AddRange(new object[] {
            "SEMESTER-1",
            "SEMESTER-2",
            "SEMESTER-3",
            "SEMESTER-4",
            "SEMESTER-5",
            "SEMESTER-6",
            "SEMESTER-7",
            "SEMESTER-8"});
            this.cmbsem.Location = new System.Drawing.Point(205, 327);
            this.cmbsem.Name = "cmbsem";
            this.cmbsem.Size = new System.Drawing.Size(200, 21);
            this.cmbsem.TabIndex = 43;
            // 
            // cmbcourse
            // 
            this.cmbcourse.FormattingEnabled = true;
            this.cmbcourse.Items.AddRange(new object[] {
            "B.Tech",
            "M.Tech"});
            this.cmbcourse.Location = new System.Drawing.Point(205, 303);
            this.cmbcourse.Name = "cmbcourse";
            this.cmbcourse.Size = new System.Drawing.Size(200, 21);
            this.cmbcourse.TabIndex = 42;
            // 
            // cmbdept
            // 
            this.cmbdept.FormattingEnabled = true;
            this.cmbdept.Items.AddRange(new object[] {
            "MECH",
            "CSE",
            "IT",
            "CIV",
            "EEE",
            "ECE",
            "MET",
            "MIN"});
            this.cmbdept.Location = new System.Drawing.Point(205, 278);
            this.cmbdept.Name = "cmbdept";
            this.cmbdept.Size = new System.Drawing.Size(200, 21);
            this.cmbdept.TabIndex = 41;
            // 
            // rbfemale
            // 
            this.rbfemale.AutoSize = true;
            this.rbfemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbfemale.Location = new System.Drawing.Point(320, 253);
            this.rbfemale.Name = "rbfemale";
            this.rbfemale.Size = new System.Drawing.Size(73, 17);
            this.rbfemale.TabIndex = 40;
            this.rbfemale.TabStop = true;
            this.rbfemale.Text = "FEMALE";
            this.rbfemale.UseVisualStyleBackColor = true;
            // 
            // rbmale
            // 
            this.rbmale.AutoSize = true;
            this.rbmale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbmale.ForeColor = System.Drawing.Color.Red;
            this.rbmale.Location = new System.Drawing.Point(205, 253);
            this.rbmale.Name = "rbmale";
            this.rbmale.Size = new System.Drawing.Size(58, 17);
            this.rbmale.TabIndex = 39;
            this.rbmale.TabStop = true;
            this.rbmale.Text = "MALE";
            this.rbmale.UseVisualStyleBackColor = true;
            // 
            // dtTimePicker1
            // 
            this.dtTimePicker1.Location = new System.Drawing.Point(205, 219);
            this.dtTimePicker1.Name = "dtTimePicker1";
            this.dtTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dtTimePicker1.TabIndex = 38;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(205, 187);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(200, 20);
            this.txtname.TabIndex = 37;
            // 
            // txtroll
            // 
            this.txtroll.Location = new System.Drawing.Point(205, 152);
            this.txtroll.Name = "txtroll";
            this.txtroll.Size = new System.Drawing.Size(200, 20);
            this.txtroll.TabIndex = 36;
            // 
            // lbphone
            // 
            this.lbphone.AutoSize = true;
            this.lbphone.Location = new System.Drawing.Point(103, 393);
            this.lbphone.Name = "lbphone";
            this.lbphone.Size = new System.Drawing.Size(55, 13);
            this.lbphone.TabIndex = 35;
            this.lbphone.Text = "Phone No";
            // 
            // lbaddr
            // 
            this.lbaddr.AutoSize = true;
            this.lbaddr.Location = new System.Drawing.Point(103, 363);
            this.lbaddr.Name = "lbaddr";
            this.lbaddr.Size = new System.Drawing.Size(45, 13);
            this.lbaddr.TabIndex = 34;
            this.lbaddr.Text = "Address";
            // 
            // lbsem
            // 
            this.lbsem.AutoSize = true;
            this.lbsem.Location = new System.Drawing.Point(103, 335);
            this.lbsem.Name = "lbsem";
            this.lbsem.Size = new System.Drawing.Size(51, 13);
            this.lbsem.TabIndex = 33;
            this.lbsem.Text = "Semester";
            // 
            // lbcourse
            // 
            this.lbcourse.AutoSize = true;
            this.lbcourse.Location = new System.Drawing.Point(103, 311);
            this.lbcourse.Name = "lbcourse";
            this.lbcourse.Size = new System.Drawing.Size(40, 13);
            this.lbcourse.TabIndex = 32;
            this.lbcourse.Text = "Course";
            // 
            // lbdept
            // 
            this.lbdept.AutoSize = true;
            this.lbdept.Location = new System.Drawing.Point(103, 286);
            this.lbdept.Name = "lbdept";
            this.lbdept.Size = new System.Drawing.Size(62, 13);
            this.lbdept.TabIndex = 31;
            this.lbdept.Text = "Department";
            // 
            // lbgender
            // 
            this.lbgender.AutoSize = true;
            this.lbgender.Location = new System.Drawing.Point(103, 258);
            this.lbgender.Name = "lbgender";
            this.lbgender.Size = new System.Drawing.Size(42, 13);
            this.lbgender.TabIndex = 30;
            this.lbgender.Text = "Gender";
            // 
            // lbdate
            // 
            this.lbdate.AutoSize = true;
            this.lbdate.Location = new System.Drawing.Point(103, 227);
            this.lbdate.Name = "lbdate";
            this.lbdate.Size = new System.Drawing.Size(44, 13);
            this.lbdate.TabIndex = 29;
            this.lbdate.Text = "Date Of";
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Location = new System.Drawing.Point(103, 194);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(35, 13);
            this.lbname.TabIndex = 28;
            this.lbname.Text = "Name";
            // 
            // lbroll
            // 
            this.lbroll.AutoSize = true;
            this.lbroll.Location = new System.Drawing.Point(103, 159);
            this.lbroll.Name = "lbroll";
            this.lbroll.Size = new System.Drawing.Size(42, 13);
            this.lbroll.TabIndex = 27;
            this.lbroll.Text = "Roll No";
            // 
            // lbstudentprof
            // 
            this.lbstudentprof.AutoSize = true;
            this.lbstudentprof.Location = new System.Drawing.Point(236, 122);
            this.lbstudentprof.Name = "lbstudentprof";
            this.lbstudentprof.Size = new System.Drawing.Size(107, 13);
            this.lbstudentprof.TabIndex = 26;
            this.lbstudentprof.Text = "STUDENT PROFILE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 596);
            this.Controls.Add(this.lbselect);
            this.Controls.Add(this.btfind);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btupdate);
            this.Controls.Add(this.btselect);
            this.Controls.Add(this.btaddnew);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtaddr);
            this.Controls.Add(this.cmbsem);
            this.Controls.Add(this.cmbcourse);
            this.Controls.Add(this.cmbdept);
            this.Controls.Add(this.rbfemale);
            this.Controls.Add(this.rbmale);
            this.Controls.Add(this.dtTimePicker1);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtroll);
            this.Controls.Add(this.lbphone);
            this.Controls.Add(this.lbaddr);
            this.Controls.Add(this.lbsem);
            this.Controls.Add(this.lbcourse);
            this.Controls.Add(this.lbdept);
            this.Controls.Add(this.lbgender);
            this.Controls.Add(this.lbdate);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.lbroll);
            this.Controls.Add(this.lbstudentprof);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbselect;
        private System.Windows.Forms.Button btfind;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.Button btselect;
        private System.Windows.Forms.Button btaddnew;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtaddr;
        private System.Windows.Forms.ComboBox cmbsem;
        private System.Windows.Forms.ComboBox cmbcourse;
        private System.Windows.Forms.ComboBox cmbdept;
        private System.Windows.Forms.RadioButton rbfemale;
        private System.Windows.Forms.RadioButton rbmale;
        private System.Windows.Forms.DateTimePicker dtTimePicker1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtroll;
        private System.Windows.Forms.Label lbphone;
        private System.Windows.Forms.Label lbaddr;
        private System.Windows.Forms.Label lbsem;
        private System.Windows.Forms.Label lbcourse;
        private System.Windows.Forms.Label lbdept;
        private System.Windows.Forms.Label lbgender;
        private System.Windows.Forms.Label lbdate;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label lbroll;
        private System.Windows.Forms.Label lbstudentprof;
    }
}

