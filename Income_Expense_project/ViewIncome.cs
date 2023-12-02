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
using System.Data;

namespace Income_Expense_project
{
    public partial class ViewIncome : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\final project - Copy\Projects\Income_Expense_project\Income_Expense_project\database\income.mdf;Integrated Security=True;Connect Timeout=30");
        public ViewIncome()
        {
            InitializeComponent();
        }

        private void ViewExpense_Load(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ViewExpense newForm = new ViewExpense();
            newForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard newForm = new Dashboard();
            newForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Income newForm = new Income();
            newForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Expense newForm = new Expense();
            newForm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Log Out");
            this.Hide();
        }

        

        private void show_btn_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from income", cn);
            DataTable t = new DataTable();
            da.Fill(t);
            dataGridView1.DataSource = t;

            label1.Text = "0";
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                label1.Text = Convert.ToString(double.Parse(label1.Text) + double.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()));
            }

      
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
            MessageBox.Show("Deleted");


        }

     

        


    }
}
