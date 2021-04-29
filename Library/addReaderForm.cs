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
    public partial class addReaderForm : Form
    {
        public addReaderForm()
        {
            InitializeComponent();

            Sql s = new Sql();
            readerDataGridView.DataSource = s.Select("Select * from Books");

            string[] combo = new string[readerDataGridView.Rows.Count - 1];

            for (int i = 0; i < readerDataGridView.Rows.Count - 1; i++)
            {
                combo[i] += readerDataGridView[1, i].Value.ToString();
            }
        }

        public static bool OnlyLetters(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsLetter(c) && c!= ' ')
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
        }

        public bool isFound = false;
        private void addReaderButton_Click(object sender, EventArgs e)
        {
            mainForm f = new mainForm();
            for (int i = 0; i < f.readerDataGridView.Rows.Count; i++)
            {
                try
                { 
                    if (f.readerDataGridView[8, i].Value.ToString() == passportTextField.Text)
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
                MessageBox.Show("Такой паспортный номер уже существует!");
                passportTextField.Text = "";
            }
            else
            {
                if (surnameTextField.Text != "" && (OnlyLetters(surnameTextField.Text))
                    && nameTextField.Text != "" && OnlyLetters(nameTextField.Text)
                    && patronymicTextField.Text != "" && OnlyLetters(patronymicTextField.Text)
                    && (OnlyLetters(positionTextField.Text) || positionTextField.Text == "")
                    && (groupCheck(groupTextField.Text) || groupTextField.Text == "")
                    && (phoneCheck(numberTextField.Text) || numberTextField.Text == "")
                    && (OnlyLetters(townTextField.Text) || townTextField.Text == "")
                    && (numCheck(passportTextField.Text) || passportTextField.Text == ""))
                {

                    string connectString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Library;" +
                        "Integrated Security=true;";


                    string sqlExpr = $"INSERT INTO Readers ( surname, name, patronymic, position, [group], phone_number, town, " +
                        $"[pasport number]) VALUES" +
                        $" ('{surnameTextField.Text}','{nameTextField.Text}','{patronymicTextField.Text}','{positionTextField.Text}'," +
                        $"'{groupTextField.Text}','{numberTextField.Text}','{townTextField.Text}','{passportTextField.Text}')";

                    using (SqlConnection c = new SqlConnection(connectString))
                    {
                        c.Open();
                        SqlCommand com = new SqlCommand(sqlExpr, c);
                        com.ExecuteNonQuery();
                        c.Close();

                        MessageBox.Show("Новый читатель добавлен!");
                    }

                    string noZero = $"update Readers set [pasport number] = NULL where [pasport number] = 0 ";

                    using (SqlConnection c = new SqlConnection(connectString))
                    {
                        c.Open();
                        SqlCommand com = new SqlCommand(noZero, c);
                        com.ExecuteNonQuery();
                        c.Close();

                    }

                    if (f.readerDataGridView != null)
                    {
                        f.readerDataGridView.Columns[0].HeaderText = "id";
                        f.readerDataGridView.Columns[1].HeaderText = "Фамилия";
                        f.readerDataGridView.Columns[2].HeaderText = "Имя";
                        f.readerDataGridView.Columns[3].HeaderText = "Отчество";
                        f.readerDataGridView.Columns[4].HeaderText = "Должность";
                        f.readerDataGridView.Columns[5].HeaderText = "Группа";
                        f.readerDataGridView.Columns[6].HeaderText = "Номер телефона";
                        f.readerDataGridView.Columns[7].HeaderText = "Город";
                        f.readerDataGridView.Columns[8].HeaderText = "Номер паспорта";
                    }

                    this.Close();
                }
                else
                {
                    if (surnameTextField.Text == "" || !OnlyLetters(surnameTextField.Text))
                    {
                        surnameTextField.Text = "";
                    }

                    if (nameTextField.Text == "" || !OnlyLetters(nameTextField.Text))
                    {
                        nameTextField.Text = "";
                    }

                    if (patronymicTextField.Text == "" || !OnlyLetters(patronymicTextField.Text))
                    {
                        patronymicTextField.Text = "";
                    }

                    if (!OnlyLetters(positionTextField.Text))
                    {
                        positionTextField.Text = "";
                    }

                    if (!groupCheck(groupTextField.Text))
                    {
                        groupTextField.Text = "";
                    }

                    if (!phoneCheck(numberTextField.Text))
                    {
                        numberTextField.Text = "";
                    }

                    if (!OnlyLetters(townTextField.Text))
                    {
                        townTextField.Text = "";
                    }

                    if (!numCheck(passportTextField.Text) || passportTextField.Text == "")
                    {
                        passportTextField.Text = "";
                    }


                    MessageBox.Show("Данные введены неверно");
                }

                Sql s = new Sql();
                // mf.booksDataGridView.DataSource = s.Select("SELECT * FROM Books");

                mainForm main = this.Owner as mainForm;
                if (main != null)
                {
                    main.readerDataGridView.DataSource = s.Select("SELECT * FROM Readers");
                }
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
