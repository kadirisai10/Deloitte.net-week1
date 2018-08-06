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

namespace ADOExample
{
    public partial class Form1 : Form
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader r = null;
        string constr = "Data Source=(local);Initial Catalog=TrainingDB;Integrated Security=True;Pooling=False";

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblCOD_Click(object sender, EventArgs e)
        {

        }

        private void btnregister_Click(object sender, EventArgs e)
        {
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
            foreach(var d in clbshop.CheckedItems)
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

            try
            {
                con = new SqlConnection(constr);
                con.Open();
                string query = "insert into ResgisterShopping values(@nm,@gen,@mem,@pre,@cod,@pwd)";//parameters to sql query
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nm", name);
                cmd.Parameters.AddWithValue("@gen", gender);
                cmd.Parameters.AddWithValue("@mem", membership);
                cmd.Parameters.AddWithValue("@pre", shopping);
                cmd.Parameters.AddWithValue("@cod", cod);
                cmd.Parameters.AddWithValue("@pwd", pass);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    MessageBox.Show("Data inserted:" + res);
                this.resgisterShoppingTableAdapter.Fill(this.trainingDBDataSet.ResgisterShopping);

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

        private void btnselect_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(constr);
                con.Open();
                string query = "select * from ResgisterShopping";
                cmd = new SqlCommand(query, con);
                r = cmd.ExecuteReader();
                lbselect.Items.Clear();
                while(r.Read())
                {
                    for(int i=0;i<r.FieldCount;i++)
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

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trainingDBDataSet.ResgisterShopping' table. You can move, or remove it, as needed.
            this.resgisterShoppingTableAdapter.Fill(this.trainingDBDataSet.ResgisterShopping);

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)cbID.SelectedValue;
                MessageBox.Show("ID is :" + id);
                con = new SqlConnection(constr);
                con.Open();
                string query = "delete from ResgisterShopping where ID=@id";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", id);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    MessageBox.Show("data Deleted:" + res);
                this.resgisterShoppingTableAdapter.Fill(this.trainingDBDataSet.ResgisterShopping);
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

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                string membership = " ";
                if (rbpaid.Checked)
                    membership = rbpaid.Text;
                if (rbfree.Checked)
                    membership = rbfree.Text;

                string shop = " ";
                foreach(var s in clbshop.CheckedItems)
                {
                    shop += s + ",";
                }

                string pass = txtpassword.Text;
                int id = (int)cbID.SelectedValue;
                con = new SqlConnection(constr);
                con.Open();
                string query = "update ResgisterShopping set Membership=@mem,ShoppingPreference=@shop,Password=@pass where Id=@id";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@mem", membership);
                cmd.Parameters.AddWithValue("@shop", shop);
                cmd.Parameters.AddWithValue("@pass", pass);
                cmd.Parameters.AddWithValue("@id", id);
                int str = cmd.ExecuteNonQuery();
                if (str > 0)
                    MessageBox.Show("Updated:" + str);



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
