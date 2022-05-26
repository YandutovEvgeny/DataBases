using MySql.Data.MySqlClient;
using MySql.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBases
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=Localhost;Database=testdb;Uid=root;Pwd=root";
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();
            string query = $"SELECT * FROM users WHERE login = '{textBox1.Text}' AND pass = '{textBox2.Text}'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, mySqlConnection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                //MessageBox.Show(table.Rows[0].ItemArray[0].ToString());
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }  
            else
                MessageBox.Show("Нет такой записи");
            mySqlConnection.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
