namespace Library
{
    partial class LendingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LendingForm));
            this.readDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.readerDataGridView = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.passordPictureBox = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.booksComboBox = new System.Windows.Forms.ComboBox();
            this.addLendingButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.readerDataGridView)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passordPictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // readDateTimePicker
            // 
            this.readDateTimePicker.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.readDateTimePicker.Location = new System.Drawing.Point(128, 107);
            this.readDateTimePicker.Name = "readDateTimePicker";
            this.readDateTimePicker.Size = new System.Drawing.Size(200, 27);
            this.readDateTimePicker.TabIndex = 68;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(-26, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(29, 448);
            this.panel3.TabIndex = 18;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(-27, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(29, 448);
            this.panel1.TabIndex = 19;
            // 
            // readerDataGridView
            // 
            this.readerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.readerDataGridView.Location = new System.Drawing.Point(420, 44);
            this.readerDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.readerDataGridView.Name = "readerDataGridView";
            this.readerDataGridView.RowHeadersWidth = 51;
            this.readerDataGridView.Size = new System.Drawing.Size(100, 118);
            this.readerDataGridView.TabIndex = 67;
            this.readerDataGridView.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(0, 217);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(498, 28);
            this.panel6.TabIndex = 66;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            this.panel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.PowderBlue;
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel.Controls.Add(this.pictureBox1);
            this.panel.Controls.Add(this.passordPictureBox);
            this.panel.Controls.Add(this.panel7);
            this.panel.Controls.Add(this.panel4);
            this.panel.Controls.Add(this.panel1);
            this.panel.Controls.Add(this.exitButton);
            this.panel.Location = new System.Drawing.Point(0, -1);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(497, 46);
            this.panel.TabIndex = 58;
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // passordPictureBox
            // 
            this.passordPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("passordPictureBox.Image")));
            this.passordPictureBox.Location = new System.Drawing.Point(50, 4);
            this.passordPictureBox.Name = "passordPictureBox";
            this.passordPictureBox.Size = new System.Drawing.Size(71, 38);
            this.passordPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.passordPictureBox.TabIndex = 47;
            this.passordPictureBox.TabStop = false;
            this.passordPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(2, -25);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(498, 28);
            this.panel7.TabIndex = 22;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            this.panel7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(495, -2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(29, 448);
            this.panel4.TabIndex = 19;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.PowderBlue;
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton.BackgroundImage")));
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.ForeColor = System.Drawing.Color.PowderBlue;
            this.exitButton.ImageKey = "(отсутствует)";
            this.exitButton.Location = new System.Drawing.Point(474, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(19, 20);
            this.exitButton.TabIndex = 17;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(495, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(29, 448);
            this.panel5.TabIndex = 65;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // booksComboBox
            // 
            this.booksComboBox.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.booksComboBox.ForeColor = System.Drawing.Color.Black;
            this.booksComboBox.FormattingEnabled = true;
            this.booksComboBox.Location = new System.Drawing.Point(128, 64);
            this.booksComboBox.Name = "booksComboBox";
            this.booksComboBox.Size = new System.Drawing.Size(292, 27);
            this.booksComboBox.TabIndex = 59;
            this.booksComboBox.Text = "Выберите книгу";
            this.booksComboBox.SelectedIndexChanged += new System.EventHandler(this.booksComboBox_SelectedIndexChanged);
            // 
            // addLendingButton
            // 
            this.addLendingButton.BackColor = System.Drawing.Color.PowderBlue;
            this.addLendingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addLendingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addLendingButton.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addLendingButton.Location = new System.Drawing.Point(128, 171);
            this.addLendingButton.Name = "addLendingButton";
            this.addLendingButton.Size = new System.Drawing.Size(142, 33);
            this.addLendingButton.TabIndex = 54;
            this.addLendingButton.Text = "Выдать книгу";
            this.addLendingButton.UseVisualStyleBackColor = false;
            this.addLendingButton.Click += new System.EventHandler(this.addLendingButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PowderBlue;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(-1, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(122, 381);
            this.panel2.TabIndex = 53;
            // 
            // LendingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 219);
            this.Controls.Add(this.readDateTimePicker);
            this.Controls.Add(this.readerDataGridView);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.booksComboBox);
            this.Controls.Add(this.addLendingButton);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LendingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LendingForm";
            ((System.ComponentModel.ISupportInitialize)(this.readerDataGridView)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passordPictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker readDateTimePicker;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exitButton;
        public System.Windows.Forms.DataGridView readerDataGridView;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.ComboBox booksComboBox;
        private System.Windows.Forms.Button addLendingButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox passordPictureBox;
    }
}