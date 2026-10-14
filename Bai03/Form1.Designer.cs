using System.Drawing;
using System.Windows.Forms;

namespace Bai03
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
            this.grpNhapLieu = new System.Windows.Forms.GroupBox();
            this.lblMaVT = new System.Windows.Forms.Label();
            this.txtMaVT = new System.Windows.Forms.TextBox();
            this.lblTenVT = new System.Windows.Forms.Label();
            this.txtTenVT = new System.Windows.Forms.TextBox();
            this.lblDonVi = new System.Windows.Forms.Label();
            this.cmbDonVi = new System.Windows.Forms.ComboBox();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();

            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnXoaAll = new System.Windows.Forms.Button();

            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.lsvVatTu = new System.Windows.Forms.ListView();
            this.colMaVT = new System.Windows.Forms.ColumnHeader();
            this.colTenVT = new System.Windows.Forms.ColumnHeader();
            this.colDonVi = new System.Windows.Forms.ColumnHeader();
            this.colDonGia = new System.Windows.Forms.ColumnHeader();

            this.grpNhapLieu.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            this.SuspendLayout();

            // === GROUP NHẬP LIỆU (BÊN TRÁI) ===
            this.grpNhapLieu.Controls.Add(this.txtDonGia);
            this.grpNhapLieu.Controls.Add(this.lblDonGia);
            this.grpNhapLieu.Controls.Add(this.cmbDonVi);
            this.grpNhapLieu.Controls.Add(this.lblDonVi);
            this.grpNhapLieu.Controls.Add(this.txtTenVT);
            this.grpNhapLieu.Controls.Add(this.lblTenVT);
            this.grpNhapLieu.Controls.Add(this.txtMaVT);
            this.grpNhapLieu.Controls.Add(this.lblMaVT);
            this.grpNhapLieu.Location = new System.Drawing.Point(20, 20);
            this.grpNhapLieu.Size = new System.Drawing.Size(320, 220);
            this.grpNhapLieu.Text = "Thông tin Nhập liệu";

            this.lblMaVT.Location = new System.Drawing.Point(15, 40);
            this.lblMaVT.Size = new System.Drawing.Size(80, 20);
            this.lblMaVT.Text = "Mã vật tư:";

            this.txtMaVT.Location = new System.Drawing.Point(100, 37);
            this.txtMaVT.Size = new System.Drawing.Size(200, 23);

            this.lblTenVT.Location = new System.Drawing.Point(15, 80);
            this.lblTenVT.Size = new System.Drawing.Size(80, 20);
            this.lblTenVT.Text = "Tên vật tư:";

            this.txtTenVT.Location = new System.Drawing.Point(100, 77);
            this.txtTenVT.Size = new System.Drawing.Size(200, 23);

            this.lblDonVi.Location = new System.Drawing.Point(15, 120);
            this.lblDonVi.Size = new System.Drawing.Size(80, 20);
            this.lblDonVi.Text = "Đơn vị tính:";

            this.cmbDonVi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDonVi.Items.AddRange(new object[] { "Cái", "Bộ", "Kg", "Mét" });
            this.cmbDonVi.Location = new System.Drawing.Point(100, 117);
            this.cmbDonVi.Size = new System.Drawing.Size(200, 23);

            this.lblDonGia.Location = new System.Drawing.Point(15, 160);
            this.lblDonGia.Size = new System.Drawing.Size(80, 20);
            this.lblDonGia.Text = "Đơn giá:";

            this.txtDonGia.Location = new System.Drawing.Point(100, 157);
            this.txtDonGia.Size = new System.Drawing.Size(200, 23);

            // === CÁC NÚT CHỨC NĂNG ===
            this.btnThemMoi.Location = new System.Drawing.Point(20, 260);
            this.btnThemMoi.Size = new System.Drawing.Size(150, 40);
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);

            this.btnCapNhat.Location = new System.Drawing.Point(190, 260);
            this.btnCapNhat.Size = new System.Drawing.Size(150, 40);
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);

            this.btnXoa.Location = new System.Drawing.Point(20, 310);
            this.btnXoa.Size = new System.Drawing.Size(150, 40);
            this.btnXoa.Text = "Xóa dòng";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            this.btnXoaAll.Location = new System.Drawing.Point(190, 310);
            this.btnXoaAll.Size = new System.Drawing.Size(150, 40);
            this.btnXoaAll.Text = "Xóa toàn bộ";
            this.btnXoaAll.Click += new System.EventHandler(this.btnXoaAll_Click);

            // === GROUP DANH SÁCH (BÊN PHẢI) ===
            this.grpDanhSach.Controls.Add(this.lsvVatTu);
            this.grpDanhSach.Location = new System.Drawing.Point(360, 20);
            this.grpDanhSach.Size = new System.Drawing.Size(500, 330);
            this.grpDanhSach.Text = "Danh sách Vật tư";

            this.lsvVatTu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaVT, this.colTenVT, this.colDonVi, this.colDonGia});
            this.lsvVatTu.FullRowSelect = true; // Chọn là chọn cả dòng
            this.lsvVatTu.GridLines = true; // Hiện đường kẻ ô lưới
            this.lsvVatTu.Location = new System.Drawing.Point(20, 30);
            this.lsvVatTu.Size = new System.Drawing.Size(460, 280);
            this.lsvVatTu.View = System.Windows.Forms.View.Details; // Chế độ hiển thị dạng bảng
            this.lsvVatTu.SelectedIndexChanged += new System.EventHandler(this.lsvVatTu_SelectedIndexChanged);

            this.colMaVT.Text = "Mã VT";
            this.colMaVT.Width = 80;

            this.colTenVT.Text = "Tên vật tư";
            this.colTenVT.Width = 180;

            this.colDonVi.Text = "Đơn vị tính";
            this.colDonVi.Width = 80;

            this.colDonGia.Text = "Đơn giá nhập";
            this.colDonGia.Width = 100;

            // === FORM CHÍNH ===
            this.ClientSize = new System.Drawing.Size(880, 380);
            this.Controls.Add(this.grpDanhSach);
            this.Controls.Add(this.btnXoaAll);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.grpNhapLieu);
            this.Name = "Form1";
            this.Text = "Bài 3: Quản lý danh mục Vật tư";
            this.grpNhapLieu.ResumeLayout(false);
            this.grpNhapLieu.PerformLayout();
            this.grpDanhSach.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.GroupBox grpNhapLieu;
        private System.Windows.Forms.Label lblMaVT;
        private System.Windows.Forms.TextBox txtMaVT;
        private System.Windows.Forms.Label lblTenVT;
        private System.Windows.Forms.TextBox txtTenVT;
        private System.Windows.Forms.Label lblDonVi;
        private System.Windows.Forms.ComboBox cmbDonVi;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.TextBox txtDonGia;

        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnXoaAll;

        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.ListView lsvVatTu;
        private System.Windows.Forms.ColumnHeader colMaVT;
        private System.Windows.Forms.ColumnHeader colTenVT;
        private System.Windows.Forms.ColumnHeader colDonVi;
        private System.Windows.Forms.ColumnHeader colDonGia;
    }
}