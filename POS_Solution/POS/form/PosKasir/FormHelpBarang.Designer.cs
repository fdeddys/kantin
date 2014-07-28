namespace POS.form.PosKasir
{
    partial class FormHelpBarang
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCariBarang = new System.Windows.Forms.TextBox();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.labelKeteranganBawah = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVBarang
            // 
            this.dGVBarang.AllowUserToAddRows = false;
            this.dGVBarang.AllowUserToDeleteRows = false;
            this.dGVBarang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVBarang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGVBarang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dGVBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVBarang.Location = new System.Drawing.Point(13, 63);
            this.dGVBarang.Margin = new System.Windows.Forms.Padding(4);
            this.dGVBarang.Name = "dGVBarang";
            this.dGVBarang.ReadOnly = true;
            this.dGVBarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVBarang.Size = new System.Drawing.Size(828, 390);
            this.dGVBarang.TabIndex = 1;
            this.dGVBarang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dGVBarang_KeyDown);
            this.dGVBarang.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dGVBarang_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 36;
            this.label1.Text = "Nama Barang";
            // 
            // txtCariBarang
            // 
            this.txtCariBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCariBarang.Location = new System.Drawing.Point(108, 10);
            this.txtCariBarang.Name = "txtCariBarang";
            this.txtCariBarang.Size = new System.Drawing.Size(734, 26);
            this.txtCariBarang.TabIndex = 0;
            this.txtCariBarang.TextChanged += new System.EventHandler(this.txtCariBarang_TextChanged);
            this.txtCariBarang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCariBarang_KeyPress);
            this.txtCariBarang.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCariBarang_KeyUp);
            // 
            // btnFirst
            // 
            this.btnFirst.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFirst.Location = new System.Drawing.Point(41, 461);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(196, 44);
            this.btnFirst.TabIndex = 2;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(237, 461);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(196, 44);
            this.btnPrev.TabIndex = 3;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(433, 461);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(196, 44);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(629, 461);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(196, 44);
            this.btnLast.TabIndex = 5;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // labelKeteranganBawah
            // 
            this.labelKeteranganBawah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelKeteranganBawah.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKeteranganBawah.ForeColor = System.Drawing.Color.DarkRed;
            this.labelKeteranganBawah.Location = new System.Drawing.Point(-2, 39);
            this.labelKeteranganBawah.Name = "labelKeteranganBawah";
            this.labelKeteranganBawah.Size = new System.Drawing.Size(852, 20);
            this.labelKeteranganBawah.TabIndex = 37;
            this.labelKeteranganBawah.Text = "   ESC  :  Kembali  -  F1  :  Hal pertama  -  F2  :  hal sebelumnya -  F3  :  hal" +
    " selanjutnya  -  F4  :  hal terakhir  -  DOWN  : pilih grid";
            // 
            // FormHelpBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(854, 515);
            this.ControlBox = false;
            this.Controls.Add(this.labelKeteranganBawah);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.txtCariBarang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGVBarang);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHelpBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHelpBarang";
            this.Load += new System.EventHandler(this.FormHelpBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVBarang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVBarang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCariBarang;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Label labelKeteranganBawah;
    }
}