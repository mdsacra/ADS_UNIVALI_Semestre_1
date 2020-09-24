namespace Adventures.View
{
    partial class EditarCliente
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
            this.editNomeCliente = new System.Windows.Forms.TextBox();
            this.editCpfCliente = new System.Windows.Forms.TextBox();
            this.editEmailCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.salvarAltClientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editNomeCliente
            // 
            this.editNomeCliente.Location = new System.Drawing.Point(85, 31);
            this.editNomeCliente.Name = "editNomeCliente";
            this.editNomeCliente.Size = new System.Drawing.Size(377, 23);
            this.editNomeCliente.TabIndex = 0;
            // 
            // editCpfCliente
            // 
            this.editCpfCliente.Location = new System.Drawing.Point(85, 60);
            this.editCpfCliente.Name = "editCpfCliente";
            this.editCpfCliente.Size = new System.Drawing.Size(137, 23);
            this.editCpfCliente.TabIndex = 0;
            // 
            // editEmailCliente
            // 
            this.editEmailCliente.Location = new System.Drawing.Point(290, 60);
            this.editEmailCliente.Name = "editEmailCliente";
            this.editEmailCliente.Size = new System.Drawing.Size(172, 23);
            this.editEmailCliente.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            // 
            // salvarAltClientes
            // 
            this.salvarAltClientes.Location = new System.Drawing.Point(338, 110);
            this.salvarAltClientes.Name = "salvarAltClientes";
            this.salvarAltClientes.Size = new System.Drawing.Size(124, 28);
            this.salvarAltClientes.TabIndex = 4;
            this.salvarAltClientes.Text = "Salvar Alterações";
            this.salvarAltClientes.UseVisualStyleBackColor = true;
            this.salvarAltClientes.Click += new System.EventHandler(this.salvarAltClientes_Click);
            // 
            // EditarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 167);
            this.Controls.Add(this.salvarAltClientes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editEmailCliente);
            this.Controls.Add(this.editCpfCliente);
            this.Controls.Add(this.editNomeCliente);
            this.Name = "EditarCliente";
            this.Text = "EditarCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox editNomeCliente;
        private System.Windows.Forms.TextBox editCpfCliente;
        private System.Windows.Forms.TextBox editEmailCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button salvarAltClientes;
    }
}