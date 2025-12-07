namespace CRUD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Read = new Button();
            Create = new Button();
            Home = new Button();
            Delete = new Button();
            Update = new Button();
            panel1 = new Panel();
            Email = new Label();
            NameL = new Label();
            Password = new Label();
            UserName = new Label();
            ID = new Label();
            numericUpDownID = new NumericUpDown();
            textBoxEmail = new TextBox();
            textBoxName = new TextBox();
            textBoxUserName = new TextBox();
            textBoxPassword = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Read
            // 
            Read.BackColor = Color.FromArgb(0, 0, 192);
            Read.Font = new Font("Segoe UI", 14F);
            Read.ForeColor = SystemColors.ControlLightLight;
            Read.Location = new Point(354, 44);
            Read.Name = "Read";
            Read.Size = new Size(161, 56);
            Read.TabIndex = 2;
            Read.Text = "Read";
            Read.UseVisualStyleBackColor = false;
            Read.Click += Read_Click;
            // 
            // Create
            // 
            Create.BackColor = Color.DarkRed;
            Create.Font = new Font("Segoe UI Historic", 14F);
            Create.ForeColor = SystemColors.HighlightText;
            Create.Location = new Point(187, 44);
            Create.Name = "Create";
            Create.Size = new Size(161, 56);
            Create.TabIndex = 1;
            Create.Text = "Create";
            Create.UseVisualStyleBackColor = false;
            Create.Click += Create_Click;
            // 
            // Home
            // 
            Home.BackColor = Color.LightSeaGreen;
            Home.Font = new Font("Segoe UI", 14F);
            Home.Location = new Point(20, 44);
            Home.Name = "Home";
            Home.Size = new Size(161, 56);
            Home.TabIndex = 0;
            Home.Text = "Home";
            Home.UseVisualStyleBackColor = false;
            Home.Click += Home_Click;
            // 
            // Delete
            // 
            Delete.BackColor = Color.DarkGreen;
            Delete.Font = new Font("Segoe UI", 14F);
            Delete.ForeColor = SystemColors.ControlLightLight;
            Delete.Location = new Point(688, 44);
            Delete.Name = "Delete";
            Delete.Size = new Size(161, 56);
            Delete.TabIndex = 4;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += Delete_Click;
            // 
            // Update
            // 
            Update.BackColor = Color.Purple;
            Update.Font = new Font("Segoe UI", 14F);
            Update.ForeColor = SystemColors.ButtonHighlight;
            Update.Location = new Point(521, 44);
            Update.Name = "Update";
            Update.Size = new Size(161, 56);
            Update.TabIndex = 3;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = false;
            Update.Click += Update_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSalmon;
            panel1.Controls.Add(Update);
            panel1.Controls.Add(Delete);
            panel1.Controls.Add(Home);
            panel1.Controls.Add(Create);
            panel1.Controls.Add(Read);
            panel1.Location = new Point(382, 760);
            panel1.Name = "panel1";
            panel1.Size = new Size(866, 117);
            panel1.TabIndex = 5;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Segoe UI", 24F);
            Email.Location = new Point(511, 257);
            Email.Name = "Email";
            Email.Size = new Size(96, 45);
            Email.TabIndex = 6;
            Email.Text = "Email";
            // 
            // NameL
            // 
            NameL.AutoSize = true;
            NameL.Font = new Font("Segoe UI", 24F);
            NameL.Location = new Point(511, 331);
            NameL.Name = "NameL";
            NameL.Size = new Size(105, 45);
            NameL.TabIndex = 7;
            NameL.Text = "Name";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Segoe UI", 24F);
            Password.Location = new Point(511, 485);
            Password.Name = "Password";
            Password.Size = new Size(153, 45);
            Password.TabIndex = 8;
            Password.Text = "Password";
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.Font = new Font("Segoe UI", 24F);
            UserName.Location = new Point(511, 409);
            UserName.Name = "UserName";
            UserName.Size = new Size(169, 45);
            UserName.TabIndex = 9;
            UserName.Text = "UserName";
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Font = new Font("Segoe UI", 24F);
            ID.Location = new Point(511, 106);
            ID.Name = "ID";
            ID.Size = new Size(51, 45);
            ID.TabIndex = 10;
            ID.Text = "ID";
            ID.Click += label5_Click;
            // 
            // numericUpDownID
            // 
            numericUpDownID.Font = new Font("Segoe UI", 24F);
            numericUpDownID.Location = new Point(819, 101);
            numericUpDownID.Name = "numericUpDownID";
            numericUpDownID.Size = new Size(344, 50);
            numericUpDownID.TabIndex = 11;
            numericUpDownID.ValueChanged += numericUpDownID_ValueChanged;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 24F);
            textBoxEmail.Location = new Point(819, 252);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(344, 50);
            textBoxEmail.TabIndex = 12;
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 24F);
            textBoxName.Location = new Point(819, 328);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(344, 50);
            textBoxName.TabIndex = 13;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Font = new Font("Segoe UI", 24F);
            textBoxUserName.Location = new Point(819, 404);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(344, 50);
            textBoxUserName.TabIndex = 14;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 24F);
            textBoxPassword.Location = new Point(819, 480);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(344, 50);
            textBoxPassword.TabIndex = 15;
            textBoxPassword.TextChanged += textBox4_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(819, 232);
            panel2.Name = "panel2";
            panel2.Size = new Size(344, 14);
            panel2.TabIndex = 16;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(819, 308);
            panel3.Name = "panel3";
            panel3.Size = new Size(344, 14);
            panel3.TabIndex = 17;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.Location = new Point(819, 384);
            panel4.Name = "panel4";
            panel4.Size = new Size(344, 14);
            panel4.TabIndex = 17;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaptionText;
            panel5.Location = new Point(819, 460);
            panel5.Name = "panel5";
            panel5.Size = new Size(344, 14);
            panel5.TabIndex = 17;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ActiveCaptionText;
            panel6.Location = new Point(819, 157);
            panel6.Name = "panel6";
            panel6.Size = new Size(344, 14);
            panel6.TabIndex = 17;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(477, 479);
            dataGridView1.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1430, 905);
            Controls.Add(dataGridView1);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUserName);
            Controls.Add(textBoxName);
            Controls.Add(textBoxEmail);
            Controls.Add(numericUpDownID);
            Controls.Add(ID);
            Controls.Add(UserName);
            Controls.Add(Password);
            Controls.Add(NameL);
            Controls.Add(Email);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownID).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Read;
        private Button Create;
        private Button Home;
        private Button Delete;
        private Button Update;
        private Panel panel1;
        private Label Email;
        private Label NameL;
        private Label Password;
        private Label UserName;
        private Label ID;
        private NumericUpDown numericUpDownID;
        private TextBox textBoxEmail;
        private TextBox textBoxName;
        private TextBox textBoxUserName;
        private TextBox textBoxPassword;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private DataGridView dataGridView1;
    }
}
