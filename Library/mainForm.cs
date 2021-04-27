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

            if (booksDataGridView.RowCount > 0)
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

            if (readerDataGridView.RowCount > 0)
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
            
            if (lendingDataGridView.RowCount > 0)
            {
                lendingDataGridView.Columns[0].HeaderText = "id";
                lendingDataGridView.Columns[1].HeaderText = "id читателя";
                lendingDataGridView.Columns[2].HeaderText = "id книги";
                lendingDataGridView.Columns[3].HeaderText = "Название книги";
                lendingDataGridView.Columns[4].HeaderText = "Дата выдачи";
            }
            
            if (returnDataGridView.RowCount > 0)
            {
                returnDataGridView.Columns[0].HeaderText = "id";
                returnDataGridView.Columns[1].HeaderText = "id читателя";
                returnDataGridView.Columns[2].HeaderText = "id книги";
                returnDataGridView.Columns[3].HeaderText = "Название книги";
                returnDataGridView.Columns[4].HeaderText = "Дата возврата";
            }
           
            if (chronologyDataGridView.RowCount > 0)
            {
                chronologyDataGridView.Columns[0].HeaderText = "id";
                chronologyDataGridView.Columns[1].HeaderText = "id читателя";
                chronologyDataGridView.Columns[2].HeaderText = "id книги";
                chronologyDataGridView.Columns[3].HeaderText = "Название книги";
                chronologyDataGridView.Columns[4].HeaderText = "Дата выдачи/возврата";
                chronologyDataGridView.Columns[5].HeaderText = "Вид операции";
            }
            if (publisherDataGridView.RowCount > 0)
            {
                
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

        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            addBookForm f = new addBookForm();
            f.Owner = this;
            f.ShowDialog();

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

        private void booksDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            string txt = "Ошибка в столбце " +
                booksDataGridView.Columns[e.ColumnIndex].HeaderText +
                "\n\n" + e.Exception.Message;
            MessageBox.Show(txt, "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            e.Cancel = false;
        }

        private void redactBooksCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (redactBooksCheckBox.Checked)
            {
                booksDataGridView.ReadOnly = false;
                booksDataGridView.Columns[11].ReadOnly = true;
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
                publisherDataGridView.Columns[7].ReadOnly = true;
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
            e.ThrowException = false;
            string txt = "Ошибка в столбце " +
                readerDataGridView.Columns[e.ColumnIndex].HeaderText +
                "\n\n" + e.Exception.Message;
            MessageBox.Show(txt, "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            e.Cancel = false;
        }

        private void publisherDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            string txt = "Ошибка в столбце " +
                publisherDataGridView.Columns[e.ColumnIndex].HeaderText +
                "\n\n" + e.Exception.Message;
            MessageBox.Show(txt, "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (lendingDataGridView.RowCount > 0)
            {
                addReturnForm f = new addReturnForm();
                f.Owner = this;
                f.ShowDialog();
            }
        }

        private void lendingbutton_Click(object sender, EventArgs e)
        {
            if (readerDataGridView.RowCount > 0)
            {
                LendingForm f = new LendingForm();
                f.Owner = this;
                f.ShowDialog();
            }
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
            
            if(booksDataGridView.RowCount<1)
            {
                booksDataGridView.DataSource = s.Select($"SELECT * FROM Books");
                MessageBox.Show("Соответствия не найдены!");
                searchTextField.Text = "";
                
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Sql s = new Sql();
            booksDataGridView.DataSource = s.Select($"SELECT * FROM Books");
            searchTextField.Text = "";
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            authorizationForm auth = new authorizationForm();
            auth.Show();
            this.Close();
        }

        private void booksDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           /* if (redactBooksCheckBox.Checked && booksDataGridView.Column)
            {
                for(int i=0;i<booksDataGridView.ColumnCount;i++)
                {
                    if(i==5 )
                    {
                        booksDataGridView[i, e.RowIndex].Value
                    }
                }

                MessageBox.Show("helpp");
            }*/
        }
    }
}
