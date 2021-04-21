﻿using System;
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

            readDateTimePicker.MaxDate = DateTime.Now;

            Sql s = new Sql();
            readerDataGridView.DataSource = s.Select("Select * from Books");

            string[] combo = new string[readerDataGridView.Rows.Count - 1];

            for (int i = 0; i < readerDataGridView.Rows.Count - 1; i++)
            {
                combo[i] += readerDataGridView[1, i].Value.ToString();


            }
            //MessageBox.Show(combo[4]);

            booksComboBox.Items.AddRange(combo);

            
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
            //TODO
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
            //TODO
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


        private void addReaderButton_Click(object sender, EventArgs e)
        {
            if (surnameTextField.Text != ""&&(OnlyLetters(surnameTextField.Text)) 
                && nameTextField.Text != "" && OnlyLetters(nameTextField.Text)
                && patronymicTextField.Text != "" && OnlyLetters(patronymicTextField.Text)
                && (OnlyLetters(positionTextField.Text) || positionTextField.Text == "")
                && (groupCheck(groupTextField.Text) || groupTextField.Text == "")
                && (phoneCheck(numberTextField.Text) || numberTextField.Text == "")
                && (OnlyLetters(townTextField.Text) || townTextField.Text == "")
                && (numCheck(passportTextField.Text) && passportTextField.Text != ""))
            {


                
                

                
                    
                string connectString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Library;" +
                    "Integrated Security=true;";
                

                //сделать ввод с оперделением id книги по названию
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

                this.Close();
            }
            else
            {
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

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void readDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            readDateTimePicker.MaxDate = DateTime.Now;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        /* private Point mouseOffset;
         private bool isMouseDown = false;*/
        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            /* int xOffset;
             int yOffset;

             if (e.Button == MouseButtons.Left)
             {
                 xOffset = -e.X - SystemInformation.FrameBorderSize.Width;
                 yOffset = -e.Y - SystemInformation.CaptionHeight -
                     SystemInformation.FrameBorderSize.Height;
                 mouseOffset = new Point(xOffset, yOffset);
                 isMouseDown = true;
             }*/

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
