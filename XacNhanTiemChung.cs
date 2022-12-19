using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhaiBaoYTe
{
    public partial class XacNhanTiemChung : Form
    {
        private int TenMui;
        public XacNhanTiemChung(int TenMui)
        {
            KetNoi.moKetNoi();
            InitializeComponent();
            this.TenMui = TenMui;
            init();
            KetNoi.dongKetNoi();
        }

        private void init()
        {
            title.Text = "THÔNG TIN TIÊM VACCINE MŨI " + TenMui;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HeThong frm = new HeThong();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

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

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string sql = "Insert into TiemChungMui1 values (@CMND, @HoTen, @NamSinh, @GioiTinh, @QuocTich, @Tinh, @Huyen, @Xa, @DiaChi, @SDT, @Email, @TenVaccine, @NgayTiem, @DonViTiemChung)";
            string sql2 = "Insert into TiemChungMui2 values (@CMND, @HoTen, @NamSinh, @GioiTinh, @QuocTich, @Tinh, @Huyen, @Xa, @DiaChi, @SDT, @Email, @TenVaccine, @NgayTiem, @DonViTiemChung)";
            string sql3 = "Insert into TiemChungMui3 values (@CMND, @HoTen, @NamSinh, @GioiTinh, @QuocTich, @Tinh, @Huyen, @Xa, @DiaChi, @SDT, @Email, @TenVaccine, @NgayTiem, @DonViTiemChung)";
            string[] name = { "@CMND", "@HoTen", "@NamSinh", "@GioiTinh", "@QuocTich", "@Tinh", "@Huyen", "@Xa", "@DiaChi", "@SDT", "@Email", "@TenVaccine", "@NgayTiem", "@DonViTiemChung" };
            string gt = ShowResult(panel2);
            object[] value = { txtCMND.Text, txtHoTen.Text, txtNamSinh.Text, gt, txtQuocTich.Text, txtTinh.Text, txtHuyen.Text, txtXa.Text, txtDiaChiCuThe.Text, txtSDT.Text, txtEmail.Text, txtTenVaccine.Text, dtpNgayTiem.Value, txtDonVi.Text};
            KetNoi.moKetNoi();
            try
            {
                if (TenMui == 1)
                {
                    KetNoi.updateData(sql, value, name, 14);
                    MessageBox.Show("Khai báo thành công!");
                }
                if (TenMui == 2)
                {
                    string sql4 = string.Format("select CMND from TiemChungMui1 where CMND= '" + txtCMND.Text + "'");

                    if (KetNoi.check(sql4) == true)
                    {
                        KetNoi.updateData(sql2, value, name, 14);
                        MessageBox.Show("Khai báo thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Đối tượng chưa tiêm mũi 1! Cần tiêm mũi 1 trước khi tiêm mũi 2!");
                    }
                }
                if (TenMui == 3)
                {
                    string sql5 = string.Format("select CMND from TiemChungMui2 where CMND= '" + txtCMND.Text + "'");

                    if (KetNoi.check(sql5) == true)
                    {
                        KetNoi.updateData(sql3, value, name, 14);
                        MessageBox.Show("Khai báo thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Đối tượng chưa tiêm mũi 2! Cần tiêm mũi 1 trước khi tiêm mũi 3!");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Khai báo không thành công!");
            }
            KetNoi.dongKetNoi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = "";
            txtNamSinh.Text = "";
            txtCMND.Text = "";
            txtQuocTich.Text = "";
            rdGioiTinhNam.Checked = false;
            rdGioiTinhNu.Checked = false;
            txtTinh.Text = "";
            txtHuyen.Text = "";
            txtXa.Text = "";
            txtDiaChiCuThe.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            txtTenVaccine.Text = "";
            dtpNgayTiem.Text = "";
            txtDonVi.Text = "";
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
