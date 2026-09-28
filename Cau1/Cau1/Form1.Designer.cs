namespace Cau1
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
            components = new System.ComponentModel.Container();
            txtSDT = new TextBox();
            txtEmail = new TextBox();
            txtHoTen = new TextBox();
            txtMatKhau = new TextBox();
            txtXacNhanMK = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnDangKy = new Button();
            btnHuy = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(269, 99);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(125, 27);
            txtSDT.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(269, 148);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 1;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(269, 56);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(125, 27);
            txtHoTen.TabIndex = 2;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(269, 199);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(125, 27);
            txtMatKhau.TabIndex = 3;
            // 
            // txtXacNhanMK
            // 
            txtXacNhanMK.Location = new Point(269, 249);
            txtXacNhanMK.Name = "txtXacNhanMK";
            txtXacNhanMK.PasswordChar = '*';
            txtXacNhanMK.Size = new Size(125, 27);
            txtXacNhanMK.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(193, 63);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 5;
            label1.Text = "Họ tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(197, 106);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 6;
            label2.Text = "SDT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(193, 155);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 7;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(177, 202);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 8;
            label4.Text = "Mật khẩu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(168, 256);
            label5.Name = "label5";
            label5.Size = new Size(95, 20);
            label5.TabIndex = 9;
            label5.Text = "Xác nhận MK";
            // 
            // btnDangKy
            // 
            btnDangKy.Location = new Point(224, 328);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(94, 29);
            btnDangKy.TabIndex = 10;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // btnHuy
            // 
            btnHuy.CausesValidation = false;
            btnHuy.Location = new Point(364, 328);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 11;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHuy);
            Controls.Add(btnDangKy);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtXacNhanMK);
            Controls.Add(txtMatKhau);
            Controls.Add(txtHoTen);
            Controls.Add(txtEmail);
            Controls.Add(txtSDT);
            Name = "Form1";
            Text = "FormDangKy";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSDT;
        private TextBox txtEmail;
        private TextBox txtHoTen;
        private TextBox txtMatKhau;
        private TextBox txtXacNhanMK;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnDangKy;
        private Button btnHuy;
        private ErrorProvider errorProvider1;
    }
}
