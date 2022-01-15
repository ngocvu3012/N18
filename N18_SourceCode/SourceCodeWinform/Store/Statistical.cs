using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using Microsoft.Office.Interop.Excel;



namespace Store
{
    public partial class Statistical : Form
    {
        public Statistical()
        {
            InitializeComponent();
        }

        private SqlConnection conn = new SqlConnection();
        private SqlDataAdapter da = new SqlDataAdapter();

        private void connectDB(string db)
        {
            string date = dateStatistical.Text.Trim();

            conn.ConnectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True";

            SqlCommand cmd = new SqlCommand("SELECT * FROM Change WHERE type='" + db + "' and date='" +date+"'" , conn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();

            da.Fill(dt);

            storeView.DataSource = dt;
        }

        private void toExcel(DataGridView storeData, string fileName)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook worbook;
            Microsoft.Office.Interop.Excel.Worksheet workSheet;

            try
            {
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;

                worbook = excel.Workbooks.Add(Type.Missing);

                workSheet = (Microsoft.Office.Interop.Excel.Worksheet)worbook.Sheets["Sheet1"];
                workSheet.Name = "Report sheet";

                for (int i = 0; i<storeData.ColumnCount; i++)
                {
                    workSheet.Cells[1, i + 1] = storeData.Columns[i].HeaderText;
                }

                for (int i = 0; i<storeData.RowCount; i++)
                {
                    for (int j = 0; j<storeData.ColumnCount; i++)
                    {
                        workSheet.Cells[i + 2, j + 1] = storeData.Rows[i].Cells[j].Value.ToString();
                    }
                }

                worbook.SaveAs(fileName);
                worbook.Close();
                excel.Quit();
                MessageBox.Show("Save success!", "Congratulation!");
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Error!");
            }
            finally
            {
                worbook = null;
                workSheet = null;
            }
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            string fileeName = "Report date " + DateTime.Today;
            toExcel(storeView, fileeName);

            this.Close();
            Store s = new Store();
            s.Show();
        }

        private void InBtn_Click(object sender, EventArgs e)
        {
            connectDB("In");
        }

        private void outBtn_Click(object sender, EventArgs e)
        {
            connectDB("Out");
        }

        private void cancleBtn_Click(object sender, EventArgs e)
        {
            Statistical sta = this;
            sta.Close();
            Store s = new Store();
            s.Show();
        }
    }
}
