namespace POS.form
{
    partial class FrmGroupBarang
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
            this.dgvGroupBarang = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNamaGroup = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKodeGroup = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupBarang)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGroupBarang
            // 
            this.dgvGroupBarang.AllowUserToOrderColumns = true;
            this.dgvGroupBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroupBarang.Location = new System.Drawing.Point(13, 13);
            this.dgvGroupBarang.Margin = new System.Windows.Forms.Padding(4);
            this.dgvGroupBarang.Name = "dgvGroupBarang";
            this.dgvGroupBarang.Size = new System.Drawing.Size(508, 256);
            this.dgvGroupBarang.TabIndex = 0;
            this.dgvGroupBarang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGroupBarang_CellContentClick);
            this.dgvGroupBarang.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGroupBarang_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNamaGroup);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtKodeGroup);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 278);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 79);
            this.panel1.TabIndex = 1;
            // 
            // txtNamaGroup
            // 
            this.txtNamaGroup.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtNamaGroup.Location = new System.Drawing.Point(116, 39);
            this.txtNamaGroup.Name = "txtNamaGroup";
            this.txtNamaGroup.ReadOnly = true;
            this.txtNamaGroup.Size = new System.Drawing.Size(369, 22);
            this.txtNamaGroup.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama Group";
            // 
            // txtKodeGroup
            // 
            this.txtKodeGroup.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtKodeGroup.Location = new System.Drawing.Point(116, 11);
            this.txtKodeGroup.Name = "txtKodeGroup";
            this.txtKodeGroup.ReadOnly = true;
            this.txtKodeGroup.Size = new System.Drawing.Size(79, 22);
            this.txtKodeGroup.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode";
            // 
            // btnKeluar
            // 
            this.btnKeluar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnKeluar.Location = new System.Drawing.Point(412, 364);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(93, 48);
            this.btnKeluar.TabIndex = 10;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnSimpan.Location = new System.Drawing.Point(313, 364);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(93, 48);
            this.btnSimpan.TabIndex = 9;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnBatal.Location = new System.Drawing.Point(214, 364);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(93, 48);
            this.btnBatal.TabIndex = 8;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnUbah.Location = new System.Drawing.Point(115, 364);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(93, 48);
            this.btnUbah.TabIndex = 7;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnTambah.Location = new System.Drawing.Point(16, 364);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(93, 48);
            this.btnTambah.TabIndex = 6;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // FrmGroupBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(528, 423);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvGroupBarang);
            this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGroupBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Group Barang";
            this.Load += new System.EventHandler(this.FrmGroupBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupBarang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGroupBarang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtKodeGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNamaGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnTambah;
    }
}