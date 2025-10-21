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
            lblDKTK = new System.Windows.Forms.Label();
            btnĐăngNhập = new System.Windows.Forms.Button();
            btnĐK = new System.Windows.Forms.Button();
            txtTK = new System.Windows.Forms.TextBox();
            txtMK = new System.Windows.Forms.TextBox();
            btnShow = new System.Windows.Forms.Button();
            btnHide = new System.Windows.Forms.Button();
            lblTK = new System.Windows.Forms.Label();
            lblMK = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lblDKTK
            // 
            lblDKTK.BackColor = System.Drawing.Color.Transparent;
            lblDKTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblDKTK.ForeColor = System.Drawing.Color.White;
            lblDKTK.Location = new System.Drawing.Point(161, 638);
            lblDKTK.Name = "lblDKTK";
            lblDKTK.Size = new System.Drawing.Size(149, 54);
            lblDKTK.TabIndex = 0;
            lblDKTK.Text = "Đăng Kí Tài Khoản";
            lblDKTK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblDKTK.Click += lblMoiDen_Click;
            // 
            // btnĐăngNhập
            // 
            btnĐăngNhập.BackColor = System.Drawing.Color.Lime;
            btnĐăngNhập.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnĐăngNhập.Location = new System.Drawing.Point(294, 381);
            btnĐăngNhập.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnĐăngNhập.Name = "btnĐăngNhập";
            btnĐăngNhập.Size = new System.Drawing.Size(173, 60);
            btnĐăngNhập.TabIndex = 2;
            btnĐăngNhập.Text = "Đăng Nhập";
            btnĐăngNhập.UseVisualStyleBackColor = false;
            btnĐăngNhập.Click += btnĐăngNhập_Click;
            // 
            // btnĐK
            // 
            btnĐK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnĐK.Location = new System.Drawing.Point(316, 638);
            btnĐK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnĐK.Name = "btnĐK";
            btnĐK.Size = new System.Drawing.Size(384, 54);
            btnĐK.TabIndex = 3;
            btnĐK.Text = "Tại Đây";
            btnĐK.UseVisualStyleBackColor = true;
            btnĐK.Click += btnĐK_Click;
            // 
            // txtTK
            // 
            txtTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            txtTK.Location = new System.Drawing.Point(246, 200);
            txtTK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtTK.Multiline = true;
            txtTK.Name = "txtTK";
            txtTK.Size = new System.Drawing.Size(300, 39);
            txtTK.TabIndex = 5;
            // 
            // txtMK
            // 
            txtMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            txtMK.Location = new System.Drawing.Point(246, 289);
            txtMK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtMK.Multiline = true;
            txtMK.Name = "txtMK";
            txtMK.Size = new System.Drawing.Size(300, 39);
            txtMK.TabIndex = 6;
            txtMK.TextChanged += txtMK_TextChanged;
            // 
            // btnShow
            // 
            btnShow.BackColor = System.Drawing.Color.DarkGray;
            btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnShow.Image = ((System.Drawing.Image)(resources.GetObject("btnShow.Image")));
            btnShow.Location = new System.Drawing.Point(509, 289);
            btnShow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnShow.Name = "btnShow";
            btnShow.Size = new System.Drawing.Size(37, 39);
            btnShow.TabIndex = 10;
            btnShow.Text = "S";
            btnShow.UseVisualStyleBackColor = false;
            btnShow.Click += btnShow_Click;
            // 
            // btnHide
            // 
            btnHide.BackColor = System.Drawing.Color.DarkGray;
            btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnHide.Image = ((System.Drawing.Image)(resources.GetObject("btnHide.Image")));
            btnHide.Location = new System.Drawing.Point(509, 289);
            btnHide.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnHide.Name = "btnHide";
            btnHide.Size = new System.Drawing.Size(37, 39);
            btnHide.TabIndex = 11;
            btnHide.Text = "H";
            btnHide.UseVisualStyleBackColor = false;
            btnHide.Click += btnHide_Click;
            // 
            // lblTK
            // 
            lblTK.BackColor = System.Drawing.Color.Transparent;
            lblTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            lblTK.ForeColor = System.Drawing.Color.IndianRed;
            lblTK.Location = new System.Drawing.Point(42, 214);
            lblTK.Name = "lblTK";
            lblTK.Size = new System.Drawing.Size(163, 25);
            lblTK.TabIndex = 12;
            lblTK.Text = "Tài Khoản";
            lblTK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblTK.Click += label1_Click;
            // 
            // lblMK
            // 
            lblMK.BackColor = System.Drawing.Color.Transparent;
            lblMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            lblMK.ForeColor = System.Drawing.Color.IndianRed;
            lblMK.Location = new System.Drawing.Point(42, 303);
            lblMK.Name = "lblMK";
            lblMK.Size = new System.Drawing.Size(163, 25);
            lblMK.TabIndex = 13;
            lblMK.Text = "Mật Khẩu";
            lblMK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            ClientSize = new System.Drawing.Size(746, 739);
            Controls.Add(lblMK);
            Controls.Add(lblTK);
            Controls.Add(btnHide);
            Controls.Add(btnShow);
            Controls.Add(txtMK);
            Controls.Add(txtTK);
            Controls.Add(btnĐK);
            Controls.Add(btnĐăngNhập);
            Controls.Add(lblDKTK);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
