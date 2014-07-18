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
            this.lblUser = new System.Windows.Forms.Label();
            this.lblJAM = new System.Windows.Forms.Label();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.lblPOS = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblNoFaktur = new System.Windows.Forms.Label();
            this.LblGrandTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCari = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LblNamaBarang = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtJumlah = new System.Windows.Forms.TextBox();
            this.LblKode = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panId.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panId
            // 
            this.panId.BackColor = System.Drawing.Color.White;
            this.panId.Controls.Add(this.lblUser);
            this.panId.Controls.Add(this.lblJAM);
            this.panId.Controls.Add(this.lblTanggal);
            this.panId.Controls.Add(this.lblPOS);
            this.panId.Location = new System.Drawing.Point(-6, 692);
            this.panId.Name = "panId";
            this.panId.Size = new System.Drawing.Size(1017, 36);
            this.panId.TabIndex = 0;
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblUser.Location = new System.Drawing.Point(758, 5);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(241, 27);
            this.lblUser.TabIndex = 21;
            this.lblUser.Text = "user";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJAM
            // 
            this.lblJAM.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJAM.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblJAM.Location = new System.Drawing.Point(531, 5);
            this.lblJAM.Name = "lblJAM";
            this.lblJAM.Size = new System.Drawing.Size(162, 27);
            this.lblJAM.TabIndex = 18;
            this.lblJAM.Text = "jam";
            this.lblJAM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTanggal
            // 
            this.lblTanggal.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTanggal.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTanggal.Location = new System.Drawing.Point(274, 5);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(162, 27);
            this.lblTanggal.TabIndex = 17;
            this.lblTanggal.Text = "tgl";
            this.lblTanggal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPOS
            // 
            this.lblPOS.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPOS.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblPOS.Location = new System.Drawing.Point(24, 5);
            this.lblPOS.Name = "lblPOS";
            this.lblPOS.Size = new System.Drawing.Size(162, 27);
            this.lblPOS.TabIndex = 16;
            this.lblPOS.Text = "POS";
            this.lblPOS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.LblGrandTotal.BackColor = System.Drawing.Color.White;
            this.LblGrandTotal.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGrandTotal.ForeColor = System.Drawing.Color.Blue;
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
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(-3, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1017, 35);
            this.label8.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 306);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(989, 376);
            this.dataGridView1.TabIndex = 17;
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
            this.label4.Text = "   F1 : Help - F2 : Total  -  F9 : Logout";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(13, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Kode / barcode";
            // 
            // TxtCari
            // 
            this.TxtCari.Location = new System.Drawing.Point(16, 252);
            this.TxtCari.Name = "TxtCari";
            this.TxtCari.Size = new System.Drawing.Size(264, 20);
            this.TxtCari.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(293, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Barang";
            // 
            // LblNamaBarang
            // 
            this.LblNamaBarang.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNamaBarang.ForeColor = System.Drawing.Color.Yellow;
            this.LblNamaBarang.Location = new System.Drawing.Point(293, 256);
            this.LblNamaBarang.Name = "LblNamaBarang";
            this.LblNamaBarang.Size = new System.Drawing.Size(519, 16);
            this.LblNamaBarang.TabIndex = 24;
            this.LblNamaBarang.Text = "Nama Barang 0000000000000000000------------";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(930, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Jumlah";
            // 
            // TxtJumlah
            // 
            this.TxtJumlah.Location = new System.Drawing.Point(912, 253);
            this.TxtJumlah.Name = "TxtJumlah";
            this.TxtJumlah.Size = new System.Drawing.Size(84, 20);
            this.TxtJumlah.TabIndex = 26;
            // 
            // LblKode
            // 
            this.LblKode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKode.ForeColor = System.Drawing.Color.MintCream;
            this.LblKode.Location = new System.Drawing.Point(818, 256);
            this.LblKode.Name = "LblKode";
            this.LblKode.Size = new System.Drawing.Size(90, 16);
            this.LblKode.TabIndex = 27;
            this.LblKode.Text = "kode";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(40, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 34);
            this.label2.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(21, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(264, 20);
            this.label9.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(916, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 20);
            this.label10.TabIndex = 29;
            // 
            // POS_sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.LblKode);
            this.Controls.Add(this.TxtJumlah);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LblNamaBarang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtCari);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Name = "POS_sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POS_sales";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.POS_sales_FormClosing);
            this.Load += new System.EventHandler(this.POS_sales_Load);
            this.panId.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtCari;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblNamaBarang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtJumlah;
        private System.Windows.Forms.Label LblKode;
        private System.Windows.Forms.Label LblNoFaktur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}