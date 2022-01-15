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

namespace Store
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private SqlConnection conn = new SqlConnection();

        private bool isEmpty()
        {
            if (emailEmployee.Text.Trim().Equals("") && 
                passEmployee.Text.Trim().Equals(""))
            {
                MessageBox.Show("Pleasee fill in!", "Error");
                return false;
            } else if(emailEmployee.Text.Trim().Equals("") || 
                passEmployee.Text.Trim().Equals(""))
            {
                MessageBox.Show("Pleasee fill in!", "Error");
                return false;
            }

            return true;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                conn.ConnectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True";
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Employee WHERE email ='" + emailEmployee.Text.Trim()
                    + "' and password='" + passEmployee.Text.Trim() + "'", conn);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable table = new DataTable();
                da.Fill(table);

                if (table.Rows.Count == 1)
                {
                    MessageBox.Show("Login succes!", "Messagee");
                    Store s = new Store();
                    this.Hide();
                    s.Show();
                }
                else
                {
                    MessageBox.Show("Try again!", "Message");
                }
                conn.Close();
            }
        }

        private void passEmployee_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailEmployee_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
