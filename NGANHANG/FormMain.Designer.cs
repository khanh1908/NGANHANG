
namespace NGANHANG
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnTaoTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.rbHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbNghiepVu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbNhanVien = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barBtnRutTien = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnGuiTien = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnChuyenTien = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barBtnDangNhap,
            this.barBtnTaoTaiKhoan,
            this.barBtnDangXuat,
            this.barBtnRutTien,
            this.barBtnGuiTien,
            this.barBtnChuyenTien});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl1.MaxItemId = 7;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbHeThong,
            this.rbNghiepVu,
            this.rbNhanVien,
            this.rbBaoCao});
            this.ribbonControl1.Size = new System.Drawing.Size(884, 209);
            // 
            // barBtnDangNhap
            // 
            this.barBtnDangNhap.Caption = "Đăng Nhập";
            this.barBtnDangNhap.Id = 1;
            this.barBtnDangNhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnDangNhap.ImageOptions.Image")));
            this.barBtnDangNhap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnDangNhap.ImageOptions.LargeImage")));
            this.barBtnDangNhap.Name = "barBtnDangNhap";
            this.barBtnDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnDangNhap_ItemClick);
            // 
            // barBtnTaoTaiKhoan
            // 
            this.barBtnTaoTaiKhoan.Caption = "Tạo Tài Khoản";
            this.barBtnTaoTaiKhoan.Id = 2;
            this.barBtnTaoTaiKhoan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnTaoTaiKhoan.ImageOptions.Image")));
            this.barBtnTaoTaiKhoan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnTaoTaiKhoan.ImageOptions.LargeImage")));
            this.barBtnTaoTaiKhoan.Name = "barBtnTaoTaiKhoan";
            // 
            // barBtnDangXuat
            // 
            this.barBtnDangXuat.Caption = "Đăng Xuất";
            this.barBtnDangXuat.Id = 3;
            this.barBtnDangXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnDangXuat.ImageOptions.Image")));
            this.barBtnDangXuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnDangXuat.ImageOptions.LargeImage")));
            this.barBtnDangXuat.Name = "barBtnDangXuat";
            // 
            // rbHeThong
            // 
            this.rbHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.rbHeThong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rbHeThong.ImageOptions.Image")));
            this.rbHeThong.Name = "rbHeThong";
            this.rbHeThong.Text = "Hệ Thống";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnDangNhap);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnTaoTaiKhoan);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnDangXuat);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // rbNghiepVu
            // 
            this.rbNghiepVu.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.rbNghiepVu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rbNghiepVu.ImageOptions.Image")));
            this.rbNghiepVu.Name = "rbNghiepVu";
            this.rbNghiepVu.Text = "Nghiệp Vụ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnRutTien);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnGuiTien);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnChuyenTien);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // rbNhanVien
            // 
            this.rbNhanVien.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.rbNhanVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rbNhanVien.ImageOptions.Image")));
            this.rbNhanVien.Name = "rbNhanVien";
            this.rbNhanVien.Text = "Nhân Viên";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // rbBaoCao
            // 
            this.rbBaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.rbBaoCao.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rbBaoCao.ImageOptions.Image")));
            this.rbBaoCao.Name = "rbBaoCao";
            this.rbBaoCao.Text = "Báo Cáo";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "ribbonPageGroup5";
            // 
            // barBtnRutTien
            // 
            this.barBtnRutTien.Caption = "Rút tiền";
            this.barBtnRutTien.Id = 4;
            this.barBtnRutTien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barBtnRutTien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barBtnRutTien.Name = "barBtnRutTien";
            // 
            // barBtnGuiTien
            // 
            this.barBtnGuiTien.Caption = "Gửi tiền";
            this.barBtnGuiTien.Id = 5;
            this.barBtnGuiTien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barBtnGuiTien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barBtnGuiTien.Name = "barBtnGuiTien";
            // 
            // barBtnChuyenTien
            // 
            this.barBtnChuyenTien.Caption = "Chuyển tiền";
            this.barBtnChuyenTien.Id = 6;
            this.barBtnChuyenTien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barBtnChuyenTien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barBtnChuyenTien.Name = "barBtnChuyenTien";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 443);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMain";
            this.Ribbon = this.ribbonControl1;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbNghiepVu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbNhanVien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barBtnDangNhap;
        private DevExpress.XtraBars.BarButtonItem barBtnTaoTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem barBtnDangXuat;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbBaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem barBtnRutTien;
        private DevExpress.XtraBars.BarButtonItem barBtnGuiTien;
        private DevExpress.XtraBars.BarButtonItem barBtnChuyenTien;
    }
}

