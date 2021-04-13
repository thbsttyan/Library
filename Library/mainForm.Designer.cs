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
            this.readersButton = new System.Windows.Forms.Button();
            this.publisherButton = new System.Windows.Forms.Button();
            this.bookButton = new System.Windows.Forms.Button();
            this.addBookButton = new System.Windows.Forms.Button();
            this.booksDataGridView = new System.Windows.Forms.DataGridView();
            this.panel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.newRegistrationButton = new System.Windows.Forms.Button();
            this.booksPanel = new System.Windows.Forms.Panel();
            this.redactBooksCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.readersPanel = new System.Windows.Forms.Panel();
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
            this.booksPanel.SuspendLayout();
            this.readersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.readerDataGridView)).BeginInit();
            this.publishersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.publisherDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PowderBlue;
            this.panel2.Controls.Add(this.readersButton);
            this.panel2.Controls.Add(this.publisherButton);
            this.panel2.Controls.Add(this.bookButton);
            this.panel2.Location = new System.Drawing.Point(-3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(161, 666);
            this.panel2.TabIndex = 1;
            // 
            // readersButton
            // 
            this.readersButton.BackColor = System.Drawing.Color.LightBlue;
            this.readersButton.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.readersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.readersButton.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.readersButton.Image = ((System.Drawing.Image)(resources.GetObject("readersButton.Image")));
            this.readersButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.readersButton.Location = new System.Drawing.Point(-2, 141);
            this.readersButton.Name = "readersButton";
            this.readersButton.Size = new System.Drawing.Size(162, 78);
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
            this.publisherButton.Location = new System.Drawing.Point(-2, 219);
            this.publisherButton.Name = "publisherButton";
            this.publisherButton.Size = new System.Drawing.Size(162, 78);
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
            this.bookButton.Location = new System.Drawing.Point(-2, 63);
            this.bookButton.Name = "bookButton";
            this.bookButton.Size = new System.Drawing.Size(162, 78);
            this.bookButton.TabIndex = 2;
            this.bookButton.Text = "Книги";
            this.bookButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bookButton.UseVisualStyleBackColor = false;
            this.bookButton.Click += new System.EventHandler(this.bookButton_Click);
            // 
            // addBookButton
            // 
            this.addBookButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addBookButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBookButton.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBookButton.Location = new System.Drawing.Point(2, 2);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(116, 23);
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
            this.booksDataGridView.Location = new System.Drawing.Point(2, 32);
            this.booksDataGridView.Name = "booksDataGridView";
            this.booksDataGridView.ReadOnly = true;
            this.booksDataGridView.RowHeadersWidth = 51;
            this.booksDataGridView.Size = new System.Drawing.Size(992, 457);
            this.booksDataGridView.TabIndex = 5;
            this.booksDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.booksDataGridView_CellValueChanged);
            this.booksDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.booksDataGridView_DataError);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.PowderBlue;
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel.Controls.Add(this.panel4);
            this.panel.Controls.Add(this.exitButton);
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1166, 23);
            this.panel.TabIndex = 10;
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(-3, -17);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1154, 20);
            this.panel4.TabIndex = 15;
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
            this.exitButton.Location = new System.Drawing.Point(1129, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(19, 20);
            this.exitButton.TabIndex = 11;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(-1, 657);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1154, 20);
            this.panel1.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(-26, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(29, 663);
            this.panel3.TabIndex = 17;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(1151, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(29, 663);
            this.panel5.TabIndex = 18;
            // 
            // newRegistrationButton
            // 
            this.newRegistrationButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.newRegistrationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newRegistrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newRegistrationButton.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newRegistrationButton.Location = new System.Drawing.Point(164, 604);
            this.newRegistrationButton.Name = "newRegistrationButton";
            this.newRegistrationButton.Size = new System.Drawing.Size(208, 45);
            this.newRegistrationButton.TabIndex = 19;
            this.newRegistrationButton.Text = "Зарегистрировать нового пользователя";
            this.newRegistrationButton.UseVisualStyleBackColor = false;
            this.newRegistrationButton.Click += new System.EventHandler(this.newRegistrationButton_Click);
            // 
            // booksPanel
            // 
            this.booksPanel.BackColor = System.Drawing.SystemColors.Control;
            this.booksPanel.Controls.Add(this.redactBooksCheckBox);
            this.booksPanel.Controls.Add(this.booksDataGridView);
            this.booksPanel.Controls.Add(this.addBookButton);
            this.booksPanel.Location = new System.Drawing.Point(219, 72);
            this.booksPanel.Name = "booksPanel";
            this.booksPanel.Size = new System.Drawing.Size(994, 575);
            this.booksPanel.TabIndex = 20;
            // 
            // redactBooksCheckBox
            // 
            this.redactBooksCheckBox.AutoSize = true;
            this.redactBooksCheckBox.Depth = 0;
            this.redactBooksCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.redactBooksCheckBox.Location = new System.Drawing.Point(140, 2);
            this.redactBooksCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.redactBooksCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.redactBooksCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.redactBooksCheckBox.Name = "redactBooksCheckBox";
            this.redactBooksCheckBox.Ripple = true;
            this.redactBooksCheckBox.Size = new System.Drawing.Size(186, 30);
            this.redactBooksCheckBox.TabIndex = 23;
            this.redactBooksCheckBox.Text = "Режим редактирования";
            this.redactBooksCheckBox.UseVisualStyleBackColor = true;
            this.redactBooksCheckBox.CheckedChanged += new System.EventHandler(this.redactBooksCheckBox_CheckedChanged);
            // 
            // readersPanel
            // 
            this.readersPanel.BackColor = System.Drawing.SystemColors.Control;
            this.readersPanel.Controls.Add(this.redactReadersCheckBox);
            this.readersPanel.Controls.Add(this.addReaderButton);
            this.readersPanel.Controls.Add(this.readerDataGridView);
            this.readersPanel.Location = new System.Drawing.Point(176, 48);
            this.readersPanel.Name = "readersPanel";
            this.readersPanel.Size = new System.Drawing.Size(992, 558);
            this.readersPanel.TabIndex = 21;
            this.readersPanel.Visible = false;
            // 
            // redactReadersCheckBox
            // 
            this.redactReadersCheckBox.AutoSize = true;
            this.redactReadersCheckBox.Depth = 0;
            this.redactReadersCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.redactReadersCheckBox.Location = new System.Drawing.Point(169, 2);
            this.redactReadersCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.redactReadersCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.redactReadersCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.redactReadersCheckBox.Name = "redactReadersCheckBox";
            this.redactReadersCheckBox.Ripple = true;
            this.redactReadersCheckBox.Size = new System.Drawing.Size(186, 30);
            this.redactReadersCheckBox.TabIndex = 24;
            this.redactReadersCheckBox.Text = "Режим редактирования";
            this.redactReadersCheckBox.UseVisualStyleBackColor = true;
            this.redactReadersCheckBox.CheckedChanged += new System.EventHandler(this.redactReadersCheckBox_CheckedChanged);
            // 
            // addReaderButton
            // 
            this.addReaderButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addReaderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addReaderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addReaderButton.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addReaderButton.Location = new System.Drawing.Point(2, 2);
            this.addReaderButton.Name = "addReaderButton";
            this.addReaderButton.Size = new System.Drawing.Size(155, 23);
            this.addReaderButton.TabIndex = 6;
            this.addReaderButton.Text = "Добавить читателя";
            this.addReaderButton.UseVisualStyleBackColor = false;
            this.addReaderButton.Click += new System.EventHandler(this.addReaderButton_Click);
            // 
            // readerDataGridView
            // 
            this.readerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.readerDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.readerDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.readerDataGridView.Location = new System.Drawing.Point(2, 32);
            this.readerDataGridView.Name = "readerDataGridView";
            this.readerDataGridView.ReadOnly = true;
            this.readerDataGridView.RowHeadersWidth = 51;
            this.readerDataGridView.Size = new System.Drawing.Size(971, 365);
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
            this.publishersPanel.Location = new System.Drawing.Point(159, 22);
            this.publishersPanel.Name = "publishersPanel";
            this.publishersPanel.Size = new System.Drawing.Size(992, 558);
            this.publishersPanel.TabIndex = 22;
            this.publishersPanel.Visible = false;
            // 
            // redactPublishersCheckBox
            // 
            this.redactPublishersCheckBox.AutoSize = true;
            this.redactPublishersCheckBox.Depth = 0;
            this.redactPublishersCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.redactPublishersCheckBox.Location = new System.Drawing.Point(172, 2);
            this.redactPublishersCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.redactPublishersCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.redactPublishersCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.redactPublishersCheckBox.Name = "redactPublishersCheckBox";
            this.redactPublishersCheckBox.Ripple = true;
            this.redactPublishersCheckBox.Size = new System.Drawing.Size(186, 30);
            this.redactPublishersCheckBox.TabIndex = 24;
            this.redactPublishersCheckBox.Text = "Режим редактирования";
            this.redactPublishersCheckBox.UseVisualStyleBackColor = true;
            this.redactPublishersCheckBox.CheckedChanged += new System.EventHandler(this.redactPublishersCheckBox_CheckedChanged);
            // 
            // addPublisherButton
            // 
            this.addPublisherButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addPublisherButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addPublisherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPublisherButton.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addPublisherButton.Location = new System.Drawing.Point(2, 2);
            this.addPublisherButton.Name = "addPublisherButton";
            this.addPublisherButton.Size = new System.Drawing.Size(155, 23);
            this.addPublisherButton.TabIndex = 6;
            this.addPublisherButton.Text = "Добавить издательство";
            this.addPublisherButton.UseVisualStyleBackColor = false;
            // 
            // publisherDataGridView
            // 
            this.publisherDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.publisherDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.publisherDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.publisherDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.publisherDataGridView.Location = new System.Drawing.Point(2, 32);
            this.publisherDataGridView.Name = "publisherDataGridView";
            this.publisherDataGridView.ReadOnly = true;
            this.publisherDataGridView.RowHeadersWidth = 51;
            this.publisherDataGridView.Size = new System.Drawing.Size(909, 365);
            this.publisherDataGridView.TabIndex = 5;
            this.publisherDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.publisherDataGridView_CellValueChanged);
            this.publisherDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.publisherDataGridView_DataError);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1156, 661);
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
            this.Name = "mainForm";
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).EndInit();
            this.panel.ResumeLayout(false);
            this.booksPanel.ResumeLayout(false);
            this.booksPanel.PerformLayout();
            this.readersPanel.ResumeLayout(false);
            this.readersPanel.PerformLayout();
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
    }
}