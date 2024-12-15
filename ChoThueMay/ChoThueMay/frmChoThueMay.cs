using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ChoThueMay
{
    public partial class frmChoThueMay : Form
    {
        public frmChoThueMay()
        {
            InitializeComponent();
        }
        private List<DSThueMay> DSYeuCauThues = new List<DSThueMay>();

        public class DSThueMay
        {
            public int STT { get; set; }
            public int Start { get; set; }
            public int End { get; set; }
            public int Price { get; set; }

            public override string ToString()
            {
                return $"STT: {STT},Bắt đầu: {Start}, Kết thúc: {End}, Giá thuê: {Price}";
            }
        }

        private DataTable DSDcDuyetKhiQHD;
        private List<DSThueMay> DSDcDuyetTL;


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
           (
           int nLeft,
           int nTop,
           int nRight,
           int rBottom,
           int nWidthEllipse,
           int nHeightEllipse
           );

        private void BoGoc(Control tmp, int goc)
        {
            tmp.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tmp.Width, tmp.Height, goc, goc));
        }

        public void GenerateRandomValues()
        {
            Random rand = new Random();

            int start = rand.Next(1, 24);
            int end = rand.Next(start + 1, 24);
            int price = rand.Next(10, 156);

            // Gán các giá trị vào các TextBox tương ứng
            txtBatDau.Text = start.ToString();
            txtKetThuc.Text = end.ToString();
            txtGia.Text = price.ToString();
        }

        //Sap xep chon 
        //private void SapXepDSThueMay(List<DSThueMay> DSYeuCauThues)
        //{
        //    int n = DSYeuCauThues.Count;
        //    for (int i = 0; i < n - 1; i++)
        //    {
        //        for (int j = i + 1; j < n; j++)
        //        {
        //            if (DSYeuCauThues[i].End > DSYeuCauThues[j].End || // nêu j+1 nhỏ hơn thì cần đổi
        //            // khi thời gian bằng nhau, sắp xếp giảm dần theo giá
        //                (DSYeuCauThues[i].End == DSYeuCauThues[j].End && DSYeuCauThues[i].Price < DSYeuCauThues[j].Price))
        //            {
        //                // hoán đổi hai yêu cầu
        //                var temp = DSYeuCauThues[i];
        //                DSYeuCauThues[i] = DSYeuCauThues[j];
        //                DSYeuCauThues[j] = temp;
        //            }

        //        }
        //    }
        //}

        //QuickSort
        //private void SapXepDSThueMay(List<DSThueMay> DSYeuCauThues)
        //{
        //    QuickSort(DSYeuCauThues, 0, DSYeuCauThues.Count - 1);
        //}

        //private void QuickSort(List<DSThueMay> DSYeuCauThues, int left, int right)
        //{
        //    if (left < right)
        //    {
        //        int pivotIndex = Partition(DSYeuCauThues, left, right);
        //        QuickSort(DSYeuCauThues, left, pivotIndex - 1);  // Sắp xếp bên trái pivot
        //        QuickSort(DSYeuCauThues, pivotIndex + 1, right); // Sắp xếp bên phải pivot
        //    }
        //}

        //private int Partition(List<DSThueMay> DSYeuCauThues, int left, int right)
        //{
        //    var pivot = DSYeuCauThues[right]; // Chọn phần tử cuối cùng làm pivot
        //    int i = left - 1; // Vị trí phần tử nhỏ hơn pivot

        //    for (int j = left; j < right; j++)
        //    {
        //        // So sánh theo thứ tự ưu tiên:
        //        if (DSYeuCauThues[j].End < pivot.End ||
        //           (DSYeuCauThues[j].End == pivot.End && DSYeuCauThues[j].Price > pivot.Price))
        //        {
        //            i++;
        //            Swap(DSYeuCauThues, i, j);
        //        }
        //    }
        //    Swap(DSYeuCauThues, i + 1, right); // Đưa pivot về đúng vị trí
        //    return i + 1; // Trả về vị trí pivot
        //}

        //private void Swap(List<DSThueMay> DSYeuCauThues, int index1, int index2)
        //{
        //    var temp = DSYeuCauThues[index1];
        //    DSYeuCauThues[index1] = DSYeuCauThues[index2];
        //    DSYeuCauThues[index2] = temp;
        //}


        private void SapXepDSThueMay(List<DSThueMay> DSYeuCauThues)//sắp xếp nổi bọt (Bubble Sort)
        {
            int n = DSYeuCauThues.Count;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (DSYeuCauThues[j].End > DSYeuCauThues[j + 1].End || // nêu j+1 nhỏ hơn thì cần đổi
                    // khi thời gian bằng nhau, sắp xếp giảm dần theo giá
                        (DSYeuCauThues[j].End == DSYeuCauThues[j + 1].End && DSYeuCauThues[j].Price < DSYeuCauThues[j + 1].Price))
                    {
                        // hoán đổi hai yêu cầu
                        var temp = DSYeuCauThues[j];
                        DSYeuCauThues[j] = DSYeuCauThues[j + 1];
                        DSYeuCauThues[j + 1] = temp;
                    }
        }

        private int MaxChoThueMayThamLam(List<DSThueMay> DSYeuCauThues, out List<DSThueMay> DSDuocChon)
        {
            var sortedDSYeuCauThue = new List<DSThueMay>(DSYeuCauThues);
            // Sắp xếp
            SapXepDSThueMay(sortedDSYeuCauThue);

            // gắn giá trị bắt đầu
            int TongTien = 0;
            int tgKetthucdangthue = 0;
            DSDuocChon = new List<DSThueMay>();

            foreach (var YeuCauThue in sortedDSYeuCauThue)
            {
                if (YeuCauThue.Start >= tgKetthucdangthue)
                {
                    TongTien += YeuCauThue.Price;
                    tgKetthucdangthue = YeuCauThue.End;//gan lại tg ket thuc
                    DSDuocChon.Add(YeuCauThue); // thêm vào ds yeu cau dc chọn
                }
            }
            DSDcDuyetTL = DSDuocChon;
            dtgSX.DataSource = sortedDSYeuCauThue;
            return TongTien;
        }


        private int MaxChoThueMayQuyHoachDong(List<DSThueMay> DSYeuCauThues, out List<DSThueMay> DSDuocChon)
        {
            var sortedDSYeuCauThue = new List<DSThueMay>(DSYeuCauThues);

            //Sắp xếp
            SapXepDSThueMay(sortedDSYeuCauThue);
            
            // khởi tạo
            sortedDSYeuCauThue.Insert(0, new DSThueMay { STT = 0, Start = 0, End = 0, Price = 0 });

            int n = sortedDSYeuCauThue.Count;
            int[] f = new int[n]; // lưu lợi nhuận
            int[] trace = new int[n]; //lưu yêu cầu được chọn

            //Quy hoạch động để tính lợi nhuận cao nhất
            for (int i = 1; i < n; i++) //duyet tung yeu cau
            {
                f[i] = sortedDSYeuCauThue[i].Price; //Lợi nhuận từ yêu cầu hiện tại
                trace[i] = 0; // chưa có yêu cầu được chọn

                for (int j = 0; j < i; j++)
                {
                    if (sortedDSYeuCauThue[i].Start >= sortedDSYeuCauThue[j].End) //kt thời gian bắt đầu có đang được sử dụng hay không
                    {
                        if (f[i] < f[j] + sortedDSYeuCauThue[i].Price) // neu chọn yêu cầu j trước i tăng lợi nhuận
                        {
                            f[i] = f[j] + sortedDSYeuCauThue[i].Price;//cap nhat loi nhuan
                            trace[i] = j; //luu truy vet
                        }
                    }
                }
            }
            //tìm giá trị lớn nhất trong f[] và vị trí
            int maxValue = 0, maxIndex = 0;
            for (int i = 1; i < n; i++)
            {
                if (f[i] > maxValue)
                {
                    maxValue = f[i];
                    maxIndex = i;
                }
            }

            // Truy vết các yêu cầu được chọn
            DSDuocChon = new List<DSThueMay>();
            while (maxIndex > 0)
            {
                DSDuocChon.Add(sortedDSYeuCauThue[maxIndex]);
                maxIndex = trace[maxIndex];
            }
            DSDuocChon.Reverse();
            dtgSX.DataSource = sortedDSYeuCauThue;
            return maxValue;
        }
        //private void In(int n, int[,] matrix)
        //{
        //    var maTranDataTable = new DataTable();
        //    maTranDataTable.Columns.Add("i\\j", typeof(string));

        //    for (int c = 0; c < n; c++)
        //    {
        //        maTranDataTable.Columns.Add($"{c + 1}", typeof(int));
        //    }

        //    for (int i = 0; i < n; i++) // Bắt đầu từ i = 0 để hiển thị chỉ số hàng
        //    {
        //        var dong = maTranDataTable.NewRow(); // Tạo dòng mới

        //        dong[0] = $"{i + 1}"; // Chỉ số hàng (i) vào cột đầu tiên

        //        // Điền dữ liệu từ ma trận vào các cột còn lại
        //        for (int j = 0; j < n; j++)
        //        {
        //            dong[j + 1] = matrix[i,j]; // Dữ liệu ma trận, cột j + 1 (vì cột đầu tiên chứa chỉ số hàng)
        //        }

        //        maTranDataTable.Rows.Add(dong); // Thêm dòng vào DataTable
        //    }

        //    DSDcDuyetKhiQHD = maTranDataTable;

        //}

        private void LoadData()
        {

            DSYeuCauThues.Add(new DSThueMay { STT = 1, Start = 5, End = 7, Price = 60 });
            DSYeuCauThues.Add(new DSThueMay { STT = 2, Start = 1, End = 4, Price = 50 });
            DSYeuCauThues.Add(new DSThueMay { STT = 3, Start = 1, End = 2, Price = 10 });
            DSYeuCauThues.Add(new DSThueMay { STT = 4, Start = 3, End = 5, Price = 20 });
            DSYeuCauThues.Add(new DSThueMay { STT = 5, Start = 3, End = 6, Price = 70 });
            DSYeuCauThues.Add(new DSThueMay { STT = 6, Start = 8, End = 9, Price = 30 });
            DSYeuCauThues.Add(new DSThueMay { STT = 7, Start = 1, End = 2, Price = 20 });

            DSYeuCauThues.Add(new DSThueMay { STT = 8, Start = 1, End = 3, Price = 50 });
            DSYeuCauThues.Add(new DSThueMay { STT = 9, Start = 2, End = 5, Price = 20 });
            DSYeuCauThues.Add(new DSThueMay { STT = 10, Start = 3, End = 4, Price = 100 });
            DSYeuCauThues.Add(new DSThueMay { STT = 11, Start = 3, End = 6, Price = 200 });

            dtgYeuCau.DataSource = null;
            dtgYeuCau.DataSource = DSYeuCauThues;

            dtgYeuCau.Columns["STT"].HeaderText = "STT";
            dtgYeuCau.Columns["Start"].HeaderText = "Bắt Đầu";
            dtgYeuCau.Columns["End"].HeaderText = "Kết Thúc";
            dtgYeuCau.Columns["Price"].HeaderText = "Giá Thuê";

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            BoGoc(btnramdom, 20);
            dtgDuocThue.ColumnHeadersHeight = 40;   
            dtgDuocThue.RowTemplate.Height = 40;
            dtgSX.ColumnHeadersHeight = 40;
            dtgSX.RowTemplate.Height = 40;

            foreach (DataGridViewColumn column in dtgYeuCau.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }


            dtgYeuCau.ColumnHeadersHeight = 40;
            dtgYeuCau.RowTemplate.Height = 40;


            dtgYeuCau.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDuocThue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgSX.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            rdoThamLam.Checked = true;
            BoGoc(btnLuaChon, 20);
            BoGoc(btnThem, 20);
            BoGoc(btnMau, 20);
            BoGoc(txtBatDau, 10);
            BoGoc(txtKetThuc, 10);
            BoGoc(txtGia, 10);
            BoGoc(txtTong, 10);
            BoGoc(button1, 20);

        }

        private void btnMau_Click(object sender, EventArgs e)
        {
            DSYeuCauThues.Clear();
            LoadData();
            progressBar2.Value = 0;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBatDau.Text, out int start) &&
                int.TryParse(txtKetThuc.Text, out int end) &&
                int.TryParse(txtGia.Text, out int price))
            {
                DSThueMay newDSYeuCauThue = new DSThueMay {STT = dtgYeuCau.RowCount + 1 , Start = start, End = end, Price = price };

                if (DSYeuCauThues == null)
                {
                    DSYeuCauThues = new List<DSThueMay>();
                }

                DSYeuCauThues.Add(newDSYeuCauThue);

                dtgYeuCau.DataSource = null;
                dtgYeuCau.DataSource = DSYeuCauThues;

                dtgYeuCau.Columns["STT"].HeaderText = "STT";
                dtgYeuCau.Columns["Start"].HeaderText = "Bắt Đầu";
                dtgYeuCau.Columns["End"].HeaderText = "Kết Thúc";
                dtgYeuCau.Columns["Price"].HeaderText = "Giá Thuê";

                txtBatDau.Clear();
                txtKetThuc.Clear();
                txtGia.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các giá trị !");
            }
            progressBar2.Value = 0;
        }

        private async void btnLuaChon_Click(object sender, EventArgs e)
        {

            List<DSThueMay> DSDuocChon;
            int TongTien = 0;
            dtgSX.DataSource = null;
            dtgDuocThue.DataSource = null;
            if(rdoQuyHoachDong.Checked)
            { 
                
            }
            else { 
                 }
            if (rdoThamLam.Checked)
                TongTien = MaxChoThueMayThamLam(DSYeuCauThues, out DSDuocChon);
            else
                TongTien = MaxChoThueMayQuyHoachDong(DSYeuCauThues, out DSDuocChon);

            progressBar2.Value = 0;
            progressBar2.Maximum = DSDuocChon.Count;

            foreach (var item in DSDuocChon)
            {
                int rowIndex = DSYeuCauThues.IndexOf(item);
                if (rowIndex >= 0 && rowIndex < dtgYeuCau.Rows.Count)
                {
                    dtgYeuCau.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightGreen;

                    progressBar2.Value += 1;

                    await Task.Delay(500);

                    dtgYeuCau.Rows[rowIndex].DefaultCellStyle.BackColor = Color.White;
                }
            }

            dtgDuocThue.DataSource = null;
            dtgDuocThue.DataSource = DSDuocChon;
            txtTongTien.Text = TongTien.ToString();

            progressBar2.Value = 0;
            dtgDuocThue.Columns["STT"].HeaderText = "STT";
            dtgDuocThue.Columns["Start"].HeaderText = "Bắt Đầu";
            dtgDuocThue.Columns["End"].HeaderText = "Kết Thúc";
            dtgDuocThue.Columns["Price"].HeaderText = "Giá Thuê";


        }

        private void txtBatDau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar !='\b')
            {
                e.Handled = true;
                errorProvider1.SetError(txtBatDau, "Thời gian bắt đầu phải là số");
            }
            else
                errorProvider1.Clear();
        }

        private void txtKetThuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
                errorProvider1.SetError(txtKetThuc, "Thời gian kết thúc phải là số");
            }
            else
                errorProvider1.Clear();
        }

        private void txtKetThuc_Leave(object sender, EventArgs e)
        {
            if (txtKetThuc.Text.Length > 0 && txtBatDau.Text.Length > 0)
            {
                if (int.Parse(txtBatDau.Text) > int.Parse(txtKetThuc.Text))
                {
                    txtKetThuc.Text = string.Empty;
                    txtKetThuc.Focus();
                    MessageBox.Show("Thời gian kết thúc phải nhỏ hơn thờ gian bắt đầu");
                }
            }
        }

        private void txtBatDau_TextChanged(object sender, EventArgs e)
        {
            if (txtBatDau.Text.Length > 0)
            {
                if (double.Parse(txtBatDau.Text) > 23)
                {
                    txtBatDau.Text = string.Empty;
                    errorProvider1.SetError(txtBatDau, "Thời gian bắt đầu phải nhỏ hơn 24");
                }
                else
                    errorProvider1.Clear();
            }
        }

        private void txtKetThuc_TextChanged(object sender, EventArgs e)
        {
            if (txtKetThuc.Text.Length > 0)
            {
                if (double.Parse(txtKetThuc.Text) > 24)
                {
                    txtKetThuc.Text = string.Empty;
                    errorProvider1.SetError(txtKetThuc, "Thời gian bắt đầu phải nhỏ hơn bằng 24");
                }
                else
                    errorProvider1.Clear();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            if (rdoQuyHoachDong.Checked)
                {;
            }
            else
                {;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtgYeuCau.DataSource = null;
        }

        private void btnramdom_Click(object sender, EventArgs e)
        {
            GenerateRandomValues();
        }
    }
}
