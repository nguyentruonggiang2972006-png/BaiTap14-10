using System.Drawing;
using System.Windows.Forms;

namespace Bai02
{
    partial class Form1
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
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.lblMaPhieu = new System.Windows.Forms.Label();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.lblNguoiYeuCau = new System.Windows.Forms.Label();
            this.txtNguoiYeuCau = new System.Windows.Forms.TextBox();
            this.lblNgay = new System.Windows.Forms.Label();
            this.dtpNgayGhiNhan = new System.Windows.Forms.DateTimePicker();
            this.lblUuTien = new System.Windows.Forms.Label();
            this.radThap = new System.Windows.Forms.RadioButton();
            this.radTrungBinh = new System.Windows.Forms.RadioButton();
            this.radKhanCap = new System.Windows.Forms.RadioButton();

            this.grpPhanLoai = new System.Windows.Forms.GroupBox();
            this.lblLoaiSuCo = new System.Windows.Forms.Label();
            this.cmbLoaiSuCo = new System.Windows.Forms.ComboBox();
            this.lblThietBi = new System.Windows.Forms.Label();
            this.chkMayTinhBan = new System.Windows.Forms.CheckBox();
            this.chkLaptop = new System.Windows.Forms.CheckBox();
            this.chkMayIn = new System.Windows.Forms.CheckBox();
            this.chkDienThoai = new System.Windows.Forms.CheckBox();
            this.picAnhLoi = new System.Windows.Forms.PictureBox();
            this.btnTaiAnh = new System.Windows.Forms.Button();

            this.btnGuiYeuCau = new System.Windows.Forms.Button();
            this.btnNhapLai = new System.Windows.Forms.Button();

