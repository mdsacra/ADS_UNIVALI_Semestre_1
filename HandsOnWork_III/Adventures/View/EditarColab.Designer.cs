namespace Adventures.View
{
    partial class EditarColab
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
            this.editNomeColab = new System.Windows.Forms.TextBox();
            this.editDptoColab = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.editEmailColab = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.salvarAltColab = new System.Windows.Forms.Button();
            this.editFoneColab = new System.Windows.Forms.TextBox();
            this.editSalColab = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // editNomeColab
            // 
            this.editNomeColab.Location = new System.Drawing.Point(98, 44);
            this.editNomeColab.Name = "editNomeColab";
            this.editNomeColab.Size = new System.Drawing.Size(377, 23);
            this.editNomeColab.TabIndex = 0;
            // 
            // editDptoColab
            // 
            this.editDptoColab.FormattingEnabled = true;
            this.editDptoColab.Location = new System.Drawing.Point(354, 102);
            this.editDptoColab.Name = "editDptoColab";
            this.editDptoColab.Size = new System.Drawing.Size(121, 23);
            this.editDptoColab.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Salário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nome";
            // 
            // editEmailColab
            // 
            this.editEmailColab.Location = new System.Drawing.Point(271, 73);
            this.editEmailColab.Name = "editEmailColab";
            this.editEmailColab.Size = new System.Drawing.Size(204, 23);
            this.editEmailColab.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Departamento";
            // 
            // salvarAltColab
            // 
            this.salvarAltColab.Location = new System.Drawing.Point(367, 158);
            this.salvarAltColab.Name = "salvarAltColab";
            this.salvarAltColab.Size = new System.Drawing.Size(108, 23);
            this.salvarAltColab.TabIndex = 10;
            this.salvarAltColab.Text = "Salvar Alterações";
            this.salvarAltColab.UseVisualStyleBackColor = true;
            this.salvarAltColab.Click += new System.EventHandler(this.salvarAltColab_Click);
            // 
            // editFoneColab
            // 
            this.editFoneColab.Location = new System.Drawing.Point(98, 73);
            this.editFoneColab.Name = "editFoneColab";
            this.editFoneColab.Size = new System.Drawing.Size(100, 23);
            this.editFoneColab.TabIndex = 11;
            // 
            // editSalColab
            // 
            this.editSalColab.Location = new System.Drawing.Point(98, 102);
            this.editSalColab.Name = "editSalColab";
            this.editSalColab.Size = new System.Drawing.Size(100, 23);
            this.editSalColab.TabIndex = 12;
            // 
            // EditarColab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 221);
            this.Controls.Add(this.editSalColab);
            this.Controls.Add(this.editFoneColab);
            this.Controls.Add(this.salvarAltColab);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.editEmailColab);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editDptoColab);
            this.Controls.Add(this.editNomeColab);
            this.Name = "EditarColab";
            this.Text = "Colaborador - Editar Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox editNomeColab;
        private System.Windows.Forms.ComboBox editDptoColab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox editEmailColab;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button salvarAltColab;
        private System.Windows.Forms.TextBox editFoneColab;
        private System.Windows.Forms.TextBox editSalColab;
    }
}