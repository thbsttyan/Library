namespace Library
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.authButton = new System.Windows.Forms.Button();
            this.registrationButton = new System.Windows.Forms.Button();
            this.readersButton = new System.Windows.Forms.Button();
            this.publisherButton = new System.Windows.Forms.Button();
            this.bookButton = new System.Windows.Forms.Button();
            this.addBookButton = new System.Windows.Forms.Button();
            this.booksDataGridView = new System.Windows.Forms.DataGridView();
            this.panel = new System.Windows.Forms.Panel();
            this.passordPictureBox = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.newRegistrationButton = new System.Windows.Forms.Button();
            this.booksPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.redactBooksCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.readersPanel = new System.Windows.Forms.Panel();
            this.chronologyDataGridView = new System.Windows.Forms.DataGridView();
            this.lendingbutton = new System.Windows.Forms.Button();
            this.lendingDataGridView = new System.Windows.Forms.DataGridView();
            this.addReturnButton = new System.Windows.Forms.Button();
            this.returnDataGridView = new System.Windows.Forms.DataGridView();
            this.redactReadersCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.addReaderButton = new System.Windows.Forms.Button();
            this.readerDataGridView = new System.Windows.Forms.DataGridView();
            this.publishersPanel = new System.Windows.Forms.Panel();
            this.redactPublishersCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.addPublisherButton = new System.Windows.Forms.Button();
            this.publisherDataGridView = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passordPictureBox)).BeginInit();
            this.booksPanel.SuspendLayout();
            this.readersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chronologyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lendingDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerDataGridView)).BeginInit();
            this.publishersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.publisherDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PowderBlue;
            this.panel2.Controls.Add(this.authButton);
            this.panel2.Controls.Add(this.registrationButton);
            this.panel2.Controls.Add(this.readersButton);
            this.panel2.Controls.Add(this.publisherButton);
            this.panel2.Controls.Add(this.bookButton);
            this.panel2.Location = new System.Drawing.Point(-4, 68);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 982);
            this.panel2.TabIndex = 1;
            // 
            // authButton
            // 
            this.authButton.BackColor = System.Drawing.Color.LightBlue;
            this.authButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.authButton.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.authButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.authButton.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authButton.Image = ((System.Drawing.Image)(resources.GetObject("authButton.Image")));
            this.authButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.authButton.Location = new System.Drawing.Point(-1, 842);
            this.authButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.authButton.Name = "authButton";
            this.authButton.Size = new System.Drawing.Size(216, 117);
            this.authButton.TabIndex = 6;
            this.authButton.Text = "Вернуться к авторизации";
            this.authButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.authButton.UseVisualStyleBackColor = false;
            this.authButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // registrationButton
            // 
            this.registrationButton.BackColor = System.Drawing.Color.LightBlue;
            this.registrationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.registrationButton.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.registrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrationButton.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationButton.Image = ((System.Drawing.Image)(resources.GetObject("registrationButton.Image")));
            this.registrationButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.registrationButton.Location = new System.Drawing.Point(-3, 322);
            this.registrationButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(216, 96);
            this.registrationButton.TabIndex = 5;
            this.registrationButton.Text = "Регистрация";
            this.registrationButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.registrationButton.UseVisualStyleBackColor = false;
            this.registrationButton.Click += new System.EventHandler(this.newRegistrationButton_Click);
            // 
            // readersButton
            // 
            this.readersButton.BackColor = System.Drawing.Color.LightBlue;
            this.readersButton.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.readersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.readersButton.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.readersButton.Image = ((System.Drawing.Image)(resources.GetObject("readersButton.Image")));
            this.readersButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.readersButton.Location = new System.Drawing.Point(-3, 98);
            this.readersButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.readersButton.Name = "readersButton";
            this.readersButton.Size = new System.Drawing.Size(216, 96);
            this.readersButton.TabIndex = 4;
            this.readersButton.Text = "Читатели";
            this.readersButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.readersButton.UseVisualStyleBackColor = false;
            this.readersButton.Click += new System.EventHandler(this.readersButton_Click);
            // 
            // publisherButton
            // 
            this.publisherButton.BackColor = System.Drawing.Color.LightBlue;
            this.publisherButton.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.publisherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.publisherButton.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.publisherButton.Image = ((System.Drawing.Image)(resources.GetObject("publisherButton.Image")));
            this.publisherButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.publisherButton.Location = new System.Drawing.Point(-3, 194);
            this.publisherButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.publisherButton.Name = "publisherButton";
            this.publisherButton.Size = new System.Drawing.Size(216, 96);
            this.publisherButton.TabIndex = 3;
            this.publisherButton.Text = "Издательства";
            this.publisherButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.publisherButton.UseVisualStyleBackColor = false;
            this.publisherButton.Click += new System.EventHandler(this.publisherButton_Click);
            // 
            // bookButton
            // 
            this.bookButton.BackColor = System.Drawing.Color.LightBlue;
            this.bookButton.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.bookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookButton.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bookButton.Image = ((System.Drawing.Image)(resources.GetObject("bookButton.Image")));
            this.bookButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bookButton.Location = new System.Drawing.Point(-3, 2);
            this.bookButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bookButton.Name = "bookButton";
            this.bookButton.Size = new System.Drawing.Size(216, 96);
            this.bookButton.TabIndex = 2;
            this.bookButton.Text = "Книги";
            this.bookButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bookButton.UseVisualStyleBackColor = false;
            this.bookButton.Click += new System.EventHandler(this.bookButton_Click);
            // 
            // addBookButton
            // 
            this.addBookButton.BackColor = System.Drawing.Color.PowderBlue;
            this.addBookButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBookButton.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBookButton.Location = new System.Drawing.Point(3, 2);
            this.addBookButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(208, 28);
            this.addBookButton.TabIndex = 0;
            this.addBookButton.Text = "Добавить книгу";
            this.addBookButton.UseVisualStyleBackColor = false;
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // booksDataGridView
            // 
            this.booksDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.booksDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.booksDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.booksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksDataGridView.Location = new System.Drawing.Point(0, 41);
            this.booksDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.booksDataGridView.Name = "booksDataGridView";
            this.booksDataGridView.ReadOnly = true;
            this.booksDataGridView.RowHeadersWidth = 51;
            this.booksDataGridView.Size = new System.Drawing.Size(1508, 937);
            this.booksDataGridView.TabIndex = 5;
            this.booksDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.booksDataGridView_CellClick);
            this.booksDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.booksDataGridView_CellValueChanged);
            this.booksDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.booksDataGridView_DataError);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.PowderBlue;
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel.Controls.Add(this.passordPictureBox);
            this.panel.Controls.Add(this.panel4);
            this.panel.Controls.Add(this.exitButton);
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1776, 70);
            this.panel.TabIndex = 10;
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // passordPictureBox
            // 
            this.passordPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("passordPictureBox.Image")));
            this.passordPictureBox.Location = new System.Drawing.Point(7, 6);
            this.passordPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passordPictureBox.Name = "passordPictureBox";
            this.passordPictureBox.Size = new System.Drawing.Size(204, 63);
            this.passordPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.passordPictureBox.TabIndex = 38;
            this.passordPictureBox.TabStop = false;
            this.passordPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(-4, -21);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1759, 25);
            this.panel4.TabIndex = 15;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
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
            this.exitButton.Location = new System.Drawing.Point(1695, 2);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(25, 25);
            this.exitButton.TabIndex = 11;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(-1, 1046);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1777, 25);
            this.panel1.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(-35, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(39, 1066);
            this.panel3.TabIndex = 17;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(1720, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(39, 1070);
            this.panel5.TabIndex = 18;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // newRegistrationButton
            // 
            this.newRegistrationButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.newRegistrationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newRegistrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newRegistrationButton.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newRegistrationButton.Location = new System.Drawing.Point(219, 1058);
            this.newRegistrationButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newRegistrationButton.Name = "newRegistrationButton";
            this.newRegistrationButton.Size = new System.Drawing.Size(277, 55);
            this.newRegistrationButton.TabIndex = 19;
            this.newRegistrationButton.Text = "Зарегистрировать нового пользователя";
            this.newRegistrationButton.UseVisualStyleBackColor = false;
            this.newRegistrationButton.Click += new System.EventHandler(this.newRegistrationButton_Click);
            // 
            // booksPanel
            // 
            this.booksPanel.BackColor = System.Drawing.SystemColors.Control;
            this.booksPanel.Controls.Add(this.label1);
            this.booksPanel.Controls.Add(this.cancelButton);
            this.booksPanel.Controls.Add(this.searchButton);
            this.booksPanel.Controls.Add(this.searchTextField);
            this.booksPanel.Controls.Add(this.redactBooksCheckBox);
            this.booksPanel.Controls.Add(this.booksDataGridView);
            this.booksPanel.Controls.Add(this.addBookButton);
            this.booksPanel.Location = new System.Drawing.Point(211, 69);
            this.booksPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.booksPanel.Name = "booksPanel";
            this.booksPanel.Size = new System.Drawing.Size(1508, 977);
            this.booksPanel.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yanone Kaffeesatz", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(412, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(599, 63);
            this.label1.TabIndex = 27;
            this.label1.Text = "Книги с таким названием не найдены!";
            this.label1.Visible = false;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.PowderBlue;
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(1377, 2);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(111, 28);
            this.cancelButton.TabIndex = 26;
            this.cancelButton.Text = "Сброс";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.PowderBlue;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.Enabled = false;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchButton.Location = new System.Drawing.Point(913, 4);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(111, 28);
            this.searchButton.TabIndex = 25;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Visible = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextField
            // 
            this.searchTextField.Depth = 0;
            this.searchTextField.Hint = "Введите название книги";
            this.searchTextField.Location = new System.Drawing.Point(556, 5);
            this.searchTextField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchTextField.MaxLength = 32767;
            this.searchTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchTextField.Name = "searchTextField";
            this.searchTextField.PasswordChar = '\0';
            this.searchTextField.SelectedText = "";
            this.searchTextField.SelectionLength = 0;
            this.searchTextField.SelectionStart = 0;
            this.searchTextField.Size = new System.Drawing.Size(349, 28);
            this.searchTextField.TabIndex = 24;
            this.searchTextField.TabStop = false;
            this.searchTextField.UseSystemPasswordChar = false;
            this.searchTextField.Click += new System.EventHandler(this.searchTextField_Click);
            this.searchTextField.TextChanged += new System.EventHandler(this.searchTextField_TextChanged);
            // 
            // redactBooksCheckBox
            // 
            this.redactBooksCheckBox.AutoSize = true;
            this.redactBooksCheckBox.Depth = 0;
            this.redactBooksCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.redactBooksCheckBox.Location = new System.Drawing.Point(229, 1);
            this.redactBooksCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.redactBooksCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.redactBooksCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.redactBooksCheckBox.Name = "redactBooksCheckBox";
            this.redactBooksCheckBox.Ripple = true;
            this.redactBooksCheckBox.Size = new System.Drawing.Size(227, 30);
            this.redactBooksCheckBox.TabIndex = 23;
            this.redactBooksCheckBox.Text = "Режим редактирования";
            this.redactBooksCheckBox.UseVisualStyleBackColor = true;
            this.redactBooksCheckBox.CheckedChanged += new System.EventHandler(this.redactBooksCheckBox_CheckedChanged);
            // 
            // readersPanel
            // 
            this.readersPanel.BackColor = System.Drawing.SystemColors.Control;
            this.readersPanel.Controls.Add(this.chronologyDataGridView);
            this.readersPanel.Controls.Add(this.lendingbutton);
            this.readersPanel.Controls.Add(this.lendingDataGridView);
            this.readersPanel.Controls.Add(this.addReturnButton);
            this.readersPanel.Controls.Add(this.returnDataGridView);
            this.readersPanel.Controls.Add(this.redactReadersCheckBox);
            this.readersPanel.Controls.Add(this.addReaderButton);
            this.readersPanel.Controls.Add(this.readerDataGridView);
            this.readersPanel.Location = new System.Drawing.Point(211, 69);
            this.readersPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.readersPanel.Name = "readersPanel";
            this.readersPanel.Size = new System.Drawing.Size(1509, 977);
            this.readersPanel.TabIndex = 21;
            this.readersPanel.Visible = false;
            // 
            // chronologyDataGridView
            // 
            this.chronologyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.chronologyDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.chronologyDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chronologyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chronologyDataGridView.Location = new System.Drawing.Point(668, 334);
            this.chronologyDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chronologyDataGridView.Name = "chronologyDataGridView";
            this.chronologyDataGridView.ReadOnly = true;
            this.chronologyDataGridView.RowHeadersWidth = 51;
            this.chronologyDataGridView.Size = new System.Drawing.Size(841, 644);
            this.chronologyDataGridView.TabIndex = 29;
            // 
            // lendingbutton
            // 
            this.lendingbutton.BackColor = System.Drawing.Color.PowderBlue;
            this.lendingbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lendingbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lendingbutton.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lendingbutton.Location = new System.Drawing.Point(3, 302);
            this.lendingbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lendingbutton.Name = "lendingbutton";
            this.lendingbutton.Size = new System.Drawing.Size(139, 28);
            this.lendingbutton.TabIndex = 28;
            this.lendingbutton.Text = "Выдать книгу";
            this.lendingbutton.UseVisualStyleBackColor = false;
            this.lendingbutton.Click += new System.EventHandler(this.lendingbutton_Click);
            // 
            // lendingDataGridView
            // 
            this.lendingDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.lendingDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.lendingDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lendingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lendingDataGridView.Location = new System.Drawing.Point(3, 335);
            this.lendingDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lendingDataGridView.Name = "lendingDataGridView";
            this.lendingDataGridView.ReadOnly = true;
            this.lendingDataGridView.RowHeadersWidth = 51;
            this.lendingDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lendingDataGridView.Size = new System.Drawing.Size(657, 161);
            this.lendingDataGridView.TabIndex = 27;
            // 
            // addReturnButton
            // 
            this.addReturnButton.BackColor = System.Drawing.Color.PowderBlue;
            this.addReturnButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addReturnButton.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addReturnButton.Location = new System.Drawing.Point(3, 546);
            this.addReturnButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addReturnButton.Name = "addReturnButton";
            this.addReturnButton.Size = new System.Drawing.Size(205, 28);
            this.addReturnButton.TabIndex = 26;
            this.addReturnButton.Text = "Оформить возврат книги";
            this.addReturnButton.UseVisualStyleBackColor = false;
            this.addReturnButton.Click += new System.EventHandler(this.addReturnButton_Click);
            // 
            // returnDataGridView
            // 
            this.returnDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.returnDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.returnDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.returnDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.returnDataGridView.Location = new System.Drawing.Point(4, 582);
            this.returnDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.returnDataGridView.Name = "returnDataGridView";
            this.returnDataGridView.ReadOnly = true;
            this.returnDataGridView.RowHeadersWidth = 51;
            this.returnDataGridView.Size = new System.Drawing.Size(656, 277);
            this.returnDataGridView.TabIndex = 25;
            // 
            // redactReadersCheckBox
            // 
            this.redactReadersCheckBox.AutoSize = true;
            this.redactReadersCheckBox.Depth = 0;
            this.redactReadersCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.redactReadersCheckBox.Location = new System.Drawing.Point(229, 2);
            this.redactReadersCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.redactReadersCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.redactReadersCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.redactReadersCheckBox.Name = "redactReadersCheckBox";
            this.redactReadersCheckBox.Ripple = true;
            this.redactReadersCheckBox.Size = new System.Drawing.Size(227, 30);
            this.redactReadersCheckBox.TabIndex = 24;
            this.redactReadersCheckBox.Text = "Режим редактирования";
            this.redactReadersCheckBox.UseVisualStyleBackColor = true;
            this.redactReadersCheckBox.CheckedChanged += new System.EventHandler(this.redactReadersCheckBox_CheckedChanged);
            // 
            // addReaderButton
            // 
            this.addReaderButton.BackColor = System.Drawing.Color.PowderBlue;
            this.addReaderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addReaderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addReaderButton.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addReaderButton.Location = new System.Drawing.Point(3, 2);
            this.addReaderButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addReaderButton.Name = "addReaderButton";
            this.addReaderButton.Size = new System.Drawing.Size(207, 28);
            this.addReaderButton.TabIndex = 6;
            this.addReaderButton.Text = "Добавить читателя";
            this.addReaderButton.UseVisualStyleBackColor = false;
            this.addReaderButton.Click += new System.EventHandler(this.addReaderButton_Click);
            // 
            // readerDataGridView
            // 
            this.readerDataGridView.AllowUserToAddRows = false;
            this.readerDataGridView.AllowUserToDeleteRows = false;
            this.readerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.readerDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.readerDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.readerDataGridView.Location = new System.Drawing.Point(3, 39);
            this.readerDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.readerDataGridView.MultiSelect = false;
            this.readerDataGridView.Name = "readerDataGridView";
            this.readerDataGridView.ReadOnly = true;
            this.readerDataGridView.RowHeadersWidth = 51;
            this.readerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.readerDataGridView.Size = new System.Drawing.Size(1332, 229);
            this.readerDataGridView.TabIndex = 5;
            this.readerDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.readerDataGridView_CellValueChanged);
            this.readerDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.readerDataGridView_DataError);
            // 
            // publishersPanel
            // 
            this.publishersPanel.BackColor = System.Drawing.SystemColors.Control;
            this.publishersPanel.Controls.Add(this.redactPublishersCheckBox);
            this.publishersPanel.Controls.Add(this.addPublisherButton);
            this.publishersPanel.Controls.Add(this.publisherDataGridView);
            this.publishersPanel.Location = new System.Drawing.Point(211, 69);
            this.publishersPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.publishersPanel.Name = "publishersPanel";
            this.publishersPanel.Size = new System.Drawing.Size(1509, 977);
            this.publishersPanel.TabIndex = 22;
            this.publishersPanel.Visible = false;
            // 
            // redactPublishersCheckBox
            // 
            this.redactPublishersCheckBox.AutoSize = true;
            this.redactPublishersCheckBox.Depth = 0;
            this.redactPublishersCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.redactPublishersCheckBox.Location = new System.Drawing.Point(229, 2);
            this.redactPublishersCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.redactPublishersCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.redactPublishersCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.redactPublishersCheckBox.Name = "redactPublishersCheckBox";
            this.redactPublishersCheckBox.Ripple = true;
            this.redactPublishersCheckBox.Size = new System.Drawing.Size(227, 30);
            this.redactPublishersCheckBox.TabIndex = 24;
            this.redactPublishersCheckBox.Text = "Режим редактирования";
            this.redactPublishersCheckBox.UseVisualStyleBackColor = true;
            this.redactPublishersCheckBox.CheckedChanged += new System.EventHandler(this.redactPublishersCheckBox_CheckedChanged);
            // 
            // addPublisherButton
            // 
            this.addPublisherButton.BackColor = System.Drawing.Color.PowderBlue;
            this.addPublisherButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addPublisherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPublisherButton.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addPublisherButton.Location = new System.Drawing.Point(3, 2);
            this.addPublisherButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addPublisherButton.Name = "addPublisherButton";
            this.addPublisherButton.Size = new System.Drawing.Size(207, 28);
            this.addPublisherButton.TabIndex = 6;
            this.addPublisherButton.Text = "Добавить издательство";
            this.addPublisherButton.UseVisualStyleBackColor = false;
            this.addPublisherButton.Click += new System.EventHandler(this.addPublisherButton_Click);
            // 
            // publisherDataGridView
            // 
            this.publisherDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.publisherDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.publisherDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.publisherDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.publisherDataGridView.Location = new System.Drawing.Point(3, 39);
            this.publisherDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.publisherDataGridView.Name = "publisherDataGridView";
            this.publisherDataGridView.ReadOnly = true;
            this.publisherDataGridView.RowHeadersWidth = 51;
            this.publisherDataGridView.Size = new System.Drawing.Size(1432, 938);
            this.publisherDataGridView.TabIndex = 5;
            this.publisherDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.publisherDataGridView_CellValueChanged);
            this.publisherDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.publisherDataGridView_DataError);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1724, 1050);
            this.Controls.Add(this.booksPanel);
            this.Controls.Add(this.readersPanel);
            this.Controls.Add(this.publishersPanel);
            this.Controls.Add(this.newRegistrationButton);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.passordPictureBox)).EndInit();
            this.booksPanel.ResumeLayout(false);
            this.booksPanel.PerformLayout();
            this.readersPanel.ResumeLayout(false);
            this.readersPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chronologyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lendingDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerDataGridView)).EndInit();
            this.publishersPanel.ResumeLayout(false);
            this.publishersPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.publisherDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bookButton;
        private System.Windows.Forms.Button addBookButton;
        public System.Windows.Forms.DataGridView booksDataGridView;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button newRegistrationButton;
        private System.Windows.Forms.Button publisherButton;
        private System.Windows.Forms.Panel booksPanel;
        private System.Windows.Forms.Panel readersPanel;
        public System.Windows.Forms.DataGridView readerDataGridView;
        private System.Windows.Forms.Button addReaderButton;
        private System.Windows.Forms.Button readersButton;
        private System.Windows.Forms.Panel publishersPanel;
        private System.Windows.Forms.Button addPublisherButton;
        public System.Windows.Forms.DataGridView publisherDataGridView;
        private MaterialSkin.Controls.MaterialCheckBox redactBooksCheckBox;
        private MaterialSkin.Controls.MaterialCheckBox redactReadersCheckBox;
        private MaterialSkin.Controls.MaterialCheckBox redactPublishersCheckBox;
        private System.Windows.Forms.Button registrationButton;
        public System.Windows.Forms.DataGridView returnDataGridView;
        private System.Windows.Forms.Button addReturnButton;
        public System.Windows.Forms.DataGridView lendingDataGridView;
        private System.Windows.Forms.Button lendingbutton;
        public System.Windows.Forms.DataGridView chronologyDataGridView;
        private System.Windows.Forms.Button searchButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField searchTextField;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.PictureBox passordPictureBox;
        private System.Windows.Forms.Button authButton;
        private System.Windows.Forms.Label label1;
    }
}