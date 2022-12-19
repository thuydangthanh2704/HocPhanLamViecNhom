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
    public partial class QuanLyTiemChung : Form
    {
        private ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.IContainer components;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private DataGridView dataGridView3;
        private DataGridView dataGridView2;
        private GroupBox groupBox1;
        private Label label15;
        private RadioButton rdNu1;
        private RadioButton rdNam1;
        private DateTimePicker dtpNgayTiem1;
        private TextBox txtTenVaccine1;
        private TextBox txtDonViTiem1;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private TextBox txtTinh1;
        private TextBox txtDiaChi1;
        private TextBox txtXa1;
        private TextBox txtSDT1;
        private TextBox txtHuyen1;
        private Label label10;
        private TextBox txtHoTen1;
        private Label label9;
        private TextBox txtNamSinh1;
        private Label label8;
        private TextBox txtEmail1;
        private Label label7;
        private TextBox txtQuocTich1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnTimKiem1;
        private TextBox txtTimKiem1;
        private TextBox txtCMND1;
        private GroupBox groupBox3;
        private Button btnTimKiem3;
        private TextBox txtTimKiem3;
        private Label label31;
        private RadioButton rdNu3;
        private RadioButton rdNam3;
        private DateTimePicker dtpNgayTiem3;
        private TextBox txtTenVaccine3;
        private TextBox txtDonViTiem3;
        private Label label32;
        private Label label33;
        private Label label34;
        private Label label35;
        private TextBox txtTinh3;
        private TextBox txtDiaChi3;
        private TextBox txtXa3;
        private TextBox txtSDT3;
        private TextBox txtHuyen3;
        private Label label36;
        private TextBox txtHoTen3;
        private Label label37;
        private TextBox txtNamSinh3;
        private Label label38;
        private TextBox txtEmail3;
        private Label label39;
        private TextBox txtQuocTich3;
        private Label label40;
        private Label label41;
        private Label label42;
        private Label label43;
        private Label label44;
        private TextBox txtCMND3;
        private Label label45;
        private GroupBox groupBox2;
        private Button btnTimKiem2;
        private TextBox txtTimKiem2;
        private Label label16;
        private RadioButton rdNu2;
        private RadioButton rdNam2;
        private DateTimePicker dtpNgayTiem2;
        private TextBox txtTenVaccine2;
        private TextBox txtDonViTiem2;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private TextBox txtTinh2;
        private TextBox txtDiaChi2;
        private TextBox txtXa2;
        private TextBox txtSDT2;
        private TextBox txtHuyen2;
        private Label label21;
        private TextBox txtHoTen2;
        private Label label22;
        private TextBox txtNamSinh2;
        private Label label23;
        private TextBox txtEmail2;
        private Label label24;
        private TextBox txtQuocTich2;
        private Label label25;
        private Label label26;
        private Label label27;
        private Label label28;
        private Label label29;
        private TextBox txtCMND2;
        private Label label30;
        private TabPage tabPage4;
        private Label label46;
        private Label label48;
        private Label label47;
        private Button btnTK;
        private TextBox txtTK;
        private Label label52;
        private Label lblMui3;
        private Label lblMui2;
        private Label lblMui1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private ToolStripMenuItem tiêmChủngMũi1ToolStripMenuItem;

        public QuanLyTiemChung()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tiêmChủngMũi1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem1 = new System.Windows.Forms.Button();
            this.txtTimKiem1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.rdNu1 = new System.Windows.Forms.RadioButton();
            this.rdNam1 = new System.Windows.Forms.RadioButton();
            this.dtpNgayTiem1 = new System.Windows.Forms.DateTimePicker();
            this.txtTenVaccine1 = new System.Windows.Forms.TextBox();
            this.txtDonViTiem1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTinh1 = new System.Windows.Forms.TextBox();
            this.txtDiaChi1 = new System.Windows.Forms.TextBox();
            this.txtXa1 = new System.Windows.Forms.TextBox();
            this.txtSDT1 = new System.Windows.Forms.TextBox();
            this.txtHuyen1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtHoTen1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNamSinh1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQuocTich1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCMND1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem2 = new System.Windows.Forms.Button();
            this.txtTimKiem2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.rdNu2 = new System.Windows.Forms.RadioButton();
            this.rdNam2 = new System.Windows.Forms.RadioButton();
            this.dtpNgayTiem2 = new System.Windows.Forms.DateTimePicker();
            this.txtTenVaccine2 = new System.Windows.Forms.TextBox();
            this.txtDonViTiem2 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtTinh2 = new System.Windows.Forms.TextBox();
            this.txtDiaChi2 = new System.Windows.Forms.TextBox();
            this.txtXa2 = new System.Windows.Forms.TextBox();
            this.txtSDT2 = new System.Windows.Forms.TextBox();
            this.txtHuyen2 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtHoTen2 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtNamSinh2 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtEmail2 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtQuocTich2 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.txtCMND2 = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem3 = new System.Windows.Forms.Button();
            this.txtTimKiem3 = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.rdNu3 = new System.Windows.Forms.RadioButton();
            this.rdNam3 = new System.Windows.Forms.RadioButton();
            this.dtpNgayTiem3 = new System.Windows.Forms.DateTimePicker();
            this.txtTenVaccine3 = new System.Windows.Forms.TextBox();
            this.txtDonViTiem3 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.txtTinh3 = new System.Windows.Forms.TextBox();
            this.txtDiaChi3 = new System.Windows.Forms.TextBox();
            this.txtXa3 = new System.Windows.Forms.TextBox();
            this.txtSDT3 = new System.Windows.Forms.TextBox();
            this.txtHuyen3 = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.txtHoTen3 = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.txtNamSinh3 = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.txtEmail3 = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.txtQuocTich3 = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.txtCMND3 = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnTK = new System.Windows.Forms.Button();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.lblMui3 = new System.Windows.Forms.Label();
            this.lblMui2 = new System.Windows.Forms.Label();
            this.lblMui1 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiêmChủngMũi1ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(219, 30);
            // 
            // tiêmChủngMũi1ToolStripMenuItem
            // 
            this.tiêmChủngMũi1ToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiêmChủngMũi1ToolStripMenuItem.Name = "tiêmChủngMũi1ToolStripMenuItem";
            this.tiêmChủngMũi1ToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.tiêmChủngMũi1ToolStripMenuItem.Text = "Tiêm chủng mũi 1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(4, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1769, 670);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1761, 635);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tiêm chủng mũi 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.btnTimKiem1);
            this.groupBox1.Controls.Add(this.txtTimKiem1);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.rdNu1);
            this.groupBox1.Controls.Add(this.rdNam1);
            this.groupBox1.Controls.Add(this.dtpNgayTiem1);
            this.groupBox1.Controls.Add(this.txtTenVaccine1);
            this.groupBox1.Controls.Add(this.txtDonViTiem1);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtTinh1);
            this.groupBox1.Controls.Add(this.txtDiaChi1);
            this.groupBox1.Controls.Add(this.txtXa1);
            this.groupBox1.Controls.Add(this.txtSDT1);
            this.groupBox1.Controls.Add(this.txtHuyen1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtHoTen1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtNamSinh1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtEmail1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtQuocTich1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCMND1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 336);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1749, 291);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // btnTimKiem1
            // 
            this.btnTimKiem1.Location = new System.Drawing.Point(922, 17);
            this.btnTimKiem1.Name = "btnTimKiem1";
            this.btnTimKiem1.Size = new System.Drawing.Size(114, 35);
            this.btnTimKiem1.TabIndex = 31;
            this.btnTimKiem1.Text = "Tìm kiếm";
            this.btnTimKiem1.UseVisualStyleBackColor = true;
            this.btnTimKiem1.Click += new System.EventHandler(this.btnTimKiem1_Click);
            // 
            // txtTimKiem1
            // 
            this.txtTimKiem1.Location = new System.Drawing.Point(501, 20);
            this.txtTimKiem1.Name = "txtTimKiem1";
            this.txtTimKiem1.Size = new System.Drawing.Size(385, 34);
            this.txtTimKiem1.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(368, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 27);
            this.label15.TabIndex = 29;
            this.label15.Text = "Tìm kiếm";
            // 
            // rdNu1
            // 
            this.rdNu1.AutoSize = true;
            this.rdNu1.Location = new System.Drawing.Point(324, 204);
            this.rdNu1.Name = "rdNu1";
            this.rdNu1.Size = new System.Drawing.Size(63, 31);
            this.rdNu1.TabIndex = 28;
            this.rdNu1.TabStop = true;
            this.rdNu1.Text = "Nữ";
            this.rdNu1.UseVisualStyleBackColor = true;
            // 
            // rdNam1
            // 
            this.rdNam1.AutoSize = true;
            this.rdNam1.Location = new System.Drawing.Point(167, 204);
            this.rdNam1.Name = "rdNam1";
            this.rdNam1.Size = new System.Drawing.Size(79, 31);
            this.rdNam1.TabIndex = 27;
            this.rdNam1.TabStop = true;
            this.rdNam1.Text = "Nam";
            this.rdNam1.UseVisualStyleBackColor = true;
            // 
            // dtpNgayTiem1
            // 
            this.dtpNgayTiem1.Location = new System.Drawing.Point(1217, 168);
            this.dtpNgayTiem1.Name = "dtpNgayTiem1";
            this.dtpNgayTiem1.Size = new System.Drawing.Size(409, 34);
            this.dtpNgayTiem1.TabIndex = 26;
            // 
            // txtTenVaccine1
            // 
            this.txtTenVaccine1.Location = new System.Drawing.Point(1217, 125);
            this.txtTenVaccine1.Name = "txtTenVaccine1";
            this.txtTenVaccine1.Size = new System.Drawing.Size(220, 34);
            this.txtTenVaccine1.TabIndex = 25;
            // 
            // txtDonViTiem1
            // 
            this.txtDonViTiem1.Location = new System.Drawing.Point(1217, 208);
            this.txtDonViTiem1.Name = "txtDonViTiem1";
            this.txtDonViTiem1.Size = new System.Drawing.Size(220, 34);
            this.txtDonViTiem1.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1082, 208);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(126, 27);
            this.label14.TabIndex = 23;
            this.label14.Text = "Đơn vị tiêm";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1082, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 27);
            this.label13.TabIndex = 22;
            this.label13.Text = "Email";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1082, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 27);
            this.label12.TabIndex = 21;
            this.label12.Text = "Tên Vaccine";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1082, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 27);
            this.label11.TabIndex = 20;
            this.label11.Text = "Ngày tiêm";
            // 
            // txtTinh1
            // 
            this.txtTinh1.Location = new System.Drawing.Point(727, 71);
            this.txtTinh1.Name = "txtTinh1";
            this.txtTinh1.Size = new System.Drawing.Size(220, 34);
            this.txtTinh1.TabIndex = 19;
            // 
            // txtDiaChi1
            // 
            this.txtDiaChi1.Location = new System.Drawing.Point(727, 201);
            this.txtDiaChi1.Name = "txtDiaChi1";
            this.txtDiaChi1.Size = new System.Drawing.Size(220, 34);
            this.txtDiaChi1.TabIndex = 18;
            // 
            // txtXa1
            // 
            this.txtXa1.Location = new System.Drawing.Point(727, 159);
            this.txtXa1.Name = "txtXa1";
            this.txtXa1.Size = new System.Drawing.Size(220, 34);
            this.txtXa1.TabIndex = 17;
            // 
            // txtSDT1
            // 
            this.txtSDT1.Location = new System.Drawing.Point(727, 241);
            this.txtSDT1.Name = "txtSDT1";
            this.txtSDT1.Size = new System.Drawing.Size(220, 34);
            this.txtSDT1.TabIndex = 16;
            // 
            // txtHuyen1
            // 
            this.txtHuyen1.Location = new System.Drawing.Point(727, 118);
            this.txtHuyen1.Name = "txtHuyen1";
            this.txtHuyen1.Size = new System.Drawing.Size(220, 34);
            this.txtHuyen1.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(575, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 27);
            this.label10.TabIndex = 14;
            this.label10.Text = "Huyện";
            // 
            // txtHoTen1
            // 
            this.txtHoTen1.Location = new System.Drawing.Point(167, 114);
            this.txtHoTen1.Name = "txtHoTen1";
            this.txtHoTen1.Size = new System.Drawing.Size(363, 34);
            this.txtHoTen1.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(576, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 27);
            this.label9.TabIndex = 12;
            this.label9.Text = "Xã";
            // 
            // txtNamSinh1
            // 
            this.txtNamSinh1.Location = new System.Drawing.Point(167, 159);
            this.txtNamSinh1.Name = "txtNamSinh1";
            this.txtNamSinh1.Size = new System.Drawing.Size(220, 34);
            this.txtNamSinh1.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(575, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 27);
            this.label8.TabIndex = 10;
            this.label8.Text = "Địa chỉ cụ thể";
            // 
            // txtEmail1
            // 
            this.txtEmail1.Location = new System.Drawing.Point(1217, 78);
            this.txtEmail1.Name = "txtEmail1";
            this.txtEmail1.Size = new System.Drawing.Size(409, 34);
            this.txtEmail1.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(575, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 27);
            this.label7.TabIndex = 8;
            this.label7.Text = "SĐT";
            // 
            // txtQuocTich1
            // 
            this.txtQuocTich1.Location = new System.Drawing.Point(167, 244);
            this.txtQuocTich1.Name = "txtQuocTich1";
            this.txtQuocTich1.Size = new System.Drawing.Size(220, 34);
            this.txtQuocTich1.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 27);
            this.label6.TabIndex = 6;
            this.label6.Text = "Họ Tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 27);
            this.label5.TabIndex = 5;
            this.label5.Text = "Năm Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giới Tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quốc tịch";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(575, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tỉnh";
            // 
            // txtCMND1
            // 
            this.txtCMND1.Location = new System.Drawing.Point(167, 71);
            this.txtCMND1.Name = "txtCMND1";
            this.txtCMND1.Size = new System.Drawing.Size(220, 34);
            this.txtCMND1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "CMND/CCCD";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14});
            this.dataGridView1.Location = new System.Drawing.Point(3, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 70;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1752, 324);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CMND";
            this.Column1.HeaderText = "CMND/CCCD";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "HoTen";
            this.Column2.HeaderText = "Họ Tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NamSinh";
            this.Column3.HeaderText = "Năm Sinh";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 117;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "GioiTinh";
            this.Column4.HeaderText = "Giới Tính";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 117;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "QuocTich";
            this.Column5.HeaderText = "Quốc Tịch";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Tinh";
            this.Column6.HeaderText = "Tỉnh";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 110;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Huyen";
            this.Column7.HeaderText = "Huyện";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 110;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Xa";
            this.Column8.HeaderText = "Xã";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 110;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "DiaChi";
            this.Column9.HeaderText = "Địa chỉ cụ thể";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "SDT";
            this.Column10.HeaderText = "SĐT";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 125;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "Email";
            this.Column11.HeaderText = "Email";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Width = 125;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "TenVaccine";
            this.Column12.HeaderText = "Tên Vaccine";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.Width = 125;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "NgayTiem";
            this.Column13.HeaderText = "Ngày tiêm";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            this.Column13.Width = 125;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "DonViTiemChung";
            this.Column14.HeaderText = "Đơn vị tiêm chủng";
            this.Column14.MinimumWidth = 6;
            this.Column14.Name = "Column14";
            this.Column14.Width = 125;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1761, 635);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tiêm chủng mũi 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.btnTimKiem2);
            this.groupBox2.Controls.Add(this.txtTimKiem2);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.rdNu2);
            this.groupBox2.Controls.Add(this.rdNam2);
            this.groupBox2.Controls.Add(this.dtpNgayTiem2);
            this.groupBox2.Controls.Add(this.txtTenVaccine2);
            this.groupBox2.Controls.Add(this.txtDonViTiem2);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.txtTinh2);
            this.groupBox2.Controls.Add(this.txtDiaChi2);
            this.groupBox2.Controls.Add(this.txtXa2);
            this.groupBox2.Controls.Add(this.txtSDT2);
            this.groupBox2.Controls.Add(this.txtHuyen2);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.txtHoTen2);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.txtNamSinh2);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.txtEmail2);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.txtQuocTich2);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Controls.Add(this.label29);
            this.groupBox2.Controls.Add(this.txtCMND2);
            this.groupBox2.Controls.Add(this.label30);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 339);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1749, 291);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // btnTimKiem2
            // 
            this.btnTimKiem2.Location = new System.Drawing.Point(922, 17);
            this.btnTimKiem2.Name = "btnTimKiem2";
            this.btnTimKiem2.Size = new System.Drawing.Size(114, 35);
            this.btnTimKiem2.TabIndex = 31;
            this.btnTimKiem2.Text = "Tìm kiếm";
            this.btnTimKiem2.UseVisualStyleBackColor = true;
            this.btnTimKiem2.Click += new System.EventHandler(this.btnTimKiem2_Click);
            // 
            // txtTimKiem2
            // 
            this.txtTimKiem2.Location = new System.Drawing.Point(501, 20);
            this.txtTimKiem2.Name = "txtTimKiem2";
            this.txtTimKiem2.Size = new System.Drawing.Size(385, 34);
            this.txtTimKiem2.TabIndex = 30;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(368, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 27);
            this.label16.TabIndex = 29;
            this.label16.Text = "Tìm kiếm";
            // 
            // rdNu2
            // 
            this.rdNu2.AutoSize = true;
            this.rdNu2.Location = new System.Drawing.Point(324, 204);
            this.rdNu2.Name = "rdNu2";
            this.rdNu2.Size = new System.Drawing.Size(63, 31);
            this.rdNu2.TabIndex = 28;
            this.rdNu2.TabStop = true;
            this.rdNu2.Text = "Nữ";
            this.rdNu2.UseVisualStyleBackColor = true;
            // 
            // rdNam2
            // 
            this.rdNam2.AutoSize = true;
            this.rdNam2.Location = new System.Drawing.Point(167, 204);
            this.rdNam2.Name = "rdNam2";
            this.rdNam2.Size = new System.Drawing.Size(79, 31);
            this.rdNam2.TabIndex = 27;
            this.rdNam2.TabStop = true;
            this.rdNam2.Text = "Nam";
            this.rdNam2.UseVisualStyleBackColor = true;
            // 
            // dtpNgayTiem2
            // 
            this.dtpNgayTiem2.Location = new System.Drawing.Point(1217, 168);
            this.dtpNgayTiem2.Name = "dtpNgayTiem2";
            this.dtpNgayTiem2.Size = new System.Drawing.Size(409, 34);
            this.dtpNgayTiem2.TabIndex = 26;
            // 
            // txtTenVaccine2
            // 
            this.txtTenVaccine2.Location = new System.Drawing.Point(1217, 125);
            this.txtTenVaccine2.Name = "txtTenVaccine2";
            this.txtTenVaccine2.Size = new System.Drawing.Size(220, 34);
            this.txtTenVaccine2.TabIndex = 25;
            // 
            // txtDonViTiem2
            // 
            this.txtDonViTiem2.Location = new System.Drawing.Point(1217, 208);
            this.txtDonViTiem2.Name = "txtDonViTiem2";
            this.txtDonViTiem2.Size = new System.Drawing.Size(220, 34);
            this.txtDonViTiem2.TabIndex = 24;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1082, 208);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(126, 27);
            this.label17.TabIndex = 23;
            this.label17.Text = "Đơn vị tiêm";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1082, 81);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 27);
            this.label18.TabIndex = 22;
            this.label18.Text = "Email";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(1082, 125);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(130, 27);
            this.label19.TabIndex = 21;
            this.label19.Text = "Tên Vaccine";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(1082, 166);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(111, 27);
            this.label20.TabIndex = 20;
            this.label20.Text = "Ngày tiêm";
            // 
            // txtTinh2
            // 
            this.txtTinh2.Location = new System.Drawing.Point(727, 71);
            this.txtTinh2.Name = "txtTinh2";
            this.txtTinh2.Size = new System.Drawing.Size(220, 34);
            this.txtTinh2.TabIndex = 19;
            // 
            // txtDiaChi2
            // 
            this.txtDiaChi2.Location = new System.Drawing.Point(727, 201);
            this.txtDiaChi2.Name = "txtDiaChi2";
            this.txtDiaChi2.Size = new System.Drawing.Size(220, 34);
            this.txtDiaChi2.TabIndex = 18;
            // 
            // txtXa2
            // 
            this.txtXa2.Location = new System.Drawing.Point(727, 159);
            this.txtXa2.Name = "txtXa2";
            this.txtXa2.Size = new System.Drawing.Size(220, 34);
            this.txtXa2.TabIndex = 17;
            // 
            // txtSDT2
            // 
            this.txtSDT2.Location = new System.Drawing.Point(727, 241);
            this.txtSDT2.Name = "txtSDT2";
            this.txtSDT2.Size = new System.Drawing.Size(220, 34);
            this.txtSDT2.TabIndex = 16;
            // 
            // txtHuyen2
            // 
            this.txtHuyen2.Location = new System.Drawing.Point(727, 118);
            this.txtHuyen2.Name = "txtHuyen2";
            this.txtHuyen2.Size = new System.Drawing.Size(220, 34);
            this.txtHuyen2.TabIndex = 15;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(575, 117);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(76, 27);
            this.label21.TabIndex = 14;
            this.label21.Text = "Huyện";
            // 
            // txtHoTen2
            // 
            this.txtHoTen2.Location = new System.Drawing.Point(167, 114);
            this.txtHoTen2.Name = "txtHoTen2";
            this.txtHoTen2.Size = new System.Drawing.Size(363, 34);
            this.txtHoTen2.TabIndex = 13;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(576, 159);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(40, 27);
            this.label22.TabIndex = 12;
            this.label22.Text = "Xã";
            // 
            // txtNamSinh2
            // 
            this.txtNamSinh2.Location = new System.Drawing.Point(167, 159);
            this.txtNamSinh2.Name = "txtNamSinh2";
            this.txtNamSinh2.Size = new System.Drawing.Size(220, 34);
            this.txtNamSinh2.TabIndex = 11;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(575, 193);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(146, 27);
            this.label23.TabIndex = 10;
            this.label23.Text = "Địa chỉ cụ thể";
            // 
            // txtEmail2
            // 
            this.txtEmail2.Location = new System.Drawing.Point(1217, 78);
            this.txtEmail2.Name = "txtEmail2";
            this.txtEmail2.Size = new System.Drawing.Size(409, 34);
            this.txtEmail2.TabIndex = 9;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(575, 233);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(55, 27);
            this.label24.TabIndex = 8;
            this.label24.Text = "SĐT";
            // 
            // txtQuocTich2
            // 
            this.txtQuocTich2.Location = new System.Drawing.Point(167, 244);
            this.txtQuocTich2.Name = "txtQuocTich2";
            this.txtQuocTich2.Size = new System.Drawing.Size(220, 34);
            this.txtQuocTich2.TabIndex = 7;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 121);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(84, 27);
            this.label25.TabIndex = 6;
            this.label25.Text = "Họ Tên";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 166);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(106, 27);
            this.label26.TabIndex = 5;
            this.label26.Text = "Năm Sinh";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(8, 208);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(104, 27);
            this.label27.TabIndex = 4;
            this.label27.Text = "Giới Tính";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 251);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(106, 27);
            this.label28.TabIndex = 3;
            this.label28.Text = "Quốc tịch";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(575, 78);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(56, 27);
            this.label29.TabIndex = 2;
            this.label29.Text = "Tỉnh";
            // 
            // txtCMND2
            // 
            this.txtCMND2.Location = new System.Drawing.Point(167, 71);
            this.txtCMND2.Name = "txtCMND2";
            this.txtCMND2.Size = new System.Drawing.Size(220, 34);
            this.txtCMND2.TabIndex = 1;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(6, 78);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(155, 27);
            this.label30.TabIndex = 0;
            this.label30.Text = "CMND/CCCD";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.dataGridView2.Location = new System.Drawing.Point(4, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 70;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1752, 327);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CMND";
            this.dataGridViewTextBoxColumn1.HeaderText = "CMND/CCCD";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 130;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HoTen";
            this.dataGridViewTextBoxColumn2.HeaderText = "Họ Tên";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NamSinh";
            this.dataGridViewTextBoxColumn3.HeaderText = "Năm Sinh";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 117;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "GioiTinh";
            this.dataGridViewTextBoxColumn4.HeaderText = "Giới Tính";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 117;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "QuocTich";
            this.dataGridViewTextBoxColumn5.HeaderText = "Quốc Tịch";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Tinh";
            this.dataGridViewTextBoxColumn6.HeaderText = "Tỉnh";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 110;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Huyen";
            this.dataGridViewTextBoxColumn7.HeaderText = "Huyện";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 110;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Xa";
            this.dataGridViewTextBoxColumn8.HeaderText = "Xã";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 110;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "DiaChi";
            this.dataGridViewTextBoxColumn9.HeaderText = "Địa chỉ cụ thể";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "SDT";
            this.dataGridViewTextBoxColumn10.HeaderText = "SĐT";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn11.HeaderText = "Email";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "TenVaccine";
            this.dataGridViewTextBoxColumn12.HeaderText = "Tên Vaccine";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "NgayTiem";
            this.dataGridViewTextBoxColumn13.HeaderText = "Ngày tiêm";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "DonViTiemChung";
            this.dataGridViewTextBoxColumn14.HeaderText = "Đơn vị tiêm chủng";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 125;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1761, 635);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tiêm chủng mũi 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox3.Controls.Add(this.btnTimKiem3);
            this.groupBox3.Controls.Add(this.txtTimKiem3);
            this.groupBox3.Controls.Add(this.label31);
            this.groupBox3.Controls.Add(this.rdNu3);
            this.groupBox3.Controls.Add(this.rdNam3);
            this.groupBox3.Controls.Add(this.dtpNgayTiem3);
            this.groupBox3.Controls.Add(this.txtTenVaccine3);
            this.groupBox3.Controls.Add(this.txtDonViTiem3);
            this.groupBox3.Controls.Add(this.label32);
            this.groupBox3.Controls.Add(this.label33);
            this.groupBox3.Controls.Add(this.label34);
            this.groupBox3.Controls.Add(this.label35);
            this.groupBox3.Controls.Add(this.txtTinh3);
            this.groupBox3.Controls.Add(this.txtDiaChi3);
            this.groupBox3.Controls.Add(this.txtXa3);
            this.groupBox3.Controls.Add(this.txtSDT3);
            this.groupBox3.Controls.Add(this.txtHuyen3);
            this.groupBox3.Controls.Add(this.label36);
            this.groupBox3.Controls.Add(this.txtHoTen3);
            this.groupBox3.Controls.Add(this.label37);
            this.groupBox3.Controls.Add(this.txtNamSinh3);
            this.groupBox3.Controls.Add(this.label38);
            this.groupBox3.Controls.Add(this.txtEmail3);
            this.groupBox3.Controls.Add(this.label39);
            this.groupBox3.Controls.Add(this.txtQuocTich3);
            this.groupBox3.Controls.Add(this.label40);
            this.groupBox3.Controls.Add(this.label41);
            this.groupBox3.Controls.Add(this.label42);
            this.groupBox3.Controls.Add(this.label43);
            this.groupBox3.Controls.Add(this.label44);
            this.groupBox3.Controls.Add(this.txtCMND3);
            this.groupBox3.Controls.Add(this.label45);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(4, 336);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1749, 291);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin";
            // 
            // btnTimKiem3
            // 
            this.btnTimKiem3.Location = new System.Drawing.Point(922, 17);
            this.btnTimKiem3.Name = "btnTimKiem3";
            this.btnTimKiem3.Size = new System.Drawing.Size(114, 35);
            this.btnTimKiem3.TabIndex = 31;
            this.btnTimKiem3.Text = "Tìm kiếm";
            this.btnTimKiem3.UseVisualStyleBackColor = true;
            this.btnTimKiem3.Click += new System.EventHandler(this.btnTimKiem3_Click);
            // 
            // txtTimKiem3
            // 
            this.txtTimKiem3.Location = new System.Drawing.Point(501, 20);
            this.txtTimKiem3.Name = "txtTimKiem3";
            this.txtTimKiem3.Size = new System.Drawing.Size(385, 34);
            this.txtTimKiem3.TabIndex = 30;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(368, 23);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(103, 27);
            this.label31.TabIndex = 29;
            this.label31.Text = "Tìm kiếm";
            // 
            // rdNu3
            // 
            this.rdNu3.AutoSize = true;
            this.rdNu3.Location = new System.Drawing.Point(324, 204);
            this.rdNu3.Name = "rdNu3";
            this.rdNu3.Size = new System.Drawing.Size(63, 31);
            this.rdNu3.TabIndex = 28;
            this.rdNu3.TabStop = true;
            this.rdNu3.Text = "Nữ";
            this.rdNu3.UseVisualStyleBackColor = true;
            // 
            // rdNam3
            // 
            this.rdNam3.AutoSize = true;
            this.rdNam3.Location = new System.Drawing.Point(167, 204);
            this.rdNam3.Name = "rdNam3";
            this.rdNam3.Size = new System.Drawing.Size(79, 31);
            this.rdNam3.TabIndex = 27;
            this.rdNam3.TabStop = true;
            this.rdNam3.Text = "Nam";
            this.rdNam3.UseVisualStyleBackColor = true;
            // 
            // dtpNgayTiem3
            // 
            this.dtpNgayTiem3.Location = new System.Drawing.Point(1217, 168);
            this.dtpNgayTiem3.Name = "dtpNgayTiem3";
            this.dtpNgayTiem3.Size = new System.Drawing.Size(409, 34);
            this.dtpNgayTiem3.TabIndex = 26;
            // 
            // txtTenVaccine3
            // 
            this.txtTenVaccine3.Location = new System.Drawing.Point(1217, 125);
            this.txtTenVaccine3.Name = "txtTenVaccine3";
            this.txtTenVaccine3.Size = new System.Drawing.Size(409, 34);
            this.txtTenVaccine3.TabIndex = 25;
            // 
            // txtDonViTiem3
            // 
            this.txtDonViTiem3.Location = new System.Drawing.Point(1217, 208);
            this.txtDonViTiem3.Name = "txtDonViTiem3";
            this.txtDonViTiem3.Size = new System.Drawing.Size(220, 34);
            this.txtDonViTiem3.TabIndex = 24;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(1082, 208);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(126, 27);
            this.label32.TabIndex = 23;
            this.label32.Text = "Đơn vị tiêm";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(1082, 81);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(68, 27);
            this.label33.TabIndex = 22;
            this.label33.Text = "Email";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(1082, 125);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(130, 27);
            this.label34.TabIndex = 21;
            this.label34.Text = "Tên Vaccine";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(1082, 166);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(111, 27);
            this.label35.TabIndex = 20;
            this.label35.Text = "Ngày tiêm";
            // 
            // txtTinh3
            // 
            this.txtTinh3.Location = new System.Drawing.Point(727, 71);
            this.txtTinh3.Name = "txtTinh3";
            this.txtTinh3.Size = new System.Drawing.Size(220, 34);
            this.txtTinh3.TabIndex = 19;
            // 
            // txtDiaChi3
            // 
            this.txtDiaChi3.Location = new System.Drawing.Point(727, 201);
            this.txtDiaChi3.Name = "txtDiaChi3";
            this.txtDiaChi3.Size = new System.Drawing.Size(220, 34);
            this.txtDiaChi3.TabIndex = 18;
            // 
            // txtXa3
            // 
            this.txtXa3.Location = new System.Drawing.Point(727, 159);
            this.txtXa3.Name = "txtXa3";
            this.txtXa3.Size = new System.Drawing.Size(220, 34);
            this.txtXa3.TabIndex = 17;
            // 
            // txtSDT3
            // 
            this.txtSDT3.Location = new System.Drawing.Point(727, 241);
            this.txtSDT3.Name = "txtSDT3";
            this.txtSDT3.Size = new System.Drawing.Size(220, 34);
            this.txtSDT3.TabIndex = 16;
            // 
            // txtHuyen3
            // 
            this.txtHuyen3.Location = new System.Drawing.Point(727, 118);
            this.txtHuyen3.Name = "txtHuyen3";
            this.txtHuyen3.Size = new System.Drawing.Size(220, 34);
            this.txtHuyen3.TabIndex = 15;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(575, 117);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(76, 27);
            this.label36.TabIndex = 14;
            this.label36.Text = "Huyện";
            // 
            // txtHoTen3
            // 
            this.txtHoTen3.Location = new System.Drawing.Point(167, 114);
            this.txtHoTen3.Name = "txtHoTen3";
            this.txtHoTen3.Size = new System.Drawing.Size(363, 34);
            this.txtHoTen3.TabIndex = 13;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(576, 159);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(40, 27);
            this.label37.TabIndex = 12;
            this.label37.Text = "Xã";
            // 
            // txtNamSinh3
            // 
            this.txtNamSinh3.Location = new System.Drawing.Point(167, 159);
            this.txtNamSinh3.Name = "txtNamSinh3";
            this.txtNamSinh3.Size = new System.Drawing.Size(220, 34);
            this.txtNamSinh3.TabIndex = 11;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(575, 203);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(146, 27);
            this.label38.TabIndex = 10;
            this.label38.Text = "Địa chỉ cụ thể";
            // 
            // txtEmail3
            // 
            this.txtEmail3.Location = new System.Drawing.Point(1217, 78);
            this.txtEmail3.Name = "txtEmail3";
            this.txtEmail3.Size = new System.Drawing.Size(409, 34);
            this.txtEmail3.TabIndex = 9;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(575, 241);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(55, 27);
            this.label39.TabIndex = 8;
            this.label39.Text = "SĐT";
            // 
            // txtQuocTich3
            // 
            this.txtQuocTich3.Location = new System.Drawing.Point(167, 244);
            this.txtQuocTich3.Name = "txtQuocTich3";
            this.txtQuocTich3.Size = new System.Drawing.Size(220, 34);
            this.txtQuocTich3.TabIndex = 7;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(6, 121);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(84, 27);
            this.label40.TabIndex = 6;
            this.label40.Text = "Họ Tên";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(6, 166);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(106, 27);
            this.label41.TabIndex = 5;
            this.label41.Text = "Năm Sinh";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(8, 208);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(104, 27);
            this.label42.TabIndex = 4;
            this.label42.Text = "Giới Tính";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(6, 251);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(106, 27);
            this.label43.TabIndex = 3;
            this.label43.Text = "Quốc tịch";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(575, 78);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(56, 27);
            this.label44.TabIndex = 2;
            this.label44.Text = "Tỉnh";
            // 
            // txtCMND3
            // 
            this.txtCMND3.Location = new System.Drawing.Point(167, 71);
            this.txtCMND3.Name = "txtCMND3";
            this.txtCMND3.Size = new System.Drawing.Size(220, 34);
            this.txtCMND3.TabIndex = 1;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(6, 78);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(155, 27);
            this.label45.TabIndex = 0;
            this.label45.Text = "CMND/CCCD";
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28});
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 70;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(1752, 324);
            this.dataGridView3.TabIndex = 1;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "CMND";
            this.dataGridViewTextBoxColumn15.HeaderText = "CMND/CCCD";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 130;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "HoTen";
            this.dataGridViewTextBoxColumn16.HeaderText = "Họ Tên";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 125;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "NamSinh";
            this.dataGridViewTextBoxColumn17.HeaderText = "Năm Sinh";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 117;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "GioiTinh";
            this.dataGridViewTextBoxColumn18.HeaderText = "Giới Tính";
            this.dataGridViewTextBoxColumn18.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Width = 117;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "QuocTich";
            this.dataGridViewTextBoxColumn19.HeaderText = "Quốc Tịch";
            this.dataGridViewTextBoxColumn19.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.Width = 125;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Tinh";
            this.dataGridViewTextBoxColumn20.HeaderText = "Tỉnh";
            this.dataGridViewTextBoxColumn20.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.Width = 110;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Huyen";
            this.dataGridViewTextBoxColumn21.HeaderText = "Huyện";
            this.dataGridViewTextBoxColumn21.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.Width = 110;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Xa";
            this.dataGridViewTextBoxColumn22.HeaderText = "Xã";
            this.dataGridViewTextBoxColumn22.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.Width = 110;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "DiaChi";
            this.dataGridViewTextBoxColumn23.HeaderText = "Địa chỉ cụ thể";
            this.dataGridViewTextBoxColumn23.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.Width = 125;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "SDT";
            this.dataGridViewTextBoxColumn24.HeaderText = "SĐT";
            this.dataGridViewTextBoxColumn24.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.Width = 125;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn25.HeaderText = "Email";
            this.dataGridViewTextBoxColumn25.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.Width = 125;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "TenVaccine";
            this.dataGridViewTextBoxColumn26.HeaderText = "Tên Vaccine";
            this.dataGridViewTextBoxColumn26.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.Width = 125;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "NgayTiem";
            this.dataGridViewTextBoxColumn27.HeaderText = "Ngày tiêm";
            this.dataGridViewTextBoxColumn27.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.Width = 125;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "DonViTiemChung";
            this.dataGridViewTextBoxColumn28.HeaderText = "Đơn vị tiêm chủng";
            this.dataGridViewTextBoxColumn28.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.Width = 125;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnTK);
            this.tabPage4.Controls.Add(this.txtTK);
            this.tabPage4.Controls.Add(this.label52);
            this.tabPage4.Controls.Add(this.lblMui3);
            this.tabPage4.Controls.Add(this.lblMui2);
            this.tabPage4.Controls.Add(this.lblMui1);
            this.tabPage4.Controls.Add(this.label48);
            this.tabPage4.Controls.Add(this.label47);
            this.tabPage4.Controls.Add(this.label46);
            this.tabPage4.Location = new System.Drawing.Point(4, 31);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1761, 635);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Thống kê";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnTK
            // 
            this.btnTK.BackColor = System.Drawing.Color.Teal;
            this.btnTK.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTK.Location = new System.Drawing.Point(924, 68);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(75, 47);
            this.btnTK.TabIndex = 8;
            this.btnTK.Text = "=>";
            this.btnTK.UseVisualStyleBackColor = false;
            // 
            // txtTK
            // 
            this.txtTK.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTK.Location = new System.Drawing.Point(604, 75);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(295, 34);
            this.txtTK.TabIndex = 7;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.Location = new System.Drawing.Point(448, 80);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(150, 27);
            this.label52.TabIndex = 6;
            this.label52.Text = "Thống kê theo";
            // 
            // lblMui3
            // 
            this.lblMui3.AutoSize = true;
            this.lblMui3.BackColor = System.Drawing.Color.Lime;
            this.lblMui3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMui3.Location = new System.Drawing.Point(1404, 221);
            this.lblMui3.Name = "lblMui3";
            this.lblMui3.Size = new System.Drawing.Size(40, 46);
            this.lblMui3.TabIndex = 5;
            this.lblMui3.Text = "1";
            // 
            // lblMui2
            // 
            this.lblMui2.AutoSize = true;
            this.lblMui2.BackColor = System.Drawing.Color.Red;
            this.lblMui2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMui2.Location = new System.Drawing.Point(802, 221);
            this.lblMui2.Name = "lblMui2";
            this.lblMui2.Size = new System.Drawing.Size(40, 46);
            this.lblMui2.TabIndex = 4;
            this.lblMui2.Text = "2";
            // 
            // lblMui1
            // 
            this.lblMui1.AutoSize = true;
            this.lblMui1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblMui1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMui1.Location = new System.Drawing.Point(288, 221);
            this.lblMui1.Name = "lblMui1";
            this.lblMui1.Size = new System.Drawing.Size(40, 46);
            this.lblMui1.TabIndex = 3;
            this.lblMui1.Text = "1";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(1239, 174);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(347, 33);
            this.label48.TabIndex = 2;
            this.label48.Text = "Số lượng người đã tiêm mũi 3";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(652, 174);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(347, 33);
            this.label47.TabIndex = 1;
            this.label47.Text = "Số lượng người đã tiêm mũi 2";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(152, 174);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(347, 33);
            this.label46.TabIndex = 0;
            this.label46.Text = "Số lượng người đã tiêm mũi 1";
            // 
            // QuanLyTiemChung
            // 
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1819, 674);
            this.Controls.Add(this.tabControl1);
            this.Name = "QuanLyTiemChung";
            this.Text = "Quản lý tiêm chủng";
            this.Load += new System.EventHandler(this.QuanLyTiemChung_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        public void loadTiemChungMui1()
        {
            KetNoi.moKetNoi();
            string sql = "select * from TiemChungMui1";
            dataGridView1.DataSource = KetNoi.getData(sql);
            KetNoi.dongKetNoi();
        }

        public void loadTiemChungMui2()
        {
            KetNoi.moKetNoi();
            string sql = "select * from TiemChungMui2";
            dataGridView2.DataSource = KetNoi.getData(sql);
            KetNoi.dongKetNoi();
        }

        public void loadTiemChungMui3()
        {
            KetNoi.moKetNoi();
            string sql = "select * from TiemChungMui3";
            dataGridView3.DataSource = KetNoi.getData(sql);
            KetNoi.dongKetNoi();
        }

        private void QuanLyTiemChung_Load(object sender, EventArgs e)
        {
            KetNoi.moKetNoi();
            loadTiemChungMui1();
            loadTiemChungMui2();
            loadTK();
            loadTiemChungMui3();
            KetNoi.dongKetNoi();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentCell.RowIndex;
            txtCMND1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtHoTen1.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtNamSinh1.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            string gt = dataGridView1.Rows[i].Cells[3].Value.ToString();
            if (gt == "Nam")
            {
                rdNam1.Checked = true;
            }
            else
                rdNu1.Checked = true;
            txtQuocTich1.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txtTinh1.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            txtHuyen1.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            txtXa1.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            txtDiaChi1.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
            txtSDT1.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
            txtEmail1.Text = dataGridView1.Rows[i].Cells[10].Value.ToString();
            txtTenVaccine1.Text = dataGridView1.Rows[i].Cells[11].Value.ToString();
            dtpNgayTiem1.Value = DateTime.Parse(dataGridView1.Rows[i].Cells[12].Value.ToString());
            txtDonViTiem1.Text = dataGridView1.Rows[i].Cells[13].Value.ToString();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView3.CurrentCell.RowIndex;
            txtCMND3.Text = dataGridView3.Rows[i].Cells[0].Value.ToString();
            txtHoTen3.Text = dataGridView3.Rows[i].Cells[1].Value.ToString();
            txtNamSinh3.Text = dataGridView3.Rows[i].Cells[2].Value.ToString();
            string gt = dataGridView3.Rows[i].Cells[3].Value.ToString();
            if (gt == "Nam")
            {
                rdNam3.Checked = true;
            }
            else
                rdNu3.Checked = true;
            txtQuocTich3.Text = dataGridView3.Rows[i].Cells[4].Value.ToString();
            txtTinh3.Text = dataGridView3.Rows[i].Cells[5].Value.ToString();
            txtHuyen3.Text = dataGridView3.Rows[i].Cells[6].Value.ToString();
            txtXa3.Text = dataGridView3.Rows[i].Cells[7].Value.ToString();
            txtDiaChi3.Text = dataGridView3.Rows[i].Cells[8].Value.ToString();
            txtSDT3.Text = dataGridView3.Rows[i].Cells[9].Value.ToString();
            txtEmail3.Text = dataGridView3.Rows[i].Cells[10].Value.ToString();
            txtTenVaccine3.Text = dataGridView3.Rows[i].Cells[11].Value.ToString();
            dtpNgayTiem3.Value = DateTime.Parse(dataGridView3.Rows[i].Cells[12].Value.ToString());
            txtDonViTiem3.Text = dataGridView3.Rows[i].Cells[13].Value.ToString();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView2.CurrentCell.RowIndex;
            txtCMND2.Text = dataGridView2.Rows[i].Cells[0].Value.ToString();
            txtHoTen2.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
            txtNamSinh2.Text = dataGridView2.Rows[i].Cells[2].Value.ToString();
            string gt = dataGridView2.Rows[i].Cells[3].Value.ToString();
            if (gt == "Nam")
            {
                rdNam2.Checked = true;
            }
            else
                rdNu2.Checked = true;
            txtQuocTich2.Text = dataGridView2.Rows[i].Cells[4].Value.ToString();
            txtTinh2.Text = dataGridView2.Rows[i].Cells[5].Value.ToString();
            txtHuyen2.Text = dataGridView2.Rows[i].Cells[6].Value.ToString();
            txtXa2.Text = dataGridView2.Rows[i].Cells[7].Value.ToString();
            txtDiaChi2.Text = dataGridView2.Rows[i].Cells[8].Value.ToString();
            txtSDT2.Text = dataGridView2.Rows[i].Cells[9].Value.ToString();
            txtEmail2.Text = dataGridView2.Rows[i].Cells[10].Value.ToString();
            txtTenVaccine2.Text = dataGridView2.Rows[i].Cells[11].Value.ToString();
            dtpNgayTiem2.Value = DateTime.Parse(dataGridView2.Rows[i].Cells[12].Value.ToString());
            txtDonViTiem2.Text = dataGridView2.Rows[i].Cells[13].Value.ToString();
        }

        private void btnTimKiem3_Click(object sender, EventArgs e)
        {
            string sql = string.Format("select * from TiemChungMui3 where CMND = '{0}'", txtTimKiem3.Text);
            dataGridView3.DataSource = KetNoi.getData(sql);
        }

        private void btnTimKiem2_Click(object sender, EventArgs e)
        {
            string sql = string.Format("select * from TiemChungMui2 where CMND = '{0}'", txtTimKiem2.Text);
            dataGridView2.DataSource = KetNoi.getData(sql);
        }

        public void loadTK()
        {
            int soLuong = 0;
            int soLuong2 = 0;
            int soLuong3 = 0;
            soLuong = (int)(KetNoi.execScalar("select count(*) from TiemChungMui1"));
            soLuong2 = (int)(KetNoi.execScalar("select count(*) from TiemChungMui2"));
            soLuong3 = (int)(KetNoi.execScalar("select count(*) from TiemChungMui3"));

            lblMui1.Text = "" + soLuong;
            lblMui2.Text = "" + soLuong2;
            lblMui3.Text = "" + soLuong3;
        }

        private void btnTimKiem1_Click(object sender, EventArgs e)
        {
            string sql2 = string.Format("select * from TiemChungMui1 where CMND = '{0}'", txtTimKiem1.Text);
            dataGridView1.DataSource = KetNoi.getData(sql2);
        }
    }
}
