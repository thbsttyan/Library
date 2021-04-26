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
using MaterialSkin;
using MaterialSkin.Controls;

namespace Library
{
    public partial class authorizationForm :Form
    {
        public authorizationForm()
        {
            InitializeComponent();
            textBox1.Select();

            Sql s = new Sql();
            authDataGridView.DataSource = s.Select("SELECT * FROM Users");
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void authorizationButton_Click(object sender, EventArgs e)
        {
         
            Sql s = new Sql();
            authDataGridView.DataSource = s.Select("SELECT * FROM Users");

            bool isFound = false;
            bool isMain = false;
            for (int i = 0; i < authDataGridView.Rows.Count; i++)
            {
                try
                {
                    if (authDataGridView[1, i].Value.ToString() == loginTextField.Text
                        && authDataGridView[2, i].Value.ToString() == passwordTextField.Text)
                    {
                        isFound = true;
                        isMain = true;
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
                MessageBox.Show("Вход выполнен!");
                this.Hide();
                mainForm f = new mainForm();
                f.Owner = this;
                f.Show();
            }
            {
                if (!isMain)
                    MessageBox.Show("Ошибка при вводе данных");
            }

            
            authDataGridView.DataSource = s.Select("SELECT * FROM Users");

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

        public bool clicked = false;
        private void loginTextField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Sql s = new Sql();
                authDataGridView.DataSource = s.Select("SELECT * FROM Users");

                bool isFound = false;
                bool isMain = false;
                for (int i = 0; i < authDataGridView.Rows.Count; i++)
                {
                    try
                    {
                        if (authDataGridView[1, i].Value.ToString() == loginTextField.Text
                            && authDataGridView[2, i].Value.ToString() == passwordTextField.Text)
                        {
                            isFound = true;
                            isMain = true;
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
                    MessageBox.Show("Вход выполнен!");
                    this.Hide();
                    mainForm f = new mainForm();
                    f.Owner = this;
                    f.Show();
                }
                {
                    if (!isMain)
                        MessageBox.Show("Ошибка при вводе данных");
                }

                authDataGridView.DataSource = s.Select("SELECT * FROM Users");
            }
        }

        private void passordPictureBox_Click(object sender, EventArgs e)
        {
            if (!clicked)
            {
                passordPictureBox.Image = Properties.Resources.visible_1_ as Bitmap;
                passwordTextField.PasswordChar = '\0';
                clicked = true;
            }
            else
            {
                passordPictureBox.Image = Properties.Resources.visible_2_ as Bitmap;
                passwordTextField.PasswordChar = '*';
                clicked = false;
            }
        }
    }
}
