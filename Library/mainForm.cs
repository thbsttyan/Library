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
        bool Ready = false;
        public mainForm()
        {
            InitializeComponent();

            booksDataGridView.AllowUserToAddRows = false;
            readerDataGridView.AllowUserToAddRows = false;
            lendingDataGridView.AllowUserToAddRows = false;
            returnDataGridView.AllowUserToAddRows = false;
            publisherDataGridView.AllowUserToAddRows = false;

            Sql s = new Sql();
            booksDataGridView.DataSource = s.Select("SELECT * FROM Books");

            publisherDataGridView.DataSource = s.Select("Select * from Publishers");

            readerDataGridView.DataSource = s.Select("Select * from Readers");

            lendingDataGridView.DataSource = s.Select("Select * from LendingBooks");

            returnDataGridView.DataSource = s.Select("Select * from ReturnBook");

            chronologyDataGridView.DataSource = s.Select("Select * from Chronology");

            //Книги
            if (booksDataGridView != null)
            {
                booksDataGridView.Columns[1].HeaderText = "Название";
                booksDataGridView.Columns[2].HeaderText = "Автор";
                booksDataGridView.Columns[3].HeaderText = "Жанр";
                booksDataGridView.Columns[4].HeaderText = "Тип";
                booksDataGridView.Columns[5].HeaderText = "Издательство";
                booksDataGridView.Columns[6].HeaderText = "Страницы";
                booksDataGridView.Columns[8].HeaderText = "Номер шкафа";
                booksDataGridView.Columns[9].HeaderText = "Номер полки";
                booksDataGridView.Columns[10].HeaderText = "Цена";
                booksDataGridView.Columns[11].HeaderText = "Статус";
            }
            //Читатели
            if (readerDataGridView != null)
            {
                readerDataGridView.Columns[0].HeaderText = "id";
                readerDataGridView.Columns[1].HeaderText = "Фамилия";
                readerDataGridView.Columns[2].HeaderText = "Имя";
                readerDataGridView.Columns[3].HeaderText = "Отчество";
                readerDataGridView.Columns[4].HeaderText = "Должность";
                readerDataGridView.Columns[5].HeaderText = "Группа";
                readerDataGridView.Columns[6].HeaderText = "Номер телефона";
                readerDataGridView.Columns[7].HeaderText = "Город";
                readerDataGridView.Columns[8].HeaderText = "Номер паспорта";
            }
            //выдачи
            if (lendingDataGridView != null)
            {
                lendingDataGridView.Columns[0].HeaderText = "id";
                lendingDataGridView.Columns[1].HeaderText = "id читателя";
                lendingDataGridView.Columns[2].HeaderText = "id книги";
                lendingDataGridView.Columns[3].HeaderText = "Название книги";
                lendingDataGridView.Columns[4].HeaderText = "Дата выдачи";
            }
            //возвраты
            if (returnDataGridView != null)
            {
                returnDataGridView.Columns[0].HeaderText = "id";
                returnDataGridView.Columns[1].HeaderText = "id читателя";
                returnDataGridView.Columns[2].HeaderText = "id книги";
                returnDataGridView.Columns[3].HeaderText = "Название книги";
                returnDataGridView.Columns[4].HeaderText = "Дата возврата";
            }
            //хронология
            if (chronologyDataGridView != null)
            {
                chronologyDataGridView.Columns[0].HeaderText = "id";
                chronologyDataGridView.Columns[1].HeaderText = "id читателя";
                chronologyDataGridView.Columns[2].HeaderText = "id книги";
                chronologyDataGridView.Columns[3].HeaderText = "Название книги";
                chronologyDataGridView.Columns[4].HeaderText = "Дата выдачи/возврата";
                chronologyDataGridView.Columns[5].HeaderText = "Вид операции";
            }
            if (publisherDataGridView != null)
            {
                //Издательства
                publisherDataGridView.Columns[0].HeaderText = "id";
                publisherDataGridView.Columns[1].HeaderText = "Издательство";
                publisherDataGridView.Columns[2].HeaderText = "Компания";
                publisherDataGridView.Columns[3].HeaderText = "Адрес";
                publisherDataGridView.Columns[4].HeaderText = "Город";
                publisherDataGridView.Columns[5].HeaderText = "Номер телефона";
                publisherDataGridView.Columns[6].HeaderText = "Рейтинг";
                publisherDataGridView.Columns[7].HeaderText = "Дата добавления";
            }

            Ready = true;

          /* DataGridViewComboBoxColumn col = new DataGridViewComboBoxColumn();
            booksDataGridView.Columns.Add(col);*/
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        public void LoadData()
        {
           //nobooksDataGridView.Rows.Clear();

            /*string connectString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Library;" +
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
               // nobooksDataGridView.Rows.Add(s);*/
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
            /*string connectString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Library;" +
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
               // nobooksDataGridView.Rows.Add(s);*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
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

        
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newRegistrationButton_Click(object sender, EventArgs e)
        {
            registrationForm f = new registrationForm();
            f.Owner = this;
            f.ShowDialog();
        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            readersPanel.Visible = false;
            readersPanel.Enabled = false;

            publishersPanel.Visible = false;
            publishersPanel.Enabled = false;

            booksPanel.Visible = true;
            booksPanel.Enabled = true;
        }

        private void publisherButton_Click(object sender, EventArgs e)
        {
            booksPanel.Visible = false;
            booksPanel.Enabled = false;

            readersPanel.Visible = false;
            readersPanel.Enabled = false;

            publishersPanel.Visible = true;
            publishersPanel.Enabled = true;
            
        }

        private void readersButton_Click(object sender, EventArgs e)
        {
            booksPanel.Visible = false;
            booksPanel.Enabled = false;

            publishersPanel.Visible = false;
            publishersPanel.Enabled = false;

            readersPanel.Visible = true;
            readersPanel.Enabled = true;
        }

        
        
        private void booksDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
            if (Ready)
            {
                try
                {
                    string connectionStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=Library; Integrated Security=true;";
                    SqlConnection connection = new SqlConnection(connectionStr);
                    connection.Open();

                    string column = booksDataGridView.Columns[e.ColumnIndex].Name;

                    var value = booksDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                    var id = booksDataGridView.Rows[e.RowIndex].Cells[0].Value;

                    SqlCommand com = new SqlCommand($"UPDATE Books set {column} = @value where id = {id}", connection);

                    com.Parameters.AddWithValue("@value", value);
                    com.ExecuteNonQuery();
                }
                catch(Exception)
                {
                    MessageBox.Show("Произошла ошибка");
                }
            }
            
        }

        private void booksDataGridView_DataError(object sender,
    DataGridViewDataErrorEventArgs e)
        {
            // Не делайте исключения, когда мы закончим.
            e.ThrowException = false;

            // Отображение сообщения об ошибке.
            string txt = "Ошибка в столбце " +
                booksDataGridView.Columns[e.ColumnIndex].HeaderText +
                "\n\n" + e.Exception.Message;
            MessageBox.Show(txt, "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            // Если это так, то пользователь попадает в эту ячейку.
            e.Cancel = false;
        }

        private void redactBooksCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (redactBooksCheckBox.Checked)
            {
                booksDataGridView.ReadOnly = false;
                

            }
            if (!redactBooksCheckBox.Checked)
            {
               
                booksDataGridView.ReadOnly = true;
                

            }
        }

        private void redactReadersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (redactReadersCheckBox.Checked)
            {
                readerDataGridView.ReadOnly = false;
                readerDataGridView.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;

            }
            if (!redactReadersCheckBox.Checked)
            {
                readerDataGridView.ReadOnly = true;
                readerDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            }
        }

        private void redactPublishersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (redactPublishersCheckBox.Checked)
            {
                publisherDataGridView.ReadOnly = false;

            }
            if (!redactPublishersCheckBox.Checked)
            {
                publisherDataGridView.ReadOnly = true;

            }
        }

        private void readerDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (Ready)
            {
                try
                {
                    string connectionStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=Library; Integrated Security=true;";
                    SqlConnection connection = new SqlConnection(connectionStr);
                    connection.Open();

                    string column = readerDataGridView.Columns[e.ColumnIndex].Name;

                    var value = readerDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                    var id = readerDataGridView.Rows[e.RowIndex].Cells[0].Value;

                    SqlCommand com = new SqlCommand($"UPDATE Readers set [{column}] = @value where id_reader = {id}", connection);

                    com.Parameters.AddWithValue("@value", value);
                    com.ExecuteNonQuery();
                }
                catch (Exception)
                {
                MessageBox.Show("Произошла ошибка");
                }
        }
        }

        private void publisherDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (Ready)
            {
                try
                {
                    string connectionStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=Library; Integrated Security=true;";
                    SqlConnection connection = new SqlConnection(connectionStr);
                    connection.Open();

                    string column = publisherDataGridView.Columns[e.ColumnIndex].Name;

                    var value = publisherDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                    var id = publisherDataGridView.Rows[e.RowIndex].Cells[0].Value;

                    SqlCommand com = new SqlCommand($"UPDATE Publishers set {column} = @value where id_pub = {id}", connection);

                    com.Parameters.AddWithValue("@value", value);
                    com.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    MessageBox.Show("Произошла ошибка");
                }
            }
        }

        private void readerDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Не делайте исключения, когда мы закончим.
            e.ThrowException = false;

            // Отображение сообщения об ошибке.
            string txt = "Ошибка в столбце " +
                readerDataGridView.Columns[e.ColumnIndex].HeaderText +
                "\n\n" + e.Exception.Message;
            MessageBox.Show(txt, "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            // Если это так, то пользователь попадает в эту ячейку.
            e.Cancel = false;
        }

        private void publisherDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Не делайте исключения, когда мы закончим.
            e.ThrowException = false;

            // Отображение сообщения об ошибке.
            string txt = "Ошибка в столбце " +
                publisherDataGridView.Columns[e.ColumnIndex].HeaderText +
                "\n\n" + e.Exception.Message;
            MessageBox.Show(txt, "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            // Если это так, то пользователь попадает в эту ячейку.
            e.Cancel = false;
        }

        private void addReaderButton_Click(object sender, EventArgs e)
        {
            addReaderForm f = new addReaderForm();
            f.Owner = this;
            f.ShowDialog();
        }

        private void addReturnButton_Click(object sender, EventArgs e)
        {
            addReturnForm f = new addReturnForm();
            f.Owner = this;
            f.ShowDialog();
        }

        private void lendingbutton_Click(object sender, EventArgs e)
        {
            LendingForm f = new LendingForm();
            f.Owner = this;
            f.ShowDialog();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void readerDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //readerDataGridView.ClearSelection();
        }

        private void addPublisherButton_Click(object sender, EventArgs e)
        {
            PublisherForm f = new PublisherForm();
            f.Owner = this;
            f.ShowDialog();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Sql s = new Sql();
            booksDataGridView.DataSource = s.Select($"SELECT * FROM Books where name like '%{searchTextField.Text}%'");
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Sql s = new Sql();
            booksDataGridView.DataSource = s.Select($"SELECT * FROM Books");
        }

        private void searchTextField_TextChanged(object sender, EventArgs e)
        {
            if(searchTextField.Text!="")
            {
                searchButton.Enabled = true;
            }
            else
            {
                searchButton.Enabled = false;
            }
        }
    }
}
