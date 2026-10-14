using System.Drawing;
using System.Windows.Forms;

namespace Bai04
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
            this.grpSoDo = new System.Windows.Forms.GroupBox();
            this.flpSoDo = new System.Windows.Forms.FlowLayoutPanel();

            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.lblKhungGio = new System.Windows.Forms.Label();
            this.cmbKhungGio = new System.Windows.Forms.ComboBox();
            this.lblSoViTri = new System.Windows.Forms.Label();
            this.lblTamTinh = new System.Windows.Forms.Label();

            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();

            this.grpSoDo.SuspendLayout();
            this.grpThongTin.SuspendLayout();
            this.SuspendLayout();

            // === GROUP SƠ ĐỒ CHỖ NGỒI ===
            this.grpSoDo.Controls.Add(this.flpSoDo);
            this.grpSoDo.Location = new System.Drawing.Point(20, 20);
            this.grpSoDo.Size = new System.Drawing.Size(380, 280);
            this.grpSoDo.Text = "Sơ đồ vị trí";

            // FlowLayoutPanel sẽ tự động xếp 20 nút từ trái qua phải, hết dòng tự rớt xuống
            this.flpSoDo.Location = new System.Drawing.Point(15, 30);
            this.flpSoDo.Size = new System.Drawing.Size(350, 240);

            // === GROUP THÔNG TIN THANH TOÁN ===
            this.grpThongTin.Controls.Add(this.lblKhungGio);
            this.grpThongTin.Controls.Add(this.cmbKhungGio);
            this.grpThongTin.Controls.Add(this.lblSoViTri);
            this.grpThongTin.Controls.Add(this.lblTamTinh);
            this.grpThongTin.Location = new System.Drawing.Point(420, 20);
            this.grpThongTin.Size = new System.Drawing.Size(300, 180);
            this.grpThongTin.Text = "Thông tin Đặt bàn";

            this.lblKhungGio.Location = new System.Drawing.Point(20, 40);
            this.lblKhungGio.Size = new System.Drawing.Size(100, 20);
            this.lblKhungGio.Text = "Khung giờ:";

            this.cmbKhungGio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhungGio.Items.AddRange(new object[] { "Sáng (100.000đ/vị trí)", "Tối (150.000đ/vị trí)" });
            this.cmbKhungGio.Location = new System.Drawing.Point(20, 65);
            this.cmbKhungGio.Size = new System.Drawing.Size(250, 23);

            this.lblSoViTri.AutoSize = true;
            this.lblSoViTri.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSoViTri.Location = new System.Drawing.Point(20, 110);
            this.lblSoViTri.Text = "Số vị trí đang chọn: 0";

            this.lblTamTinh.AutoSize = true;
            this.lblTamTinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTamTinh.ForeColor = System.Drawing.Color.Red;
            this.lblTamTinh.Location = new System.Drawing.Point(20, 140);
            this.lblTamTinh.Text = "Tạm tính tiền: 0 VNĐ";

            // === CÁC NÚT CHỨC NĂNG ===
            this.btnXacNhan.BackColor = System.Drawing.Color.LightBlue;
            this.btnXacNhan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXacNhan.Location = new System.Drawing.Point(420, 220);
            this.btnXacNhan.Size = new System.Drawing.Size(140, 50);
            this.btnXacNhan.Text = "Xác nhận đặt";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);

            this.btnHuy.Location = new System.Drawing.Point(580, 220);
            this.btnHuy.Size = new System.Drawing.Size(140, 50);
            this.btnHuy.Text = "Hủy chọn tất cả";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);

            // === FORM CHÍNH ===
            this.ClientSize = new System.Drawing.Size(750, 320);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.grpSoDo);
            this.Name = "Form1";
            this.Text = "Bài 4: Đặt bàn / Chỗ ngồi";
            this.Load += new System.EventHandler(this.Form1_Load);

            this.grpSoDo.ResumeLayout(false);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.GroupBox grpSoDo;
        private System.Windows.Forms.FlowLayoutPanel flpSoDo;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblKhungGio;
        private System.Windows.Forms.ComboBox cmbKhungGio;
        private System.Windows.Forms.Label lblSoViTri;
        private System.Windows.Forms.Label lblTamTinh;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnHuy;
    }
}