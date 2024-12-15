namespace LCS
{
    partial class frmLCS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChuoiX = new System.Windows.Forms.TextBox();
            this.txtChuoiY = new System.Windows.Forms.TextBox();
            this.btnTinhLCS = new System.Windows.Forms.Button();
            this.dataGridViewLCS = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.txtTruongHop = new System.Windows.Forms.Label();
            this.btnMau = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLCS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Chuỗi X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập Chuỗi Y";
            // 
            // txtChuoiX
            // 
            this.txtChuoiX.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChuoiX.Location = new System.Drawing.Point(202, 21);
            this.txtChuoiX.Name = "txtChuoiX";
            this.txtChuoiX.Size = new System.Drawing.Size(295, 32);
            this.txtChuoiX.TabIndex = 2;
            // 
            // txtChuoiY
            // 
            this.txtChuoiY.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChuoiY.Location = new System.Drawing.Point(200, 92);
            this.txtChuoiY.Name = "txtChuoiY";
            this.txtChuoiY.Size = new System.Drawing.Size(297, 32);
            this.txtChuoiY.TabIndex = 3;
            // 
            // btnTinhLCS
            // 
            this.btnTinhLCS.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTinhLCS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhLCS.ForeColor = System.Drawing.Color.Red;
            this.btnTinhLCS.Location = new System.Drawing.Point(518, 14);
            this.btnTinhLCS.Name = "btnTinhLCS";
            this.btnTinhLCS.Size = new System.Drawing.Size(116, 46);
            this.btnTinhLCS.TabIndex = 4;
            this.btnTinhLCS.Text = "Chạy";
            this.btnTinhLCS.UseVisualStyleBackColor = false;
            this.btnTinhLCS.Click += new System.EventHandler(this.btnTinhLCS_Click);
            // 
            // dataGridViewLCS
            // 
            this.dataGridViewLCS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewLCS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLCS.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewLCS.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLCS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewLCS.ColumnHeadersHeight = 60;
            this.dataGridViewLCS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewLCS.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewLCS.Location = new System.Drawing.Point(26, 150);
            this.dataGridViewLCS.MultiSelect = false;
            this.dataGridViewLCS.Name = "dataGridViewLCS";
            this.dataGridViewLCS.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLCS.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewLCS.RowHeadersVisible = false;
            this.dataGridViewLCS.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewLCS.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewLCS.RowTemplate.Height = 40;
            this.dataGridViewLCS.Size = new System.Drawing.Size(1401, 819);
            this.dataGridViewLCS.TabIndex = 5;
            this.dataGridViewLCS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLCS_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(818, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kết quả";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblKetQua.Location = new System.Drawing.Point(920, 21);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(46, 25);
            this.lblKetQua.TabIndex = 7;
            this.lblKetQua.Text = "null";
            // 
            // txtTruongHop
            // 
            this.txtTruongHop.AutoSize = true;
            this.txtTruongHop.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTruongHop.Location = new System.Drawing.Point(697, 96);
            this.txtTruongHop.Name = "txtTruongHop";
            this.txtTruongHop.Size = new System.Drawing.Size(54, 28);
            this.txtTruongHop.TabIndex = 8;
            this.txtTruongHop.Text = "null";
            // 
            // btnMau
            // 
            this.btnMau.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMau.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMau.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnMau.Location = new System.Drawing.Point(666, 14);
            this.btnMau.Name = "btnMau";
            this.btnMau.Size = new System.Drawing.Size(115, 46);
            this.btnMau.TabIndex = 9;
            this.btnMau.Text = "Mẫu";
            this.btnMau.UseVisualStyleBackColor = false;
            this.btnMau.Click += new System.EventHandler(this.btnMau_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnClear.Location = new System.Drawing.Point(518, 84);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(116, 46);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Xoá";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmLCS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1449, 995);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnMau);
            this.Controls.Add(this.txtTruongHop);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewLCS);
            this.Controls.Add(this.btnTinhLCS);
            this.Controls.Add(this.txtChuoiY);
            this.Controls.Add(this.txtChuoiX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmLCS";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLCS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtChuoiX;
        private System.Windows.Forms.TextBox txtChuoiY;
        private System.Windows.Forms.Button btnTinhLCS;
        private System.Windows.Forms.DataGridView dataGridViewLCS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Label txtTruongHop;
        private System.Windows.Forms.Button btnMau;
        private System.Windows.Forms.Button btnClear;
    }
}

