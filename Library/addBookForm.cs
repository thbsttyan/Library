using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Library
{
    public partial class addBookForm : Form
    {
       
        public addBookForm()
        {
            InitializeComponent();

            Sql s = new Sql();
            pubDataGridView.DataSource = s.Select("Select * from Publishers"); 

            string[] combo = new string[pubDataGridView.Rows.Count-1];
            
            for (int i = 0; i < pubDataGridView.Rows.Count-1; i++)
            {
                    combo[i] += pubDataGridView[1, i].Value.ToString();

                
            }

           publisherComboBox.Items.AddRange(combo);            
        }

        public static bool OnlyLetters(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsLetter(c) && c != ' ')
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

        public static bool priceCheck(string s)
        {
            bool isFloat = false;

            Regex reg1 = new Regex(@"\-?\d+\.?\,?\d*");
            if (reg1.IsMatch(s))
            {
                isFloat = true;
            }
            else
            {
                isFloat = false;
            }

            return isFloat;
        }

        public static bool isbnCheck(string s)
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
        }

        public string type;
        public bool isType = false;
        public string publisher;
        public bool isPublisher = false;
        public float price;
        mainForm mf = new mainForm();
        private void addBookButton_Click(object sender, EventArgs e)
        {
            if (typeComboBox.SelectedIndex == -1)
            {
                type = null;
                isType = false;
            }
            else
            {
                type = typeComboBox.Text;
                isType = true;
            }

            if (publisherComboBox.SelectedIndex == -1)
            {
                publisher = null;
                isPublisher = false;
            }
            else
            {
                publisher = publisherComboBox.Text;
                isPublisher = true;
            }

            if (nameTextField.Text!="" && (authorTextField.Text != "" && OnlyLetters(authorTextField.Text))
                && (OnlyLetters(genreTextField.Text) || genreTextField.Text=="")
                && (isbnCheck(isbnTextField.Text) || isbnTextField.Text=="") 
                && (OnlyNumbers(pagesTextField.Text) || pagesTextField.Text == "")
                && (OnlyNumbers(lockerTextField.Text) || lockerTextField.Text=="")
                && (OnlyNumbers(shelfTextField.Text) || shelfTextField.Text=="")
                && (priceCheck(priceTextField.Text) || priceTextField.Text=="")
                && isType && isPublisher)
            {
                

                

                string connectString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Library;" +
                    "Integrated Security=true;";

                

                string sqlExpr = $"INSERT INTO Books (name, author, genre, type, publisher, pages, ISBN, locker, shelf, price, status) VALUES" +
                    $" ('{nameTextField.Text}','{authorTextField.Text}','{genreTextField.Text}','{type}','{publisher}'," +
                    $"'{pagesTextField.Text}','{isbnTextField.Text}','{lockerTextField.Text}','{shelfTextField.Text}','{priceTextField.Text}', 'В библиотеке')";

                using (SqlConnection c = new SqlConnection(connectString))
                {
                    c.Open();
                    SqlCommand com = new SqlCommand(sqlExpr, c);
                    com.ExecuteNonQuery();
                    c.Close();

                    MessageBox.Show("Книга добавлена!");
                }


                string noZeroPages = $"update Books set pages = NULL where pages = 0";
                string noZeroLocker = $"update Books set locker = NULL where locker = 0";
                string noZeroShelf = $"update Books set shelf = NULL where shelf = 0";
                string noZeroPrice = $"update Books set price = NULL where price = 0";

                using (SqlConnection c = new SqlConnection(connectString))
                {
                    c.Open();
                    SqlCommand com = new SqlCommand(noZeroPages, c);
                    SqlCommand com2 = new SqlCommand(noZeroLocker, c);
                    SqlCommand com3 = new SqlCommand(noZeroShelf, c);
                    SqlCommand com4 = new SqlCommand(noZeroPrice, c);
                    com.ExecuteNonQuery();
                    com2.ExecuteNonQuery();
                    com3.ExecuteNonQuery();
                    com4.ExecuteNonQuery();
                    c.Close();
                }


                mainForm f = new mainForm();
                if (f.booksDataGridView != null)
                {
                    f.booksDataGridView.Columns[1].HeaderText = "Название";
                    f.booksDataGridView.Columns[2].HeaderText = "Автор";
                    f.booksDataGridView.Columns[3].HeaderText = "Жанр";
                    f.booksDataGridView.Columns[4].HeaderText = "Тип";
                    f.booksDataGridView.Columns[5].HeaderText = "Издательство";
                    f.booksDataGridView.Columns[6].HeaderText = "Страницы";
                    f.booksDataGridView.Columns[8].HeaderText = "Номер шкафа";
                    f.booksDataGridView.Columns[9].HeaderText = "Номер полки";
                    f.booksDataGridView.Columns[10].HeaderText = "Цена";
                    f.booksDataGridView.Columns[11].HeaderText = "Статус";
                }
                

                this.Close();
            }
            else
            {
                if(nameTextField.Text == "")
                {
                    
                }
                if (authorTextField.Text == "" || !OnlyLetters(authorTextField.Text))
                {
                    authorTextField.Text = "";
                }

                if (!OnlyLetters(genreTextField.Text) )
                {
                    genreTextField.Text = "";
                }

                if (!isbnCheck(isbnTextField.Text) )
                {
                    isbnTextField.Text = "";
                }

                if(!OnlyNumbers(pagesTextField.Text) )
                {
                    pagesTextField.Text = "";
                }

                if(!OnlyNumbers(lockerTextField.Text) )
                {
                    lockerTextField.Text = "";
                }

                if(!OnlyNumbers(shelfTextField.Text) )
                {
                    shelfTextField.Text = "";
                }

                if(!priceCheck(priceTextField.Text) )
                {
                    priceTextField.Text = "";
                }
                MessageBox.Show("Данные введены неверно");
            }

            Sql s = new Sql();

            mainForm main = this.Owner as mainForm;
            if (main != null)
            {
                main.booksDataGridView.DataSource = s.Select("SELECT * FROM Books");
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

       
        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

    }
}
