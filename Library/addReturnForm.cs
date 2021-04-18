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
    public partial class addReturnForm : Form
    {
        public addReturnForm()
        {
            InitializeComponent();

            readDateTimePicker.MaxDate = DateTime.Now;

            



        }
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

        /* private Point mouseOffset;
         private bool isMouseDown = false;*/
        private void panel7_MouseDown(object sender, MouseEventArgs e)
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

        public string id_book;
        public string book;
        private void addReaderButton_Click(object sender, EventArgs e)
        {
            


                if (booksComboBox.SelectedIndex == -1)
                {
                    id_book = null;
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



                string connectString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Library;" +
                    "Integrated Security=true;";


                //сделать ввод с оперделением id книги по названию
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


            Sql s = new Sql();
            // mf.booksDataGridView.DataSource = s.Select("SELECT * FROM Books");

            mainForm main = this.Owner as mainForm;
            if (main != null)
            {
                main.returnDataGridView.DataSource = s.Select("SELECT * FROM ReturnBook");
                main.booksDataGridView.DataSource = s.Select("SELECT * FROM Books");
            }

            for (int i = 0; i < main.lendingDataGridView.Rows.Count - 1; i++)
            {
                if (main.lendingDataGridView[1, i] == cell)
                {
                    main.lendingDataGridView.Rows[i].ReadOnly = true;
                }
            }


        }

        
        private void readerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public DataGridViewCell cell;
        private void addReturnForm_Load(object sender, EventArgs e)
        {
            mainForm main = this.Owner as mainForm;

            /*int rowNum = 2;
            cell = main.lendingDataGridView.Rows[rowNum].Cells[0];
            main.lendingDataGridView.CurrentCell = cell;
            main.lendingDataGridView.CurrentCell.Selected = true;
            */
            selectedID = main.lendingDataGridView.CurrentCell.RowIndex + 1;
            //selectedLending = main.lendingDataGridView.SelectedCells[0].RowIndex + 1;

            // MessageBox.Show("aaaaa= " + selectedID.ToString());

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
    }
}
