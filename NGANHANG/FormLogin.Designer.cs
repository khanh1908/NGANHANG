
namespace NGANHANG
{
    partial class FormLogin
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
            this.lbChiNhanh = new System.Windows.Forms.Label();
            this.cbChiNhanh = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.edtUsername = new DevExpress.XtraEditors.TextEdit();
            this.edtMatkhau = new DevExpress.XtraEditors.TextEdit();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cbChiNhanh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMatkhau.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbChiNhanh
            // 
            this.lbChiNhanh.AutoSize = true;
            this.lbChiNhanh.Font = new System.Drawing.Font("Tahoma", 18F);
            this.lbChiNhanh.Location = new System.Drawing.Point(210, 122);
            this.lbChiNhanh.Name = "lbChiNhanh";
            this.lbChiNhanh.Size = new System.Drawing.Size(153, 36);
            this.lbChiNhanh.TabIndex = 0;
            this.lbChiNhanh.Text = "Chi Nhánh";
            // 
            // cbChiNhanh
            // 
            this.cbChiNhanh.Location = new System.Drawing.Point(454, 116);
            this.cbChiNhanh.Name = "cbChiNhanh";
            this.cbChiNhanh.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            this.cbChiNhanh.Properties.Appearance.Options.UseFont = true;
            this.cbChiNhanh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbChiNhanh.Size = new System.Drawing.Size(280, 42);
            this.cbChiNhanh.TabIndex = 1;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Tahoma", 18F);
            this.lbUserName.Location = new System.Drawing.Point(210, 205);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(225, 36);
            this.lbUserName.TabIndex = 2;
            this.lbUserName.Text = "Tên Đăng Nhập";
            this.lbUserName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.Font = new System.Drawing.Font("Tahoma", 18F);
            this.lbMatKhau.Location = new System.Drawing.Point(210, 288);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(141, 36);
            this.lbMatKhau.TabIndex = 3;
            this.lbMatKhau.Text = "Mật Khẩu";
            // 
            // edtUsername
            // 
            this.edtUsername.Location = new System.Drawing.Point(454, 202);
            this.edtUsername.Name = "edtUsername";
            this.edtUsername.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            this.edtUsername.Properties.Appearance.Options.UseFont = true;
            this.edtUsername.Size = new System.Drawing.Size(280, 42);
            this.edtUsername.TabIndex = 4;
            // 
            // edtMatkhau
            // 
            this.edtMatkhau.Location = new System.Drawing.Point(454, 282);
            this.edtMatkhau.Name = "edtMatkhau";
            this.edtMatkhau.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            this.edtMatkhau.Properties.Appearance.Options.UseFont = true;
            this.edtMatkhau.Size = new System.Drawing.Size(280, 42);
            this.edtMatkhau.TabIndex = 5;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DarkGray;
            this.btnLogin.Font = new System.Drawing.Font("Tahoma", 16F);
            this.btnLogin.Location = new System.Drawing.Point(304, 370);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(185, 52);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Đăng Nhập";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.OrangeRed;
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 16F);
            this.btnThoat.Location = new System.Drawing.Point(528, 370);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(185, 52);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 490);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.edtMatkhau);
            this.Controls.Add(this.edtUsername);
            this.Controls.Add(this.lbMatKhau);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.cbChiNhanh);
            this.Controls.Add(this.lbChiNhanh);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            ((System.ComponentModel.ISupportInitialize)(this.cbChiNhanh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMatkhau.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbChiNhanh;
        private DevExpress.XtraEditors.ComboBoxEdit cbChiNhanh;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbMatKhau;
        private DevExpress.XtraEditors.TextEdit edtUsername;
        private DevExpress.XtraEditors.TextEdit edtMatkhau;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnThoat;
    }
}