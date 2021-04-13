using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class addReaderForm : Form
    {
        public addReaderForm()
        {
            InitializeComponent();
        }

        private void addReaderButton_Click(object sender, EventArgs e)
        {
           /* if (surnameTextField.Text != "" && nameTextField.Text != "" && patronymicTextField.Text != "" && OnlyLetters(authorTextField.Text)
                && (OnlyLetters(genreTextField.Text) || genreTextField.Text == "")
                && (isbnCheck(isbnTextField.Text) || isbnTextField.Text == "")
                && (OnlyNumbers(pagesTextField.Text) || pagesTextField.Text == "")
                && (OnlyNumbers(lockerTextField.Text) || lockerTextField.Text == "")
                && (OnlyNumbers(shelfTextField.Text) || shelfTextField.Text == "")
                && (priceCheck(priceTextField.Text)) || priceTextField.Text == "")
            {


                if (typeComboBox.SelectedIndex == -1)
                {
                    type = null;
                }
                else
                {
                    type = typeComboBox.Text;
                }

                if (publisherComboBox.SelectedIndex == -1)
                {
                    publisher = null;
                }
                else
                {
                    publisher = publisherComboBox.Text;
                }

                string connectString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Library;" +
                    "Integrated Security=true;";



                string sqlExpr = $"INSERT INTO Books (name, author, genre, type, publisher, pages, ISBN, locker, shelf, price) VALUES" +
                    $" ('{nameTextField.Text}','{authorTextField.Text}','{genreTextField.Text}','{type}','{publisher}'," +
                    $"'{pagesTextField.Text}','{isbnTextField.Text}','{lockerTextField.Text}','{shelfTextField.Text}','{priceTextField.Text}')";

                using (SqlConnection c = new SqlConnection(connectString))
                {
                    c.Open();
                    SqlCommand com = new SqlCommand(sqlExpr, c);
                    com.ExecuteNonQuery();
                    c.Close();

                    MessageBox.Show("Книга добавлена!");
                }


            }
            else
            {
                MessageBox.Show("aaaa");
            }*/
        }
    }
}
