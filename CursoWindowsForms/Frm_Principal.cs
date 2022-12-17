using System;
using System.Drawing;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Btn_DemostracaoKey_Click(object sender, EventArgs e)
        {
            Frm_DemonstracaoKey formulario = new Frm_DemonstracaoKey();
            formulario.ShowDialog();
        }

        private void Btn_HelloWorld_Click(object sender, EventArgs e)
        {
            Frm_HelloWorld formulario = new Frm_HelloWorld();
            formulario.ShowDialog();
        }

        private void Btn_Mascara_Click(object sender, EventArgs e)
        {
            Frm_Mascara formulario = new Frm_Mascara();
            formulario.ShowDialog();
        }

        private void Btn_ValidaCPF_Click(object sender, EventArgs e)
        {
            Frm_ValidaCPF formulario = new Frm_ValidaCPF();
            formulario.ShowDialog();
        }

        private void Btn_ValidaCPF2_Click(object sender, EventArgs e)
        {
            Frm_ValidaCPF2 formulario = new Frm_ValidaCPF2();
            formulario.ShowDialog();
        }

        private void Btn_ValidaSenha_Click(object sender, EventArgs e)
        {
            Frm_ValidaSenha formulario = new Frm_ValidaSenha();
            formulario.ShowDialog();
        }
    }
}
