using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            if ( passwordTextField.Text != "" && password2TextField.Text != ""
                    && loginTextField.Text != "")
            {
                

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
            }
            else
            {
                MessageBox.Show("Данные введены неверно!");
            }

                authDataGridView.DataSource = s.Select("SELECT * FROM Users");
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

        private void passordPictureBox_Click(object sender, EventArgs e)
        {
            if (!clicked)
            {
                passordPictureBox.Image = Properties.Resources.visible_1_ as Bitmap;
                passwordTextField.PasswordChar = '\0';
                password2TextField.PasswordChar = '\0';
                clicked = true;
            }
            else
            {
                passordPictureBox.Image = Properties.Resources.visible_2_ as Bitmap;
                passwordTextField.PasswordChar = '*';
                password2TextField.PasswordChar = '*';
                clicked = false;
            }
        }
    }
}

