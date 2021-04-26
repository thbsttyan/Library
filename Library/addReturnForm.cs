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
    public partial class addReturnForm : Form
    {
        public addReturnForm()
        {
            InitializeComponent();

            readDateTimePicker.MaxDate = DateTime.Now;
        }
        public DateTime dateOfIssue;

        public int selectedID = 0;
        public int selectedLending = 0;

        public string surname;
        public string name;
        public string patronymic;


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

       
        private void panel7_MouseDown(object sender, MouseEventArgs e)
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

            Regex reg1 = new Regex(@"^[A-Z]-\d{2,4}");
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

        public static bool numCheck(string s)
        {
            bool isMat = false;

            Regex reg1 = new Regex(@"\d{14}");
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

        public string id_book;
        public string book;
        

        public DataGridViewCell cell;
        private void addReturnForm_Load(object sender, EventArgs e)
        {
            mainForm main = this.Owner as mainForm;

            selectedID = Convert.ToInt32(main.lendingDataGridView.SelectedRows[0].Cells["id_reader"].Value);


            Sql s = new Sql();


            booksComboBox.Items.Clear();

            readerDataGridView.DataSource = s.Select($"Select * from Books where id in (select id_book from LendingBooks where id_reader = {selectedID})");
            string[] combo2 = new string[readerDataGridView.Rows.Count - 1];

            for (int i = 0; i < readerDataGridView.Rows.Count - 1; i++)
            {
                combo2[i] += readerDataGridView[1, i].Value.ToString();


            }
            booksComboBox.Items.AddRange(combo2);
        }

        private void addReturnButton_Click(object sender, EventArgs e)
        {
            
            mainForm main = this.Owner as mainForm;

            string connectString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Library;" +
                    "Integrated Security=true;";

                string sqlExpr = $"INSERT INTO ReturnBook (id_reader, id_book, book, [date of return]) VALUES" +
                    $" ('{selectedID}','{id_book}', '{book}','{readDateTimePicker.Value.Date}')";

                using (SqlConnection c = new SqlConnection(connectString))
                {
                    c.Open();
                    SqlCommand com = new SqlCommand(sqlExpr, c);
                    com.ExecuteNonQuery();
                    c.Close();

                    MessageBox.Show("Книга возвращена!");
                }

                string sqlE = $"update Books set status = '{"В библиотеке"}' where id = '{id_book}'";

                using (SqlConnection c = new SqlConnection(connectString))
                {
                    c.Open();
                    SqlCommand com = new SqlCommand(sqlE, c);
                    com.ExecuteNonQuery();
                    c.Close();

                }

                string sqlForChronology = $"INSERT INTO Chronology (id_reader, id_book, book, [date], operation) VALUES" +
                        $" ('{selectedID}','{id_book}', '{book}','{readDateTimePicker.Value.Date}', 'Возврат')";
                using (SqlConnection c = new SqlConnection(connectString))
                {
                    c.Open();
                    SqlCommand com = new SqlCommand(sqlForChronology, c);
                    com.ExecuteNonQuery();
                    c.Close();

                }
                if (main.returnDataGridView != null)
                {
                    string sqlForDelete = $"delete from LendingBooks where id_book = {id_book}";
                    using (SqlConnection c = new SqlConnection(connectString))
                    {
                        c.Open();
                        SqlCommand com = new SqlCommand(sqlForDelete, c);
                        com.ExecuteNonQuery();
                        c.Close();
                    }
                }

                Sql s = new Sql();

                if (main != null)
                {
                    main.returnDataGridView.DataSource = s.Select("SELECT * FROM ReturnBook");
                    main.booksDataGridView.DataSource = s.Select("SELECT * FROM Books");
                    main.chronologyDataGridView.DataSource = s.Select("SELECT * FROM Chronology");
                    main.lendingDataGridView.DataSource = s.Select("SELECT * FROM LendingBooks");
                }

                for (int i = 0; i < main.lendingDataGridView.Rows.Count - 1; i++)
                {
                    if (main.lendingDataGridView[1, i] == cell)
                    {
                        main.lendingDataGridView.Rows[i].ReadOnly = true;
                    }
                }

                if (main.returnDataGridView.RowCount > 0)
                {
                    main.returnDataGridView.Columns[0].HeaderText = "id";
                    main.returnDataGridView.Columns[1].HeaderText = "id читателя";
                    main.returnDataGridView.Columns[2].HeaderText = "id книги";
                    main.returnDataGridView.Columns[3].HeaderText = "Название книги";
                    main.returnDataGridView.Columns[4].HeaderText = "Дата возврата";
                }

                this.Close();

        }

        private void booksComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            mainForm main = this.Owner as mainForm;

            if (booksComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Пожалуйста, выберите книгу!");
                return;
            }
            else
            {
                for (int i = 0; i < readerDataGridView.Rows.Count - 1; i++)
                {
                    if (booksComboBox.Text == readerDataGridView[1, i].Value.ToString())
                    {
                        id_book = readerDataGridView[0, i].Value.ToString();
                        book = readerDataGridView[1, i].Value.ToString();
                    }
                }
            }


            for (int i = 0; i < main.lendingDataGridView.Rows.Count; i++)
            {
                if (Convert.ToInt32(main.lendingDataGridView[1, i].Value.ToString()) == selectedID && main.lendingDataGridView[2, i].Value.ToString() == id_book)
                {

                    dateOfIssue = Convert.ToDateTime(main.lendingDataGridView[4, i].Value.ToString());
                }
            }

            readDateTimePicker.MinDate = dateOfIssue;

            readDateTimePicker.Enabled = true;
        }
    }
}
