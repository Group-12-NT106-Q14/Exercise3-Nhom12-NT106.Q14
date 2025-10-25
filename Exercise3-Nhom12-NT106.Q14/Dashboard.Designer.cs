namespace Exercise3_Nhom12_NT106.Q14
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            lblTK = new Label();
            lblFullName = new Label();
            lblEmail = new Label();
            lblNS = new Label();
            textBox4 = new TextBox();
            btnDX = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(311, 96);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(291, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(311, 165);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(291, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(311, 254);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(291, 27);
            textBox3.TabIndex = 2;
            // 
            // lblTK
            // 
            lblTK.BackColor = Color.Transparent;
            lblTK.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            lblTK.Location = new Point(97, 96);
            lblTK.Name = "lblTK";
            lblTK.Size = new Size(142, 25);
            lblTK.TabIndex = 3;
            lblTK.Text = "Tài Khoản";
            // 
            // lblFullName
            // 
            lblFullName.BackColor = Color.Transparent;
            lblFullName.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            lblFullName.Location = new Point(97, 167);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(142, 25);
            lblFullName.TabIndex = 4;
            lblFullName.Text = "Họ và tên";
            // 
            // lblEmail
            // 
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            lblEmail.Location = new Point(97, 257);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(142, 25);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email";
            // 
            // lblNS
            // 
            lblNS.BackColor = Color.Transparent;
            lblNS.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            lblNS.Location = new Point(97, 348);
            lblNS.Name = "lblNS";
            lblNS.Size = new Size(142, 25);
            lblNS.TabIndex = 6;
            lblNS.Text = "Ngày Sinh";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(311, 348);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(291, 27);
            textBox4.TabIndex = 7;
            // 
            // btnDX
            // 
            btnDX.BackColor = Color.FromArgb(128, 255, 128);
            btnDX.Location = new Point(547, 453);
            btnDX.Name = "btnDX";
            btnDX.Size = new Size(134, 57);
            btnDX.TabIndex = 8;
            btnDX.Text = "Đăng Xuất";
            btnDX.UseVisualStyleBackColor = false;
            btnDX.Click += btnDX_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(737, 552);
            Controls.Add(btnDX);
            Controls.Add(textBox4);
            Controls.Add(lblNS);
            Controls.Add(lblEmail);
            Controls.Add(lblFullName);
            Controls.Add(lblTK);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblTK;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNS;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnDX;
    }
}
