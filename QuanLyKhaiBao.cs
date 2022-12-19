using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace KhaiBaoYTe
{
    public partial class QuanLyKhaiBao : Form
    {
        public QuanLyKhaiBao()
        {
            InitializeComponent();
        }


        public string hoten;
        public string cmnd;
        public string namsinh;
        public string gioitinh;
        public string quoctich;
        public string tinhVN;
        public string huyenVN;
        public string xaVN;
        public string diachicutheVN;
        public string sdt;
        public string email;
        public string dichuyen;
        public string tinhdichuyen;
        public string huyendichuyen;
        public string xadichuyen;
        public string diachicuthedichuyen;
        public string dauhieubenhly;
        public string tiepxuxnguoibenh;
        public string tiepxucnuoccocovid;
        public string tiepxucnguoicobieuhien;
        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            KetNoi.moKetNoi();
            HienThi();
            KetNoi.dongKetNoi();
        }
        public void HienThi()
        {
            listView1.Items.Clear();
            KetNoi.moKetNoi();
            string sql = string.Format("Select * from KhaiBao Where CMND like N'%{0}%'",txtTimKiem.Text);
            SqlDataReader docdulieu = KetNoi.HienThii(sql);
            if (docdulieu.Read())
            {
                listView1.Items.Add(docdulieu[1].ToString());
                listView1.Items[0].SubItems.Add(docdulieu[2].ToString());
                listView1.Items[0].SubItems.Add(docdulieu[3].ToString());
                listView1.Items[0].SubItems.Add(docdulieu[5].ToString());
                listView1.Items[0].SubItems.Add(docdulieu[6].ToString());
                listView1.Items[0].SubItems.Add(docdulieu[7].ToString());
                listView1.Items[0].SubItems.Add(docdulieu[8].ToString());
                listView1.Items[0].SubItems.Add(docdulieu[9].ToString());
                listView1.Items[0].SubItems.Add(docdulieu[4].ToString());
                listView1.Items[0].SubItems.Add(docdulieu[0].ToString());
                listView1.Items[0].SubItems.Add(docdulieu[10].ToString());
                listView1.Items[0].SubItems.Add(docdulieu[11].ToString());
                listView1.Items[0].SubItems.Add(docdulieu[12].ToString());
                listView1.Items[0].SubItems.Add(docdulieu[13].ToString());
                listView1.Items[0].SubItems.Add(docdulieu[14].ToString());
                listView1.Items[0].SubItems.Add(docdulieu[15].ToString());
                listView1.Items[0].SubItems.Add(docdulieu[16].ToString());
                listView1.Items[0].SubItems.Add(docdulieu[17].ToString());
                listView1.Items[0].SubItems.Add(docdulieu[18].ToString());
                listView1.Items[0].SubItems.Add(docdulieu[19].ToString());
            }
            else
            {
                MessageBox.Show("Không co du lieu");
            };   
            KetNoi.dongKetNoi();
        }

        private void QuanLyKhaiBao_Load(object sender, EventArgs e)
        {

        }

        private void thôngTinBảnKhaiBáoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            QuanLy f = new QuanLy();
            f.CMND = cmnd;
            f.HoTen = hoten;
            f.NamSinh = namsinh;
            f.GioiTinh = gioitinh;
            f.QuocTich = quoctich;
            f.TinhVN = tinhVN;
            f.HuyenVN = huyenVN;
            f.XaVN = xaVN;
            f.DiaChiCuTheVN = diachicutheVN;
            f.SDT = sdt;
            f.Email = email;
            f.DiChuyen = dichuyen;
            f.TinhDiChuyen = tinhdichuyen;
            f.HuyenDiChuyen = huyendichuyen;
            f.XaDiChuyen = xadichuyen;
            f.DiaChiCuTheDiChuyen = diachicuthedichuyen;
            f.DauHieuBenhLy = dauhieubenhly;
            f.TiepXucNguoiBenh = tiepxuxnguoibenh;
            f.TiepXucNuocCoCovid = tiepxucnuoccocovid;
            f.TiepXucNguoiCoBieuHien = tiepxucnguoicobieuhien;
            f.Show();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            hoten = listView1.SelectedItems[0].SubItems[0].Text;
            cmnd = listView1.SelectedItems[0].SubItems[9].Text;
            namsinh = listView1.SelectedItems[0].SubItems[1].Text;
            gioitinh = listView1.SelectedItems[0].SubItems[2].Text;
            quoctich = listView1.SelectedItems[0].SubItems[8].Text;
            tinhVN = listView1.SelectedItems[0].SubItems[3].Text;
            huyenVN = listView1.SelectedItems[0].SubItems[4].Text;
            xaVN = listView1.SelectedItems[0].SubItems[5].Text;
            diachicutheVN = listView1.SelectedItems[0].SubItems[6].Text;
            sdt = listView1.SelectedItems[0].SubItems[7].Text;
            email = listView1.SelectedItems[0].SubItems[10].Text;
            dichuyen = listView1.SelectedItems[0].SubItems[11].Text;
            tinhdichuyen = listView1.SelectedItems[0].SubItems[12].Text;
            huyendichuyen = listView1.SelectedItems[0].SubItems[13].Text;
            xadichuyen = listView1.SelectedItems[0].SubItems[14].Text;
            diachicuthedichuyen = listView1.SelectedItems[0].SubItems[15].Text;
            dauhieubenhly = listView1.SelectedItems[0].SubItems[16].Text;
            tiepxuxnguoibenh = listView1.SelectedItems[0].SubItems[17].Text;
            tiepxucnuoccocovid = listView1.SelectedItems[0].SubItems[18].Text;
            tiepxucnguoicobieuhien = listView1.SelectedItems[0].SubItems[19].Text;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DangKy frm = new DangKy();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            HeThong frm = new HeThong();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
