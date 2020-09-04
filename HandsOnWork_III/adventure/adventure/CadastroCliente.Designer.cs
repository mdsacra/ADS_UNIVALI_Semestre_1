namespace adventure
{
    partial class cadastroClientes
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
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.sairCliente = new System.Windows.Forms.Button();
            this.cadastraCliente = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dtNascCliente = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cpfCliente = new System.Windows.Forms.TextBox();
            this.emailCliente = new System.Windows.Forms.TextBox();
            this.foneCliente = new System.Windows.Forms.TextBox();
            this.nomeCliente = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(69, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 16);
            this.label12.TabIndex = 54;
            this.label12.Text = "Dados Pessoais";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(250, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(284, 25);
            this.label11.TabIndex = 53;
            this.label11.Text = "Cadastre um novo Cliente";
            // 
            // sairCliente
            // 
            this.sairCliente.Location = new System.Drawing.Point(684, 355);
            this.sairCliente.Name = "sairCliente";
            this.sairCliente.Size = new System.Drawing.Size(75, 23);
            this.sairCliente.TabIndex = 52;
            this.sairCliente.Text = "Cancelar";
            this.sairCliente.UseVisualStyleBackColor = true;
            // 
            // cadastraCliente
            // 
            this.cadastraCliente.Location = new System.Drawing.Point(562, 355);
            this.cadastraCliente.Name = "cadastraCliente";
            this.cadastraCliente.Size = new System.Drawing.Size(106, 23);
            this.cadastraCliente.TabIndex = 51;
            this.cadastraCliente.Text = "Cadastrar Cliente";
            this.cadastraCliente.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(318, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Data de Nascimento:";
            // 
            // dtNascCliente
            // 
            this.dtNascCliente.Location = new System.Drawing.Point(431, 196);
            this.dtNascCliente.Name = "dtNascCliente";
            this.dtNascCliente.Size = new System.Drawing.Size(235, 20);
            this.dtNascCliente.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Telefone:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Nome:";
            // 
            // cpfCliente
            // 
            this.cpfCliente.Location = new System.Drawing.Point(105, 196);
            this.cpfCliente.Name = "cpfCliente";
            this.cpfCliente.Size = new System.Drawing.Size(161, 20);
            this.cpfCliente.TabIndex = 32;
            // 
            // emailCliente
            // 
            this.emailCliente.Location = new System.Drawing.Point(359, 245);
            this.emailCliente.Name = "emailCliente";
            this.emailCliente.Size = new System.Drawing.Size(235, 20);
            this.emailCliente.TabIndex = 31;
            // 
            // foneCliente
            // 
            this.foneCliente.Location = new System.Drawing.Point(127, 245);
            this.foneCliente.Name = "foneCliente";
            this.foneCliente.Size = new System.Drawing.Size(139, 20);
            this.foneCliente.TabIndex = 30;
            // 
            // nomeCliente
            // 
            this.nomeCliente.Location = new System.Drawing.Point(120, 148);
            this.nomeCliente.Name = "nomeCliente";
            this.nomeCliente.Size = new System.Drawing.Size(283, 20);
            this.nomeCliente.TabIndex = 29;
            // 
            // cadastroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.sairCliente);
            this.Controls.Add(this.cadastraCliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtNascCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cpfCliente);
            this.Controls.Add(this.emailCliente);
            this.Controls.Add(this.foneCliente);
            this.Controls.Add(this.nomeCliente);
            this.Name = "cadastroClientes";
            this.Text = "Cadastro de Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button sairCliente;
        private System.Windows.Forms.Button cadastraCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtNascCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cpfCliente;
        private System.Windows.Forms.TextBox emailCliente;
        private System.Windows.Forms.TextBox foneCliente;
        private System.Windows.Forms.TextBox nomeCliente;
    }
}