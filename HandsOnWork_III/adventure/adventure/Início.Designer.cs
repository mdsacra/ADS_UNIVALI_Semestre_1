namespace adventure
{
    partial class TelaInicio
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
            this.pacotes = new System.Windows.Forms.Button();
            this.cadastrar = new System.Windows.Forms.Button();
            this.buscar = new System.Windows.Forms.Button();
            this.sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pacotes
            // 
            this.pacotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pacotes.Location = new System.Drawing.Point(162, 102);
            this.pacotes.Name = "pacotes";
            this.pacotes.Size = new System.Drawing.Size(454, 87);
            this.pacotes.TabIndex = 0;
            this.pacotes.Text = "Listar Pacotes de Viagens";
            this.pacotes.UseVisualStyleBackColor = true;
            // 
            // cadastrar
            // 
            this.cadastrar.Location = new System.Drawing.Point(201, 346);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(99, 23);
            this.cadastrar.TabIndex = 1;
            this.cadastrar.Text = "Novo Cadastro";
            this.cadastrar.UseVisualStyleBackColor = true;
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(355, 346);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(82, 23);
            this.buscar.TabIndex = 2;
            this.buscar.Text = "Nova Busca";
            this.buscar.UseVisualStyleBackColor = true;
            // 
            // sair
            // 
            this.sair.Location = new System.Drawing.Point(496, 346);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(75, 23);
            this.sair.TabIndex = 3;
            this.sair.Text = "Sair";
            this.sair.UseVisualStyleBackColor = true;
            // 
            // TelaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.cadastrar);
            this.Controls.Add(this.pacotes);
            this.Name = "TelaInicio";
            this.Text = "AdVenture - Início";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pacotes;
        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.Button sair;
    }
}