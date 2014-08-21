namespace POS.form.PosKasir
{
    partial class POS_sales
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
            this.panId = new System.Windows.Forms.Panel();
            this.lblCekHarga = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblJAM = new System.Windows.Forms.Label();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.lblPOS = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblNoFaktur = new System.Windows.Forms.Label();
            this.LblGrandTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCari = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LblNamaBarang = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtJumlah = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblHarga = new System.Windows.Forms.Label();
            this.lblSatuan = new System.Windows.Forms.Label();
            this.dgvListBarang = new System.Windows.Forms.DataGridView();
            this.panelBayar = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtJumlahBayar = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lblBayarTotalKembali = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblBayarTotalBelanja = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelKeteranganBawah = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lblSaldoAwal = new System.Windows.Forms.Label();
            this.btnOpenShift = new System.Windows.Forms.Button();
            this.btnBatalOpenShift = new System.Windows.Forms.Button();
            this.panelOpenShift = new System.Windows.Forms.Panel();
            this.panId.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBarang)).BeginInit();
            this.panelBayar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelOpenShift.SuspendLayout();
            this.SuspendLayout();
            // 
            // panId
            // 
            this.panId.BackColor = System.Drawing.Color.White;
            this.panId.Controls.Add(this.lblCekHarga);
            this.panId.Controls.Add(this.lblUser);
            this.panId.Controls.Add(this.lblJAM);
            this.panId.Controls.Add(this.lblTanggal);
            this.panId.Controls.Add(this.lblPOS);
            this.panId.Location = new System.Drawing.Point(-6, 686);
            this.panId.Name = "panId";
            this.panId.Size = new System.Drawing.Size(1017, 36);
            this.panId.TabIndex = 0;
            // 
            // lblCekHarga
            // 
            this.lblCekHarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCekHarga.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCekHarga.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCekHarga.Location = new System.Drawing.Point(563, 5);
            this.lblCekHarga.Name = "lblCekHarga";
            this.lblCekHarga.Size = new System.Drawing.Size(206, 27);
            this.lblCekHarga.TabIndex = 37;
            this.lblCekHarga.Text = "Cek Harga";
            this.lblCekHarga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCekHarga.Visible = false;
            // 
            // lblUser
            // 
            this.lblUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUser.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Magenta;
            this.lblUser.Location = new System.Drawing.Point(775, 5);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(230, 27);
            this.lblUser.TabIndex = 21;
            this.lblUser.Text = "user";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJAM
            // 
            this.lblJAM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblJAM.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJAM.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblJAM.Location = new System.Drawing.Point(395, 5);
            this.lblJAM.Name = "lblJAM";
            this.lblJAM.Size = new System.Drawing.Size(162, 27);
            this.lblJAM.TabIndex = 18;
            this.lblJAM.Text = "jam";
            this.lblJAM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTanggal
            // 
            this.lblTanggal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTanggal.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTanggal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTanggal.Location = new System.Drawing.Point(227, 5);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(162, 27);
            this.lblTanggal.TabIndex = 17;
            this.lblTanggal.Text = "tgl";
            this.lblTanggal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPOS
            // 
            this.lblPOS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPOS.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPOS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPOS.Location = new System.Drawing.Point(12, 5);
            this.lblPOS.Name = "lblPOS";
            this.lblPOS.Size = new System.Drawing.Size(209, 27);
            this.lblPOS.TabIndex = 16;
            this.lblPOS.Text = "POS";
            this.lblPOS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.LblNoFaktur);
            this.panel1.Controls.Add(this.LblGrandTotal);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(631, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 175);
            this.panel1.TabIndex = 2;
            // 
            // LblNoFaktur
            // 
            this.LblNoFaktur.BackColor = System.Drawing.Color.SteelBlue;
            this.LblNoFaktur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblNoFaktur.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNoFaktur.ForeColor = System.Drawing.Color.Ivory;
            this.LblNoFaktur.Location = new System.Drawing.Point(31, 9);
            this.LblNoFaktur.Name = "LblNoFaktur";
            this.LblNoFaktur.Size = new System.Drawing.Size(309, 36);
            this.LblNoFaktur.TabIndex = 25;
            this.LblNoFaktur.Text = "FyyMM99999";
            this.LblNoFaktur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblGrandTotal
            // 
            this.LblGrandTotal.BackColor = System.Drawing.Color.Black;
            this.LblGrandTotal.Font = new System.Drawing.Font("Courier New", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGrandTotal.ForeColor = System.Drawing.Color.Lime;
            this.LblGrandTotal.Location = new System.Drawing.Point(0, 100);
            this.LblGrandTotal.Name = "LblGrandTotal";
            this.LblGrandTotal.Size = new System.Drawing.Size(366, 62);
            this.LblGrandTotal.TabIndex = 1;
            this.LblGrandTotal.Text = "Rp 9,999,999";
            this.LblGrandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblGrandTotal.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vani", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(81, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Belanja";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(40, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 34);
            this.label2.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(-3, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1017, 35);
            this.label8.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-1, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1017, 10);
            this.label3.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(-3, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1013, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "   F1 : Cari Barang  -  F2 : Bayar - F3 : Cek Harga  -  F4 :  Ubah Jumlah/hapus  " +
    "-  F8 - Laporan Harian  -  F9 : Logout  -  F10 : Print Struk terakhir  -  F12 : " +
    "Open Shift  ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(21, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "Kode / barcode";
            // 
            // TxtCari
            // 
            this.TxtCari.BackColor = System.Drawing.Color.White;
            this.TxtCari.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCari.Location = new System.Drawing.Point(16, 252);
            this.TxtCari.Name = "TxtCari";
            this.TxtCari.Size = new System.Drawing.Size(264, 26);
            this.TxtCari.TabIndex = 0;
            this.TxtCari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCari_KeyPress);
            this.TxtCari.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtCari_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(304, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "Barang";
            // 
            // LblNamaBarang
            // 
            this.LblNamaBarang.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNamaBarang.ForeColor = System.Drawing.Color.Yellow;
            this.LblNamaBarang.Location = new System.Drawing.Point(293, 256);
            this.LblNamaBarang.Name = "LblNamaBarang";
            this.LblNamaBarang.Size = new System.Drawing.Size(319, 28);
            this.LblNamaBarang.TabIndex = 24;
            this.LblNamaBarang.Text = "Nama Barang 0000000000000000000------------";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(930, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 18);
            this.label7.TabIndex = 25;
            this.label7.Text = "Jumlah";
            // 
            // TxtJumlah
            // 
            this.TxtJumlah.BackColor = System.Drawing.Color.White;
            this.TxtJumlah.Enabled = false;
            this.TxtJumlah.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtJumlah.Location = new System.Drawing.Point(882, 253);
            this.TxtJumlah.Name = "TxtJumlah";
            this.TxtJumlah.Size = new System.Drawing.Size(111, 26);
            this.TxtJumlah.TabIndex = 1;
            this.TxtJumlah.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtJumlah_KeyPress);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(21, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(264, 23);
            this.label9.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(890, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 27);
            this.label10.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Indigo;
            this.label11.Location = new System.Drawing.Point(657, 231);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 18);
            this.label11.TabIndex = 30;
            this.label11.Text = "Harga";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.LawnGreen;
            this.label12.Location = new System.Drawing.Point(791, 231);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 18);
            this.label12.TabIndex = 31;
            this.label12.Text = "Satuan";
            // 
            // lblHarga
            // 
            this.lblHarga.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHarga.ForeColor = System.Drawing.Color.Indigo;
            this.lblHarga.Location = new System.Drawing.Point(628, 255);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(115, 28);
            this.lblHarga.TabIndex = 32;
            this.lblHarga.Text = "Rp 9,999,999,-";
            this.lblHarga.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSatuan
            // 
            this.lblSatuan.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSatuan.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblSatuan.Location = new System.Drawing.Point(759, 255);
            this.lblSatuan.Name = "lblSatuan";
            this.lblSatuan.Size = new System.Drawing.Size(115, 28);
            this.lblSatuan.TabIndex = 33;
            this.lblSatuan.Text = "pcs";
            this.lblSatuan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvListBarang
            // 
            this.dgvListBarang.AllowUserToAddRows = false;
            this.dgvListBarang.AllowUserToDeleteRows = false;
            this.dgvListBarang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListBarang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvListBarang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvListBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListBarang.Location = new System.Drawing.Point(0, 302);
            this.dgvListBarang.Name = "dgvListBarang";
            this.dgvListBarang.ReadOnly = true;
            this.dgvListBarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListBarang.Size = new System.Drawing.Size(1010, 353);
            this.dgvListBarang.TabIndex = 34;
            this.dgvListBarang.Click += new System.EventHandler(this.dgvListBarang_Click);
            this.dgvListBarang.Enter += new System.EventHandler(this.dgvListBarang_Enter);
            this.dgvListBarang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvListBarang_KeyPress);
            this.dgvListBarang.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvListBarang_KeyUp);
            this.dgvListBarang.Leave += new System.EventHandler(this.dgvListBarang_Leave);
            // 
            // panelBayar
            // 
            this.panelBayar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelBayar.Controls.Add(this.label21);
            this.panelBayar.Controls.Add(this.label20);
            this.panelBayar.Controls.Add(this.label15);
            this.panelBayar.Controls.Add(this.label14);
            this.panelBayar.Controls.Add(this.label19);
            this.panelBayar.Controls.Add(this.label18);
            this.panelBayar.Controls.Add(this.txtJumlahBayar);
            this.panelBayar.Controls.Add(this.label17);
            this.panelBayar.Controls.Add(this.lblBayarTotalKembali);
            this.panelBayar.Controls.Add(this.label16);
            this.panelBayar.Controls.Add(this.lblBayarTotalBelanja);
            this.panelBayar.Controls.Add(this.label13);
            this.panelBayar.Location = new System.Drawing.Point(238, 84);
            this.panelBayar.Name = "panelBayar";
            this.panelBayar.Size = new System.Drawing.Size(559, 313);
            this.panelBayar.TabIndex = 35;
            this.panelBayar.Visible = false;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.GhostWhite;
            this.label21.Location = new System.Drawing.Point(216, 224);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(39, 36);
            this.label21.TabIndex = 26;
            this.label21.Text = ":";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.GhostWhite;
            this.label20.Location = new System.Drawing.Point(216, 164);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(39, 36);
            this.label20.TabIndex = 25;
            this.label20.Text = ":";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.GhostWhite;
            this.label15.Location = new System.Drawing.Point(216, 104);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 36);
            this.label15.TabIndex = 24;
            this.label15.Text = ":";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Gainsboro;
            this.label14.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkRed;
            this.label14.Location = new System.Drawing.Point(0, 283);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(559, 20);
            this.label14.TabIndex = 23;
            this.label14.Text = "   ENTER : Pembayaran   ESC : Batal Bayar";
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label19.Location = new System.Drawing.Point(17, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(527, 66);
            this.label19.TabIndex = 22;
            this.label19.Text = "-- Pembayaran --";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.GhostWhite;
            this.label18.Location = new System.Drawing.Point(11, 224);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(134, 36);
            this.label18.TabIndex = 21;
            this.label18.Text = "Kembali";
            // 
            // txtJumlahBayar
            // 
            this.txtJumlahBayar.BackColor = System.Drawing.Color.White;
            this.txtJumlahBayar.Font = new System.Drawing.Font("Times New Roman", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJumlahBayar.Location = new System.Drawing.Point(257, 150);
            this.txtJumlahBayar.Name = "txtJumlahBayar";
            this.txtJumlahBayar.Size = new System.Drawing.Size(295, 58);
            this.txtJumlahBayar.TabIndex = 20;
            this.txtJumlahBayar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJumlahBayar_KeyPress);
            this.txtJumlahBayar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtJumlahBayar_KeyUp);
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Gainsboro;
            this.label17.Location = new System.Drawing.Point(0, 66);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(559, 10);
            this.label17.TabIndex = 19;
            // 
            // lblBayarTotalKembali
            // 
            this.lblBayarTotalKembali.BackColor = System.Drawing.Color.Black;
            this.lblBayarTotalKembali.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBayarTotalKembali.Font = new System.Drawing.Font("Times New Roman", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBayarTotalKembali.ForeColor = System.Drawing.Color.Lime;
            this.lblBayarTotalKembali.Location = new System.Drawing.Point(257, 212);
            this.lblBayarTotalKembali.Name = "lblBayarTotalKembali";
            this.lblBayarTotalKembali.Size = new System.Drawing.Size(295, 53);
            this.lblBayarTotalKembali.TabIndex = 4;
            this.lblBayarTotalKembali.Text = "Rp 9,999,999";
            this.lblBayarTotalKembali.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.GhostWhite;
            this.label16.Location = new System.Drawing.Point(11, 164);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 36);
            this.label16.TabIndex = 3;
            this.label16.Text = "Bayar";
            // 
            // lblBayarTotalBelanja
            // 
            this.lblBayarTotalBelanja.BackColor = System.Drawing.Color.Black;
            this.lblBayarTotalBelanja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBayarTotalBelanja.Font = new System.Drawing.Font("Times New Roman", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBayarTotalBelanja.ForeColor = System.Drawing.Color.Lime;
            this.lblBayarTotalBelanja.Location = new System.Drawing.Point(257, 87);
            this.lblBayarTotalBelanja.Name = "lblBayarTotalBelanja";
            this.lblBayarTotalBelanja.Size = new System.Drawing.Size(295, 62);
            this.lblBayarTotalBelanja.TabIndex = 2;
            this.lblBayarTotalBelanja.Text = "Rp 9,999,999";
            this.lblBayarTotalBelanja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.GhostWhite;
            this.label13.Location = new System.Drawing.Point(11, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(199, 36);
            this.label13.TabIndex = 1;
            this.label13.Text = "Total Belanja";
            // 
            // labelKeteranganBawah
            // 
            this.labelKeteranganBawah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelKeteranganBawah.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKeteranganBawah.ForeColor = System.Drawing.Color.DarkRed;
            this.labelKeteranganBawah.Location = new System.Drawing.Point(-1, 658);
            this.labelKeteranganBawah.Name = "labelKeteranganBawah";
            this.labelKeteranganBawah.Size = new System.Drawing.Size(1013, 20);
            this.labelKeteranganBawah.TabIndex = 36;
            this.labelKeteranganBawah.Text = "   DEL : hapus data  -  ESC  :  Kembali ke kode/barcode  -  SPACE BAR :  ubah jum" +
    "lah barang";
            this.labelKeteranganBawah.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 300;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(6, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 174);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label23.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label23.Location = new System.Drawing.Point(3, 22);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(487, 66);
            this.label23.TabIndex = 23;
            this.label23.Text = "-- Open Shift --";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Green;
            this.label25.Location = new System.Drawing.Point(20, 114);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(145, 26);
            this.label25.TabIndex = 24;
            this.label25.Text = "Saldo Awal  :";
            // 
            // lblSaldoAwal
            // 
            this.lblSaldoAwal.BackColor = System.Drawing.Color.Black;
            this.lblSaldoAwal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSaldoAwal.Font = new System.Drawing.Font("Courier New", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoAwal.ForeColor = System.Drawing.Color.Lime;
            this.lblSaldoAwal.Location = new System.Drawing.Point(171, 93);
            this.lblSaldoAwal.Name = "lblSaldoAwal";
            this.lblSaldoAwal.Size = new System.Drawing.Size(295, 62);
            this.lblSaldoAwal.TabIndex = 25;
            this.lblSaldoAwal.Text = "Rp 9,999,999";
            this.lblSaldoAwal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOpenShift
            // 
            this.btnOpenShift.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenShift.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnOpenShift.Location = new System.Drawing.Point(25, 163);
            this.btnOpenShift.Name = "btnOpenShift";
            this.btnOpenShift.Size = new System.Drawing.Size(212, 61);
            this.btnOpenShift.TabIndex = 26;
            this.btnOpenShift.Text = "Open Shift";
            this.btnOpenShift.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOpenShift.UseVisualStyleBackColor = true;
            this.btnOpenShift.Click += new System.EventHandler(this.btnOpenShift_Click);
            // 
            // btnBatalOpenShift
            // 
            this.btnBatalOpenShift.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatalOpenShift.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBatalOpenShift.Location = new System.Drawing.Point(240, 162);
            this.btnBatalOpenShift.Name = "btnBatalOpenShift";
            this.btnBatalOpenShift.Size = new System.Drawing.Size(212, 61);
            this.btnBatalOpenShift.TabIndex = 27;
            this.btnBatalOpenShift.Text = "Batal";
            this.btnBatalOpenShift.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBatalOpenShift.UseVisualStyleBackColor = true;
            this.btnBatalOpenShift.Click += new System.EventHandler(this.btnBatalOpenShift_Click);
            // 
            // panelOpenShift
            // 
            this.panelOpenShift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelOpenShift.Controls.Add(this.btnBatalOpenShift);
            this.panelOpenShift.Controls.Add(this.btnOpenShift);
            this.panelOpenShift.Controls.Add(this.lblSaldoAwal);
            this.panelOpenShift.Controls.Add(this.label25);
            this.panelOpenShift.Controls.Add(this.label23);
            this.panelOpenShift.Location = new System.Drawing.Point(107, 125);
            this.panelOpenShift.Name = "panelOpenShift";
            this.panelOpenShift.Size = new System.Drawing.Size(493, 239);
            this.panelOpenShift.TabIndex = 37;
            this.panelOpenShift.Visible = false;
            // 
            // POS_sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.panelOpenShift);
            this.Controls.Add(this.labelKeteranganBawah);
            this.Controls.Add(this.panelBayar);
            this.Controls.Add(this.dgvListBarang);
            this.Controls.Add(this.lblSatuan);
            this.Controls.Add(this.lblHarga);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtJumlah);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LblNamaBarang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtCari);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Name = "POS_sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POS_sales";
            this.Load += new System.EventHandler(this.POS_sales_Load);
            this.panId.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBarang)).EndInit();
            this.panelBayar.ResumeLayout(false);
            this.panelBayar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelOpenShift.ResumeLayout(false);
            this.panelOpenShift.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panId;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblJAM;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.Label lblPOS;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblGrandTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtCari;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblNamaBarang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtJumlah;
        private System.Windows.Forms.Label LblNoFaktur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.Label lblSatuan;
        private System.Windows.Forms.DataGridView dgvListBarang;
        private System.Windows.Forms.Panel panelBayar;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtJumlahBayar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblBayarTotalKembali;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblBayarTotalBelanja;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelKeteranganBawah;
        private System.Windows.Forms.Label lblCekHarga;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lblSaldoAwal;
        private System.Windows.Forms.Button btnOpenShift;
        private System.Windows.Forms.Button btnBatalOpenShift;
        private System.Windows.Forms.Panel panelOpenShift;
    }
}