            this.grpThongTin.SuspendLayout();
            this.grpPhanLoai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhLoi)).BeginInit();
            this.SuspendLayout();

            // === GROUP THÔNG TIN PHIẾU ===
            this.grpThongTin.Controls.Add(this.radKhanCap);
            this.grpThongTin.Controls.Add(this.radTrungBinh);
            this.grpThongTin.Controls.Add(this.radThap);
            this.grpThongTin.Controls.Add(this.lblUuTien);
            this.grpThongTin.Controls.Add(this.dtpNgayGhiNhan);
            this.grpThongTin.Controls.Add(this.lblNgay);
            this.grpThongTin.Controls.Add(this.txtNguoiYeuCau);
            this.grpThongTin.Controls.Add(this.lblNguoiYeuCau);
            this.grpThongTin.Controls.Add(this.txtMaPhieu);
            this.grpThongTin.Controls.Add(this.lblMaPhieu);
            this.grpThongTin.Location = new System.Drawing.Point(20, 20);
            this.grpThongTin.Size = new System.Drawing.Size(370, 200);
            this.grpThongTin.Text = "Thông tin phiếu";

            this.lblMaPhieu.Location = new System.Drawing.Point(20, 35);
            this.lblMaPhieu.Size = new System.Drawing.Size(100, 20);
            this.lblMaPhieu.Text = "Mã phiếu:";

            this.txtMaPhieu.Location = new System.Drawing.Point(130, 32);
            this.txtMaPhieu.Size = new System.Drawing.Size(220, 23);

            this.lblNguoiYeuCau.Location = new System.Drawing.Point(20, 75);
            this.lblNguoiYeuCau.Size = new System.Drawing.Size(100, 20);
            this.lblNguoiYeuCau.Text = "Người yêu cầu:";

            this.txtNguoiYeuCau.Location = new System.Drawing.Point(130, 72);
            this.txtNguoiYeuCau.Size = new System.Drawing.Size(220, 23);

            this.lblNgay.Location = new System.Drawing.Point(20, 115);
            this.lblNgay.Size = new System.Drawing.Size(100, 20);
            this.lblNgay.Text = "Ngày ghi nhận:";

            this.dtpNgayGhiNhan.Location = new System.Drawing.Point(130, 112);
            this.dtpNgayGhiNhan.Size = new System.Drawing.Size(220, 23);
            this.dtpNgayGhiNhan.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            this.lblUuTien.Location = new System.Drawing.Point(20, 155);
            this.lblUuTien.Size = new System.Drawing.Size(100, 20);
            this.lblUuTien.Text = "Mức độ ưu tiên:";

            this.radThap.Location = new System.Drawing.Point(130, 153);
            this.radThap.Size = new System.Drawing.Size(60, 20);
            this.radThap.Text = "Thấp";
            this.radThap.Checked = true;

            this.radTrungBinh.Location = new System.Drawing.Point(195, 153);
            this.radTrungBinh.Size = new System.Drawing.Size(90, 20);
            this.radTrungBinh.Text = "Trung bình";

            this.radKhanCap.Location = new System.Drawing.Point(285, 153);
            this.radKhanCap.Size = new System.Drawing.Size(80, 20);
            this.radKhanCap.Text = "Khẩn cấp";

            // === GROUP PHÂN LOẠI & CHI TIẾT ===
            this.grpPhanLoai.Controls.Add(this.btnTaiAnh);
            this.grpPhanLoai.Controls.Add(this.picAnhLoi);
            this.grpPhanLoai.Controls.Add(this.chkDienThoai);
            this.grpPhanLoai.Controls.Add(this.chkMayIn);
            this.grpPhanLoai.Controls.Add(this.chkLaptop);
            this.grpPhanLoai.Controls.Add(this.chkMayTinhBan);
            this.grpPhanLoai.Controls.Add(this.lblThietBi);
            this.grpPhanLoai.Controls.Add(this.cmbLoaiSuCo);
            this.grpPhanLoai.Controls.Add(this.lblLoaiSuCo);
            this.grpPhanLoai.Location = new System.Drawing.Point(410, 20);
            this.grpPhanLoai.Size = new System.Drawing.Size(350, 300);
            this.grpPhanLoai.Text = "Phân loại & Chi tiết";

            this.lblLoaiSuCo.Location = new System.Drawing.Point(20, 35);
            this.lblLoaiSuCo.Size = new System.Drawing.Size(100, 20);
            this.lblLoaiSuCo.Text = "Loại sự cố:";

            this.cmbLoaiSuCo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiSuCo.Items.AddRange(new object[] { "Phần cứng", "Phần mềm", "Mạng", "Tài khoản" });
            this.cmbLoaiSuCo.Location = new System.Drawing.Point(130, 32);
            this.cmbLoaiSuCo.Size = new System.Drawing.Size(200, 23);

            this.lblThietBi.Location = new System.Drawing.Point(20, 75);
            this.lblThietBi.Size = new System.Drawing.Size(120, 20);
            this.lblThietBi.Text = "Thiết bị ảnh hưởng:";

            this.chkMayTinhBan.Location = new System.Drawing.Point(130, 74);
            this.chkMayTinhBan.Size = new System.Drawing.Size(100, 20);
            this.chkMayTinhBan.Text = "Máy tính bàn";

            this.chkLaptop.Location = new System.Drawing.Point(240, 74);
            this.chkLaptop.Size = new System.Drawing.Size(80, 20);
            this.chkLaptop.Text = "Laptop";

            this.chkMayIn.Location = new System.Drawing.Point(130, 100);
            this.chkMayIn.Size = new System.Drawing.Size(100, 20);
            this.chkMayIn.Text = "Máy in";

            this.chkDienThoai.Location = new System.Drawing.Point(240, 100);
            this.chkDienThoai.Size = new System.Drawing.Size(100, 20);
            this.chkDienThoai.Text = "Điện thoại";

            this.picAnhLoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnhLoi.Location = new System.Drawing.Point(30, 130);
            this.picAnhLoi.Size = new System.Drawing.Size(300, 120);
            this.picAnhLoi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            this.btnTaiAnh.Location = new System.Drawing.Point(130, 260);
            this.btnTaiAnh.Size = new System.Drawing.Size(100, 30);
            this.btnTaiAnh.Text = "Tải ảnh lỗi";
            this.btnTaiAnh.Click += new System.EventHandler(this.btnTaiAnh_Click);

            // === CÁC NÚT CHỨC NĂNG ===
            this.btnGuiYeuCau.Location = new System.Drawing.Point(280, 350);
            this.btnGuiYeuCau.Size = new System.Drawing.Size(120, 45);
            this.btnGuiYeuCau.Text = "Gửi yêu cầu";
            this.btnGuiYeuCau.Click += new System.EventHandler(this.btnGuiYeuCau_Click);

            this.btnNhapLai.Location = new System.Drawing.Point(420, 350);
            this.btnNhapLai.Size = new System.Drawing.Size(120, 45);
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);

            // === FORM CHÍNH ===
            this.ClientSize = new System.Drawing.Size(780, 420);
            this.Controls.Add(this.btnNhapLai);
            this.Controls.Add(this.btnGuiYeuCau);
            this.Controls.Add(this.grpPhanLoai);
            this.Controls.Add(this.grpThongTin);
            this.Name = "Form1";
            this.Text = "Bài 2: Tiếp nhận sự cố IT";
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.grpPhanLoai.ResumeLayout(false);
            this.grpPhanLoai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhLoi)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblMaPhieu;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.Label lblNguoiYeuCau;
        private System.Windows.Forms.TextBox txtNguoiYeuCau;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.DateTimePicker dtpNgayGhiNhan;
        private System.Windows.Forms.Label lblUuTien;
        private System.Windows.Forms.RadioButton radThap;
        private System.Windows.Forms.RadioButton radTrungBinh;
        private System.Windows.Forms.RadioButton radKhanCap;

        private System.Windows.Forms.GroupBox grpPhanLoai;
        private System.Windows.Forms.Label lblLoaiSuCo;
        private System.Windows.Forms.ComboBox cmbLoaiSuCo;
        private System.Windows.Forms.Label lblThietBi;
        private System.Windows.Forms.CheckBox chkMayTinhBan;
        private System.Windows.Forms.CheckBox chkLaptop;
        private System.Windows.Forms.CheckBox chkMayIn;
        private System.Windows.Forms.CheckBox chkDienThoai;
        private System.Windows.Forms.PictureBox picAnhLoi;
        private System.Windows.Forms.Button btnTaiAnh;

        private System.Windows.Forms.Button btnGuiYeuCau;
        private System.Windows.Forms.Button btnNhapLai;
    }
}