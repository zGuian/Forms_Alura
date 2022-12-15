namespace CursoWindowsForms
{
    partial class Frm_HelloWorld
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
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.Btn_ModificaLabel = new System.Windows.Forms.Button();
            this.txt_ConteudoLabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(13, 13);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(206, 19);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Visual Studio .Net Version";
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.Location = new System.Drawing.Point(198, 138);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(121, 37);
            this.Btn_Sair.TabIndex = 1;
            this.Btn_Sair.Text = "Fechar a aplicação";
            this.Btn_Sair.UseVisualStyleBackColor = true;
            this.Btn_Sair.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // Btn_ModificaLabel
            // 
            this.Btn_ModificaLabel.Location = new System.Drawing.Point(17, 35);
            this.Btn_ModificaLabel.Name = "Btn_ModificaLabel";
            this.Btn_ModificaLabel.Size = new System.Drawing.Size(202, 31);
            this.Btn_ModificaLabel.TabIndex = 2;
            this.Btn_ModificaLabel.Text = "Modificador de Label";
            this.Btn_ModificaLabel.UseVisualStyleBackColor = true;
            this.Btn_ModificaLabel.Click += new System.EventHandler(this.Btn_ModificaLabel_Click);
            // 
            // txt_ConteudoLabel
            // 
            this.txt_ConteudoLabel.Location = new System.Drawing.Point(17, 75);
            this.txt_ConteudoLabel.Multiline = true;
            this.txt_ConteudoLabel.Name = "txt_ConteudoLabel";
            this.txt_ConteudoLabel.Size = new System.Drawing.Size(201, 39);
            this.txt_ConteudoLabel.TabIndex = 3;
            this.txt_ConteudoLabel.TextChanged += new System.EventHandler(this.txt_ConteudoLabel_TextChanged);
            // 
            // Frm_HelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(331, 187);
            this.Controls.Add(this.txt_ConteudoLabel);
            this.Controls.Add(this.Btn_ModificaLabel);
            this.Controls.Add(this.Btn_Sair);
            this.Controls.Add(this.lbl_Titulo);
            this.MinimizeBox = false;
            this.Name = "Frm_HelloWorld";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello World";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Button Btn_Sair;
        private System.Windows.Forms.Button Btn_ModificaLabel;
        private System.Windows.Forms.TextBox txt_ConteudoLabel;
    }
}

