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
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        private string select;
        private string storeSelected;

        public Edit(string action, string store): this()
        {
            select = action;
            storeSelected = store;

            typeAction.Text = action;
            selectedStore.Text = store;

            da = new SqlDataAdapter("SELECT * FROM " + selectedStore, conn);

            dt = new DataTable();

            da.Fill(dt);

            conn.Open();

            typeAction_SelectedIndexChanged();
        }

        public Edit(string action, string store, string ID, string name, string number, string price, string detail): this()
        {
            valuePrice.Text = price;
            valueDetail.Text = detail;
            select = action;
            storeSelected = store;
            valueID.Text = ID;
            valueName.Text = name;

            if (store.Equals("Vegetable") || store.Equals("Meat") || store.Equals("Fruit"))
                valueNumber.Text = number + " kg";
            else if (store.Equals("Drink"))
                valueNumber.Text = number + " pack";

            da = new SqlDataAdapter("SELECT * FROM " + selectedStore, conn);

            dt = new DataTable();

            da.Fill(dt);

            conn.Open();

            typeAction_SelectedIndexChanged();
        }

        private void typeAction_SelectedIndexChanged()
        {
            if (typeAction.Text.Equals("In"))
            {
                takeoutNumber.ReadOnly = true;
                valuePrice.ReadOnly = false;
                valueDetail.ReadOnly = false;
                select = "In";
            }
            else if (typeAction.Text.Equals("Out"))
            {
                takeoutNumber.ReadOnly = false;
                valuePrice.ReadOnly = true;
                valueDetail.ReadOnly = true;
                select = "Out";
            }
            else if (typeAction.Text.Equals("Edit"))
            {
                takeoutNumber.ReadOnly = true;
                valuePrice.ReadOnly = false;
                valueDetail.ReadOnly = false;
                valueID.ReadOnly = true;
                select = "Edit";
            }
        }

        private void cancleBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private SqlConnection conn = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
        private SqlDataAdapter da;
        private DataTable dt;

        private bool valueIn()
        {
            if (valueName.Text.Equals("") || valueNumber.Text.Equals("") || valuePrice.Text.Equals("")
                || valueID.Text.Equals(""))
            {
                MessageBox.Show("PLease fil in!", "Error");
                return false;
            }

            string sqlCheck = "SELECT ID FROM " + selectedStore + " WHERE ID='" + valueID.Text + "'";
            SqlCommand cmdCheck = new SqlCommand(sqlCheck, conn);
            SqlDataReader dr = cmdCheck.ExecuteReader();
            if (dr.Read() == true)
            {
                MessageBox.Show("ID havee been exist!", "Error");
                return false;
            }
            else if (dr.Read() == false)
            {
                string sql = @"INSERT INTO " + selectedStore + "(ID, name, number, price, detail)" +
                    " VALUES(N'" + valueID.Text.ToString()+@"', N'"+valueName.Text.ToString()
                    + @"', N'"+ float.Parse(valueNumber.Text)+ @"', N'"+ valuePrice.Text+@"', N'" + valueDetail.Text +@"')";

                SqlCommand cmd = new SqlCommand(sql, conn);
                
            }

            dr.Close();

            return true;
        }

        private bool valueOut()
        {
            if (valueName.Text.Equals("") || valueNumber.Text.Equals("") || valuePrice.Text.Equals("")
            || valueID.Text.Equals(""))
            {
                MessageBox.Show("PLease fil in!", "Error");
                return false;
            }
            else
            {
                float number = float.Parse(valueNumber.Text);
                float valueTakeOut = float.Parse(takeoutNumber.Text);
                float temp;
                if (number < valueTakeOut)
                {
                    MessageBox.Show("Too much value take out", "Error!");
                    return false;
                }
                else
                {
                    temp = number - valueTakeOut;

                    string sql = "UPDATE " + selectedStore + "SET name = @name, value = @value, price = @price, detail = @detail";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("name", valueName.Text);
                    cmd.Parameters.AddWithValue("value", temp);
                    cmd.Parameters.AddWithValue("price", valuePrice.Text);
                    cmd.Parameters.AddWithValue("detail", valueDetail.Text);
                }
            }

            return true;
        }

        private void editValue()
        {
            string sql = "UPDATE " + selectedStore + "SET name = @name, value = @value, price = @price, detail = @detail";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("name", valueName.Text);
            cmd.Parameters.AddWithValue("value", float.Parse(valueNumber.Text));
            cmd.Parameters.AddWithValue("price", valuePrice.Text);
            cmd.Parameters.AddWithValue("detail", valueDetail.Text);
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (select.Equals("In"))
            {
                if (valueIn() == true)
                {
                    MessageBox.Show("Success!", "Congratulation");
                    this.Close();
                }
            }
            else if (select.Equals("Out"))
            {
                if (valueOut() == true)
                {
                    MessageBox.Show("Success!", "Congratulation");
                    this.Close();
                }
            }
            else if (select.Equals("Edit"))
            {
                editValue();
            }

            connectToStatistical();
        }

        private void connectToStatistical()
        {
            da = new SqlDataAdapter("SELECT * FROM Change", conn);

            dt = new DataTable();

            da.Fill(dt);

            conn.Open();

            if (select.Equals("In") || select.Equals(""))
            {
                string sql = @"INSERT INTO Change(ID, name, number, price, detail, date, type)" +
                    " VALUES(N'" + valueID.Text.ToString() + @"', N'" + valueName.Text.ToString()
                    + @"', N'" + float.Parse(valueNumber.Text) + @"', N'" + valuePrice.Text + @"', N'" + valueDetail.Text + @"', N'"
                    + valueDate.Value +@"', N'" + select + @"')";

                SqlCommand cmd = new SqlCommand(sql, conn);
            }
        }
    }
}
