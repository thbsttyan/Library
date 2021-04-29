namespace Library
{
    partial class addBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addBookForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addBookButton = new System.Windows.Forms.Button();
            this.nameTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.authorTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.genreTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.publisherComboBox = new System.Windows.Forms.ComboBox();
            this.pagesTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.isbnTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lockerTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.shelfTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.priceTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.passordPictureBox = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pubDataGridView = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passordPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pubDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PowderBlue;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(122, 406);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(-26, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(29, 448);
            this.panel3.TabIndex = 18;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // addBookButton
            // 
            this.addBookButton.BackColor = System.Drawing.Color.PowderBlue;
            this.addBookButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBookButton.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBookButton.Location = new System.Drawing.Point(407, 404);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(116, 33);
            this.addBookButton.TabIndex = 3;
            this.addBookButton.Text = "Добавить книгу";
            this.addBookButton.UseVisualStyleBackColor = false;
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // nameTextField
            // 
            this.nameTextField.Depth = 0;
            this.nameTextField.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextField.Hint = "Название";
            this.nameTextField.Location = new System.Drawing.Point(131, 60);
            this.nameTextField.MaxLength = 32767;
            this.nameTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.nameTextField.Name = "nameTextField";
            this.nameTextField.PasswordChar = '\0';
            this.nameTextField.SelectedText = "";
            this.nameTextField.SelectionLength = 0;
            this.nameTextField.SelectionStart = 0;
            this.nameTextField.Size = new System.Drawing.Size(357, 23);
            this.nameTextField.TabIndex = 4;
            this.nameTextField.TabStop = false;
            this.nameTextField.UseSystemPasswordChar = false;
            // 
            // authorTextField
            // 
            this.authorTextField.Depth = 0;
            this.authorTextField.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorTextField.Hint = "Автор";
            this.authorTextField.Location = new System.Drawing.Point(131, 102);
            this.authorTextField.MaxLength = 32767;
            this.authorTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.authorTextField.Name = "authorTextField";
            this.authorTextField.PasswordChar = '\0';
            this.authorTextField.SelectedText = "";
            this.authorTextField.SelectionLength = 0;
            this.authorTextField.SelectionStart = 0;
            this.authorTextField.Size = new System.Drawing.Size(357, 23);
            this.authorTextField.TabIndex = 5;
            this.authorTextField.TabStop = false;
            this.authorTextField.UseSystemPasswordChar = false;
            // 
            // genreTextField
            // 
            this.genreTextField.Depth = 0;
            this.genreTextField.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genreTextField.Hint = "Жанр";
            this.genreTextField.Location = new System.Drawing.Point(131, 147);
            this.genreTextField.MaxLength = 32767;
            this.genreTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.genreTextField.Name = "genreTextField";
            this.genreTextField.PasswordChar = '\0';
            this.genreTextField.SelectedText = "";
            this.genreTextField.SelectionLength = 0;
            this.genreTextField.SelectionStart = 0;
            this.genreTextField.Size = new System.Drawing.Size(357, 23);
            this.genreTextField.TabIndex = 6;
            this.genreTextField.TabStop = false;
            this.genreTextField.UseSystemPasswordChar = false;
            // 
            // typeComboBox
            // 
            this.typeComboBox.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeComboBox.ForeColor = System.Drawing.Color.Black;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Книга",
            "Журнал"});
            this.typeComboBox.Location = new System.Drawing.Point(131, 188);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(157, 27);
            this.typeComboBox.TabIndex = 10;
            this.typeComboBox.Text = "Выберите тип";
            // 
            // publisherComboBox
            // 
            this.publisherComboBox.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.publisherComboBox.ForeColor = System.Drawing.Color.Black;
            this.publisherComboBox.FormattingEnabled = true;
            this.publisherComboBox.Location = new System.Drawing.Point(309, 188);
            this.publisherComboBox.Name = "publisherComboBox";
            this.publisherComboBox.Size = new System.Drawing.Size(201, 27);
            this.publisherComboBox.TabIndex = 11;
            this.publisherComboBox.Text = "Выберите издательство";
            // 
            // pagesTextField
            // 
            this.pagesTextField.Depth = 0;
            this.pagesTextField.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pagesTextField.Hint = "Страницы";
            this.pagesTextField.Location = new System.Drawing.Point(131, 245);
            this.pagesTextField.MaxLength = 32767;
            this.pagesTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.pagesTextField.Name = "pagesTextField";
            this.pagesTextField.PasswordChar = '\0';
            this.pagesTextField.SelectedText = "";
            this.pagesTextField.SelectionLength = 0;
            this.pagesTextField.SelectionStart = 0;
            this.pagesTextField.Size = new System.Drawing.Size(129, 23);
            this.pagesTextField.TabIndex = 12;
            this.pagesTextField.TabStop = false;
            this.pagesTextField.UseSystemPasswordChar = false;
            // 
            // isbnTextField
            // 
            this.isbnTextField.Depth = 0;
            this.isbnTextField.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isbnTextField.Hint = "ISBN";
            this.isbnTextField.Location = new System.Drawing.Point(309, 245);
            this.isbnTextField.MaxLength = 32767;
            this.isbnTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.isbnTextField.Name = "isbnTextField";
            this.isbnTextField.PasswordChar = '\0';
            this.isbnTextField.SelectedText = "";
            this.isbnTextField.SelectionLength = 0;
            this.isbnTextField.SelectionStart = 0;
            this.isbnTextField.Size = new System.Drawing.Size(129, 23);
            this.isbnTextField.TabIndex = 13;
            this.isbnTextField.TabStop = false;
            this.isbnTextField.UseSystemPasswordChar = false;
            // 
            // lockerTextField
            // 
            this.lockerTextField.Depth = 0;
            this.lockerTextField.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lockerTextField.Hint = "Номер шкафа";
            this.lockerTextField.Location = new System.Drawing.Point(131, 300);
            this.lockerTextField.MaxLength = 32767;
            this.lockerTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.lockerTextField.Name = "lockerTextField";
            this.lockerTextField.PasswordChar = '\0';
            this.lockerTextField.SelectedText = "";
            this.lockerTextField.SelectionLength = 0;
            this.lockerTextField.SelectionStart = 0;
            this.lockerTextField.Size = new System.Drawing.Size(129, 23);
            this.lockerTextField.TabIndex = 14;
            this.lockerTextField.TabStop = false;
            this.lockerTextField.UseSystemPasswordChar = false;
            // 
            // shelfTextField
            // 
            this.shelfTextField.Depth = 0;
            this.shelfTextField.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shelfTextField.Hint = "Номер полки";
            this.shelfTextField.Location = new System.Drawing.Point(309, 300);
            this.shelfTextField.MaxLength = 32767;
            this.shelfTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.shelfTextField.Name = "shelfTextField";
            this.shelfTextField.PasswordChar = '\0';
            this.shelfTextField.SelectedText = "";
            this.shelfTextField.SelectionLength = 0;
            this.shelfTextField.SelectionStart = 0;
            this.shelfTextField.Size = new System.Drawing.Size(129, 23);
            this.shelfTextField.TabIndex = 15;
            this.shelfTextField.TabStop = false;
            this.shelfTextField.UseSystemPasswordChar = false;
            // 
            // priceTextField
            // 
            this.priceTextField.Depth = 0;
            this.priceTextField.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceTextField.Hint = "Цена";
            this.priceTextField.Location = new System.Drawing.Point(131, 356);
            this.priceTextField.MaxLength = 32767;
            this.priceTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.priceTextField.Name = "priceTextField";
            this.priceTextField.PasswordChar = '\0';
            this.priceTextField.SelectedText = "";
            this.priceTextField.SelectionLength = 0;
            this.priceTextField.SelectionStart = 0;
            this.priceTextField.Size = new System.Drawing.Size(129, 23);
            this.priceTextField.TabIndex = 16;
            this.priceTextField.TabStop = false;
            this.priceTextField.UseSystemPasswordChar = false;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.PowderBlue;
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel.Controls.Add(this.pictureBox1);
            this.panel.Controls.Add(this.passordPictureBox);
            this.panel.Controls.Add(this.panel7);
            this.panel.Controls.Add(this.panel1);
            this.panel.Controls.Add(this.exitButton);
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(529, 46);
            this.panel.TabIndex = 9;
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
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
            this.passordPictureBox.TabIndex = 41;
            this.passordPictureBox.TabStop = false;
            this.passordPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(1, -25);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(544, 28);
            this.panel7.TabIndex = 22;
            this.panel7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(-26, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(29, 448);
            this.panel1.TabIndex = 19;
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
            this.exitButton.Location = new System.Drawing.Point(507, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(19, 20);
            this.exitButton.TabIndex = 17;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(529, -1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(29, 448);
            this.panel5.TabIndex = 20;
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(-23, 444);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(556, 28);
            this.panel6.TabIndex = 21;
            this.panel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // pubDataGridView
            // 
            this.pubDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pubDataGridView.Location = new System.Drawing.Point(409, 64);
            this.pubDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.pubDataGridView.Name = "pubDataGridView";
            this.pubDataGridView.RowHeadersWidth = 51;
            this.pubDataGridView.Size = new System.Drawing.Size(100, 118);
            this.pubDataGridView.TabIndex = 35;
            this.pubDataGridView.Visible = false;
            // 
            // addBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 445);
            this.Controls.Add(this.pubDataGridView);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.priceTextField);
            this.Controls.Add(this.shelfTextField);
            this.Controls.Add(this.lockerTextField);
            this.Controls.Add(this.isbnTextField);
            this.Controls.Add(this.pagesTextField);
            this.Controls.Add(this.publisherComboBox);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.genreTextField);
            this.Controls.Add(this.authorTextField);
            this.Controls.Add(this.nameTextField);
            this.Controls.Add(this.addBookButton);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление книги";
            this.panel2.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passordPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pubDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button addBookButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField nameTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField authorTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField genreTextField;
        private System.Windows.Forms.ComboBox typeComboBox;
        public System.Windows.Forms.ComboBox publisherComboBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField pagesTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField isbnTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField lockerTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField shelfTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField priceTextField;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.DataGridView pubDataGridView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox passordPictureBox;
    }
}