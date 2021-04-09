using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using MaterialSkin.Controls;
using System.Runtime.InteropServices;

namespace Library
{
    public partial class mainForm : Form
    {
        /*public DataGridView BooksDataGridView { get; set; }

        private void DoSomething()
        {
            var anotherForm = new addBookForm();
            anotherForm.DoSomethingElse(this);
        }*/
        public mainForm()
        {
            InitializeComponent();
            Sql s = new Sql();
            booksDataGridView.DataSource = s.Select("SELECT * FROM Books");
            //LoadData();

            booksDataGridView.Columns[1].HeaderText = "Название";
            booksDataGridView.Columns[2].HeaderText = "Автор";
            booksDataGridView.Columns[3].HeaderText = "Жанр";
            booksDataGridView.Columns[4].HeaderText = "Тип";
            booksDataGridView.Columns[5].HeaderText = "Издательство";
            booksDataGridView.Columns[6].HeaderText = "Страницы";
            booksDataGridView.Columns[8].HeaderText = "Номер шкафа";
            booksDataGridView.Columns[9].HeaderText = "Номер полки";
            booksDataGridView.Columns[10].HeaderText = "Ценаx";
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        public void LoadData()
        {
           //nobooksDataGridView.Rows.Clear();

            string connectString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Library;" +
                "Integrated Security=true;";

            SqlConnection myConnection = new SqlConnection(connectString);

            myConnection.Open();

            string query = "SELECT * FROM Books";

            SqlCommand command = new SqlCommand(query, myConnection);

            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[11]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
                data[data.Count - 1][7] = reader[7].ToString();
                data[data.Count - 1][8] = reader[8].ToString();
                data[data.Count - 1][9] = reader[9].ToString();
                data[data.Count - 1][10] = reader[10].ToString();
            }

            reader.Close();

            myConnection.Close();

            //foreach (string[] s in data)
               // nobooksDataGridView.Rows.Add(s);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {}

        private void addBookButton_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //addBookForm newForm = new addBookForm();
            // newForm.ShowDialog();

            addBookForm f = new addBookForm();
            f.Owner = this;
            f.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string connectString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Library;" +
               "Integrated Security=true;";

            SqlConnection myConnection = new SqlConnection(connectString);

            myConnection.Open();

            string query = "SELECT * FROM Books";

            SqlCommand command = new SqlCommand(query, myConnection);

            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[11]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
                data[data.Count - 1][7] = reader[7].ToString();
                data[data.Count - 1][8] = reader[8].ToString();
                data[data.Count - 1][9] = reader[9].ToString();
                data[data.Count - 1][10] = reader[10].ToString();
            }

            reader.Close();

            myConnection.Close();

            //foreach (string[] s in data)
               // nobooksDataGridView.Rows.Add(s);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

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

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
