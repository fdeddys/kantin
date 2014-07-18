namespace POS.form.master
{
    partial class FrmMasterItem
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
            this.dGVBarang = new System.Windows.Forms.DataGridView();
            this.chkStock = new System.Windows.Forms.CheckBox();
            this.txtHargaJual = new System.Windows.Forms.TextBox();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.panelIsi = new System.Windows.Forms.Panel();
            this.txtIsi = new System.Windows.Forms.TextBox();
            this.cmbSatuanKecil = new System.Windows.Forms.ComboBox();
            this.cmbMerk = new System.Windows.Forms.ComboBox();
            this.cmbSatuan = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDaftarBarcode = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBarang)).BeginInit();
            this.panelIsi.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGVBarang
            // 
            this.dGVBarang.AllowUserToAddRows = false;
            this.dGVBarang.AllowUserToDeleteRows = false;
            this.dGVBarang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVBarang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGVBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVBarang.Location = new System.Drawing.Point(0, 0);
            this.dGVBarang.Name = "dGVBarang";
            this.dGVBarang.ReadOnly = true;
            this.dGVBarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVBarang.Size = new System.Drawing.Size(649, 212);
            this.dGVBarang.TabIndex = 13;
            // 
            // chkStock
            // 
            this.chkStock.AutoSize = true;
            this.chkStock.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkStock.Location = new System.Drawing.Point(10, 101);
            this.chkStock.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkStock.Name = "chkStock";
            this.chkStock.Size = new System.Drawing.Size(43, 20);
            this.chkStock.TabIndex = 10;
            this.chkStock.Text = "Ya";
            this.chkStock.UseVisualStyleBackColor = true;
            // 
            // txtHargaJual
            // 
            this.txtHargaJual.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHargaJual.Location = new System.Drawing.Point(10, 79);
            this.txtHargaJual.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtHargaJual.Name = "txtHargaJual";
            this.txtHargaJual.Size = new System.Drawing.Size(371, 22);
            this.txtHargaJual.TabIndex = 9;
            // 
            // cmbGroup
            // 
            this.cmbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbGroup.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(10, 55);
            this.cmbGroup.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(436, 24);
            this.cmbGroup.TabIndex = 8;
            // 
            // txtNama
            // 
            this.txtNama.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNama.Location = new System.Drawing.Point(10, 33);
            this.txtNama.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(436, 22);
            this.txtNama.TabIndex = 7;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.ForeColor = System.Drawing.Color.Crimson;
            this.btnSimpan.Location = new System.Drawing.Point(322, 439);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(100, 43);
            this.btnSimpan.TabIndex = 11;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.ForeColor = System.Drawing.Color.Crimson;
            this.btnBatal.Location = new System.Drawing.Point(222, 439);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(100, 43);
            this.btnBatal.TabIndex = 10;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbah.ForeColor = System.Drawing.Color.Crimson;
            this.btnUbah.Location = new System.Drawing.Point(122, 439);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(100, 43);
            this.btnUbah.TabIndex = 9;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // txtKode
            // 
            this.txtKode.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKode.Location = new System.Drawing.Point(10, 11);
            this.txtKode.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtKode.Name = "txtKode";
            this.txtKode.ReadOnly = true;
            this.txtKode.Size = new System.Drawing.Size(92, 22);
            this.txtKode.TabIndex = 6;
            // 
            // btnKeluar
            // 
            this.btnKeluar.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeluar.ForeColor = System.Drawing.Color.Crimson;
            this.btnKeluar.Location = new System.Drawing.Point(522, 439);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(100, 43);
            this.btnKeluar.TabIndex = 12;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.ForeColor = System.Drawing.Color.Crimson;
            this.btnTambah.Location = new System.Drawing.Point(22, 439);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(100, 43);
            this.btnTambah.TabIndex = 8;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // panelIsi
            // 
            this.panelIsi.BackColor = System.Drawing.SystemColors.Control;
            this.panelIsi.Controls.Add(this.txtIsi);
            this.panelIsi.Controls.Add(this.cmbSatuanKecil);
            this.panelIsi.Controls.Add(this.cmbMerk);
            this.panelIsi.Controls.Add(this.cmbSatuan);
            this.panelIsi.Controls.Add(this.chkStock);
            this.panelIsi.Controls.Add(this.txtHargaJual);
            this.panelIsi.Controls.Add(this.cmbGroup);
            this.panelIsi.Controls.Add(this.txtNama);
            this.panelIsi.Controls.Add(this.txtKode);
            this.panelIsi.Location = new System.Drawing.Point(174, 220);
            this.panelIsi.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panelIsi.Name = "panelIsi";
            this.panelIsi.Size = new System.Drawing.Size(475, 206);
            this.panelIsi.TabIndex = 7;
            // 
            // txtIsi
            // 
            this.txtIsi.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIsi.Location = new System.Drawing.Point(10, 146);
            this.txtIsi.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtIsi.Name = "txtIsi";
            this.txtIsi.Size = new System.Drawing.Size(87, 22);
            this.txtIsi.TabIndex = 12;
            // 
            // cmbSatuanKecil
            // 
            this.cmbSatuanKecil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSatuanKecil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSatuanKecil.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSatuanKecil.FormattingEnabled = true;
            this.cmbSatuanKecil.Location = new System.Drawing.Point(99, 145);
            this.cmbSatuanKecil.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbSatuanKecil.Name = "cmbSatuanKecil";
            this.cmbSatuanKecil.Size = new System.Drawing.Size(335, 24);
            this.cmbSatuanKecil.TabIndex = 13;
            // 
            // cmbMerk
            // 
            this.cmbMerk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMerk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMerk.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMerk.FormattingEnabled = true;
            this.cmbMerk.Location = new System.Drawing.Point(10, 170);
            this.cmbMerk.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbMerk.Name = "cmbMerk";
            this.cmbMerk.Size = new System.Drawing.Size(424, 24);
            this.cmbMerk.TabIndex = 14;
            // 
            // cmbSatuan
            // 
            this.cmbSatuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSatuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSatuan.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSatuan.FormattingEnabled = true;
            this.cmbSatuan.Location = new System.Drawing.Point(10, 121);
            this.cmbSatuan.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbSatuan.Name = "cmbSatuan";
            this.cmbSatuan.Size = new System.Drawing.Size(424, 24);
            this.cmbSatuan.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(15, 344);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Satuan Besar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(15, 234);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Kode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(15, 256);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(15, 278);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Group Barang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(15, 300);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Harga Jual";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(15, 322);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Stock [Y/T]";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(-3, 432);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(661, 57);
            this.label7.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(15, 393);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Merk";
            // 
            // btnDaftarBarcode
            // 
            this.btnDaftarBarcode.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaftarBarcode.ForeColor = System.Drawing.Color.Crimson;
            this.btnDaftarBarcode.Location = new System.Drawing.Point(422, 439);
            this.btnDaftarBarcode.Name = "btnDaftarBarcode";
            this.btnDaftarBarcode.Size = new System.Drawing.Size(100, 43);
            this.btnDaftarBarcode.TabIndex = 22;
            this.btnDaftarBarcode.Text = "Barcode";
            this.btnDaftarBarcode.UseVisualStyleBackColor = true;
            this.btnDaftarBarcode.Click += new System.EventHandler(this.btnDaftarBarcode_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(15, 369);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Isi / Satuan Kecil";
            // 
            // FrmMasterItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(649, 496);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnDaftarBarcode);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dGVBarang);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.panelIsi);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmMasterItem";
            this.Text = "FrmMasterItem";
            this.Load += new System.EventHandler(this.FrmMasterItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVBarang)).EndInit();
            this.panelIsi.ResumeLayout(false);
            this.panelIsi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVBarang;
        private System.Windows.Forms.CheckBox chkStock;
        private System.Windows.Forms.TextBox txtHargaJual;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.TextBox txtKode;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Panel panelIsi;
        private System.Windows.Forms.ComboBox cmbSatuan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbMerk;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDaftarBarcode;
        private System.Windows.Forms.TextBox txtIsi;
        private System.Windows.Forms.ComboBox cmbSatuanKecil;
        private System.Windows.Forms.Label label9;
    }
}