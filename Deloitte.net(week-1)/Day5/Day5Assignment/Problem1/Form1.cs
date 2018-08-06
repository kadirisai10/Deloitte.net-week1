using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem1
{
   

    public partial class Form1 : Form
    {
        AssignmentDBEntities db = new AssignmentDBEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void btaddnew_Click(object sender, EventArgs e)
        {
            //int rollno = (int)Parse(txtroll.Text);
            string name = txtname.Text;
            DateTime dob = DateTime.Parse(dtTimePicker1.Value.ToString());
            string gender = " ";
            if (rbfemale.Checked)
                gender = rbfemale.Text;
            if (rbmale.Checked)
                gender = rbmale.Text;
            string dept = cmbdept.SelectedItem.ToString();
            string course = cmbcourse.SelectedItem.ToString();
            string sem = cmbsem.SelectedItem.ToString();
            string addr = txtaddr.Text;
            string phone = txtphone.Text;

            MessageBox.Show( name + " " + dob + " " + gender + " " + dept + " " + course + " " + sem + " " + addr + " " + phone);

            StudentInfo si = new StudentInfo();
           // si.Rollno = rollno;
            si.name = name;
            si.DOB = dob;
            si.dept = dept;
            si.gender = gender;
            si.course = course;
            si.sem = sem;
            si.addr = addr;
            si.phone = phone;


            db.StudentInfoes.Add(si);
            var res = db.SaveChanges();
            if (res > 0)
                MessageBox.Show("data inserted " + res);

        }

        private void btselect_Click(object sender, EventArgs e)
        {
            lbselect.Items.Clear();
            foreach (var i in db.StudentInfoes)
            {
                lbselect.Items.Add(i.Rollno);
                lbselect.Items.Add(i.name);
                lbselect.Items.Add(i.DOB);
                lbselect.Items.Add(i.gender);
                lbselect.Items.Add(i.dept);
                lbselect.Items.Add(i.course);
                lbselect.Items.Add(i.sem);
                lbselect.Items.Add(i.addr);
                lbselect.Items.Add(i.phone);
                lbselect.Items.Add("***********");
            }
        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            string gender = " ";
            if (rbfemale.Checked)
                gender = rbfemale.Text;
            if (rbmale.Checked)
                gender = rbmale.Text;
            DateTime dob = DateTime.Parse(dtTimePicker1.Value.ToString());
            string dept = cmbdept.SelectedItem.ToString();
            string course = cmbcourse.SelectedItem.ToString();
            string sem = cmbsem.SelectedItem.ToString();
            

            int roll = int.Parse(txtroll.Text);

            var olddata = db.StudentInfoes.Where(x => x.Rollno == roll).SingleOrDefault();
            olddata.name = name;
            olddata.DOB = dob;
            olddata.gender = gender;
            olddata.dept = dept;
            olddata.course = course;
            olddata.sem = sem;

            var res = db.SaveChanges();
            MessageBox.Show("data updated");
                
            


        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtroll.Text);
            var del = (from t in db.StudentInfoes
                       where t.Rollno == id
                       select t).SingleOrDefault();

            db.StudentInfoes.Remove(del);
            var res = db.SaveChanges();
            if (res > 0)
                MessageBox.Show("data deleted" + res);
        }

        private void btfind_Click(object sender, EventArgs e)
        {
            lbselect.Items.Clear();
            int roll = int.Parse(txtroll.Text);
            var data = (from t in db.StudentInfoes
                        where t.Rollno == roll
                        select t).SingleOrDefault();

            lbselect.Items.Add(data.name);
            lbselect.Items.Add(data.DOB);
            lbselect.Items.Add(data.gender);
            lbselect.Items.Add(data.dept);
            lbselect.Items.Add(data.course);
            lbselect.Items.Add(data.sem);
            lbselect.Items.Add(data.addr);
            lbselect.Items.Add(data.phone);



        }
    }
}
