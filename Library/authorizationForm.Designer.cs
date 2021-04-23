namespace Library
{
    partial class authorizationForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(authorizationForm));
            this.loginTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.passwordTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.authorizationButton = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.authDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.passwordShowButton = new System.Windows.Forms.Button();
            this.showPasswordLabel = new System.Windows.Forms.Label();
            this.passordPictureBox = new System.Windows.Forms.PictureBox();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passordPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // loginTextField
            // 
            this.loginTextField.Depth = 0;
            this.loginTextField.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextField.Hint = "Логин";
            this.loginTextField.Location = new System.Drawing.Point(25, 66);
            this.loginTextField.Margin = new System.Windows.Forms.Padding(4);
            this.loginTextField.MaxLength = 32767;
            this.loginTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginTextField.Name = "loginTextField";
            this.loginTextField.PasswordChar = '\0';
            this.loginTextField.SelectedText = "";
            this.loginTextField.SelectionLength = 0;
            this.loginTextField.SelectionStart = 0;
            this.loginTextField.Size = new System.Drawing.Size(457, 28);
            this.loginTextField.TabIndex = 5;
            this.loginTextField.TabStop = false;
            this.loginTextField.UseSystemPasswordChar = false;
            this.loginTextField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.loginTextField_KeyDown);
            // 
            // passwordTextField
            // 
            this.passwordTextField.Depth = 0;
            this.passwordTextField.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextField.Hint = "Пароль";
            this.passwordTextField.Location = new System.Drawing.Point(25, 128);
            this.passwordTextField.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextField.MaxLength = 32767;
            this.passwordTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordTextField.Name = "passwordTextField";
            this.passwordTextField.PasswordChar = '*';
            this.passwordTextField.SelectedText = "";
            this.passwordTextField.SelectionLength = 0;
            this.passwordTextField.SelectionStart = 0;
            this.passwordTextField.Size = new System.Drawing.Size(457, 28);
            this.passwordTextField.TabIndex = 6;
            this.passwordTextField.TabStop = false;
            this.passwordTextField.UseSystemPasswordChar = false;
            this.passwordTextField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.loginTextField_KeyDown);
            // 
            // authorizationButton
            // 
            this.authorizationButton.BackColor = System.Drawing.Color.PowderBlue;
            this.authorizationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.authorizationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.authorizationButton.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorizationButton.Location = new System.Drawing.Point(177, 218);
            this.authorizationButton.Margin = new System.Windows.Forms.Padding(4);
            this.authorizationButton.Name = "authorizationButton";
            this.authorizationButton.Size = new System.Drawing.Size(192, 41);
            this.authorizationButton.TabIndex = 7;
            this.authorizationButton.Text = "Авторизация";
            this.authorizationButton.UseVisualStyleBackColor = false;
            this.authorizationButton.Click += new System.EventHandler(this.authorizationButton_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.PowderBlue;
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel.Controls.Add(this.panel4);
            this.panel.Controls.Add(this.exitButton);
            this.panel.Location = new System.Drawing.Point(-8, 0);
            this.panel.Margin = new System.Windows.Forms.Padding(4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(544, 27);
            this.panel.TabIndex = 10;
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            this.panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_MouseUp);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(12, -12);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(569, 17);
            this.panel4.TabIndex = 14;
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
            this.exitButton.Location = new System.Drawing.Point(420, 4);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(25, 25);
            this.exitButton.TabIndex = 12;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-32, 34);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(27, 22);
            this.textBox1.TabIndex = 11;
            // 
            // authDataGridView
            // 
            this.authDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.authDataGridView.Location = new System.Drawing.Point(466, 34);
            this.authDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.authDataGridView.Name = "authDataGridView";
            this.authDataGridView.RowHeadersWidth = 51;
            this.authDataGridView.Size = new System.Drawing.Size(320, 185);
            this.authDataGridView.TabIndex = 12;
            this.authDataGridView.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(-4, 270);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 17);
            this.panel1.TabIndex = 13;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(-27, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(32, 352);
            this.panel2.TabIndex = 14;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(438, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(32, 374);
            this.panel3.TabIndex = 15;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // passwordShowButton
            // 
            this.passwordShowButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.passwordShowButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passwordShowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passwordShowButton.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordShowButton.Location = new System.Drawing.Point(17, 277);
            this.passwordShowButton.Margin = new System.Windows.Forms.Padding(5);
            this.passwordShowButton.Name = "passwordShowButton";
            this.passwordShowButton.Size = new System.Drawing.Size(177, 32);
            this.passwordShowButton.TabIndex = 33;
            this.passwordShowButton.Text = "показать пароль";
            this.passwordShowButton.UseVisualStyleBackColor = false;
            this.passwordShowButton.Click += new System.EventHandler(this.passwordShowButton_Click);
            // 
            // showPasswordLabel
            // 
            this.showPasswordLabel.AutoSize = true;
            this.showPasswordLabel.Location = new System.Drawing.Point(32, 314);
            this.showPasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.showPasswordLabel.Name = "showPasswordLabel";
            this.showPasswordLabel.Size = new System.Drawing.Size(121, 17);
            this.showPasswordLabel.TabIndex = 34;
            this.showPasswordLabel.Text = "Показать пароль";
            this.showPasswordLabel.Click += new System.EventHandler(this.passwordShowButton_Click);
            // 
            // passordPictureBox
            // 
            this.passordPictureBox.Image = global::Library.Properties.Resources.visible_2_;
            this.passordPictureBox.Location = new System.Drawing.Point(365, 109);
            this.passordPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.passordPictureBox.Name = "passordPictureBox";
            this.passordPictureBox.Size = new System.Drawing.Size(72, 67);
            this.passordPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.passordPictureBox.TabIndex = 35;
            this.passordPictureBox.TabStop = false;
            this.passordPictureBox.Click += new System.EventHandler(this.passordPictureBox_Click);
            // 
            // authorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 274);
            this.Controls.Add(this.passordPictureBox);
            this.Controls.Add(this.showPasswordLabel);
            this.Controls.Add(this.passwordShowButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.authDataGridView);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.authorizationButton);
            this.Controls.Add(this.passwordTextField);
            this.Controls.Add(this.loginTextField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "authorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.authorizationForm_Load);
            this.Click += new System.EventHandler(this.authorizationForm_Click);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.authDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passordPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField loginTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField passwordTextField;
        private System.Windows.Forms.Button authorizationButton;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView authDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button passwordShowButton;
        private System.Windows.Forms.Label showPasswordLabel;
        private System.Windows.Forms.PictureBox passordPictureBox;
    }
}

