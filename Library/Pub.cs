using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Pub : Form
    {
        public Pub()
        {
            InitializeComponent();

            Sql s = new Sql();
            pubDataGridView.DataSource = s.Select("Select * from Publishers");

            string[] combo = new string[pubDataGridView.Rows.Count - 1];

            for (int i = 0; i < pubDataGridView.Rows.Count - 1; i++)
            {
                combo[i] += pubDataGridView[1, i].Value.ToString();


            }

            publisherComboBox.Items.AddRange(combo);

            //this.Location = new System.Drawing.Point(Cursor.Position.X, Cursor.Position.Y);
            this.StartPosition = FormStartPosition.Manual;
            this.Left = Cursor.Position.X - 30;
            this.Top = Cursor.Position.Y - 30;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pub_Load(object sender, EventArgs e)
        {

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


            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void publisherComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
