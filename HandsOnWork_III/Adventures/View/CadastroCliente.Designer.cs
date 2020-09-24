namespace Adventures.View
{
    partial class CadastroCliente
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.removerCliente = new System.Windows.Forms.Button();
            this.editarCliente = new System.Windows.Forms.Button();
            this.cadastrarCliente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.emailCliente = new System.Windows.Forms.TextBox();
            this.cpfCliente = new System.Windows.Forms.TextBox();
            this.nomeCliente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 279);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.Text = "dataGridView1";
            // 
            // removerCliente
            // 
            this.removerCliente.Location = new System.Drawing.Point(654, 82);
            this.removerCliente.Name = "removerCliente";
            this.removerCliente.Size = new System.Drawing.Size(75, 23);
            this.removerCliente.TabIndex = 5;
            this.removerCliente.Text = "Remover";
            this.removerCliente.UseVisualStyleBackColor = true;
            this.removerCliente.Click += new System.EventHandler(this.removerCliente_Click);
            // 
            // editarCliente
            // 
            this.editarCliente.Location = new System.Drawing.Point(654, 53);
            this.editarCliente.Name = "editarCliente";
            this.editarCliente.Size = new System.Drawing.Size(75, 23);
            this.editarCliente.TabIndex = 5;
            this.editarCliente.Text = "Editar";
            this.editarCliente.UseVisualStyleBackColor = true;
            // 
            // cadastrarCliente
            // 
            this.cadastrarCliente.Location = new System.Drawing.Point(654, 24);
            this.cadastrarCliente.Name = "cadastrarCliente";
            this.cadastrarCliente.Size = new System.Drawing.Size(75, 23);
            this.cadastrarCliente.TabIndex = 5;
            this.cadastrarCliente.Text = "Cadastrar";
            this.cadastrarCliente.UseVisualStyleBackColor = true;
            this.cadastrarCliente.Click += new System.EventHandler(this.cadastrarCliente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "CPF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nome";
            // 
            // emailCliente
            // 
            this.emailCliente.Location = new System.Drawing.Point(78, 82);
            this.emailCliente.Name = "emailCliente";
            this.emailCliente.Size = new System.Drawing.Size(204, 23);
            this.emailCliente.TabIndex = 0;
            // 
            // cpfCliente
            // 
            this.cpfCliente.Location = new System.Drawing.Point(78, 53);
            this.cpfCliente.Name = "cpfCliente";
            this.cpfCliente.Size = new System.Drawing.Size(204, 23);
            this.cpfCliente.TabIndex = 0;
            // 
            // nomeCliente
            // 
            this.nomeCliente.Location = new System.Drawing.Point(78, 24);
            this.nomeCliente.Name = "nomeCliente";
            this.nomeCliente.Size = new System.Drawing.Size(377, 23);
            this.nomeCliente.TabIndex = 0;
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nomeCliente);
            this.Controls.Add(this.cpfCliente);
            this.Controls.Add(this.emailCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cadastrarCliente);
            this.Controls.Add(this.editarCliente);
            this.Controls.Add(this.removerCliente);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CadastroCliente";
            this.Text = "CadastroCliente";
            this.Load += new System.EventHandler(this.CadastroCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button removerCliente;
        private System.Windows.Forms.Button editarCliente;
        private System.Windows.Forms.Button cadastrarCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox emailCliente;
        private System.Windows.Forms.TextBox cpfCliente;
        private System.Windows.Forms.TextBox nomeCliente;
    }
}