namespace Library
{
    partial class Pub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pub));
            this.panel = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.publisherComboBox = new System.Windows.Forms.ComboBox();
            this.pubDataGridView = new System.Windows.Forms.DataGridView();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pubDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.PowderBlue;
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel.Controls.Add(this.panel6);
            this.panel.Controls.Add(this.panel5);
            this.panel.Controls.Add(this.panel4);
            this.panel.Controls.Add(this.exitButton);
            this.panel.Location = new System.Drawing.Point(-9, -2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(408, 22);
            this.panel.TabIndex = 39;
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(-14, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(24, 286);
            this.panel6.TabIndex = 44;
            this.panel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(190, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(24, 304);
            this.panel5.TabIndex = 45;
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(9, -11);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(427, 14);
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
            this.exitButton.Location = new System.Drawing.Point(170, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(19, 20);
            this.exitButton.TabIndex = 12;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(181, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(24, 304);
            this.panel3.TabIndex = 44;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(-23, -8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(24, 286);
            this.panel2.TabIndex = 43;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(-1, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 14);
            this.panel1.TabIndex = 42;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // publisherComboBox
            // 
            this.publisherComboBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.publisherComboBox.ForeColor = System.Drawing.Color.Black;
            this.publisherComboBox.FormattingEnabled = true;
            this.publisherComboBox.Location = new System.Drawing.Point(3, 21);
            this.publisherComboBox.Name = "publisherComboBox";
            this.publisherComboBox.Size = new System.Drawing.Size(177, 24);
            this.publisherComboBox.TabIndex = 45;
            this.publisherComboBox.Text = "Выберите издательство";
            this.publisherComboBox.SelectedIndexChanged += new System.EventHandler(this.publisherComboBox_SelectedIndexChanged);
            // 
            // pubDataGridView
            // 
            this.pubDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pubDataGridView.Location = new System.Drawing.Point(33, 50);
            this.pubDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.pubDataGridView.Name = "pubDataGridView";
            this.pubDataGridView.RowHeadersWidth = 51;
            this.pubDataGridView.Size = new System.Drawing.Size(100, 118);
            this.pubDataGridView.TabIndex = 46;
            this.pubDataGridView.Visible = false;
            // 
            // Pub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 49);
            this.Controls.Add(this.pubDataGridView);
            this.Controls.Add(this.publisherComboBox);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Pub";
            this.Load += new System.EventHandler(this.Pub_Load);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pubDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.ComboBox publisherComboBox;
        public System.Windows.Forms.DataGridView pubDataGridView;
    }
}