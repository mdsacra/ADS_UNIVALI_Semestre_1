namespace adventure
{
    partial class buscar
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
            this.voltarBusca = new System.Windows.Forms.Button();
            this.realizarBusca = new System.Windows.Forms.Button();
            this.buscarEmpresa = new System.Windows.Forms.RadioButton();
            this.buscarColab = new System.Windows.Forms.RadioButton();
            this.buscarCliente = new System.Windows.Forms.RadioButton();
            this.buscarPacote = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // voltarBusca
            // 
            this.voltarBusca.Location = new System.Drawing.Point(131, 103);
            this.voltarBusca.Name = "voltarBusca";
            this.voltarBusca.Size = new System.Drawing.Size(75, 23);
            this.voltarBusca.TabIndex = 13;
            this.voltarBusca.Text = "Voltar";
            this.voltarBusca.UseVisualStyleBackColor = true;
            // 
            // realizarBusca
            // 
            this.realizarBusca.Location = new System.Drawing.Point(38, 103);
            this.realizarBusca.Name = "realizarBusca";
            this.realizarBusca.Size = new System.Drawing.Size(75, 23);
            this.realizarBusca.TabIndex = 12;
            this.realizarBusca.Text = "Buscar";
            this.realizarBusca.UseVisualStyleBackColor = true;
            // 
            // buscarEmpresa
            // 
            this.buscarEmpresa.AutoSize = true;
            this.buscarEmpresa.Location = new System.Drawing.Point(358, 64);
            this.buscarEmpresa.Name = "buscarEmpresa";
            this.buscarEmpresa.Size = new System.Drawing.Size(140, 17);
            this.buscarEmpresa.TabIndex = 11;
            this.buscarEmpresa.TabStop = true;
            this.buscarEmpresa.Text = "Empresa de Transportes";
            this.buscarEmpresa.UseVisualStyleBackColor = true;
            // 
            // buscarColab
            // 
            this.buscarColab.AutoSize = true;
            this.buscarColab.Location = new System.Drawing.Point(253, 64);
            this.buscarColab.Name = "buscarColab";
            this.buscarColab.Size = new System.Drawing.Size(82, 17);
            this.buscarColab.TabIndex = 10;
            this.buscarColab.TabStop = true;
            this.buscarColab.Text = "Colaborador";
            this.buscarColab.UseVisualStyleBackColor = true;
            // 
            // buscarCliente
            // 
            this.buscarCliente.AutoSize = true;
            this.buscarCliente.Location = new System.Drawing.Point(173, 64);
            this.buscarCliente.Name = "buscarCliente";
            this.buscarCliente.Size = new System.Drawing.Size(57, 17);
            this.buscarCliente.TabIndex = 9;
            this.buscarCliente.TabStop = true;
            this.buscarCliente.Text = "Cliente";
            this.buscarCliente.UseVisualStyleBackColor = true;
            // 
            // buscarPacote
            // 
            this.buscarPacote.AutoSize = true;
            this.buscarPacote.Location = new System.Drawing.Point(38, 64);
            this.buscarPacote.Name = "buscarPacote";
            this.buscarPacote.Size = new System.Drawing.Size(112, 17);
            this.buscarPacote.TabIndex = 8;
            this.buscarPacote.TabStop = true;
            this.buscarPacote.Text = "Pacote de Viagem";
            this.buscarPacote.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "O que você procura?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "(Área para os dados da busca)";
            // 
            // buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.voltarBusca);
            this.Controls.Add(this.realizarBusca);
            this.Controls.Add(this.buscarEmpresa);
            this.Controls.Add(this.buscarColab);
            this.Controls.Add(this.buscarCliente);
            this.Controls.Add(this.buscarPacote);
            this.Controls.Add(this.label1);
            this.Name = "buscar";
            this.Text = "Buscar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button voltarBusca;
        private System.Windows.Forms.Button realizarBusca;
        private System.Windows.Forms.RadioButton buscarEmpresa;
        private System.Windows.Forms.RadioButton buscarColab;
        private System.Windows.Forms.RadioButton buscarCliente;
        private System.Windows.Forms.RadioButton buscarPacote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}