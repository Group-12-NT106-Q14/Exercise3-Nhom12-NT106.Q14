namespace Exercise3_Nhom12_NT106.Q14
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            lblDKTK = new Label();
            btnĐăngNhập = new Button();
            btnĐK = new Button();
            txtTK = new TextBox();
            txtMK = new TextBox();
            btnShow = new Button();
            btnHide = new Button();
            lblTK = new Label();
            lblMK = new Label();
            SuspendLayout();
            // 
            // lblDKTK
            // 
            lblDKTK.BackColor = Color.Transparent;
            lblDKTK.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDKTK.ForeColor = Color.Black;
            lblDKTK.Location = new Point(84, 638);
            lblDKTK.Name = "lblDKTK";
            lblDKTK.Size = new Size(149, 54);
            lblDKTK.TabIndex = 0;
            lblDKTK.Text = "Đăng Kí Tài Khoản";
            lblDKTK.TextAlign = ContentAlignment.MiddleCenter;
            lblDKTK.Click += lblMoiDen_Click;
            // 
            // btnĐăngNhập
            // 
            btnĐăngNhập.BackColor = Color.Lime;
            btnĐăngNhập.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnĐăngNhập.Location = new Point(294, 381);
            btnĐăngNhập.Margin = new Padding(3, 4, 3, 4);
            btnĐăngNhập.Name = "btnĐăngNhập";
            btnĐăngNhập.Size = new Size(173, 60);
            btnĐăngNhập.TabIndex = 2;
            btnĐăngNhập.Text = "Đăng Nhập";
            btnĐăngNhập.UseVisualStyleBackColor = false;
            btnĐăngNhập.Click += btnĐăngNhập_Click;
            // 
            // btnĐK
            // 
            btnĐK.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnĐK.Location = new Point(246, 638);
            btnĐK.Margin = new Padding(3, 4, 3, 4);
            btnĐK.Name = "btnĐK";
            btnĐK.Size = new Size(384, 54);
            btnĐK.TabIndex = 3;
            btnĐK.Text = "Tại Đây";
            btnĐK.UseVisualStyleBackColor = true;
            btnĐK.Click += btnĐK_Click;
            // 
            // txtTK
            // 
            txtTK.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTK.Location = new Point(246, 200);
            txtTK.Margin = new Padding(3, 4, 3, 4);
            txtTK.Multiline = true;
            txtTK.Name = "txtTK";
            txtTK.Size = new Size(300, 39);
            txtTK.TabIndex = 5;
            // 
            // txtMK
            // 
            txtMK.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMK.Location = new Point(246, 289);
            txtMK.Margin = new Padding(3, 4, 3, 4);
            txtMK.Multiline = true;
            txtMK.Name = "txtMK";
            txtMK.Size = new Size(300, 39);
            txtMK.TabIndex = 6;
            txtMK.TextChanged += txtMK_TextChanged;
            // 
            // btnShow
            // 
            btnShow.BackColor = Color.DarkGray;
            btnShow.FlatStyle = FlatStyle.Flat;
            btnShow.Image = (Image)resources.GetObject("btnShow.Image");
            btnShow.Location = new Point(509, 289);
            btnShow.Margin = new Padding(3, 4, 3, 4);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(37, 39);
            btnShow.TabIndex = 10;
            btnShow.Text = "S";
            btnShow.UseVisualStyleBackColor = false;
            btnShow.Click += btnShow_Click;
            // 
            // btnHide
            // 
            btnHide.BackColor = Color.DarkGray;
            btnHide.FlatStyle = FlatStyle.Flat;
            btnHide.Image = (Image)resources.GetObject("btnHide.Image");
            btnHide.Location = new Point(509, 289);
            btnHide.Margin = new Padding(3, 4, 3, 4);
            btnHide.Name = "btnHide";
            btnHide.Size = new Size(37, 39);
            btnHide.TabIndex = 11;
            btnHide.Text = "H";
            btnHide.UseVisualStyleBackColor = false;
            btnHide.Click += btnHide_Click;
            // 
            // lblTK
            // 
            lblTK.BackColor = Color.Transparent;
            lblTK.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            lblTK.ForeColor = Color.IndianRed;
            lblTK.Location = new Point(42, 214);
            lblTK.Name = "lblTK";
            lblTK.Size = new Size(163, 25);
            lblTK.TabIndex = 12;
            lblTK.Text = "Tài Khoản";
            lblTK.TextAlign = ContentAlignment.MiddleCenter;
            lblTK.Click += label1_Click;
            // 
            // lblMK
            // 
            lblMK.BackColor = Color.Transparent;
            lblMK.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            lblMK.ForeColor = Color.IndianRed;
            lblMK.Location = new Point(42, 303);
            lblMK.Name = "lblMK";
            lblMK.Size = new Size(163, 25);
            lblMK.TabIndex = 13;
            lblMK.Text = "Mật Khẩu";
            lblMK.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(673, 739);
            Controls.Add(lblMK);
            Controls.Add(lblTK);
            Controls.Add(btnHide);
            Controls.Add(btnShow);
            Controls.Add(txtMK);
            Controls.Add(txtTK);
            Controls.Add(btnĐK);
            Controls.Add(btnĐăngNhập);
            Controls.Add(lblDKTK);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblDKTK;
        private System.Windows.Forms.Button btnĐăngNhập;
        private System.Windows.Forms.Button btnĐK;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Label lblTK;
        private System.Windows.Forms.Label lblMK;
    }
}
