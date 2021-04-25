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

namespace Library
{
    public partial class PublisherForm : Form
    {
        public PublisherForm()
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

        public static bool phoneCheck(string s)
        {
            bool isMat = false;

            Regex reg1 = new Regex(@"^((\+)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,11}$");
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


        DateTime Today = new DateTime();
        private void addReaderButton_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addPublisherButton_Click(object sender, EventArgs e)
        {
            mainForm main = this.Owner as mainForm;
            if (publisherTextField.Text != ""
               && (phoneCheck(numberTextField.Text) || numberTextField.Text == "")
               && (OnlyLetters(townTextField.Text) || townTextField.Text == "")
               && (OnlyNumbers(ratingTextField.Text) || ratingTextField.Text == ""))
            {



                Today = DateTime.Now;




                string connectString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Library;" +
                    "Integrated Security=true;";


                //сделать ввод с оперделением id книги по названию
                string sqlExpr = $"INSERT INTO Publishers ( publisher, company, adress, town, phone_number, rating, added) VALUES" +
                    $" ('{publisherTextField.Text}','{companyTextField.Text}','{adressTextField.Text}','{townTextField.Text}'," +
                    $"'{numberTextField.Text}','{ratingTextField.Text}','{Today}')";

                using (SqlConnection c = new SqlConnection(connectString))
                {
                    c.Open();
                    SqlCommand com = new SqlCommand(sqlExpr, c);
                    com.ExecuteNonQuery();
                    c.Close();

                    MessageBox.Show("Новое издательство добавлено!");
                }

                if (main.publisherDataGridView != null)
                {
                    //Издательства
                    main.publisherDataGridView.Columns[0].HeaderText = "id";
                    main.publisherDataGridView.Columns[1].HeaderText = "Издательство";
                    main.publisherDataGridView.Columns[2].HeaderText = "Компания";
                    main.publisherDataGridView.Columns[3].HeaderText = "Адрес";
                    main.publisherDataGridView.Columns[4].HeaderText = "Город";
                    main.publisherDataGridView.Columns[5].HeaderText = "Номер телефона";
                    main.publisherDataGridView.Columns[6].HeaderText = "Рейтинг";
                    main.publisherDataGridView.Columns[7].HeaderText = "Дата добавления";
                }

                this.Close();

            }
            else
            {
                if (publisherTextField.Text == "")
                { 
                
                }
                if(!phoneCheck(numberTextField.Text) )
                {
                    numberTextField.Text = "";
                }
                if(!OnlyLetters(townTextField.Text) )
                {
                    townTextField.Text = "";
                }
                if(!OnlyNumbers(ratingTextField.Text) )
                {
                    ratingTextField.Text = "";
                }

                MessageBox.Show("Данные введены неверно");
            }

            Sql s = new Sql();
            // mf.booksDataGridView.DataSource = s.Select("SELECT * FROM Books");

            
            if (main != null)
            {
                main.publisherDataGridView.DataSource = s.Select("SELECT * FROM Publishers");
            }

            //this.Close();
        }

        private void PublisherForm_Load(object sender, EventArgs e)
        {

        }
    }
}
