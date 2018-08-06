using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBFirstExample
{
    public partial class Form1 : Form
    {
        TrainingDBEntities db = new TrainingDBEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            //form data
            //textbox
            string name = txtname.Text;
            //combobox
            string gender = cbgender.SelectedItem.ToString();
            //radiobutton
            string membership = " ";

            if (rbfree.Checked)
                membership = rbfree.Text;
            if (rbpaid.Checked)
                membership = rbpaid.Text;
            //checkedlistbox

            string shopping = " ";
            foreach (var d in clbshop.CheckedItems)
            {
                shopping += d + ",";
            }

            //checkbox
            string cod = " ";
            if (cbcod.Checked)
                cod = "Yes";
            else
                cod = "No";

            string pass = txtpassword.Text;

            MessageBox.Show(name + "\n" + gender + "\n" + membership + "\n" + shopping + "\n" + cod + "\n" + pass);

            //insert data to db through Entity Framework

            ResgisterShopping rs = new ResgisterShopping();
            rs.Name = name;
            rs.Gender = gender;
            rs.Membership = membership;
            rs.ShoppingPreference = shopping;
            rs.COD = cod;
            rs.Password = pass;
            db.ResgisterShoppings.Add(rs);
            var res=db.SaveChanges();//save it to storage model
            if (res > 0)
                MessageBox.Show("data inserted"+res);
            this.resgisterShoppingTableAdapter.Fill(this.trainingDBDataSet.ResgisterShopping);
        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            foreach (var t in db.ResgisterShoppings)

            {
                lbselect.Items.Add(t.Id);
                lbselect.Items.Add(t.Name);
                lbselect.Items.Add(t.Gender);
                lbselect.Items.Add(t.Membership);
                lbselect.Items.Add(t.ShoppingPreference);
                lbselect.Items.Add(t.COD);
                lbselect.Items.Add(t.Password);
                lbselect.Items.Add("***********");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trainingDBDataSet.ResgisterShopping' table. You can move, or remove it, as needed.
            this.resgisterShoppingTableAdapter.Fill(this.trainingDBDataSet.ResgisterShopping);

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int id = (int)cbID.SelectedValue;
            var del = (from t in db.ResgisterShoppings
                       where t.Id == id
                       select t).SingleOrDefault();

            db.ResgisterShoppings.Remove(del);
            var res = db.SaveChanges();
            if (res > 0)
                MessageBox.Show("data deleted" + res);

                this.resgisterShoppingTableAdapter.Fill(this.trainingDBDataSet.ResgisterShopping);

        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            string membership = " ";

            if (rbfree.Checked)
                membership = rbfree.Text;
            if (rbpaid.Checked)
                membership = rbpaid.Text;
            //checkedlistbox

            string shopping = " ";
            foreach (var d in clbshop.CheckedItems)
            {
                shopping += d + ",";
            }

            //checkbox
            string cod = " ";
            if (cbcod.Checked)
                cod = "Yes";
            else
                cod = "No";

            string pass = txtpassword.Text;

            int id = (int)cbID.SelectedValue;
            var olddata = db.ResgisterShoppings.Where(x => x.Id == id).SingleOrDefault();
            olddata.Membership = membership;
            olddata.ShoppingPreference = shopping;
            olddata.COD = cod;
            olddata.Password = pass;
            olddata.Id = id;
            var res = db.SaveChanges();
            if (res > 0)
                MessageBox.Show("data updated" + res);
        }

        private void btncallsp_Click(object sender, EventArgs e)
        {
            int id = (int)cbID.SelectedValue;
            lbselect.Items.Clear();
            var rs = db.sp_SelectRegisterShopping(id);

            foreach (var r in rs)
            {


                lbselect.Items.Add(r.Id);
                
                lbselect.Items.Add(r.Name);
                lbselect.Items.Add(r.Gender);
                lbselect.Items.Add(r.Membership);
                lbselect.Items.Add(r.ShoppingPreference);
                lbselect.Items.Add(r.COD);
                lbselect.Items.Add(r.Password);
            }
        }
    }
}
