namespace Library
{
    partial class registrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registrationForm));
            this.authDataGridView = new System.Windows.Forms.DataGridView();
            this.password2TextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.passwordShowButton = new System.Windows.Forms.Button();
            this.registrationButton = new System.Windows.Forms.Button();
            this.passwordTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.loginTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.authDataGridView)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // authDataGridView
            // 
            this.authDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.authDataGridView.Location = new System.Drawing.Point(563, 30);
            this.authDataGridView.Margin = new System.Windows.Forms.Padding(5);
            this.authDataGridView.Name = "authDataGridView";
            this.authDataGridView.RowHeadersWidth = 51;
            this.authDataGridView.Size = new System.Drawing.Size(427, 228);
            this.authDataGridView.TabIndex = 34;
            this.authDataGridView.Visible = false;
            // 
            // password2TextField
            // 
            this.password2TextField.Depth = 0;
            this.password2TextField.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password2TextField.Hint = "Повторить пароль";
            this.password2TextField.Location = new System.Drawing.Point(17, 194);
            this.password2TextField.Margin = new System.Windows.Forms.Padding(5);
            this.password2TextField.MaxLength = 32767;
            this.password2TextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.password2TextField.Name = "password2TextField";
            this.password2TextField.PasswordChar = '*';
            this.password2TextField.SelectedText = "";
            this.password2TextField.SelectionLength = 0;
            this.password2TextField.SelectionStart = 0;
            this.password2TextField.Size = new System.Drawing.Size(496, 28);
            this.password2TextField.TabIndex = 33;
            this.password2TextField.TabStop = false;
            this.password2TextField.UseSystemPasswordChar = false;
            // 
            // passwordShowButton
            // 
            this.passwordShowButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.passwordShowButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passwordShowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passwordShowButton.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordShowButton.Location = new System.Drawing.Point(17, 246);
            this.passwordShowButton.Margin = new System.Windows.Forms.Padding(5);
            this.passwordShowButton.Name = "passwordShowButton";
            this.passwordShowButton.Size = new System.Drawing.Size(177, 32);
            this.passwordShowButton.TabIndex = 32;
            this.passwordShowButton.Text = "показать пароль";
            this.passwordShowButton.UseVisualStyleBackColor = false;
            this.passwordShowButton.Click += new System.EventHandler(this.passwordShowButton_Click);
            // 
            // registrationButton
            // 
            this.registrationButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.registrationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrationButton.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationButton.Location = new System.Drawing.Point(323, 305);
            this.registrationButton.Margin = new System.Windows.Forms.Padding(5);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(256, 50);
            this.registrationButton.TabIndex = 31;
            this.registrationButton.Text = "Регистрация";
            this.registrationButton.UseVisualStyleBackColor = false;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // passwordTextField
            // 
            this.passwordTextField.Depth = 0;
            this.passwordTextField.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextField.Hint = "Пароль";
            this.passwordTextField.Location = new System.Drawing.Point(17, 118);
            this.passwordTextField.Margin = new System.Windows.Forms.Padding(5);
            this.passwordTextField.MaxLength = 32767;
            this.passwordTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordTextField.Name = "passwordTextField";
            this.passwordTextField.PasswordChar = '*';
            this.passwordTextField.SelectedText = "";
            this.passwordTextField.SelectionLength = 0;
            this.passwordTextField.SelectionStart = 0;
            this.passwordTextField.Size = new System.Drawing.Size(496, 28);
            this.passwordTextField.TabIndex = 30;
            this.passwordTextField.TabStop = false;
            this.passwordTextField.UseSystemPasswordChar = false;
            // 
            // loginTextField
            // 
            this.loginTextField.Depth = 0;
            this.loginTextField.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextField.Hint = "Логин";
            this.loginTextField.Location = new System.Drawing.Point(17, 52);
            this.loginTextField.Margin = new System.Windows.Forms.Padding(5);
            this.loginTextField.MaxLength = 32767;
            this.loginTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginTextField.Name = "loginTextField";
            this.loginTextField.PasswordChar = '\0';
            this.loginTextField.SelectedText = "";
            this.loginTextField.SelectionLength = 0;
            this.loginTextField.SelectionStart = 0;
            this.loginTextField.Size = new System.Drawing.Size(496, 28);
            this.loginTextField.TabIndex = 29;
            this.loginTextField.TabStop = false;
            this.loginTextField.UseSystemPasswordChar = false;
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
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(25, 25);
            this.exitButton.TabIndex = 17;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.PowderBlue;
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel.Controls.Add(this.panel7);
            this.panel.Controls.Add(this.panel4);
            this.panel.Controls.Add(this.panel1);
            this.panel.Controls.Add(this.exitButton);
            this.panel.Location = new System.Drawing.Point(-65, -1);
            this.panel.Margin = new System.Windows.Forms.Padding(4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(663, 28);
            this.panel.TabIndex = 35;
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(1, -30);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(664, 34);
            this.panel7.TabIndex = 22;
            this.panel7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(659, -2);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(39, 551);
            this.panel4.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(-35, -4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(39, 551);
            this.panel1.TabIndex = 19;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(-35, 364);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(664, 34);
            this.panel6.TabIndex = 36;
            this.panel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(-33, -90);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(39, 551);
            this.panel3.TabIndex = 37;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(592, -91);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(39, 551);
            this.panel5.TabIndex = 38;
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // registrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 369);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.authDataGridView);
            this.Controls.Add(this.password2TextField);
            this.Controls.Add(this.passwordShowButton);
            this.Controls.Add(this.registrationButton);
            this.Controls.Add(this.passwordTextField);
            this.Controls.Add(this.loginTextField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "registrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "registrationForm";
            ((System.ComponentModel.ISupportInitialize)(this.authDataGridView)).EndInit();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView authDataGridView;
        private MaterialSkin.Controls.MaterialSingleLineTextField password2TextField;
        private System.Windows.Forms.Button passwordShowButton;
        private System.Windows.Forms.Button registrationButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField passwordTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField loginTextField;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
    }
}