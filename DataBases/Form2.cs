using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace DataBases
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            /*MySqlConnection connection = new MySqlConnection
                ("Server=Localhost;Database=testdb;Uid=root;Pwd=root");
            connection.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM users", connection);*/

            MySqlDataAdapter adapter = new MySqlDataAdapter
                ("SELECT * FROM users", "Server=Localhost;Database=testdb;Uid=root;Pwd=root");

            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            //connection.Close();
        }
    }
}
