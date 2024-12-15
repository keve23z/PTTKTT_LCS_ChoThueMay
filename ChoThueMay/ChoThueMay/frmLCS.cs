using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LCS
{
    public partial class frmLCS : Form
    {
        private int[,] maTranLCS;
        private string chuoiConLCS;
        private int doDaiLCS;
        public frmLCS()
        {
            InitializeComponent();
        }

        private void btnTinhLCS_Click(object sender, EventArgs e)
        {
            string X = txtChuoiX.Text.Trim();
            string Y = txtChuoiY.Text.Trim();

            if (string.IsNullOrEmpty(X) || string.IsNullOrEmpty(Y))
            {
                MessageBox.Show("Vui lòng nhập cả hai chuỗi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            var ketQua = TinhDoDaiLCS(X, Y);
            maTranLCS = ketQua.Matrix;
            string[,] huongDi = ketQua.Directions;
            chuoiConLCS = ketQua.LcsString;
            doDaiLCS = ketQua.LcsLength;

            HienThiMaTran(maTranLCS, huongDi, X, Y);


            lblKetQua.Text = $"Chuỗi con chung dài nhất (LCS): {chuoiConLCS}\n" +
                             $"Độ dài: {doDaiLCS}";
        }

        private (int[,] Matrix, string[,] Directions, string LcsString, int LcsLength) TinhDoDaiLCS(string X, string Y)
        {
            // Bước 1: xác định độ dài của 2 chuỗi
            int n = X.Length;
            int m = Y.Length;

            // Bước 2: Khởi tạo ma trận c với khích thước (n+1) (m+1)
            int[,] c = new int[n + 1, m + 1];
            string[,] directions = new string[n + 1, m + 1];        // Ma trận hướng để hỗ trợ truy vết

            // Bước 3: Điền các giá trị vào ma trận c và xác định hướng truy vết
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    if (X[i - 1] == Y[j - 1])
                    {
                        c[i, j] = c[i - 1, j - 1] + 1;
                        directions[i, j] = "↖";             //hai chuỗi khớp nhau
                    }
                    else if (c[i - 1, j] >= c[i, j - 1])
                    {
                        c[i, j] = c[i - 1, j];
                        directions[i, j] = "↑";             //kế thừa từ hàng trên
                    }
                    else
                    {
                        c[i, j] = c[i, j - 1];
                        directions[i, j] = "←";             //kế thừa từ cột trước.
                    }
                }
            }

            // Bước 4: Truy vết để tìm chuỗi con chung dài nhất (LCS)
            StringBuilder lcs = new StringBuilder();
            int x = n, y = m;
            while (x > 0 && y > 0)
            {
                if (directions[x, y] == "↖")
                {
                    lcs.Append(X[x - 1]);
                    x--; y--;
                }
                else if (directions[x, y] == "↑")
                {
                    x--;
                }
                else
                {
                    y--;
                }
            }
            // Bước 5: Đảo ngược chuỗi LCS vì đã truy vết từ cuối lên
            char[] lcsArray = lcs.ToString().ToCharArray();
            Array.Reverse(lcsArray);

            return (c, directions, new string(lcsArray), c[n, m]);
        }

        private void HienThiMaTran(int[,] maTran, string[,] huong, string X, string Y)
        {
            dataGridViewLCS.Rows.Clear();
            dataGridViewLCS.Columns.Clear();

            int soHang = maTran.GetLength(0);
            int soCot = maTran.GetLength(1);

            dataGridViewLCS.Columns.Add("ChiSoHang", "i/j");

            for (int j = 0; j < soCot; j++)
            {
                if (j == 0)
                {
                    dataGridViewLCS.Columns.Add($"Cot{j}", "j=0");
                }
                else
                {
                    dataGridViewLCS.Columns.Add($"Cot{j}", $"j={j} ({Y[j - 1]})");
                }
            }

            DataGridViewRow hangTieuDe = new DataGridViewRow();
            hangTieuDe.Cells.Add(new DataGridViewTextBoxCell { Value = "i/j" });

            for (int j = 0; j < soCot; j++)
            {
                hangTieuDe.Cells.Add(new DataGridViewTextBoxCell { Value = j == 0 ? "" : Y[j - 1].ToString() });
            }

            dataGridViewLCS.Rows.Add(hangTieuDe);

            for (int i = 0; i < soHang; i++)
            {
                DataGridViewRow hangMoi = new DataGridViewRow();

                hangMoi.Cells.Add(new DataGridViewTextBoxCell { Value = i == 0 ? "j=0" : $"i={i} ({X[i - 1]})" });

                for (int j = 0; j < soCot; j++)
                {
                    string value = $"{maTran[i, j]} {huong[i, j]}";
                    hangMoi.Cells.Add(new DataGridViewTextBoxCell { Value = value });
                }
            dataGridViewLCS.Rows.Add(hangMoi);

            }
        }


        private void dataGridViewLCS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            int i = e.RowIndex;
            int j = e.ColumnIndex;

            if (i == 1 || j == 1)
            {
                txtTruongHop.Text = $"Trường hợp i = 0 hoặc j = 0 => Giá trị = 0";
                return;
            }

            i = i - 1;
            j = j - 1;

            if (maTranLCS == null || string.IsNullOrEmpty(txtChuoiX.Text) || string.IsNullOrEmpty(txtChuoiY.Text)) return;

            if (i >= maTranLCS.GetLength(0) || j >= maTranLCS.GetLength(1)) return;

            string truongHop = "";
            if (i > 0 && j > 0)
            {
                if (txtChuoiX.Text[i - 1] == txtChuoiY.Text[j - 1])
                {
                    truongHop = $"X[{i}] == Y[{j}] ({txtChuoiX.Text[i - 1]}): Lấy từ c[{i - 1}][{j - 1}] + 1";
                }
                else if (maTranLCS[i - 1, j] >= maTranLCS[i, j - 1])
                {
                    truongHop = $"X[{i}] != Y[{j}]: Lấy max từ c[{i - 1}][{j}]";
                }
                else
                {
                    truongHop = $"X[{i}] != Y[{j}]: Lấy max từ c[{i}][{j - 1}]";
                }
            }
            else
            {
                truongHop = "Trường hợp biên hoặc tiêu đề, không tính toán.";
            }

            txtTruongHop.Text = truongHop;
        }

        private void btnMau_Click(object sender, EventArgs e)
        {
            string X = "ABCDCAE";
            string Y = "DACDBA";
            txtChuoiX.Text = X;

            txtChuoiY.Text = Y;

            if (string.IsNullOrEmpty(X) || string.IsNullOrEmpty(Y))
            {
                MessageBox.Show("Vui lòng nhập cả hai chuỗi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            var ketQua = TinhDoDaiLCS(X, Y);
            maTranLCS = ketQua.Matrix;
            string[,] huongDi = ketQua.Directions;
            chuoiConLCS = ketQua.LcsString;
            doDaiLCS = ketQua.LcsLength;

            HienThiMaTran(maTranLCS, huongDi, X, Y);


            lblKetQua.Text = $"Chuỗi con chung dài nhất (LCS): {chuoiConLCS}\n" +
                             $"Độ dài: {doDaiLCS}";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtChuoiX.Clear();
            txtChuoiY.Clear();
            dataGridViewLCS.Rows.Clear();
            dataGridViewLCS.Columns.Clear();
            lblKetQua.Text = "";
            txtTruongHop.Text = "";
        }
    }
}

   