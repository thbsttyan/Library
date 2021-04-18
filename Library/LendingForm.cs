using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
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
        private void addLendingButton_Click(object sender, EventArgs e)
        {
            mainForm main = this.Owner as mainForm;
              int rowindex = main.readerDataGridView.CurrentCell.RowIndex;
              int columnindex = main.readerDataGridView.CurrentCell.ColumnIndex;
              selectedReader = Convert.ToInt32(main.readerDataGridView.Rows[rowindex].Cells[columnindex].Value.ToString());
            // selectedReader = Convert.ToInt32(main.readerDataGridView.SelectedRows[0].Cells[0].Value.ToString()) ;

           /* if (main.readerDataGridView.SelectedCells.Count > 0)
            {
                int selectedrowindex = main.readerDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = main.readerDataGridView.Rows[selectedrowindex];
                string a = Convert.ToString(selectedRow.Cells["id_reader"].Value);
            }*/

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

            string sqlForChronology = $"INSERT INTO Chronology (id_reader, id_book, book, [date]) VALUES" +
                  $" ('{selectedReader}','{id_book}', '{book}','{readDateTimePicker.Value.Date}')";
            using (SqlConnection c = new SqlConnection(connectString))
            {
                c.Open();
                SqlCommand com = new SqlCommand(sqlForChronology, c);
                com.ExecuteNonQuery();
                c.Close();
            }
/*
            string sqlForDelete = $"delete from LendingBooks where ";
            using (SqlConnection c = new SqlConnection(connectString))
            {
                c.Open();
                SqlCommand com = new SqlCommand(sqlForChronology, c);
                com.ExecuteNonQuery();
                c.Close();
            }*/


            Sql s = new Sql();
            // mf.booksDataGridView.DataSource = s.Select("SELECT * FROM Books");

            //mainForm main = this.Owner as mainForm;
            if (main != null)
            {
                main.lendingDataGridView.DataSource = s.Select("SELECT * FROM LendingBooks");
                main.booksDataGridView.DataSource = s.Select("SELECT * FROM Books");
            }
        }
    }
}
