namespace Exercise3_Nhom12_NT106.Q14
{
    partial class Register
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            btnĐK = new Button();
            lblEmail = new Label();
            lblTK = new Label();
            lblMK = new Label();
            lblNLMK = new Label();
            txtEmail = new TextBox();
            txtTK = new TextBox();
            txtMK = new TextBox();
            txtNLMK = new TextBox();
            btnShow1 = new Button();
            btnShow2 = new Button();
            btnHide1 = new Button();
            btnHide2 = new Button();
            errorProvider1 = new ErrorProvider(components);
            lblFN = new Label();
            lblNS = new Label();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnĐK
            // 
            btnĐK.BackColor = Color.Lime;
            btnĐK.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnĐK.Location = new Point(319, 511);
            btnĐK.Margin = new Padding(3, 4, 3, 4);
            btnĐK.Name = "btnĐK";
            btnĐK.Size = new Size(115, 48);
            btnĐK.TabIndex = 0;
            btnĐK.Text = "Đăng Kí";
            btnĐK.UseVisualStyleBackColor = false;
            btnĐK.Click += btnĐK_Click;
            // 
            // lblEmail
            // 
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(63, 42);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(132, 29);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email";
            lblEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTK
            // 
            lblTK.BackColor = Color.Transparent;
            lblTK.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTK.ForeColor = Color.White;
            lblTK.Location = new Point(63, 119);
            lblTK.Name = "lblTK";
            lblTK.Size = new Size(132, 29);
            lblTK.TabIndex = 2;
            lblTK.Text = "Tài Khoản";
            lblTK.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMK
            // 
            lblMK.BackColor = Color.Transparent;
            lblMK.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMK.ForeColor = Color.White;
            lblMK.Location = new Point(63, 191);
            lblMK.Name = "lblMK";
            lblMK.Size = new Size(132, 29);
            lblMK.TabIndex = 3;
            lblMK.Text = "Mật Khẩu";
            lblMK.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNLMK
            // 
            lblNLMK.BackColor = Color.Transparent;
            lblNLMK.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNLMK.ForeColor = Color.White;
            lblNLMK.Location = new Point(63, 288);
            lblNLMK.Name = "lblNLMK";
            lblNLMK.Size = new Size(191, 29);
            lblNLMK.TabIndex = 4;
            lblNLMK.Text = "Nhập Lại Mật Khẩu";
            lblNLMK.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(292, 44);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(268, 27);
            txtEmail.TabIndex = 5;
            // 
            // txtTK
            // 
            txtTK.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTK.Location = new Point(292, 121);
            txtTK.Margin = new Padding(3, 4, 3, 4);
            txtTK.Name = "txtTK";
            txtTK.Size = new Size(268, 27);
            txtTK.TabIndex = 6;
            // 
            // txtMK
            // 
            txtMK.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMK.Location = new Point(292, 193);
            txtMK.Margin = new Padding(3, 4, 3, 4);
            txtMK.Name = "txtMK";
            txtMK.Size = new Size(268, 27);
            txtMK.TabIndex = 7;
            txtMK.TextChanged += txtMK_TextChanged;
            // 
            // txtNLMK
            // 
            txtNLMK.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNLMK.Location = new Point(292, 288);
            txtNLMK.Margin = new Padding(3, 4, 3, 4);
            txtNLMK.Name = "txtNLMK";
            txtNLMK.Size = new Size(268, 27);
            txtNLMK.TabIndex = 8;
            txtNLMK.TextChanged += txtNLMK_TextChanged;
            // 
            // btnShow1
            // 
            btnShow1.FlatStyle = FlatStyle.Flat;
            btnShow1.Image = (Image)resources.GetObject("btnShow1.Image");
            btnShow1.Location = new Point(521, 192);
            btnShow1.Margin = new Padding(3, 4, 3, 4);
            btnShow1.Name = "btnShow1";
            btnShow1.Size = new Size(39, 27);
            btnShow1.TabIndex = 9;
            btnShow1.UseVisualStyleBackColor = true;
            btnShow1.Click += button2_Click;
            // 
            // btnShow2
            // 
            btnShow2.FlatStyle = FlatStyle.Flat;
            btnShow2.Image = (Image)resources.GetObject("btnShow2.Image");
            btnShow2.Location = new Point(521, 288);
            btnShow2.Margin = new Padding(3, 4, 3, 4);
            btnShow2.Name = "btnShow2";
            btnShow2.Size = new Size(39, 27);
            btnShow2.TabIndex = 10;
            btnShow2.UseVisualStyleBackColor = true;
            btnShow2.Click += btnShow2_Click;
            // 
            // btnHide1
            // 
            btnHide1.FlatStyle = FlatStyle.Flat;
            btnHide1.Image = (Image)resources.GetObject("btnHide1.Image");
            btnHide1.Location = new Point(521, 193);
            btnHide1.Margin = new Padding(3, 4, 3, 4);
            btnHide1.Name = "btnHide1";
            btnHide1.Size = new Size(39, 27);
            btnHide1.TabIndex = 11;
            btnHide1.UseVisualStyleBackColor = true;
            btnHide1.Click += btnHide1_Click;
            // 
            // btnHide2
            // 
            btnHide2.FlatStyle = FlatStyle.Flat;
            btnHide2.Image = (Image)resources.GetObject("btnHide2.Image");
            btnHide2.Location = new Point(521, 288);
            btnHide2.Margin = new Padding(3, 4, 3, 4);
            btnHide2.Name = "btnHide2";
            btnHide2.Size = new Size(39, 27);
            btnHide2.TabIndex = 12;
            btnHide2.UseVisualStyleBackColor = true;
            btnHide2.Click += btnHide2_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // lblFN
            // 
            lblFN.BackColor = Color.Transparent;
            lblFN.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            lblFN.ForeColor = Color.White;
            lblFN.Location = new Point(63, 372);
            lblFN.Name = "lblFN";
            lblFN.Size = new Size(162, 25);
            lblFN.TabIndex = 13;
            lblFN.Text = "Họ và tên";
            // 
            // lblNS
            // 
            lblNS.BackColor = Color.Transparent;
            lblNS.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            lblNS.ForeColor = Color.White;
            lblNS.Location = new Point(63, 453);
            lblNS.Name = "lblNS";
            lblNS.Size = new Size(162, 25);
            lblNS.TabIndex = 14;
            lblNS.Text = "Ngày Sinh";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(292, 372);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(268, 34);
            textBox1.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(292, 453);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(268, 27);
            dateTimePicker1.TabIndex = 16;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(738, 785);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(lblNS);
            Controls.Add(lblFN);
            Controls.Add(btnHide2);
            Controls.Add(btnHide1);
            Controls.Add(btnShow2);
            Controls.Add(btnShow1);
            Controls.Add(txtNLMK);
            Controls.Add(txtMK);
            Controls.Add(txtTK);
            Controls.Add(txtEmail);
            Controls.Add(lblNLMK);
            Controls.Add(lblMK);
            Controls.Add(lblTK);
            Controls.Add(lblEmail);
            Controls.Add(btnĐK);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Button btnĐK;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTK;
        private System.Windows.Forms.Label lblMK;
        private System.Windows.Forms.Label lblNLMK;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.TextBox txtNLMK;
        private System.Windows.Forms.Button btnShow1;
        private System.Windows.Forms.Button btnShow2;
        private System.Windows.Forms.Button btnHide1;
        private System.Windows.Forms.Button btnHide2;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblNS;
        private System.Windows.Forms.Label lblFN;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
