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
    public partial class QuanLy : Form
    {
        public QuanLy()
        {
            InitializeComponent();
        }

        public string HoTen;nè he
        public string CMND;
        public string NamSinh;
        public string GioiTinh;
        public string QuocTich;
        public string TinhVN;
        public string HuyenVN;
        public string XaVN;
        public string DiaChiCuTheVN;
        public string SDT;
        public string Email;
        public string DiChuyen;
        public string TinhDiChuyen;
        public string HuyenDiChuyen;
        public string XaDiChuyen;
        public string DiaChiCuTheDiChuyen;
        public string DauHieuBenhLy;
        public string TiepXucNguoiBenh;
        public string TiepXucNuocCoCovid;
        public string TiepXucNguoiCoBieuHien;

        public string ShowResult(Panel pn)
        {
            string ketqua = null;
            foreach (RadioButton rd in pn.Controls)
            {

                if (rd.Checked)
                {
                    ketqua = rd.Text;
                }
            }
            return ketqua;
        }

        private void btnGuiToKhai_Click_1(object sender, EventArgs e)
        {
            string sql = string.Format("Update KhaiBao set CMND = @CMND, HoTen = @HoTen, NamSinh = @NamSinh, GioiTinh = @GioiTinh, QuocTich = @QuocTich, TinhVN = @TinhVN, HuyenVN = @HuyenVN, XaVN = @XaVN, DiaChiCuTheVN = @DiaChiCuTheVN, SDT = @SDT, Email = @Email, DiChuyen = @DiChuyen, TinhDiChuyen = @TinhDiChuyen, HuyenDiChuyen = @HuyenDiChuyen, XaDiChuyen = @XaDiChuyen, DiaChiCuTheDiChuyen = @DiaChiCuTheDiChuyen, DauHieuBenhLy = @DauHieuBenhLy, TiepXucNguoiBenh = @TiepXucNguoiBenh, TiepXucNguoiNuocCoCovid = @TiepXucNguoiNuocCoCovid, TiepXucNguoiCoBieuHien = @TiepXucNguoiCoBieuHien where CMND ='{0}'", txtCMND.Text);
            string[] name = { "@CMND", "@HoTen", "@NamSinh", "@GioiTinh", "@QuocTich", "@TinhVN", "@HuyenVN", "@XaVN", "@DiaChiCuTheVN", "@SDT", "@Email", "@DiChuyen", "@TinhDiChuyen", "@HuyenDiChuyen", "@XaDiChuyen", "@DiaChiCuTheDiChuyen", "@DauHieuBenhLy", "@TiepXucNguoiBenh", "@TiepXucNguoiNuocCoCovid", "@TiepXucNguoiCoBieuHien" };
            string gt = ShowResult(panel2);
            string DiChuyen = ShowResult(panel7);
            string DauHieu = ShowResult(panel3);
            string TXNguoi = ShowResult(panel4);
            string TXNuoc = ShowResult(panel5);
            string TXBieuHien = ShowResult(panel6);
            object[] value = { txtCMND.Text, txtHoTen.Text, txtNamSinh.Text, gt, txtQuocTich.Text, txtTinh.Text, txtHuyen.Text, txtXa.Text, txtDiaChiCuThe.Text, txtSDT.Text, txtEmail.Text, DiChuyen, txtTinhDi.Text, txtHuyenDi.Text, txtXaDi.Text, txtDiaChiCuTheDi.Text, DauHieu, TXNguoi, TXNuoc, TXBieuHien };
            KetNoi.moKetNoi();
            try
            {
                KetNoi.updateData(sql, value, name, 20);
                MessageBox.Show("Cập nhật thành công!");
            }
            catch
            {
                MessageBox.Show("Cập nhật không thành công!");
            }
            KetNoi.dongKetNoi();
        }

        private void QuanLy_Load_1(object sender, EventArgs e)
        {
            txtHoTen.Text = HoTen;
            txtCMND.Text = CMND;
            txtNamSinh.Text = NamSinh;
            if (GioiTinh == "Nữ")
            {
                rdGioiTinhNu.Checked = true;
            }
            else
            {
                rdGioiTinhNam.Checked = true;
            }
            txtQuocTich.Text = QuocTich;
            txtTinh.Text = TinhVN;
            txtHuyen.Text = HuyenVN;
            txtXa.Text = XaVN;
            txtDiaChiCuThe.Text = DiaChiCuTheVN;
            txtSDT.Text = SDT;
            txtEmail.Text = Email;
            txtDiaChiCuTheDi.Text = DiaChiCuTheDiChuyen;
            if (DiChuyen == "Có")
            {
                rdCoDi.Checked = true;
            }
            else
            {
                rdKhongDi.Checked = true;
            }
            txtTinhDi.Text = TinhDiChuyen;
            txtHuyenDi.Text = HuyenDiChuyen;
            txtXaDi.Text = XaDiChuyen;
            if (DauHieuBenhLy == "Có")
            {
                rdCoDauHieu.Checked = true;
            }
            else
            {
                rdKhongCoDauHieu.Checked = true;
            }

            if (TiepXucNguoiBenh == "Có")
            {
                rdCoTXNguoiBenh.Checked = true;
            }
            else
            {
                rdKhongTXNguoiBenh.Checked = true;
            }

            if (TiepXucNuocCoCovid == "Có")
            {
                radioButton3.Checked = true;
            }
            else
            {
                radioButton5.Checked = true;
            }


            if (TiepXucNguoiCoBieuHien == "Có")
            {
                radioButton4.Checked = true;
            }
            else
            {
                radioButton6.Checked = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HeThong frm = new HeThong();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDangNhap frm = new FrmDangNhap();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}

