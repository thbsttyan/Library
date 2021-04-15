namespace Library
{
    partial class addReaderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addReaderForm));
            this.readerDataGridView = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.passportTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.townTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.numberTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.positionTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.booksComboBox = new System.Windows.Forms.ComboBox();
            this.patronymicTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.nameTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.surnameTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.addReaderButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel2 = new System.Windows.Forms.Panel();
            this.readDateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.readerDataGridView)).BeginInit();
            this.panel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // readerDataGridView
            // 
            this.readerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.readerDataGridView.Location = new System.Drawing.Point(516, 41);
            this.readerDataGridView.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.readerDataGridView.Name = "readerDataGridView";
            this.readerDataGridView.RowHeadersWidth = 51;
            this.readerDataGridView.Size = new System.Drawing.Size(133, 145);
            this.readerDataGridView.TabIndex = 51;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(659, -1);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(39, 551);
            this.panel5.TabIndex = 49;
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(1, -31);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(664, 34);
            this.panel7.TabIndex = 22;
            this.panel7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(659, -2);
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
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(0, 516);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(664, 34);
            this.panel6.TabIndex = 50;
            this.panel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.PowderBlue;
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel.Controls.Add(this.panel7);
            this.panel.Controls.Add(this.panel4);
            this.panel.Controls.Add(this.panel1);
            this.panel.Controls.Add(this.exitButton);
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(663, 28);
            this.panel.TabIndex = 41;
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
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
            this.exitButton.Location = new System.Drawing.Point(632, 4);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(25, 25);
            this.exitButton.TabIndex = 17;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // passportTextField
            // 
            this.passportTextField.Depth = 0;
            this.passportTextField.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passportTextField.Hint = "Номер паспорта";
            this.passportTextField.Location = new System.Drawing.Point(128, 438);
            this.passportTextField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passportTextField.MaxLength = 32767;
            this.passportTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.passportTextField.Name = "passportTextField";
            this.passportTextField.PasswordChar = '\0';
            this.passportTextField.SelectedText = "";
            this.passportTextField.SelectionLength = 0;
            this.passportTextField.SelectionStart = 0;
            this.passportTextField.Size = new System.Drawing.Size(172, 28);
            this.passportTextField.TabIndex = 48;
            this.passportTextField.TabStop = false;
            this.passportTextField.UseSystemPasswordChar = false;
            // 
            // townTextField
            // 
            this.townTextField.Depth = 0;
            this.townTextField.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.townTextField.Hint = "Город";
            this.townTextField.Location = new System.Drawing.Point(365, 369);
            this.townTextField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.townTextField.MaxLength = 32767;
            this.townTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.townTextField.Name = "townTextField";
            this.townTextField.PasswordChar = '\0';
            this.townTextField.SelectedText = "";
            this.townTextField.SelectionLength = 0;
            this.townTextField.SelectionStart = 0;
            this.townTextField.Size = new System.Drawing.Size(172, 28);
            this.townTextField.TabIndex = 47;
            this.townTextField.TabStop = false;
            this.townTextField.UseSystemPasswordChar = false;
            // 
            // numberTextField
            // 
            this.numberTextField.Depth = 0;
            this.numberTextField.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberTextField.Hint = "Номер телефона";
            this.numberTextField.Location = new System.Drawing.Point(128, 369);
            this.numberTextField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numberTextField.MaxLength = 32767;
            this.numberTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.numberTextField.Name = "numberTextField";
            this.numberTextField.PasswordChar = '\0';
            this.numberTextField.SelectedText = "";
            this.numberTextField.SelectionLength = 0;
            this.numberTextField.SelectionStart = 0;
            this.numberTextField.Size = new System.Drawing.Size(172, 28);
            this.numberTextField.TabIndex = 46;
            this.numberTextField.TabStop = false;
            this.numberTextField.UseSystemPasswordChar = false;
            // 
            // positionTextField
            // 
            this.positionTextField.Depth = 0;
            this.positionTextField.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.positionTextField.Hint = "Должность";
            this.positionTextField.Location = new System.Drawing.Point(128, 302);
            this.positionTextField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.positionTextField.MaxLength = 32767;
            this.positionTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.positionTextField.Name = "positionTextField";
            this.positionTextField.PasswordChar = '\0';
            this.positionTextField.SelectedText = "";
            this.positionTextField.SelectionLength = 0;
            this.positionTextField.SelectionStart = 0;
            this.positionTextField.Size = new System.Drawing.Size(172, 28);
            this.positionTextField.TabIndex = 44;
            this.positionTextField.TabStop = false;
            this.positionTextField.UseSystemPasswordChar = false;
            // 
            // booksComboBox
            // 
            this.booksComboBox.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.booksComboBox.ForeColor = System.Drawing.Color.Black;
            this.booksComboBox.FormattingEnabled = true;
            this.booksComboBox.Location = new System.Drawing.Point(128, 196);
            this.booksComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.booksComboBox.Name = "booksComboBox";
            this.booksComboBox.Size = new System.Drawing.Size(388, 32);
            this.booksComboBox.TabIndex = 43;
            this.booksComboBox.Text = "Выберите книгу";
            // 
            // patronymicTextField
            // 
            this.patronymicTextField.Depth = 0;
            this.patronymicTextField.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patronymicTextField.Hint = "Отчество";
            this.patronymicTextField.Location = new System.Drawing.Point(128, 143);
            this.patronymicTextField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.patronymicTextField.MaxLength = 32767;
            this.patronymicTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.patronymicTextField.Name = "patronymicTextField";
            this.patronymicTextField.PasswordChar = '\0';
            this.patronymicTextField.SelectedText = "";
            this.patronymicTextField.SelectionLength = 0;
            this.patronymicTextField.SelectionStart = 0;
            this.patronymicTextField.Size = new System.Drawing.Size(476, 28);
            this.patronymicTextField.TabIndex = 40;
            this.patronymicTextField.TabStop = false;
            this.patronymicTextField.UseSystemPasswordChar = false;
            // 
            // nameTextField
            // 
            this.nameTextField.Depth = 0;
            this.nameTextField.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextField.Hint = "Имя";
            this.nameTextField.Location = new System.Drawing.Point(128, 87);
            this.nameTextField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameTextField.MaxLength = 32767;
            this.nameTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.nameTextField.Name = "nameTextField";
            this.nameTextField.PasswordChar = '\0';
            this.nameTextField.SelectedText = "";
            this.nameTextField.SelectionLength = 0;
            this.nameTextField.SelectionStart = 0;
            this.nameTextField.Size = new System.Drawing.Size(476, 28);
            this.nameTextField.TabIndex = 39;
            this.nameTextField.TabStop = false;
            this.nameTextField.UseSystemPasswordChar = false;
            // 
            // surnameTextField
            // 
            this.surnameTextField.Depth = 0;
            this.surnameTextField.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameTextField.Hint = "Фамилия";
            this.surnameTextField.Location = new System.Drawing.Point(128, 36);
            this.surnameTextField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.surnameTextField.MaxLength = 32767;
            this.surnameTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.surnameTextField.Name = "surnameTextField";
            this.surnameTextField.PasswordChar = '\0';
            this.surnameTextField.SelectedText = "";
            this.surnameTextField.SelectionLength = 0;
            this.surnameTextField.SelectionStart = 0;
            this.surnameTextField.Size = new System.Drawing.Size(476, 28);
            this.surnameTextField.TabIndex = 38;
            this.surnameTextField.TabStop = false;
            this.surnameTextField.UseSystemPasswordChar = false;
            // 
            // addReaderButton
            // 
            this.addReaderButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addReaderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addReaderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addReaderButton.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addReaderButton.Location = new System.Drawing.Point(457, 464);
            this.addReaderButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addReaderButton.Name = "addReaderButton";
            this.addReaderButton.Size = new System.Drawing.Size(189, 41);
            this.addReaderButton.TabIndex = 37;
            this.addReaderButton.Text = "Добавить читателя";
            this.addReaderButton.UseVisualStyleBackColor = false;
            this.addReaderButton.Click += new System.EventHandler(this.addReaderButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(-35, 22);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(39, 551);
            this.panel3.TabIndex = 18;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // groupTextField
            // 
            this.groupTextField.Depth = 0;
            this.groupTextField.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupTextField.Hint = "Группа";
            this.groupTextField.Location = new System.Drawing.Point(365, 302);
            this.groupTextField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupTextField.MaxLength = 32767;
            this.groupTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.groupTextField.Name = "groupTextField";
            this.groupTextField.PasswordChar = '\0';
            this.groupTextField.SelectedText = "";
            this.groupTextField.SelectionLength = 0;
            this.groupTextField.SelectionStart = 0;
            this.groupTextField.Size = new System.Drawing.Size(172, 28);
            this.groupTextField.TabIndex = 45;
            this.groupTextField.TabStop = false;
            this.groupTextField.UseSystemPasswordChar = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PowderBlue;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(119, 518);
            this.panel2.TabIndex = 36;
            // 
            // readDateTimePicker
            // 
            this.readDateTimePicker.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.readDateTimePicker.Location = new System.Drawing.Point(128, 249);
            this.readDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.readDateTimePicker.Name = "readDateTimePicker";
            this.readDateTimePicker.Size = new System.Drawing.Size(265, 32);
            this.readDateTimePicker.TabIndex = 52;
            this.readDateTimePicker.ValueChanged += new System.EventHandler(this.readDateTimePicker_ValueChanged);
            // 
            // addReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 519);
            this.Controls.Add(this.readDateTimePicker);
            this.Controls.Add(this.readerDataGridView);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.passportTextField);
            this.Controls.Add(this.townTextField);
            this.Controls.Add(this.numberTextField);
            this.Controls.Add(this.positionTextField);
            this.Controls.Add(this.booksComboBox);
            this.Controls.Add(this.patronymicTextField);
            this.Controls.Add(this.nameTextField);
            this.Controls.Add(this.surnameTextField);
            this.Controls.Add(this.addReaderButton);
            this.Controls.Add(this.groupTextField);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "addReaderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addReaderForm";
            ((System.ComponentModel.ISupportInitialize)(this.readerDataGridView)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView readerDataGridView;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel;
        private MaterialSkin.Controls.MaterialSingleLineTextField passportTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField townTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField numberTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField positionTextField;
        public System.Windows.Forms.ComboBox booksComboBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField patronymicTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField nameTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField surnameTextField;
        private System.Windows.Forms.Button addReaderButton;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField groupTextField;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker readDateTimePicker;
    }
}