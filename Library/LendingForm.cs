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
    public partial class LendingForm : Form
    {
        public LendingForm()
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

        private void booksComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string id_book;
        public string book;
        int selectedReader;
        bool BookOnHands = false;
        private void addLendingButton_Click(object sender, EventArgs e)
        {
            

            mainForm main = this.Owner as mainForm;
             /* int rowindex = main.readerDataGridView.CurrentCell.RowIndex;
              int columnindex = main.readerDataGridView.CurrentCell.ColumnIndex;
            
            selectedReader = Convert.ToInt32(main.readerDataGridView.Rows[rowindex].Cells[columnindex].Value.ToString());*/
            // selectedReader = Convert.ToInt32(main.readerDataGridView.SelectedRows[0].Cells[0].Value.ToString()) ;

            /* if (main.readerDataGridView.SelectedCells.Count > 0)
             {
                 int selectedrowindex = main.readerDataGridView.SelectedCells[0].RowIndex;
                 DataGridViewRow selectedRow = main.readerDataGridView.Rows[selectedrowindex];
                 string a = Convert.ToString(selectedRow.Cells["id_reader"].Value);
             }*/
            selectedReader = Convert.ToInt32(main.readerDataGridView.SelectedRows[0].Cells[0].Value);


           MessageBox.Show("aaaaa= " + selectedReader.ToString());


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

            MessageBox.Show("id_book = " + id_book );
            for (int i = 0; i < main.booksDataGridView.Rows.Count; i++)//ВНИМАНИЕ! Возможна поломка в связи с удалением "-1" после main.booksDataGridView.Rows.Count. СПАСИБО ЗА ВНИАНИЕ!
            {
                if (main.booksDataGridView[0, i].Value.ToString()==id_book )
                {
                    if (main.booksDataGridView[11, i].Value.ToString() == "На руках")
                    {
                        BookOnHands = true;
                        MessageBox.Show("НАШЕЛ КНИГУ " + main.booksDataGridView[0, i].Value.ToString());
                    }
                    else
                    {
                        BookOnHands = false;
                    }
                    MessageBox.Show("нашел книгу " + main.booksDataGridView[0, i].Value.ToString());
                }
                
            }
            

            if (!BookOnHands)
            {

                //сделать ввод с оперделением id книги по названию
                string sqlExpr = $"INSERT INTO LendingBooks (id_reader, id_book, book, [date of issue]) VALUES" +
                    $" ('{selectedReader}','{id_book}', '{book}','{readDateTimePicker.Value.Date}')";

                using (SqlConnection c = new SqlConnection(connectString))
                {
                    c.Open();
                    SqlCommand com = new SqlCommand(sqlExpr, c);
                    com.ExecuteNonQuery();
                    c.Close();

                    MessageBox.Show("Книга выдана!");
                }

                string sqlE = $"update Books set status = '{"На руках"}' where id = '{id_book}'";

                using (SqlConnection c = new SqlConnection(connectString))
                {
                    c.Open();
                    SqlCommand com = new SqlCommand(sqlE, c);
                    com.ExecuteNonQuery();
                    c.Close();

                }

                string sqlForChronology = $"INSERT INTO Chronology (id_reader, id_book, book, [date], operation) VALUES" +
                      $" ('{selectedReader}','{id_book}', '{book}','{readDateTimePicker.Value.Date}', 'Выдача')";
                using (SqlConnection c = new SqlConnection(connectString))
                {
                    c.Open();
                    SqlCommand com = new SqlCommand(sqlForChronology, c);
                    com.ExecuteNonQuery();
                    c.Close();
                }


                //ПРОВЕРКА НА ПУСТОТУ
                if (main.returnDataGridView != null)
                {
                    string sqlForDelete = $"delete from ReturnBook where id_book = {id_book}";
                    using (SqlConnection c = new SqlConnection(connectString))
                    {
                        c.Open();
                        SqlCommand com = new SqlCommand(sqlForDelete, c);
                        com.ExecuteNonQuery();
                        c.Close();
                    }
                }


                Sql s = new Sql();
                // mf.booksDataGridView.DataSource = s.Select("SELECT * FROM Books");

                //mainForm main = this.Owner as mainForm;
                if (main != null)
                {
                    main.lendingDataGridView.DataSource = s.Select("SELECT * FROM LendingBooks");
                    main.booksDataGridView.DataSource = s.Select("SELECT * FROM Books");
                    main.chronologyDataGridView.DataSource = s.Select("SELECT * FROM Chronology");
                    main.chronologyDataGridView.DataSource = s.Select("SELECT * FROM Chronology");
                    main.returnDataGridView.DataSource = s.Select("SELECT * FROM ReturnBook");
                }


            }
            else
            {
                MessageBox.Show("Книга уже взята!");
            }

            if (main.lendingDataGridView != null)
            {
                main.lendingDataGridView.Columns[0].HeaderText = "id";
                main.lendingDataGridView.Columns[1].HeaderText = "id читателя";
                main.lendingDataGridView.Columns[2].HeaderText = "id книги";
                main.lendingDataGridView.Columns[3].HeaderText = "Название книги";
                main.lendingDataGridView.Columns[4].HeaderText = "Дата выдачи";
            }

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

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
