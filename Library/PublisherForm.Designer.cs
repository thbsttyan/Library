namespace Library
{
    partial class PublisherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PublisherForm));
            this.numberTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.publisherTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.companyTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.adressTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.townTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ratingTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel5 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.passordPictureBox = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.readerDataGridView = new System.Windows.Forms.DataGridView();
            this.addPublisherButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passordPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // numberTextField
            // 
            this.numberTextField.Depth = 0;
            this.numberTextField.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberTextField.Hint = "Номер телефона";
            this.numberTextField.Location = new System.Drawing.Point(128, 245);
            this.numberTextField.MaxLength = 32767;
            this.numberTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.numberTextField.Name = "numberTextField";
            this.numberTextField.PasswordChar = '\0';
            this.numberTextField.SelectedText = "";
            this.numberTextField.SelectionLength = 0;
            this.numberTextField.SelectionStart = 0;
            this.numberTextField.Size = new System.Drawing.Size(295, 23);
            this.numberTextField.TabIndex = 62;
            this.numberTextField.TabStop = false;
            this.numberTextField.UseSystemPasswordChar = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(-25, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(29, 448);
            this.panel3.TabIndex = 18;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PowderBlue;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(-1, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(122, 375);
            this.panel2.TabIndex = 53;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // publisherTextField
            // 
            this.publisherTextField.Depth = 0;
            this.publisherTextField.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.publisherTextField.Hint = "Издательство";
            this.publisherTextField.Location = new System.Drawing.Point(128, 62);
            this.publisherTextField.MaxLength = 32767;
            this.publisherTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.publisherTextField.Name = "publisherTextField";
            this.publisherTextField.PasswordChar = '\0';
            this.publisherTextField.SelectedText = "";
            this.publisherTextField.SelectionLength = 0;
            this.publisherTextField.SelectionStart = 0;
            this.publisherTextField.Size = new System.Drawing.Size(357, 23);
            this.publisherTextField.TabIndex = 55;
            this.publisherTextField.TabStop = false;
            this.publisherTextField.UseSystemPasswordChar = false;
            // 
            // companyTextField
            // 
            this.companyTextField.Depth = 0;
            this.companyTextField.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.companyTextField.Hint = "Компания";
            this.companyTextField.Location = new System.Drawing.Point(128, 103);
            this.companyTextField.MaxLength = 32767;
            this.companyTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.companyTextField.Name = "companyTextField";
            this.companyTextField.PasswordChar = '\0';
            this.companyTextField.SelectedText = "";
            this.companyTextField.SelectionLength = 0;
            this.companyTextField.SelectionStart = 0;
            this.companyTextField.Size = new System.Drawing.Size(357, 23);
            this.companyTextField.TabIndex = 56;
            this.companyTextField.TabStop = false;
            this.companyTextField.UseSystemPasswordChar = false;
            // 
            // adressTextField
            // 
            this.adressTextField.Depth = 0;
            this.adressTextField.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adressTextField.Hint = "Адрес";
            this.adressTextField.Location = new System.Drawing.Point(128, 149);
            this.adressTextField.MaxLength = 32767;
            this.adressTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.adressTextField.Name = "adressTextField";
            this.adressTextField.PasswordChar = '\0';
            this.adressTextField.SelectedText = "";
            this.adressTextField.SelectionLength = 0;
            this.adressTextField.SelectionStart = 0;
            this.adressTextField.Size = new System.Drawing.Size(357, 23);
            this.adressTextField.TabIndex = 57;
            this.adressTextField.TabStop = false;
            this.adressTextField.UseSystemPasswordChar = false;
            // 
            // townTextField
            // 
            this.townTextField.Depth = 0;
            this.townTextField.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.townTextField.Hint = "Город";
            this.townTextField.Location = new System.Drawing.Point(128, 193);
            this.townTextField.MaxLength = 32767;
            this.townTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.townTextField.Name = "townTextField";
            this.townTextField.PasswordChar = '\0';
            this.townTextField.SelectedText = "";
            this.townTextField.SelectionLength = 0;
            this.townTextField.SelectionStart = 0;
            this.townTextField.Size = new System.Drawing.Size(358, 23);
            this.townTextField.TabIndex = 60;
            this.townTextField.TabStop = false;
            this.townTextField.UseSystemPasswordChar = false;
            // 
            // ratingTextField
            // 
            this.ratingTextField.Depth = 0;
            this.ratingTextField.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ratingTextField.Hint = "Рейтинг";
            this.ratingTextField.Location = new System.Drawing.Point(128, 287);
            this.ratingTextField.MaxLength = 32767;
            this.ratingTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.ratingTextField.Name = "ratingTextField";
            this.ratingTextField.PasswordChar = '\0';
            this.ratingTextField.SelectedText = "";
            this.ratingTextField.SelectionLength = 0;
            this.ratingTextField.SelectionStart = 0;
            this.ratingTextField.Size = new System.Drawing.Size(235, 23);
            this.ratingTextField.TabIndex = 64;
            this.ratingTextField.TabStop = false;
            this.ratingTextField.UseSystemPasswordChar = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(495, 17);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(29, 448);
            this.panel5.TabIndex = 65;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseDown);
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
            this.exitButton.Location = new System.Drawing.Point(476, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(19, 20);
            this.exitButton.TabIndex = 17;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(-26, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(29, 448);
            this.panel1.TabIndex = 19;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseDown);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(495, -4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(29, 448);
            this.panel4.TabIndex = 19;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseDown);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(-1, -25);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(498, 28);
            this.panel7.TabIndex = 22;
            this.panel7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseDown);
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
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(509, 48);
            this.panel.TabIndex = 58;
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // passordPictureBox
            // 
            this.passordPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("passordPictureBox.Image")));
            this.passordPictureBox.Location = new System.Drawing.Point(50, 4);
            this.passordPictureBox.Name = "passordPictureBox";
            this.passordPictureBox.Size = new System.Drawing.Size(71, 38);
            this.passordPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.passordPictureBox.TabIndex = 39;
            this.passordPictureBox.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(0, 361);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(498, 32);
            this.panel6.TabIndex = 66;
            this.panel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseDown);
            // 
            // readerDataGridView
            // 
            this.readerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.readerDataGridView.Location = new System.Drawing.Point(387, 67);
            this.readerDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.readerDataGridView.Name = "readerDataGridView";
            this.readerDataGridView.RowHeadersWidth = 51;
            this.readerDataGridView.Size = new System.Drawing.Size(100, 118);
            this.readerDataGridView.TabIndex = 67;
            this.readerDataGridView.Visible = false;
            // 
            // addPublisherButton
            // 
            this.addPublisherButton.BackColor = System.Drawing.Color.PowderBlue;
            this.addPublisherButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addPublisherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPublisherButton.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addPublisherButton.Location = new System.Drawing.Point(335, 321);
            this.addPublisherButton.Name = "addPublisherButton";
            this.addPublisherButton.Size = new System.Drawing.Size(152, 33);
            this.addPublisherButton.TabIndex = 54;
            this.addPublisherButton.Text = "Добавить издательство";
            this.addPublisherButton.UseVisualStyleBackColor = false;
            this.addPublisherButton.Click += new System.EventHandler(this.addPublisherButton_Click);
            // 
            // PublisherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 365);
            this.Controls.Add(this.readerDataGridView);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.ratingTextField);
            this.Controls.Add(this.townTextField);
            this.Controls.Add(this.adressTextField);
            this.Controls.Add(this.companyTextField);
            this.Controls.Add(this.publisherTextField);
            this.Controls.Add(this.addPublisherButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.numberTextField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PublisherForm";
            this.Text = "PublisherForm";
            this.Load += new System.EventHandler(this.PublisherForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passordPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField numberTextField;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField publisherTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField companyTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField adressTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField townTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField ratingTextField;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.DataGridView readerDataGridView;
        private System.Windows.Forms.Button addPublisherButton;
        private System.Windows.Forms.PictureBox passordPictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}