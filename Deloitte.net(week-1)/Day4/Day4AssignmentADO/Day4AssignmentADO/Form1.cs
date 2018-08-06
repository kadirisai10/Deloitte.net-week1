using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Day4AssignmentADO
{
    public partial class Form1 : Form
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader r = null;
        string constr = "Data Source=(local);Initial Catalog=AssignmentDB;Integrated Security=True;Pooling=False";
        public Form1()
        {
            InitializeComponent();
        }

        private void btaddnew_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;

            DateTime dob = DateTime.Parse(dtTimePicker1.Value.ToString());

            string gender = " ";
            if (rbmale.Checked)
                gender = rbmale.Text;
            if (rbfemale.Checked)
                gender = rbfemale.Text;

            string dept = cmbdept.SelectedItem.ToString();

            string course = cmbcourse.SelectedItem.ToString();

            string sem = cmbsem.SelectedItem.ToString();

            string address = txtaddr.Text;

            string phone = txtphone.Text;

           
            try
            {
                con = new SqlConnection(constr);
                con.Open();
                string query = "insert into StudentInfo(name,DOB,gender,dept,course,sem,addr,phone) values(@nm,@dob,@gen,@dep,@cou,@sem,@add,@pho)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nm", name);
                cmd.Parameters.AddWithValue("@dob", dob);
                cmd.Parameters.AddWithValue("@gen", gender);
                cmd.Parameters.AddWithValue("@dep", dept);
                cmd.Parameters.AddWithValue("@cou", course);
                cmd.Parameters.AddWithValue("@sem", sem);
                cmd.Parameters.AddWithValue("@add", address);
                cmd.Parameters.AddWithValue("@pho", phone);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    MessageBox.Show("Data inserted:" + res);
                

            }
            catch (SqlException sql)
            {

                MessageBox.Show(sql.Message);

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

            finally
                {
                con.Close();
            }



        }

        private void btselect_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(constr);
                con.Open();
                string query = "select * from StudentInfo";
                cmd = new SqlCommand(query, con);
                r= cmd.ExecuteReader();
                lbselect.Items.Clear();

                while (r.Read())
                {
                    for (int i = 0; i < r.FieldCount; i++)
                    {
                        lbselect.Items.Add(r[i]);
                    }

                    lbselect.Items.Add("*********");
                }
            }
            catch (SqlException sql)
            {

                MessageBox.Show(sql.Message);
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();
            }
        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            try
            {
                int rollno = int.Parse(txtroll.Text);
                string name = txtname.Text;
                string addr = txtaddr.Text;
                string phone = txtphone.Text;
                DateTime dob = DateTime.Parse(dtTimePicker1.Value.ToString());

                string gender = " ";
                if (rbmale.Checked)
                    gender = rbmale.Text;
                if (rbfemale.Checked)
                    gender = rbfemale.Text;

                string dept = cmbdept.SelectedItem.ToString();
                string course = cmbcourse.SelectedItem.ToString();
                string sem = cmbsem.SelectedItem.ToString();

                con = new SqlConnection(constr);
                con.Open();
                string query = "update StudentInfo set name=@name,DOB=@dob,gender=@gen,dept=@dep,course=@cor,sem=@sem,addr=@add,phone=@pho where Rollno=@roll";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@roll", rollno);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@dob", dob);
                cmd.Parameters.AddWithValue("@gen", gender);
                cmd.Parameters.AddWithValue("@dep", dept);
                cmd.Parameters.AddWithValue("@cor", course);
                cmd.Parameters.AddWithValue("@sem", sem);
                cmd.Parameters.AddWithValue("@add", addr);
                cmd.Parameters.AddWithValue("@pho", phone);

                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    MessageBox.Show("data updated:" + res);

            }
            catch (SqlException sql)
            {

                MessageBox.Show(sql.Message);
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();
            }
        }

        private void btfind_Click(object sender, EventArgs e)
        {
            
            try
            {
                int rollno = int.Parse(txtroll.Text);
                con = new SqlConnection(constr);
                con.Open();
                string query = "select * from StudentInfo where Rollno=@roll";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@roll", rollno);
                r = cmd.ExecuteReader();
                lbselect.Items.Clear();

                while (r.Read())
                {
                    for (int i = 0; i < r.FieldCount; i++)
                    {
                        lbselect.Items.Add(r[i]);
                    }

                    lbselect.Items.Add("*********");
                }
            }
            catch (SqlException sql)
            {

                MessageBox.Show(sql.Message);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();
            }
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            try
            {
                int roll = int.Parse(txtroll.Text);
                MessageBox.Show(" deleted :" + roll);
                con = new SqlConnection(constr);
                con.Open();
                string query = "delete from StudentInfo where Rollno=@roll";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@roll", roll);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    MessageBox.Show("data Deleted:" + res);
                
                //Update to data sert takes place here

            }
            catch (SqlException sql)
            {

                MessageBox.Show(sql.Message);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            finally
            {
                con.Close();
            }
        }
    }
}
