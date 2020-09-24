namespace Adventures.View
{
    partial class CadastroEmpTrans
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
            this.editarEmpresa = new System.Windows.Forms.Button();
            this.removerEmpresa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cadastrarEmpresa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cnpjEmpresa = new System.Windows.Forms.TextBox();
            this.nomeEmpresa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tipoEmpresa = new System.Windows.Forms.ComboBox();
            this.respEmpresa = new System.Windows.Forms.TextBox();
            this.cpfRespEmp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(776, 295);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.Text = "dataGridView1";
            // 
            // editarEmpresa
            // 
            this.editarEmpresa.Location = new System.Drawing.Point(662, 53);
            this.editarEmpresa.Name = "editarEmpresa";
            this.editarEmpresa.Size = new System.Drawing.Size(75, 23);
            this.editarEmpresa.TabIndex = 5;
            this.editarEmpresa.Text = "Editar";
            this.editarEmpresa.UseVisualStyleBackColor = true;
            
            // 
            // removerEmpresa
            // 
            this.removerEmpresa.Location = new System.Drawing.Point(662, 82);
            this.removerEmpresa.Name = "removerEmpresa";
            this.removerEmpresa.Size = new System.Drawing.Size(75, 23);
            this.removerEmpresa.TabIndex = 5;
            this.removerEmpresa.Text = "Remover";
            this.removerEmpresa.UseVisualStyleBackColor = true;
            this.removerEmpresa.Click += new System.EventHandler(this.removerEmpresa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Responsável";
            // 
            // cadastrarEmpresa
            // 
            this.cadastrarEmpresa.Location = new System.Drawing.Point(662, 24);
            this.cadastrarEmpresa.Name = "cadastrarEmpresa";
            this.cadastrarEmpresa.Size = new System.Drawing.Size(75, 23);
            this.cadastrarEmpresa.TabIndex = 5;
            this.cadastrarEmpresa.Text = "Cadastrar";
            this.cadastrarEmpresa.UseVisualStyleBackColor = true;
            this.cadastrarEmpresa.Click += new System.EventHandler(this.cadastrarEmpresa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "CNPJ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nome";
            // 
            // cnpjEmpresa
            // 
            this.cnpjEmpresa.Location = new System.Drawing.Point(90, 53);
            this.cnpjEmpresa.Name = "cnpjEmpresa";
            this.cnpjEmpresa.Size = new System.Drawing.Size(169, 23);
            this.cnpjEmpresa.TabIndex = 0;
            // 
            // nomeEmpresa
            // 
            this.nomeEmpresa.Location = new System.Drawing.Point(90, 24);
            this.nomeEmpresa.Name = "nomeEmpresa";
            this.nomeEmpresa.Size = new System.Drawing.Size(377, 23);
            this.nomeEmpresa.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(308, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tipo";
            // 
            // tipoEmpresa
            // 
            this.tipoEmpresa.FormattingEnabled = true;
            this.tipoEmpresa.Location = new System.Drawing.Point(344, 53);
            this.tipoEmpresa.Name = "tipoEmpresa";
            this.tipoEmpresa.Size = new System.Drawing.Size(123, 23);
            this.tipoEmpresa.TabIndex = 6;
            // 
            // respEmpresa
            // 
            this.respEmpresa.Location = new System.Drawing.Point(90, 82);
            this.respEmpresa.Name = "respEmpresa";
            this.respEmpresa.Size = new System.Drawing.Size(169, 23);
            this.respEmpresa.TabIndex = 0;
            // 
            // cpfRespEmp
            // 
            this.cpfRespEmp.Location = new System.Drawing.Point(344, 82);
            this.cpfRespEmp.Name = "cpfRespEmp";
            this.cpfRespEmp.Size = new System.Drawing.Size(123, 23);
            this.cpfRespEmp.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "CPF Resp.";
            // 
            // CadastroEmpTrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cpfRespEmp);
            this.Controls.Add(this.respEmpresa);
            this.Controls.Add(this.tipoEmpresa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nomeEmpresa);
            this.Controls.Add(this.cnpjEmpresa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cadastrarEmpresa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removerEmpresa);
            this.Controls.Add(this.editarEmpresa);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CadastroEmpTrans";
            this.Text = "CadastroEmpTrans";
            this.Load += new System.EventHandler(this.CadastroEmpTrans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button editarEmpresa;
        private System.Windows.Forms.Button removerEmpresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cadastrarEmpresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cnpjEmpresa;
        private System.Windows.Forms.TextBox nomeEmpresa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox tipoEmpresa;
        private System.Windows.Forms.TextBox respEmpresa;
        private System.Windows.Forms.TextBox cpfRespEmp;
        private System.Windows.Forms.Label label2;
    }
}