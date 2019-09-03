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

namespace CRUD_with_code
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }
        connection obj = new connection();
        string Availibility;
        

        
            
        

        private void bttn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                


                if (txt_ID.Text!="" && txt_name.Text!="" && txt_price.Text!="" && txt_ingredients.Text!="")
                {
                    string id = txt_ID.Text;
                    string name = txt_name.Text;
                    double price = Convert.ToDouble(txt_price.Text);
                    string ingredients = txt_ingredients.Text;

                    if (rad_available.Checked)
                    {
                        Availibility = "Available";
                    }
                    if (rad_notavailable.Checked)
                    {
                        Availibility = "Not Available";
                    }


                    SqlConnection con = obj.connect();
                    string insert_query = "insert into Item values('" + id + "','" + name + "',"+ price +",'" + ingredients + "','" + Availibility + "')";
                    SqlCommand cmd = new SqlCommand(insert_query, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("inserted");
                    con.Close();

                    
                }
                else
                {
                    MessageBox.Show("Please complete form correctlly");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_ID.Text != "" && txt_name.Text != "" && txt_price.Text != "" && txt_ingredients.Text != "")
                {
                    string id = txt_ID.Text;
                    string Eid = txt_enterID.Text;
                    string name = txt_name.Text;
                    double price = Convert.ToDouble(txt_price.Text);
                    string ingredients = txt_ingredients.Text;

                    if (rad_available.Checked)
                    {
                        Availibility = "Available";
                    }
                    if (rad_notavailable.Checked)
                    {
                        Availibility = "Not Available";
                    }

                    SqlConnection con = obj.connect();
                    string update_query = "update Item set Id='"+id+"', Name='"+name+"',Price="+price+",Ingredients='"+ ingredients + "',Availability='"+ Availibility + "' where Id ='"+ Eid + "'";
                    SqlCommand cmd = new SqlCommand(update_query, con);
                    SqlDataReader rdr;
                    con.Open();
                    rdr = cmd.ExecuteReader();
                    MessageBox.Show("Data Updated");
                    con.Close();

                }
                else
                {
                    MessageBox.Show("Please complete form correctlly");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_enterID.Text!="")
            {
                string Eid = txt_enterID.Text;

                SqlConnection con = obj.connect();
                string delete_query = "delete from Item where Id='"+Eid+"'";
                SqlCommand cmd = new SqlCommand(delete_query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleteed");
                con.Close();
            }

            else
            {
                MessageBox.Show("please enter the ID");
            }
        }

        private void btn_fetch_Click(object sender, EventArgs e)
        {
            SqlConnection con = obj.connect();
            string show_query = "select * from Item";
            SqlDataAdapter da = new SqlDataAdapter(show_query, con);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();
            dgv_pizza.DataSource = dt;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = obj.connect();
                string query = "select * from Item where Id='" + txt_enterID.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr;
                con.Open();
                sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    txt_ID.Text = txt_enterID.Text;
                    txt_name.Text = sdr.GetString(1);
                    txt_price.Text = sdr.GetValue(2).ToString();
                    txt_ingredients.Text = sdr.GetString(3);

                    string result = sdr["Availability"].ToString();
                    if (result == "Available")
                    {
                        rad_available.Checked = true;
                    }
                    if (result == "Not Available")
                    {
                        rad_notavailable.Checked = true;
                    }
                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_enterID.Text = "";
            txt_ID.Text = "";
            txt_ingredients.Text = "";
            txt_name.Text = "";
            txt_price.Text = "";
            rad_available.Checked = false;
            rad_notavailable.Checked = false;
        }
    }
}
