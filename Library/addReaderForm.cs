using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public static bool OnlyLetters(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsLetter(c))
                    return false;
            }
            return true;
        }

        public static bool OnlyNumbers(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsNumber(c))
                    return false;
            }
            return true;
        }

        public static bool groupCheck(string s)
        {
            bool isMat = false;

            Regex reg1 = new Regex(@"(\d)-(\d)-(\d)-(\d)-(\d)");
            if (reg1.IsMatch(s))
            {
                isMat = true;
            }
            else
            {
                isMat = false;
            }

            return isMat;
            //TODO
        }

        public static bool numCheck(string s)
        {
            bool isMat = false;

            Regex reg1 = new Regex(@"(\d)-(\d)-(\d)-(\d)-(\d)");
            if (reg1.IsMatch(s))
            {
                isMat = true;
            }
            else
            {
                isMat = false;
            }

            return isMat;
            //TODO
        }

        public string book;
        private void addReaderButton_Click(object sender, EventArgs e)
        {
            if (surnameTextField.Text != ""&&(OnlyLetters(surnameTextField.Text)) 
                && nameTextField.Text != "" && OnlyLetters(nameTextField.Text)
                && patronymicTextField.Text != "" && OnlyLetters(patronymicTextField.Text)
                && (OnlyLetters(positionTextField.Text) || positionTextField.Text == "")
                && (groupCheck(groupTextField.Text) || groupTextField.Text == "")
                && (numCheck(numberTextField.Text) || numberTextField.Text == "")
                && (OnlyLetters(townTextField.Text) || townTextField.Text == "")
                && (OnlyNumbers(passportTextField.Text) || passportTextField.Text == ""))
            {


                if (booksComboBox.SelectedIndex == -1)
                {
                    book = null;
                }
                else
                {
                    book = booksComboBox.Text;
                }

                

                string connectString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Library;" +
                    "Integrated Security=true;";


                //сделать ввод с оперделением id книги по названию
                string sqlExpr = $"INSERT INTO Books (name, author, genre, type, publisher, pages, ISBN, locker, shelf, price) VALUES" +
                    $" ('{surnameTextField.Text}','{authorTextField.Text}','{genreTextField.Text}','{type}','{publisher}'," +
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
            }
        }
    }
}
