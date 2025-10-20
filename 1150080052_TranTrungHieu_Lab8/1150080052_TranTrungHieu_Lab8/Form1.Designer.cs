namespace _1150080052_TranTrungHieu_Lab8
{
    partial class Form1
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblListTitle = new System.Windows.Forms.Label();
            this.lsvDanhSach = new System.Windows.Forms.ListView();
            this.colMaNXB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenNXB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblInputTitle = new System.Windows.Forms.Label();
            this.lblMaNXB = new System.Windows.Forms.Label();
            this.txtMaNXB = new System.Windows.Forms.TextBox();
            this.txtTenNXB = new System.Windows.Forms.TextBox();
            this.lblTenNXB = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.btnThemDL = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(300, 25);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(181, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Thêm dữ liệu";
            // 
            // lblListTitle
            // 
            this.lblListTitle.AutoSize = true;
            this.lblListTitle.Location = new System.Drawing.Point(36, 80);
            this.lblListTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblListTitle.Name = "lblListTitle";
            this.lblListTitle.Size = new System.Drawing.Size(152, 16);
            this.lblListTitle.TabIndex = 1;
            this.lblListTitle.Text = "Danh sách nhà xuất bản:";
            // 
            // lsvDanhSach
            // 
            this.lsvDanhSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaNXB,
            this.colTenNXB,
            this.colDiaChi});
            this.lsvDanhSach.FullRowSelect = true;
            this.lsvDanhSach.GridLines = true;
            this.lsvDanhSach.HideSelection = false;
            this.lsvDanhSach.Location = new System.Drawing.Point(40, 105);
            this.lsvDanhSach.Margin = new System.Windows.Forms.Padding(4);
            this.lsvDanhSach.Name = "lsvDanhSach";
            this.lsvDanhSach.Size = new System.Drawing.Size(372, 368);
            this.lsvDanhSach.TabIndex = 2;
            this.lsvDanhSach.UseCompatibleStateImageBehavior = false;
            this.lsvDanhSach.View = System.Windows.Forms.View.Details;
            this.lsvDanhSach.SelectedIndexChanged += new System.EventHandler(this.lsvDanhSach_SelectedIndexChanged);
            // 
            // colMaNXB
            // 
            this.colMaNXB.Text = "Mã NXB";
            this.colMaNXB.Width = 80;
            // 
            // colTenNXB
            // 
            this.colTenNXB.Text = "Tên NXB";
            this.colTenNXB.Width = 100;
            // 
            // colDiaChi
            // 
            this.colDiaChi.Text = "Địa chỉ";
            this.colDiaChi.Width = 95;
            // 
            // lblInputTitle
            // 
            this.lblInputTitle.AutoSize = true;
            this.lblInputTitle.Location = new System.Drawing.Point(453, 80);
            this.lblInputTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInputTitle.Name = "lblInputTitle";
            this.lblInputTitle.Size = new System.Drawing.Size(122, 16);
            this.lblInputTitle.TabIndex = 3;
            this.lblInputTitle.Text = "Thông tin nhập liệu:";
            // 
            // lblMaNXB
            // 
            this.lblMaNXB.AutoSize = true;
            this.lblMaNXB.Location = new System.Drawing.Point(453, 113);
            this.lblMaNXB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaNXB.Name = "lblMaNXB";
            this.lblMaNXB.Size = new System.Drawing.Size(59, 16);
            this.lblMaNXB.TabIndex = 4;
            this.lblMaNXB.Text = "Mã NXB:";
            // 
            // txtMaNXB
            // 
            this.txtMaNXB.Location = new System.Drawing.Point(540, 110);
            this.txtMaNXB.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNXB.Multiline = true;
            this.txtMaNXB.Name = "txtMaNXB";
            this.txtMaNXB.Size = new System.Drawing.Size(212, 22);
            this.txtMaNXB.TabIndex = 5;
            // 
            // txtTenNXB
            // 
            this.txtTenNXB.Location = new System.Drawing.Point(540, 154);
            this.txtTenNXB.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNXB.Name = "txtTenNXB";
            this.txtTenNXB.Size = new System.Drawing.Size(212, 22);
            this.txtTenNXB.TabIndex = 7;
            // 
            // lblTenNXB
            // 
            this.lblTenNXB.AutoSize = true;
            this.lblTenNXB.Location = new System.Drawing.Point(453, 158);
            this.lblTenNXB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenNXB.Name = "lblTenNXB";
            this.lblTenNXB.Size = new System.Drawing.Size(64, 16);
            this.lblTenNXB.TabIndex = 6;
            this.lblTenNXB.Text = "Tên NXB:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(540, 198);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(212, 22);
            this.txtDiaChi.TabIndex = 9;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(453, 202);
            this.lblDiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(50, 16);
            this.lblDiaChi.TabIndex = 8;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // btnThemDL
            // 
            this.btnThemDL.BackColor = System.Drawing.Color.PaleGreen;
            this.btnThemDL.Location = new System.Drawing.Point(420, 253);
            this.btnThemDL.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemDL.Name = "btnThemDL";
            this.btnThemDL.Size = new System.Drawing.Size(173, 49);
            this.btnThemDL.TabIndex = 10;
            this.btnThemDL.Text = "Thêm nhà xuất bản";
            this.btnThemDL.UseVisualStyleBackColor = false;
            this.btnThemDL.Click += new System.EventHandler(this.btnThemDL_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.PaleGreen;
            this.btnCapNhat.Location = new System.Drawing.Point(601, 253);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(173, 49);
            this.btnCapNhat.TabIndex = 11;
            this.btnCapNhat.Text = "Cập nhật thông tin";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.PaleGreen;
            this.btnXoa.Location = new System.Drawing.Point(508, 325);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(173, 49);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa dữ liệu";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 506);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThemDL);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.txtTenNXB);
            this.Controls.Add(this.lblTenNXB);
            this.Controls.Add(this.txtMaNXB);
            this.Controls.Add(this.lblMaNXB);
            this.Controls.Add(this.lblInputTitle);
            this.Controls.Add(this.lsvDanhSach);
            this.Controls.Add(this.lblListTitle);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Khai báo các biến cho control
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblListTitle;
        private System.Windows.Forms.ListView lsvDanhSach;
        private System.Windows.Forms.ColumnHeader colMaNXB;
        private System.Windows.Forms.ColumnHeader colTenNXB;
        private System.Windows.Forms.ColumnHeader colDiaChi;
        private System.Windows.Forms.Label lblInputTitle;
        private System.Windows.Forms.Label lblMaNXB;
        private System.Windows.Forms.TextBox txtMaNXB;
        private System.Windows.Forms.TextBox txtTenNXB;
        private System.Windows.Forms.Label lblTenNXB;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Button btnThemDL;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
    }
}