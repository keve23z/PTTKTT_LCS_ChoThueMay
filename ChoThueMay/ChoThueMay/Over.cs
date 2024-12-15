using LCS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChoThueMay
{
    public partial class Over : Form
    {
        public Over()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLCS lcs = new frmLCS();
            lcs.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmChoThueMay thue = new frmChoThueMay();
            thue.ShowDialog();
        }
    }
}
