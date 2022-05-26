using MySql.Data.MySqlClient;
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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                MessageBox.Show("Все поля обязательны к заполнению!");
            else if (textBox3.Text != textBox2.Text)
                MessageBox.Show("Пароли должны совпадать!");
            else
            {
                try
                {
                    //Создаём подключение в базу
                    string connectionString = "Server=Localhost;Database=testdb;Uid=root;Pwd=root";
                    MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
                    //Открываем подключение в базу (Заходим в базу)
                    mySqlConnection.Open();
                    // Запрос на добавление в базу данных
                    string query = $"INSERT INTO users (login, pass) VALUES ('{textBox1.Text}', '{textBox2.Text}')";
                    //Создаём запрос query на такую то базу данных
                    MySqlCommand command = new MySqlCommand(query, mySqlConnection);
                    //Отправляем запрос
                    command.ExecuteNonQuery();
                    //Выходим из базы
                    mySqlConnection.Close();
                    Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Данный логин уже занят");
                }
                
            }
        }
    }
}
