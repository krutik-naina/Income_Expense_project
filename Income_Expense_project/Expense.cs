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


namespace Income_Expense_project
{
    public partial class Expense : Form
    {
        public Expense()
        {
            InitializeComponent();
        }

        SqlConnection cn;


        private void button2_Click(object sender, EventArgs e)
        {
            Income newForm = new Income();
            newForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewIncome newForm = new ViewIncome();
            newForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button7_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("insert into Expense values('" + textBox1.Text + "','" + comboBox1.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Text + "')", cn);
            DataTable t = new DataTable();
            da.Fill(t);
            MessageBox.Show("Inserted");

            string f = textBox1.Text;
            string l = textBox2.Text;

            label7.Text = f + " " + l;

            textBox1.Text = "";
            textBox2.Text = "";
            Select();
        }

        private void Expense_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\final project - Copy\Projects\Income_Expense_project\Income_Expense_project\database\Expense.mdf;Integrated Security=True;Connect Timeout=30");
            cn.Open();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ViewExpense newForm = new ViewExpense();
            newForm.Show();
            this.Hide();
        }
    }
}
