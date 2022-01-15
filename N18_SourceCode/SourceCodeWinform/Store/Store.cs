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
    public partial class Store : Form
    {
        public Store()
        {
            InitializeComponent();
        }

        private SqlConnection conn = new SqlConnection();

        private string select;

        private string ProductID, name, number, price, detail;

        private void connectDB()
        {
            storeListView.Items.Clear();

            conn.ConnectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True";

            SqlCommand cmd = new SqlCommand("SELECT * FROM " + select,  conn);

            SqlDataReader dr = cmd.ExecuteReader();

            int i = 0;

            while(dr.Read() == true)
            {
                storeListView.Items.Add(dr[0].ToString());
                storeListView.Items[i].SubItems.Add(dr[1].ToString());
                storeListView.Items[i].SubItems.Add(dr[2].ToString());
                storeListView.Items[i].SubItems.Add(dr[3].ToString());
                storeListView.Items[i].SubItems.Add(dr[4].ToString());
            }

        }

        private void cancleBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit?", "Alert!", MessageBoxButtons.YesNo);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Have a nice day! :)))", "Good bye");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Welcome back!", "Hello");
            }
        }

        private void editInChange_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit("In", select);
            edit.Show();
        }

        private void editOutChange_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit("Out", select, ProductID, name, number, price, detail);
            edit.Show();
        }

        private void statisticalView_Click(object sender, EventArgs e)
        {
            Statistical report = new Statistical();
            report.Show();
            this.Hide();
        }

        private void deleBtn_Click(object sender, EventArgs e)
        {

        }

        private void vegetableBtn_Click(object sender, EventArgs e)
        { 
            select = "Vegetable";

            connectDB();
        }

        private void meatBtn_Click(object sender, EventArgs e)
        {
            select = "Meat";

            connectDB();
        }

        private void fruitBtn_Click(object sender, EventArgs e)
        {
            select = "Fruit";

            connectDB();
        }

        private void drinkBtn_Click(object sender, EventArgs e)
        {
            select = "Drink";

            connectDB();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            Edit ed = new Edit("Edit", select, ProductID, name, number, price, detail);
            ed.Show();
        }

        private void storeListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductID = storeListView.SelectedItems[0].SubItems[0].Text;
            name = storeListView.SelectedItems[1].SubItems[1].Text;
            number = storeListView.SelectedItems[2].SubItems[2].Text;
            price = storeListView.SelectedItems[3].SubItems[3].Text;
            detail = storeListView.SelectedItems[4].SubItems[4].Text;
        }
    }
}
