using CursoWindowsFormsBiblioteca;
using System;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_ValidaCPF2 : Form
    {
        public Frm_ValidaCPF2()
        {
            InitializeComponent();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Msk_CPF.Text = "";
            Msk_CPF.Focus();
        }

        private void Btn_Valida_Click(object sender, EventArgs e)
        {
            string verConteudo;
            verConteudo = Msk_CPF.Text;
            verConteudo = verConteudo.Replace(".", "").Replace("-", "").Trim();
            //verConteudo = verConteudo.Trim();

            if (verConteudo == "")
            {
                MessageBox.Show("Você deve digitar um CPF", "Mensagem de validação", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                Msk_CPF.Focus();
            }
            else
            {
                if (verConteudo.Length != 11)
                {
                    MessageBox.Show("CPF deve ter 11 dígitos", "Mensagem de validação", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                    Msk_CPF.Focus();
                }
                else
                {
                    if (MessageBox.Show("Você deseja realmente validar o CPF?", "Mensagem de validação", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        bool validaCPF = false;
                        validaCPF = Cls_Uteis.Valida(Msk_CPF.Text);
                        if (validaCPF == true)
                        {
                            MessageBox.Show("CPF VÁLIDO", "Mensagem de validação", MessageBoxButtons.OK, 
                            MessageBoxIcon.Information);
                            Msk_CPF.Focus();
                        }
                        else
                        {
                            MessageBox.Show("CPF INVÁLIDO", "Mensagem de validação", MessageBoxButtons.OK, 
                            MessageBoxIcon.Error);
                            Msk_CPF.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Obrigado", "Mensagem de validação", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        Msk_CPF.Focus();
                    }
                }
            }
        }
    }
}