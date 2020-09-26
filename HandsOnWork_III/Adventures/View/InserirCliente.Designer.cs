namespace Adventures.View
{
    partial class InserirCliente
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.salvarCliente = new System.Windows.Forms.Button();
            this.novoCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(440, 260);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Text = "dataGridView1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 23);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar Cliente";
            // 
            // salvarCliente
            // 
            this.salvarCliente.Location = new System.Drawing.Point(161, 367);
            this.salvarCliente.Name = "salvarCliente";
            this.salvarCliente.Size = new System.Drawing.Size(132, 56);
            this.salvarCliente.TabIndex = 3;
            this.salvarCliente.Text = "Inserir Cliente no Pacote";
            this.salvarCliente.UseVisualStyleBackColor = true;
            this.salvarCliente.Click += new System.EventHandler(this.salvarCliente_Click);
            // 
            // novoCliente
            // 
            this.novoCliente.Location = new System.Drawing.Point(346, 36);
            this.novoCliente.Name = "novoCliente";
            this.novoCliente.Size = new System.Drawing.Size(88, 23);
            this.novoCliente.TabIndex = 4;
            this.novoCliente.Text = "Novo Cliente";
            this.novoCliente.UseVisualStyleBackColor = true;
            this.novoCliente.Click += new System.EventHandler(this.novoCliente_Click);
            // 
            // InserirCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 450);
            this.Controls.Add(this.novoCliente);
            this.Controls.Add(this.salvarCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "InserirCliente";
            this.Text = "InserirCliente";
            this.Load += new System.EventHandler(this.InserirCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button salvarCliente;
        private System.Windows.Forms.Button novoCliente;
    }
}