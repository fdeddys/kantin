﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.form
{
    public partial class LoginUtama : Form
    {
        public LoginUtama()
        {
            InitializeComponent();
        }

        private void btnCancelLogin_Click(object sender, EventArgs e)
        {
            MenuUtama.userLogin = "x";
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuUtama.userLogin = txtUserId.Text;
            Func.VarGlobal.UserNameLogin = txtUserId.Text;
            this.Close();
        }

        private void LoginUtama_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath shape = new System.Drawing.Drawing2D.GraphicsPath();
            shape.AddEllipse(0, 0, this.Width, this.Height);
            this.Region = new System.Drawing.Region(shape);
        }
    }
}
