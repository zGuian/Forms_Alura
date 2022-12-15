namespace CursoWindowsForms
{
    partial class Frm_ValidaSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ValidaSenha));
            this.Txt_Senha = new System.Windows.Forms.TextBox();
            this.Lbl_Resultado = new System.Windows.Forms.Label();
            this.Btn_Reset = new System.Windows.Forms.Button();
            this.Btn_VerSenha = new System.Windows.Forms.Button();
            this.Lbl_TItuloValidador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_Senha
            // 
            resources.ApplyResources(this.Txt_Senha, "Txt_Senha");
            this.Txt_Senha.Name = "Txt_Senha";
            this.Txt_Senha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Senha_KeyDown);
            // 
            // Lbl_Resultado
            // 
            resources.ApplyResources(this.Lbl_Resultado, "Lbl_Resultado");
            this.Lbl_Resultado.Name = "Lbl_Resultado";
            // 
            // Btn_Reset
            // 
            resources.ApplyResources(this.Btn_Reset, "Btn_Reset");
            this.Btn_Reset.Name = "Btn_Reset";
            this.Btn_Reset.UseVisualStyleBackColor = true;
            this.Btn_Reset.Click += new System.EventHandler(this.Btn_Reset_Click);
            // 
            // Btn_VerSenha
            // 
            resources.ApplyResources(this.Btn_VerSenha, "Btn_VerSenha");
            this.Btn_VerSenha.Name = "Btn_VerSenha";
            this.Btn_VerSenha.UseVisualStyleBackColor = true;
            this.Btn_VerSenha.Click += new System.EventHandler(this.Btn_VerSenha_Click);
            // 
            // Lbl_TItuloValidador
            // 
            resources.ApplyResources(this.Lbl_TItuloValidador, "Lbl_TItuloValidador");
            this.Lbl_TItuloValidador.Name = "Lbl_TItuloValidador";
            // 
            // Frm_ValidaSenha
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Lbl_TItuloValidador);
            this.Controls.Add(this.Btn_VerSenha);
            this.Controls.Add(this.Btn_Reset);
            this.Controls.Add(this.Lbl_Resultado);
            this.Controls.Add(this.Txt_Senha);
            this.MaximizeBox = false;
            this.Name = "Frm_ValidaSenha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Senha;
        private System.Windows.Forms.Label Lbl_Resultado;
        private System.Windows.Forms.Button Btn_Reset;
        private System.Windows.Forms.Button Btn_VerSenha;
        private System.Windows.Forms.Label Lbl_TItuloValidador;
    }
}