namespace Adventures.View
{
    partial class CadastroColaborador
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
            this.colabNome = new System.Windows.Forms.TextBox();
            this.colabFone = new System.Windows.Forms.TextBox();
            this.colabEmail = new System.Windows.Forms.TextBox();
            this.colabSalario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cadastraColab = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buscaColab = new System.Windows.Forms.Button();
            this.removeColab = new System.Windows.Forms.Button();
            this.editaColab = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // colabNome
            // 
            this.colabNome.Location = new System.Drawing.Point(78, 34);
            this.colabNome.Name = "colabNome";
            this.colabNome.Size = new System.Drawing.Size(377, 23);
            this.colabNome.TabIndex = 0;
            // 
            // colabFone
            // 
            this.colabFone.Location = new System.Drawing.Point(78, 63);
            this.colabFone.Name = "colabFone";
            this.colabFone.Size = new System.Drawing.Size(105, 23);
            this.colabFone.TabIndex = 0;
            // 
            // colabEmail
            // 
            this.colabEmail.Location = new System.Drawing.Point(251, 63);
            this.colabEmail.Name = "colabEmail";
            this.colabEmail.Size = new System.Drawing.Size(204, 23);
            this.colabEmail.TabIndex = 0;
            // 
            // colabSalario
            // 
            this.colabSalario.Location = new System.Drawing.Point(78, 92);
            this.colabSalario.Name = "colabSalario";
            this.colabSalario.Size = new System.Drawing.Size(105, 23);
            this.colabSalario.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Salário";
            // 
            // cadastraColab
            // 
            this.cadastraColab.Location = new System.Drawing.Point(525, 33);
            this.cadastraColab.Name = "cadastraColab";
            this.cadastraColab.Size = new System.Drawing.Size(75, 23);
            this.cadastraColab.TabIndex = 5;
            this.cadastraColab.Text = "Cadastrar";
            this.cadastraColab.UseVisualStyleBackColor = true;
            this.cadastraColab.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(300, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Departamento";
            // 
            // buscaColab
            // 
            this.buscaColab.Location = new System.Drawing.Point(525, 62);
            this.buscaColab.Name = "buscaColab";
            this.buscaColab.Size = new System.Drawing.Size(75, 23);
            this.buscaColab.TabIndex = 5;
            this.buscaColab.Text = "Buscar";
            this.buscaColab.UseVisualStyleBackColor = true;
            this.buscaColab.Click += new System.EventHandler(this.button1_Click);
            // 
            // removeColab
            // 
            this.removeColab.Location = new System.Drawing.Point(606, 62);
            this.removeColab.Name = "removeColab";
            this.removeColab.Size = new System.Drawing.Size(75, 23);
            this.removeColab.TabIndex = 5;
            this.removeColab.Text = "Remover";
            this.removeColab.UseVisualStyleBackColor = true;
            this.removeColab.Click += new System.EventHandler(this.button1_Click);
            // 
            // editaColab
            // 
            this.editaColab.Location = new System.Drawing.Point(606, 33);
            this.editaColab.Name = "editaColab";
            this.editaColab.Size = new System.Drawing.Size(75, 23);
            this.editaColab.TabIndex = 5;
            this.editaColab.Text = "Editar";
            this.editaColab.UseVisualStyleBackColor = true;
            this.editaColab.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 295);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.Text = "dataGridView1";
            // 
            // CadastroColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.editaColab);
            this.Controls.Add(this.removeColab);
            this.Controls.Add(this.buscaColab);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cadastraColab);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colabSalario);
            this.Controls.Add(this.colabEmail);
            this.Controls.Add(this.colabFone);
            this.Controls.Add(this.colabNome);
            this.Name = "CadastroColaborador";
            this.Text = "CadastroColaborador";
            this.Load += new System.EventHandler(this.CadastroColaborador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox colabNome;
        private System.Windows.Forms.TextBox colabFone;
        private System.Windows.Forms.TextBox colabEmail;
        private System.Windows.Forms.TextBox colabSalario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cadastraColab;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buscaColab;
        private System.Windows.Forms.Button removeColab;
        private System.Windows.Forms.Button editaColab;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}