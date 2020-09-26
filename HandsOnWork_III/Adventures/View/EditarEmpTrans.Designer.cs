namespace Adventures.View
{
    partial class EditarEmpTrans
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
            this.label1 = new System.Windows.Forms.Label();
            this.editCpfRespEmpTrans = new System.Windows.Forms.TextBox();
            this.editRespEmpTrans = new System.Windows.Forms.TextBox();
            this.editTipoEmpTrans = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.editNomeEmpTrans = new System.Windows.Forms.TextBox();
            this.editCnpjEmpTrans = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.salvarAltEmpTrans = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "CPF Resp.";
            // 
            // editCpfRespEmpTrans
            // 
            this.editCpfRespEmpTrans.Location = new System.Drawing.Point(368, 101);
            this.editCpfRespEmpTrans.Name = "editCpfRespEmpTrans";
            this.editCpfRespEmpTrans.Size = new System.Drawing.Size(123, 23);
            this.editCpfRespEmpTrans.TabIndex = 0;
            // 
            // editRespEmpTrans
            // 
            this.editRespEmpTrans.Location = new System.Drawing.Point(114, 101);
            this.editRespEmpTrans.Name = "editRespEmpTrans";
            this.editRespEmpTrans.Size = new System.Drawing.Size(169, 23);
            this.editRespEmpTrans.TabIndex = 0;
            // 
            // editTipoEmpTrans
            // 
            this.editTipoEmpTrans.FormattingEnabled = true;
            this.editTipoEmpTrans.Location = new System.Drawing.Point(368, 72);
            this.editTipoEmpTrans.Name = "editTipoEmpTrans";
            this.editTipoEmpTrans.Size = new System.Drawing.Size(123, 23);
            this.editTipoEmpTrans.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tipo";
            // 
            // editNomeEmpTrans
            // 
            this.editNomeEmpTrans.Location = new System.Drawing.Point(114, 43);
            this.editNomeEmpTrans.Name = "editNomeEmpTrans";
            this.editNomeEmpTrans.Size = new System.Drawing.Size(377, 23);
            this.editNomeEmpTrans.TabIndex = 0;
            // 
            // editCnpjEmpTrans
            // 
            this.editCnpjEmpTrans.Location = new System.Drawing.Point(114, 72);
            this.editCnpjEmpTrans.Name = "editCnpjEmpTrans";
            this.editCnpjEmpTrans.Size = new System.Drawing.Size(169, 23);
            this.editCnpjEmpTrans.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "CNPJ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Responsável";
            // 
            // salvarAltEmpTrans
            // 
            this.salvarAltEmpTrans.Location = new System.Drawing.Point(368, 163);
            this.salvarAltEmpTrans.Name = "salvarAltEmpTrans";
            this.salvarAltEmpTrans.Size = new System.Drawing.Size(122, 29);
            this.salvarAltEmpTrans.TabIndex = 10;
            this.salvarAltEmpTrans.Text = "Salvar Alterações";
            this.salvarAltEmpTrans.UseVisualStyleBackColor = true;
            this.salvarAltEmpTrans.Click += new System.EventHandler(this.salvarAltEmpTrans_Click);
            // 
            // EditarEmpTrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 250);
            this.Controls.Add(this.salvarAltEmpTrans);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.editCnpjEmpTrans);
            this.Controls.Add(this.editNomeEmpTrans);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.editTipoEmpTrans);
            this.Controls.Add(this.editRespEmpTrans);
            this.Controls.Add(this.editCpfRespEmpTrans);
            this.Controls.Add(this.label1);
            this.Name = "EditarEmpTrans";
            this.Text = "Empresas de Transporte - Editar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox editCpfRespEmpTrans;
        private System.Windows.Forms.TextBox editRespEmpTrans;
        private System.Windows.Forms.ComboBox editTipoEmpTrans;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox editNomeEmpTrans;
        private System.Windows.Forms.TextBox editCnpjEmpTrans;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button salvarAltEmpTrans;
    }
}