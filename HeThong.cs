using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KhaiBaoYTe
{
    public partial class HeThong : Form
    {
        private int TenMui;
        
        public HeThong()
        {
            InitializeComponent();
        }
        public HeThong(int TenMui)
        {
            InitializeComponent();
            this.TenMui = TenMui;
        }

        private void DangKy_Load(object sender, EventArgs e)
        {

        }

        private void TSMKhaiBao_Click(object sender, EventArgs e)
        {
            ToKhaiYTe frm = new ToKhaiYTe();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDangNhap frm = new FrmDangNhap();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void đăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangKy frm = new DangKy();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void quaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyKhaiBao frm = new QuanLyKhaiBao();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void mũi1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TenMui = 1;
            XacNhanTiemChung frm = new XacNhanTiemChung(TenMui);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void mũi2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TenMui = 2;
            XacNhanTiemChung frm = new XacNhanTiemChung(TenMui);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void xácNhậnTiêmChủngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TenMui = 2;
            XacNhanTiemChung frm = new XacNhanTiemChung(TenMui);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void mũi3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TenMui = 3;
            XacNhanTiemChung frm = new XacNhanTiemChung(TenMui);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void uToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyTiemChung frm = new QuanLyTiemChung();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDangNhap frm = new FrmDangNhap();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
