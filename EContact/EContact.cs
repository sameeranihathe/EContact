using EContact.EContactClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EContact
{
    public partial class EContact : Form
    {
        public EContact()
        {
            InitializeComponent();
        }
        ContactClass c = new ContactClass();

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_contact_id_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        public void Clear()
        {
            txt_box_contact_id.Text = "";
            txt_box_first_name.Text = "";
            txt_box_last_name.Text = "";
            txt_box_address.Text = "";
            txt_box_contact_no.Text = "";
            cmb_box_gendar.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.FirstName = txt_box_first_name.Text;
            c.LastName = txt_box_last_name.Text;
            c.ContactNo = txt_box_contact_no.Text;
            c.Address = txt_box_address.Text;
            c.Gendar = cmb_box_gendar.Text;
            bool success = c.Insert(c);
            if (success == true)
            {
                MessageBox.Show("New Contact Successfully Inserted");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to Add New Contact");
            }

            //load data into gridview
            DataTable dt = c.Select();
            dataGridView.DataSource = dt;
        }

        private void EContact_Load(object sender, EventArgs e)
        {

            //load data into gridview
            DataTable dt = c.Select();
            dataGridView.DataSource = dt;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get data and load to textboxes
            int rowIndex = e.RowIndex;
            txt_box_contact_id.Text = dataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            txt_box_first_name.Text = dataGridView.Rows[rowIndex].Cells[1].Value.ToString();
            txt_box_last_name.Text = dataGridView.Rows[rowIndex].Cells[2].Value.ToString();
            txt_box_contact_no.Text = dataGridView.Rows[rowIndex].Cells[3].Value.ToString();
            txt_box_address.Text = dataGridView.Rows[rowIndex].Cells[4].Value.ToString();
            cmb_box_gendar.Text = dataGridView.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            c.ContactID = int.Parse(txt_box_contact_id.Text);
            c.FirstName = txt_box_first_name.Text;
            c.LastName = txt_box_last_name.Text;
            c.ContactNo = txt_box_contact_no.Text;
            c.Address = txt_box_address.Text;
            c.Gendar = cmb_box_gendar.Text;

            bool success = c.Update(c);
            if (success ==true)
            {
                MessageBox.Show("Contact has been updated");

                //load data into gridview
                DataTable dt = c.Select();
                dataGridView.DataSource = dt;

                //clear data
                Clear();
               
            }
            else
            {
                MessageBox.Show("Failed to update contact.");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear();
           

            
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            c.ContactID = Convert.ToInt32(txt_box_contact_id.Text);
           // c.ContactID = int.Parse(txt_box_contact_id.Text);
            bool success = c.Delete(c);

            if (success== true)
            {
                MessageBox.Show("Contact succesfully deleted.");
                //load data on gridview
                DataTable dt = c.Select();
                dataGridView.DataSource = dt;

                Clear();
                
            }
            else
            {
                MessageBox.Show("Failed to Delete Contact. Try again.");
            }
        }
        static string myconnstring = ConfigurationManager.ConnectionStrings["conn_string"].ConnectionString;

        private void txt_box_search_TextChanged(object sender, EventArgs e)
        {
            //get the value from textbox
            string keyword = txt_box_search.Text;
            SqlConnection conn = new SqlConnection(myconnstring);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_contact WHERE FirstName LIKE '%" + keyword + "%' OR LastName LIKE '%" + keyword + "%' OR Address LIKE '%" + keyword + "%'",conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView.DataSource = dt;

        }

        
    }
}
