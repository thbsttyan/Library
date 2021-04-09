using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class registrationForm : Form
    {
        public registrationForm()
        {
            InitializeComponent();
        }

        public bool clicked = false;
        private void passwordShowButton_Click(object sender, EventArgs e)
        {
            if (!clicked)
            {
                passwordTextField.PasswordChar = '\0';
                password2TextField.PasswordChar = '\0';
                clicked = true;
            }
            else
            {
                passwordTextField.PasswordChar = '*';
                password2TextField.PasswordChar = '*';
                clicked = false;
            }
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            Sql s = new Sql();
            authDataGridView.DataSource = s.Select("SELECT * FROM Users");

            bool isFound = false;
            for (int i = 0; i < authDataGridView.Rows.Count; i++)
            {
                try
                {
                    if (authDataGridView[1, i].Value.ToString() == loginTextField.Text)
                    {
                        isFound = true;
                        break;
                    }


                }
                catch
                {
                    isFound = false;
                    break;
                }
            }

            if (isFound)
            {
                MessageBox.Show("Такой логин уже существует");
            }
            else
            {
                if (passwordTextField.Text == password2TextField.Text)
                {
                    string connectString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Library;" +
                        "Integrated Security=true;";



                    string sqlExpr = $"INSERT INTO Users (login, pass) VALUES" +
                        $" ('{loginTextField.Text}','{passwordTextField.Text}')";

                    using (SqlConnection c = new SqlConnection(connectString))
                    {
                        c.Open();
                        SqlCommand com = new SqlCommand(sqlExpr, c);
                        com.ExecuteNonQuery();
                        c.Close();

                        MessageBox.Show("Регистрация успешна!");
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Пароли не совпадают!");
                }
            }

            
            authDataGridView.DataSource = s.Select("SELECT * FROM Users");
        }
    }
}

