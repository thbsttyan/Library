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

        private void authorizationForm_Load(object sender, EventArgs e)
        {
        
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void authorizationButton_Click(object sender, EventArgs e)
        {
            /*string connectionStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=Library; Integrated Security=true;";


          Program.connection = @"Data Source=.\\SQLEXPRESS;Initial Catalog=Library; User id =" + loginTextField.Text + "; Password =" + passwordTextField.Text + ";Integrated Security=true;";


          int j = 1;


              SqlConnection connection = new SqlConnection(Program.connection);
              connection.Open();

              j++;
              connection.Close();



          if (j != 1)
          {
              mainForm fm2 = new mainForm();
              fm2.Show();
              this.Hide();
          }*/
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

        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            /*if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }*/
        }

        private void panel_MouseUp(object sender, MouseEventArgs e)
        {
           /* // Changes the isMouseDown field so that the form does
            // not move unless the user is pressing the left mouse button.
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }*/
        }

        public bool clicked = false;
        private void passwordShowButton_Click(object sender, EventArgs e)
        {
            if (!clicked)
            {
                passwordTextField.PasswordChar = '\0';
                clicked = true;
            }
            else
            {
                passwordTextField.PasswordChar = '*';
                clicked = false;
            }
        }

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

        private void authorizationForm_Click(object sender, EventArgs e)
        {

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
