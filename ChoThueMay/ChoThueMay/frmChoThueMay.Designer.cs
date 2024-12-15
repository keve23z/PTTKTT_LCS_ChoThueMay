namespace ChoThueMay
{
    partial class frmChoThueMay
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rdoQuyHoachDong = new System.Windows.Forms.RadioButton();
            this.rdoThamLam = new System.Windows.Forms.RadioButton();
            this.btnMau = new System.Windows.Forms.Button();
            this.btnLuaChon = new System.Windows.Forms.Button();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtKetThuc = new System.Windows.Forms.TextBox();
            this.txtBatDau = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.dtgYeuCau = new System.Windows.Forms.DataGridView();
            this.dtgSX = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblsx = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.dtgDuocThue = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btnramdom = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgYeuCau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSX)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDuocThue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bắt đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kết thúc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(392, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btnramdom);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.rdoQuyHoachDong);
            this.groupBox1.Controls.Add(this.rdoThamLam);
            this.groupBox1.Controls.Add(this.btnMau);
            this.groupBox1.Controls.Add(this.btnLuaChon);
            this.groupBox1.Controls.Add(this.txtGia);
            this.groupBox1.Controls.Add(this.txtKetThuc);
            this.groupBox1.Controls.Add(this.txtBatDau);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1597, 122);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm khách thuê";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1262, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 50);
            this.button1.TabIndex = 10;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdoQuyHoachDong
            // 
            this.rdoQuyHoachDong.AutoSize = true;
            this.rdoQuyHoachDong.Location = new System.Drawing.Point(679, 52);
            this.rdoQuyHoachDong.Name = "rdoQuyHoachDong";
            this.rdoQuyHoachDong.Size = new System.Drawing.Size(251, 36);
            this.rdoQuyHoachDong.TabIndex = 9;
            this.rdoQuyHoachDong.TabStop = true;
            this.rdoQuyHoachDong.Text = "Quy Hoạch Động";
            this.rdoQuyHoachDong.UseVisualStyleBackColor = true;
            // 
            // rdoThamLam
            // 
            this.rdoThamLam.AutoSize = true;
            this.rdoThamLam.Location = new System.Drawing.Point(522, 52);
            this.rdoThamLam.Name = "rdoThamLam";
            this.rdoThamLam.Size = new System.Drawing.Size(169, 36);
            this.rdoThamLam.TabIndex = 2;
            this.rdoThamLam.TabStop = true;
            this.rdoThamLam.Text = "Tham Lam";
            this.rdoThamLam.UseVisualStyleBackColor = true;
            // 
            // btnMau
            // 
            this.btnMau.BackColor = System.Drawing.Color.White;
            this.btnMau.FlatAppearance.BorderSize = 0;
            this.btnMau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMau.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMau.Location = new System.Drawing.Point(984, 45);
            this.btnMau.Name = "btnMau";
            this.btnMau.Size = new System.Drawing.Size(114, 50);
            this.btnMau.TabIndex = 8;
            this.btnMau.Text = "Mẫu";
            this.btnMau.UseVisualStyleBackColor = false;
            this.btnMau.Click += new System.EventHandler(this.btnMau_Click);
            // 
            // btnLuaChon
            // 
            this.btnLuaChon.BackColor = System.Drawing.Color.White;
            this.btnLuaChon.FlatAppearance.BorderSize = 0;
            this.btnLuaChon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuaChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuaChon.Location = new System.Drawing.Point(1104, 45);
            this.btnLuaChon.Name = "btnLuaChon";
            this.btnLuaChon.Size = new System.Drawing.Size(152, 50);
            this.btnLuaChon.TabIndex = 7;
            this.btnLuaChon.Text = "Lựa chọn";
            this.btnLuaChon.UseVisualStyleBackColor = false;
            this.btnLuaChon.Click += new System.EventHandler(this.btnLuaChon_Click);
            // 
            // txtGia
            // 
            this.txtGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(449, 52);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(70, 34);
            this.txtGia.TabIndex = 6;
            // 
            // txtKetThuc
            // 
            this.txtKetThuc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKetThuc.Location = new System.Drawing.Point(324, 52);
            this.txtKetThuc.Name = "txtKetThuc";
            this.txtKetThuc.Size = new System.Drawing.Size(70, 34);
            this.txtKetThuc.TabIndex = 5;
            this.txtKetThuc.TextChanged += new System.EventHandler(this.txtKetThuc_TextChanged);
            this.txtKetThuc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKetThuc_KeyPress);
            this.txtKetThuc.Leave += new System.EventHandler(this.txtKetThuc_Leave);
            // 
            // txtBatDau
            // 
            this.txtBatDau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatDau.Location = new System.Drawing.Point(145, 52);
            this.txtBatDau.Name = "txtBatDau";
            this.txtBatDau.Size = new System.Drawing.Size(70, 34);
            this.txtBatDau.TabIndex = 4;
            this.txtBatDau.TextChanged += new System.EventHandler(this.txtBatDau_TextChanged);
            this.txtBatDau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBatDau_KeyPress);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(879, 45);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(99, 50);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar2);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.dtgYeuCau);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(742, 737);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách yêu cầu thuê";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(25, 656);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(692, 34);
            this.progressBar2.TabIndex = 2;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(12, 365);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(0, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // dtgYeuCau
            // 
            this.dtgYeuCau.AllowUserToAddRows = false;
            this.dtgYeuCau.AllowUserToDeleteRows = false;
            this.dtgYeuCau.AllowUserToResizeColumns = false;
            this.dtgYeuCau.AllowUserToResizeRows = false;
            this.dtgYeuCau.BackgroundColor = System.Drawing.Color.White;
            this.dtgYeuCau.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgYeuCau.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dtgYeuCau.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgYeuCau.ColumnHeadersHeight = 30;
            this.dtgYeuCau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgYeuCau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgYeuCau.Location = new System.Drawing.Point(3, 34);
            this.dtgYeuCau.MultiSelect = false;
            this.dtgYeuCau.Name = "dtgYeuCau";
            this.dtgYeuCau.ReadOnly = true;
            this.dtgYeuCau.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgYeuCau.RowHeadersVisible = false;
            this.dtgYeuCau.RowHeadersWidth = 51;
            this.dtgYeuCau.RowTemplate.Height = 24;
            this.dtgYeuCau.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgYeuCau.Size = new System.Drawing.Size(736, 700);
            this.dtgYeuCau.TabIndex = 0;
            // 
            // dtgSX
            // 
            this.dtgSX.AllowUserToAddRows = false;
            this.dtgSX.AllowUserToDeleteRows = false;
            this.dtgSX.AllowUserToResizeColumns = false;
            this.dtgSX.AllowUserToResizeRows = false;
            this.dtgSX.BackgroundColor = System.Drawing.Color.White;
            this.dtgSX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgSX.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dtgSX.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgSX.ColumnHeadersHeight = 30;
            this.dtgSX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgSX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgSX.Location = new System.Drawing.Point(3, 34);
            this.dtgSX.MultiSelect = false;
            this.dtgSX.Name = "dtgSX";
            this.dtgSX.ReadOnly = true;
            this.dtgSX.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgSX.RowHeadersVisible = false;
            this.dtgSX.RowHeadersWidth = 51;
            this.dtgSX.RowTemplate.Height = 24;
            this.dtgSX.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgSX.Size = new System.Drawing.Size(849, 370);
            this.dtgSX.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgSX);
            this.groupBox3.Controls.Add(this.lblsx);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtTong);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(742, 122);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(855, 407);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // lblsx
            // 
            this.lblsx.AutoSize = true;
            this.lblsx.Location = new System.Drawing.Point(8, 1);
            this.lblsx.Name = "lblsx";
            this.lblsx.Size = new System.Drawing.Size(123, 32);
            this.lblsx.TabIndex = 9;
            this.lblsx.Text = "Sắp Xếp";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(20, 913);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(487, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tổng số tiền lớn nhất có thể thu được:";
            // 
            // txtTong
            // 
            this.txtTong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtTong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTong.Location = new System.Drawing.Point(-171, 910);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(179, 38);
            this.txtTong.TabIndex = 1;
            this.txtTong.Text = "0";
            this.txtTong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtgDuocThue
            // 
            this.dtgDuocThue.AllowUserToAddRows = false;
            this.dtgDuocThue.AllowUserToDeleteRows = false;
            this.dtgDuocThue.AllowUserToResizeColumns = false;
            this.dtgDuocThue.AllowUserToResizeRows = false;
            this.dtgDuocThue.BackgroundColor = System.Drawing.Color.White;
            this.dtgDuocThue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgDuocThue.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dtgDuocThue.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgDuocThue.ColumnHeadersHeight = 30;
            this.dtgDuocThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgDuocThue.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtgDuocThue.Location = new System.Drawing.Point(3, 34);
            this.dtgDuocThue.MultiSelect = false;
            this.dtgDuocThue.Name = "dtgDuocThue";
            this.dtgDuocThue.ReadOnly = true;
            this.dtgDuocThue.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgDuocThue.RowHeadersVisible = false;
            this.dtgDuocThue.RowHeadersWidth = 51;
            this.dtgDuocThue.RowTemplate.Height = 24;
            this.dtgDuocThue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgDuocThue.Size = new System.Drawing.Size(849, 233);
            this.dtgDuocThue.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtTongTien);
            this.groupBox4.Controls.Add(this.dtgDuocThue);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(742, 529);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(855, 338);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh Sách Yêu Cầu Được Chọn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 32);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tổng lợi nhuận :";
            // 
            // txtTongTien
            // 
            this.txtTongTien.BackColor = System.Drawing.Color.MistyRose;
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(253, 268);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(100, 38);
            this.txtTongTien.TabIndex = 8;
            // 
            // btnramdom
            // 
            this.btnramdom.BackColor = System.Drawing.Color.White;
            this.btnramdom.FlatAppearance.BorderSize = 0;
            this.btnramdom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnramdom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnramdom.Location = new System.Drawing.Point(1352, 45);
            this.btnramdom.Name = "btnramdom";
            this.btnramdom.Size = new System.Drawing.Size(177, 50);
            this.btnramdom.TabIndex = 11;
            this.btnramdom.Text = "RamdomYC";
            this.btnramdom.UseVisualStyleBackColor = false;
            this.btnramdom.Click += new System.EventHandler(this.btnramdom_Click);
            // 
            // frmChoThueMay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1597, 859);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChoThueMay";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgYeuCau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSX)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDuocThue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtKetThuc;
        private System.Windows.Forms.TextBox txtBatDau;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuaChon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgYeuCau;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgDuocThue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.Button btnMau;
        private System.Windows.Forms.RadioButton rdoThamLam;
        private System.Windows.Forms.RadioButton rdoQuyHoachDong;
        private System.Windows.Forms.DataGridView dtgSX;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label lblsx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnramdom;
    }
}

