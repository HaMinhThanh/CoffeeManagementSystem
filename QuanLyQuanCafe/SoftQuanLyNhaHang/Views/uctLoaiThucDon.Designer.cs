﻿namespace SoftQuanLyNhaHang.Views
{
    partial class uctLoaiThucDon
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label12 = new System.Windows.Forms.Label();
            this.dgvDanhSachLTD = new System.Windows.Forms.DataGridView();
            this.IdLoaiThucDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiThucDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienGiai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grDanhSachKV = new System.Windows.Forms.GroupBox();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.grQuanLyNV = new System.Windows.Forms.GroupBox();
            this.cmbTrangThaiLTDon = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDienGiaiLTDon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTenLTDon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdLTDon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLTD)).BeginInit();
            this.grDanhSachKV.SuspendLayout();
            this.grQuanLyNV.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(144, 43);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(283, 22);
            this.label12.TabIndex = 87;
            this.label12.Text = "DANH SÁCH LOẠI THỰC ĐƠN";
            // 
            // dgvDanhSachLTD
            // 
            this.dgvDanhSachLTD.AllowUserToAddRows = false;
            this.dgvDanhSachLTD.AllowUserToDeleteRows = false;
            this.dgvDanhSachLTD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachLTD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachLTD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdLoaiThucDon,
            this.TenLoaiThucDon,
            this.DienGiai,
            this.TrangThai});
            this.dgvDanhSachLTD.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDanhSachLTD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvDanhSachLTD.Location = new System.Drawing.Point(4, 82);
            this.dgvDanhSachLTD.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDanhSachLTD.Name = "dgvDanhSachLTD";
            this.dgvDanhSachLTD.ReadOnly = true;
            this.dgvDanhSachLTD.RowHeadersWidth = 51;
            this.dgvDanhSachLTD.Size = new System.Drawing.Size(583, 378);
            this.dgvDanhSachLTD.TabIndex = 88;
            // 
            // IdLoaiThucDon
            // 
            this.IdLoaiThucDon.DataPropertyName = "IdLoaiThucDon";
            this.IdLoaiThucDon.HeaderText = "Id loại TĐ";
            this.IdLoaiThucDon.MinimumWidth = 6;
            this.IdLoaiThucDon.Name = "IdLoaiThucDon";
            this.IdLoaiThucDon.ReadOnly = true;
            // 
            // TenLoaiThucDon
            // 
            this.TenLoaiThucDon.DataPropertyName = "TenLoaiThucDon";
            this.TenLoaiThucDon.HeaderText = "Tên TĐ";
            this.TenLoaiThucDon.MinimumWidth = 6;
            this.TenLoaiThucDon.Name = "TenLoaiThucDon";
            this.TenLoaiThucDon.ReadOnly = true;
            // 
            // DienGiai
            // 
            this.DienGiai.DataPropertyName = "DienGiai";
            this.DienGiai.HeaderText = "Diễn giải";
            this.DienGiai.MinimumWidth = 6;
            this.DienGiai.Name = "DienGiai";
            this.DienGiai.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // grDanhSachKV
            // 
            this.grDanhSachKV.Controls.Add(this.label12);
            this.grDanhSachKV.Controls.Add(this.dgvDanhSachLTD);
            this.grDanhSachKV.Location = new System.Drawing.Point(4, 78);
            this.grDanhSachKV.Margin = new System.Windows.Forms.Padding(4);
            this.grDanhSachKV.Name = "grDanhSachKV";
            this.grDanhSachKV.Padding = new System.Windows.Forms.Padding(4);
            this.grDanhSachKV.Size = new System.Drawing.Size(591, 464);
            this.grDanhSachKV.TabIndex = 95;
            this.grDanhSachKV.TabStop = false;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.Location = new System.Drawing.Point(657, 474);
            this.btnThemMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(100, 64);
            this.btnThemMoi.TabIndex = 102;
            this.btnThemMoi.Text = "Thêm ";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(1047, 474);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 64);
            this.btnHuy.TabIndex = 106;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(949, 474);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 64);
            this.btnLuu.TabIndex = 105;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(852, 474);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 64);
            this.btnXoa.TabIndex = 104;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(755, 474);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 64);
            this.btnSua.TabIndex = 103;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // grQuanLyNV
            // 
            this.grQuanLyNV.Controls.Add(this.textBox1);
            this.grQuanLyNV.Controls.Add(this.label3);
            this.grQuanLyNV.Controls.Add(this.cmbTrangThaiLTDon);
            this.grQuanLyNV.Controls.Add(this.label10);
            this.grQuanLyNV.Controls.Add(this.txtDienGiaiLTDon);
            this.grQuanLyNV.Controls.Add(this.label8);
            this.grQuanLyNV.Controls.Add(this.txtTenLTDon);
            this.grQuanLyNV.Controls.Add(this.label2);
            this.grQuanLyNV.Controls.Add(this.txtIdLTDon);
            this.grQuanLyNV.Controls.Add(this.label6);
            this.grQuanLyNV.Controls.Add(this.label1);
            this.grQuanLyNV.Location = new System.Drawing.Point(616, 68);
            this.grQuanLyNV.Margin = new System.Windows.Forms.Padding(4);
            this.grQuanLyNV.Name = "grQuanLyNV";
            this.grQuanLyNV.Padding = new System.Windows.Forms.Padding(4);
            this.grQuanLyNV.Size = new System.Drawing.Size(702, 275);
            this.grQuanLyNV.TabIndex = 101;
            this.grQuanLyNV.TabStop = false;
            // 
            // cmbTrangThaiLTDon
            // 
            this.cmbTrangThaiLTDon.FormattingEnabled = true;
            this.cmbTrangThaiLTDon.Location = new System.Drawing.Point(451, 131);
            this.cmbTrangThaiLTDon.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTrangThaiLTDon.Name = "cmbTrangThaiLTDon";
            this.cmbTrangThaiLTDon.Size = new System.Drawing.Size(124, 24);
            this.cmbTrangThaiLTDon.TabIndex = 79;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(356, 136);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 17);
            this.label10.TabIndex = 77;
            this.label10.Text = "Trạng Thái :";
            // 
            // txtDienGiaiLTDon
            // 
            this.txtDienGiaiLTDon.Location = new System.Drawing.Point(170, 131);
            this.txtDienGiaiLTDon.Margin = new System.Windows.Forms.Padding(4);
            this.txtDienGiaiLTDon.Name = "txtDienGiaiLTDon";
            this.txtDienGiaiLTDon.Size = new System.Drawing.Size(161, 22);
            this.txtDienGiaiLTDon.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 136);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 17);
            this.label8.TabIndex = 78;
            this.label8.Text = "Diễn Giải :";
            // 
            // txtTenLTDon
            // 
            this.txtTenLTDon.Location = new System.Drawing.Point(451, 87);
            this.txtTenLTDon.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenLTDon.Name = "txtTenLTDon";
            this.txtTenLTDon.Size = new System.Drawing.Size(192, 22);
            this.txtTenLTDon.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 65;
            this.label2.Text = "Tên :";
            // 
            // txtIdLTDon
            // 
            this.txtIdLTDon.Enabled = false;
            this.txtIdLTDon.Location = new System.Drawing.Point(170, 87);
            this.txtIdLTDon.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdLTDon.Name = "txtIdLTDon";
            this.txtIdLTDon.Size = new System.Drawing.Size(116, 22);
            this.txtIdLTDon.TabIndex = 73;
            this.txtIdLTDon.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 92);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 17);
            this.label6.TabIndex = 71;
            this.label6.Text = "Id Loại Thực Đơn :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 22);
            this.label1.TabIndex = 72;
            this.label1.Text = "QUẢN LÝ  LOẠI THỰC ĐƠN";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(170, 185);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 22);
            this.textBox1.TabIndex = 80;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 81;
            this.label3.Text = "Đơn vị";
            // 
            // uctLoaiThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.grQuanLyNV);
            this.Controls.Add(this.grDanhSachKV);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "uctLoaiThucDon";
            this.Size = new System.Drawing.Size(1408, 565);
            this.Load += new System.EventHandler(this.uctLoaiThucDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLTD)).EndInit();
            this.grDanhSachKV.ResumeLayout(false);
            this.grDanhSachKV.PerformLayout();
            this.grQuanLyNV.ResumeLayout(false);
            this.grQuanLyNV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvDanhSachLTD;
        private System.Windows.Forms.GroupBox grDanhSachKV;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox grQuanLyNV;
        private System.Windows.Forms.ComboBox cmbTrangThaiLTDon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDienGiaiLTDon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTenLTDon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdLTDon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLoaiThucDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiThucDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienGiai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}
