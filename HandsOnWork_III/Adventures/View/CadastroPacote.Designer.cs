namespace Adventures.View
{
    partial class CadastroPacote
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
            this.empPacote = new System.Windows.Forms.ComboBox();
            this.cadastrarPacote = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.vlrEstadiaPacote = new System.Windows.Forms.TextBox();
            this.hotelPacote = new System.Windows.Forms.TextBox();
            this.paisPacote = new System.Windows.Forms.TextBox();
            this.cidadePacote = new System.Windows.Forms.TextBox();
            this.dataPartida = new System.Windows.Forms.DateTimePicker();
            this.dataRetorno = new System.Windows.Forms.DateTimePicker();
            this.vlrTransPacote = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.allInclusive = new System.Windows.Forms.CheckBox();
            this.cadEmpTrans = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Empresa";
            // 
            // empPacote
            // 
            this.empPacote.FormattingEnabled = true;
            this.empPacote.Location = new System.Drawing.Point(105, 124);
            this.empPacote.Name = "empPacote";
            this.empPacote.Size = new System.Drawing.Size(249, 23);
            this.empPacote.TabIndex = 6;
            // 
            // cadastrarPacote
            // 
            this.cadastrarPacote.Location = new System.Drawing.Point(379, 248);
            this.cadastrarPacote.Name = "cadastrarPacote";
            this.cadastrarPacote.Size = new System.Drawing.Size(75, 23);
            this.cadastrarPacote.TabIndex = 5;
            this.cadastrarPacote.Text = "Cadastrar";
            this.cadastrarPacote.UseVisualStyleBackColor = true;
            this.cadastrarPacote.Click += new System.EventHandler(this.cadastrarPacote_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor Estadia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hotel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "País";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Cidade";
            // 
            // vlrEstadiaPacote
            // 
            this.vlrEstadiaPacote.Location = new System.Drawing.Point(105, 95);
            this.vlrEstadiaPacote.Name = "vlrEstadiaPacote";
            this.vlrEstadiaPacote.Size = new System.Drawing.Size(105, 23);
            this.vlrEstadiaPacote.TabIndex = 0;
            // 
            // hotelPacote
            // 
            this.hotelPacote.Location = new System.Drawing.Point(105, 66);
            this.hotelPacote.Name = "hotelPacote";
            this.hotelPacote.Size = new System.Drawing.Size(204, 23);
            this.hotelPacote.TabIndex = 0;
            // 
            // paisPacote
            // 
            this.paisPacote.Location = new System.Drawing.Point(334, 37);
            this.paisPacote.Name = "paisPacote";
            this.paisPacote.Size = new System.Drawing.Size(120, 23);
            this.paisPacote.TabIndex = 0;
            // 
            // cidadePacote
            // 
            this.cidadePacote.Location = new System.Drawing.Point(105, 37);
            this.cidadePacote.Name = "cidadePacote";
            this.cidadePacote.Size = new System.Drawing.Size(139, 23);
            this.cidadePacote.TabIndex = 0;
            // 
            // dataPartida
            // 
            this.dataPartida.Location = new System.Drawing.Point(105, 153);
            this.dataPartida.Name = "dataPartida";
            this.dataPartida.Size = new System.Drawing.Size(249, 23);
            this.dataPartida.TabIndex = 8;
            // 
            // dataRetorno
            // 
            this.dataRetorno.Location = new System.Drawing.Point(105, 182);
            this.dataRetorno.Name = "dataRetorno";
            this.dataRetorno.Size = new System.Drawing.Size(249, 23);
            this.dataRetorno.TabIndex = 9;
            // 
            // vlrTransPacote
            // 
            this.vlrTransPacote.Location = new System.Drawing.Point(354, 95);
            this.vlrTransPacote.Name = "vlrTransPacote";
            this.vlrTransPacote.Size = new System.Drawing.Size(100, 23);
            this.vlrTransPacote.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Valor Transporte";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Data Partida";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Data Retorno";
            // 
            // allInclusive
            // 
            this.allInclusive.AutoSize = true;
            this.allInclusive.Location = new System.Drawing.Point(105, 212);
            this.allInclusive.Name = "allInclusive";
            this.allInclusive.Size = new System.Drawing.Size(89, 19);
            this.allInclusive.TabIndex = 14;
            this.allInclusive.Text = "All Inclusive";
            this.allInclusive.UseVisualStyleBackColor = true;
            // 
            // cadEmpTrans
            // 
            this.cadEmpTrans.Location = new System.Drawing.Point(361, 124);
            this.cadEmpTrans.Name = "cadEmpTrans";
            this.cadEmpTrans.Size = new System.Drawing.Size(93, 23);
            this.cadEmpTrans.TabIndex = 15;
            this.cadEmpTrans.Text = "Nova Empresa";
            this.cadEmpTrans.UseVisualStyleBackColor = true;
            this.cadEmpTrans.Click += new System.EventHandler(this.cadEmpTrans_Click);
            // 
            // CadastroPacote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 310);
            this.Controls.Add(this.cadEmpTrans);
            this.Controls.Add(this.allInclusive);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.vlrTransPacote);
            this.Controls.Add(this.dataRetorno);
            this.Controls.Add(this.dataPartida);
            this.Controls.Add(this.cidadePacote);
            this.Controls.Add(this.paisPacote);
            this.Controls.Add(this.hotelPacote);
            this.Controls.Add(this.vlrEstadiaPacote);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cadastrarPacote);
            this.Controls.Add(this.empPacote);
            this.Controls.Add(this.label1);
            this.Name = "CadastroPacote";
            this.Text = "CadastroPacote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox empPacote;
        private System.Windows.Forms.Button cadastrarPacote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox vlrEstadiaPacote;
        private System.Windows.Forms.TextBox hotelPacote;
        private System.Windows.Forms.TextBox paisPacote;
        private System.Windows.Forms.TextBox cidadePacote;
        private System.Windows.Forms.DateTimePicker dataPartida;
        private System.Windows.Forms.DateTimePicker dataRetorno;
        private System.Windows.Forms.TextBox vlrTransPacote;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox allInclusive;
        private System.Windows.Forms.Button cadEmpTrans;
    }
}