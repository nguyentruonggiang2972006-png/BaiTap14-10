using System.Drawing;
using System.Windows.Forms;

namespace Bai05
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
            this.components = new System.ComponentModel.Container();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabGiaoHang = new System.Windows.Forms.TabPage();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();

            this.grpKhachHang = new System.Windows.Forms.GroupBox();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.lblLoaiVanChuyen = new System.Windows.Forms.Label();
            this.cmbLoaiVanChuyen = new System.Windows.Forms.ComboBox();

            this.grpChiTiet = new System.Windows.Forms.GroupBox();
            this.dgvHangHoa = new System.Windows.Forms.DataGridView();
            this.colTenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrongLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.lblThoiGian = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTongSoLuong = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTongTrongLuong = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTongTien = new System.Windows.Forms.ToolStripStatusLabel();

            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);

            this.tabControlMain.SuspendLayout();
            this.tabGiaoHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.grpKhachHang.SuspendLayout();
            this.grpChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).BeginInit();
            this.statusStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();

            // === TAB CONTROL ===
            this.tabControlMain.Controls.Add(this.tabGiaoHang);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Size = new System.Drawing.Size(980, 530);

            this.tabGiaoHang.Controls.Add(this.splitContainerMain);
            this.tabGiaoHang.Location = new System.Drawing.Point(4, 29);
            this.tabGiaoHang.Text = "Quản lý Đơn giao hàng";
            this.tabGiaoHang.Padding = new System.Windows.Forms.Padding(3);

            // === SPLIT CONTAINER (Chia 2 cột) ===
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(3, 3);
            this.splitContainerMain.SplitterDistance = 300; // Cột trái rộng 300px

            // === PANEL TRÁI (Thông tin khách hàng) ===
            this.splitContainerMain.Panel1.Controls.Add(this.grpKhachHang);
            this.grpKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpKhachHang.Text = "Thông tin Khách hàng";
            this.grpKhachHang.Padding = new System.Windows.Forms.Padding(15);

            this.lblTenKH.Location = new System.Drawing.Point(20, 40);
            this.lblTenKH.Text = "Tên khách hàng:";
            this.txtTenKH.Location = new System.Drawing.Point(20, 65);
            this.txtTenKH.Size = new System.Drawing.Size(250, 27);

            this.lblDienThoai.Location = new System.Drawing.Point(20, 110);
            this.lblDienThoai.Text = "Số điện thoại:";
            this.txtDienThoai.Location = new System.Drawing.Point(20, 135);
            this.txtDienThoai.Size = new System.Drawing.Size(250, 27);

            this.lblLoaiVanChuyen.Location = new System.Drawing.Point(20, 180);
            this.lblLoaiVanChuyen.Text = "Loại vận chuyển:";
            this.cmbLoaiVanChuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiVanChuyen.Items.AddRange(new object[] { "Giao hàng Tiêu chuẩn", "Giao hàng Hỏa tốc", "Giao hàng Tiết kiệm" });
            this.cmbLoaiVanChuyen.Location = new System.Drawing.Point(20, 205);
            this.cmbLoaiVanChuyen.Size = new System.Drawing.Size(250, 28);

            this.grpKhachHang.Controls.Add(this.lblTenKH);
            this.grpKhachHang.Controls.Add(this.txtTenKH);
            this.grpKhachHang.Controls.Add(this.lblDienThoai);
            this.grpKhachHang.Controls.Add(this.txtDienThoai);
            this.grpKhachHang.Controls.Add(this.lblLoaiVanChuyen);
            this.grpKhachHang.Controls.Add(this.cmbLoaiVanChuyen);

            // === PANEL PHẢI (Chi tiết hàng hóa DataGridView) ===
            this.splitContainerMain.Panel2.Controls.Add(this.grpChiTiet);
            this.grpChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpChiTiet.Text = "Chi tiết Danh mục Hàng hóa (Nhấn F2 để thêm, Delete để xóa)";

            this.dgvHangHoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHangHoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHangHoa.AllowUserToAddRows = true;
            this.dgvHangHoa.AllowUserToDeleteRows = true;
            this.dgvHangHoa.BackgroundColor = System.Drawing.Color.White;
            this.dgvHangHoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colTenHang, this.colSoLuong, this.colTrongLuong, this.colDonGia, this.colThanhTien});

            this.colTenHang.HeaderText = "Tên hàng";
            this.colTenHang.Name = "colTenHang";
            this.colSoLuong.HeaderText = "Số lượng";
            this.colSoLuong.Name = "colSoLuong";
            this.colTrongLuong.HeaderText = "Trọng lượng (kg)";
            this.colTrongLuong.Name = "colTrongLuong";
            this.colDonGia.HeaderText = "Đơn giá (VNĐ)";
            this.colDonGia.Name = "colDonGia";
            this.colThanhTien.HeaderText = "Thành tiền";
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.ReadOnly = true; // Cột này tự tính, không cho sửa tay
            this.colThanhTien.DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;

            this.grpChiTiet.Controls.Add(this.dgvHangHoa);

            // === STATUS STRIP ===
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.lblThoiGian, this.lblTongSoLuong, this.lblTongTrongLuong, this.lblTongTien});
            this.statusStripMain.Location = new System.Drawing.Point(0, 530);

            this.lblThoiGian.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblThoiGian.Text = "Thời gian: --:--:--";
            this.lblThoiGian.Width = 150;

            this.lblTongSoLuong.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblTongSoLuong.Text = "Tổng SL: 0";
            this.lblTongSoLuong.Width = 100;

            this.lblTongTrongLuong.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblTongTrongLuong.Text = "Tổng TL: 0 kg";
            this.lblTongTrongLuong.Width = 150;

            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.ForeColor = System.Drawing.Color.Red;
            this.lblTongTien.Text = "Tổng tiền: 0 VNĐ";

            // === FORM CHÍNH ===
            this.ClientSize = new System.Drawing.Size(980, 560);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.statusStripMain);
            this.KeyPreview = true; // Bắt buộc bật để Form nhận diện được phím F2, Delete
            this.Name = "Form1";
            this.Text = "Bài 5: Dashboard Quản lý Đơn giao hàng";

            this.tabControlMain.ResumeLayout(false);
            this.tabGiaoHang.ResumeLayout(false);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.grpKhachHang.ResumeLayout(false);
            this.grpKhachHang.PerformLayout();
            this.grpChiTiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).EndInit();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabGiaoHang;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.GroupBox grpKhachHang;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label lblLoaiVanChuyen;
        private System.Windows.Forms.ComboBox cmbLoaiVanChuyen;

        private System.Windows.Forms.GroupBox grpChiTiet;
        private System.Windows.Forms.DataGridView dgvHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrongLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;

        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel lblThoiGian;
        private System.Windows.Forms.ToolStripStatusLabel lblTongSoLuong;
        private System.Windows.Forms.ToolStripStatusLabel lblTongTrongLuong;
        private System.Windows.Forms.ToolStripStatusLabel lblTongTien;

        private System.Windows.Forms.Timer tmrClock;
        private System.Windows.Forms.ErrorProvider errProvider;
    }
}