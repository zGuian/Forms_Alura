﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_HelloWorld : Form
    {
        public Frm_HelloWorld()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_ModificaLabel_Click(object sender, EventArgs e)
        {
            lbl_Titulo.Text = txt_ConteudoLabel.Text;
        }

        private void txt_ConteudoLabel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
