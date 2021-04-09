﻿namespace Library
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
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PowderBlue;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(119, 518);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(-35, 22);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(39, 551);
            this.panel3.TabIndex = 18;
            // 
            // addBookButton
            // 
            this.addBookButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addBookButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBookButton.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBookButton.Location = new System.Drawing.Point(492, 464);
            this.addBookButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(155, 41);
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
            this.nameTextField.Location = new System.Drawing.Point(128, 36);
            this.nameTextField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameTextField.MaxLength = 32767;
            this.nameTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.nameTextField.Name = "nameTextField";
            this.nameTextField.PasswordChar = '\0';
            this.nameTextField.SelectedText = "";
            this.nameTextField.SelectionLength = 0;
            this.nameTextField.SelectionStart = 0;
            this.nameTextField.Size = new System.Drawing.Size(476, 28);
            this.nameTextField.TabIndex = 4;
            this.nameTextField.TabStop = false;
            this.nameTextField.UseSystemPasswordChar = false;
            this.nameTextField.TextChanged += new System.EventHandler(this.nameTextField_TextChanged);
            // 
            // authorTextField
            // 
            this.authorTextField.Depth = 0;
            this.authorTextField.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorTextField.Hint = "Автор";
            this.authorTextField.Location = new System.Drawing.Point(128, 87);
            this.authorTextField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.authorTextField.MaxLength = 32767;
            this.authorTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.authorTextField.Name = "authorTextField";
            this.authorTextField.PasswordChar = '\0';
            this.authorTextField.SelectedText = "";
            this.authorTextField.SelectionLength = 0;
            this.authorTextField.SelectionStart = 0;
            this.authorTextField.Size = new System.Drawing.Size(476, 28);
            this.authorTextField.TabIndex = 5;
            this.authorTextField.TabStop = false;
            this.authorTextField.UseSystemPasswordChar = false;
            this.authorTextField.TextChanged += new System.EventHandler(this.authorTextField_TextChanged);
            // 
            // genreTextField
            // 
            this.genreTextField.Depth = 0;
            this.genreTextField.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genreTextField.Hint = "Жанр";
            this.genreTextField.Location = new System.Drawing.Point(128, 143);
            this.genreTextField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.genreTextField.MaxLength = 32767;
            this.genreTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.genreTextField.Name = "genreTextField";
            this.genreTextField.PasswordChar = '\0';
            this.genreTextField.SelectedText = "";
            this.genreTextField.SelectionLength = 0;
            this.genreTextField.SelectionStart = 0;
            this.genreTextField.Size = new System.Drawing.Size(476, 28);
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
            this.typeComboBox.Location = new System.Drawing.Point(128, 194);
            this.typeComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(208, 32);
            this.typeComboBox.TabIndex = 10;
            this.typeComboBox.Text = "Выберите тип";
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // publisherComboBox
            // 
            this.publisherComboBox.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.publisherComboBox.ForeColor = System.Drawing.Color.Black;
            this.publisherComboBox.FormattingEnabled = true;
            this.publisherComboBox.Items.AddRange(new object[] {
            "Харвест",
            "Азбука",
            "Эксмо"});
            this.publisherComboBox.Location = new System.Drawing.Point(365, 194);
            this.publisherComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.publisherComboBox.Name = "publisherComboBox";
            this.publisherComboBox.Size = new System.Drawing.Size(267, 32);
            this.publisherComboBox.TabIndex = 11;
            this.publisherComboBox.Text = "Выберите издательство";
            // 
            // pagesTextField
            // 
            this.pagesTextField.Depth = 0;
            this.pagesTextField.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pagesTextField.Hint = "Страницы";
            this.pagesTextField.Location = new System.Drawing.Point(128, 263);
            this.pagesTextField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pagesTextField.MaxLength = 32767;
            this.pagesTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.pagesTextField.Name = "pagesTextField";
            this.pagesTextField.PasswordChar = '\0';
            this.pagesTextField.SelectedText = "";
            this.pagesTextField.SelectionLength = 0;
            this.pagesTextField.SelectionStart = 0;
            this.pagesTextField.Size = new System.Drawing.Size(172, 28);
            this.pagesTextField.TabIndex = 12;
            this.pagesTextField.TabStop = false;
            this.pagesTextField.UseSystemPasswordChar = false;
            // 
            // isbnTextField
            // 
            this.isbnTextField.Depth = 0;
            this.isbnTextField.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isbnTextField.Hint = "ISBN";
            this.isbnTextField.Location = new System.Drawing.Point(365, 263);
            this.isbnTextField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.isbnTextField.MaxLength = 32767;
            this.isbnTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.isbnTextField.Name = "isbnTextField";
            this.isbnTextField.PasswordChar = '\0';
            this.isbnTextField.SelectedText = "";
            this.isbnTextField.SelectionLength = 0;
            this.isbnTextField.SelectionStart = 0;
            this.isbnTextField.Size = new System.Drawing.Size(172, 28);
            this.isbnTextField.TabIndex = 13;
            this.isbnTextField.TabStop = false;
            this.isbnTextField.UseSystemPasswordChar = false;
            // 
            // lockerTextField
            // 
            this.lockerTextField.Depth = 0;
            this.lockerTextField.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lockerTextField.Hint = "Номер шкафа";
            this.lockerTextField.Location = new System.Drawing.Point(128, 331);
            this.lockerTextField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lockerTextField.MaxLength = 32767;
            this.lockerTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.lockerTextField.Name = "lockerTextField";
            this.lockerTextField.PasswordChar = '\0';
            this.lockerTextField.SelectedText = "";
            this.lockerTextField.SelectionLength = 0;
            this.lockerTextField.SelectionStart = 0;
            this.lockerTextField.Size = new System.Drawing.Size(172, 28);
            this.lockerTextField.TabIndex = 14;
            this.lockerTextField.TabStop = false;
            this.lockerTextField.UseSystemPasswordChar = false;
            // 
            // shelfTextField
            // 
            this.shelfTextField.Depth = 0;
            this.shelfTextField.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shelfTextField.Hint = "Номер полки";
            this.shelfTextField.Location = new System.Drawing.Point(365, 331);
            this.shelfTextField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.shelfTextField.MaxLength = 32767;
            this.shelfTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.shelfTextField.Name = "shelfTextField";
            this.shelfTextField.PasswordChar = '\0';
            this.shelfTextField.SelectedText = "";
            this.shelfTextField.SelectionLength = 0;
            this.shelfTextField.SelectionStart = 0;
            this.shelfTextField.Size = new System.Drawing.Size(172, 28);
            this.shelfTextField.TabIndex = 15;
            this.shelfTextField.TabStop = false;
            this.shelfTextField.UseSystemPasswordChar = false;
            // 
            // priceTextField
            // 
            this.priceTextField.Depth = 0;
            this.priceTextField.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceTextField.Hint = "Цена";
            this.priceTextField.Location = new System.Drawing.Point(128, 400);
            this.priceTextField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.priceTextField.MaxLength = 32767;
            this.priceTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.priceTextField.Name = "priceTextField";
            this.priceTextField.PasswordChar = '\0';
            this.priceTextField.SelectedText = "";
            this.priceTextField.SelectionLength = 0;
            this.priceTextField.SelectionStart = 0;
            this.priceTextField.Size = new System.Drawing.Size(172, 28);
            this.priceTextField.TabIndex = 16;
            this.priceTextField.TabStop = false;
            this.priceTextField.UseSystemPasswordChar = false;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.PowderBlue;
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel.Controls.Add(this.panel7);
            this.panel.Controls.Add(this.panel4);
            this.panel.Controls.Add(this.panel1);
            this.panel.Controls.Add(this.button1);
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(663, 28);
            this.panel.TabIndex = 9;
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(1, -31);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(664, 34);
            this.panel7.TabIndex = 22;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(658, -2);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(39, 551);
            this.panel4.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(-35, -4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(39, 551);
            this.panel1.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PowderBlue;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.PowderBlue;
            this.button1.ImageKey = "(отсутствует)";
            this.button1.Location = new System.Drawing.Point(632, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(659, -1);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(39, 551);
            this.panel5.TabIndex = 20;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(0, 516);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(664, 34);
            this.panel6.TabIndex = 21;
            // 
            // addBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 519);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "addBookForm";
            this.Text = "Добавление книги";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.addBookForm_FormClosing);
            this.panel2.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button addBookButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField nameTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField authorTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField genreTextField;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.ComboBox publisherComboBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField pagesTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField isbnTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField lockerTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField shelfTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField priceTextField;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
    }
}