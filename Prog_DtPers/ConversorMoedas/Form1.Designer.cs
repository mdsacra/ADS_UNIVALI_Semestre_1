namespace ConversorMoedas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TbValor = new System.Windows.Forms.TextBox();
            this.CbMoedaEntrada = new System.Windows.Forms.ComboBox();
            this.CbMoedaSaida = new System.Windows.Forms.ComboBox();
            this.TbResultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtConverter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TbValor
            // 
            this.TbValor.Location = new System.Drawing.Point(116, 40);
            this.TbValor.Name = "TbValor";
            this.TbValor.Size = new System.Drawing.Size(121, 23);
            this.TbValor.TabIndex = 0;
            // 
            // CbMoedaEntrada
            // 
            this.CbMoedaEntrada.FormattingEnabled = true;
            this.CbMoedaEntrada.Location = new System.Drawing.Point(57, 111);
            this.CbMoedaEntrada.Name = "CbMoedaEntrada";
            this.CbMoedaEntrada.Size = new System.Drawing.Size(121, 23);
            this.CbMoedaEntrada.TabIndex = 1;
            // 
            // CbMoedaSaida
            // 
            this.CbMoedaSaida.FormattingEnabled = true;
            this.CbMoedaSaida.Location = new System.Drawing.Point(57, 140);
            this.CbMoedaSaida.Name = "CbMoedaSaida";
            this.CbMoedaSaida.Size = new System.Drawing.Size(121, 23);
            this.CbMoedaSaida.TabIndex = 1;
            // 
            // TbResultado
            // 
            this.TbResultado.Location = new System.Drawing.Point(109, 214);
            this.TbResultado.Name = "TbResultado";
            this.TbResultado.ReadOnly = true;
            this.TbResultado.Size = new System.Drawing.Size(121, 23);
            this.TbResultado.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite um valor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "De:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Para:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Resultado:";
            // 
            // BtConverter
            // 
            this.BtConverter.Location = new System.Drawing.Point(184, 126);
            this.BtConverter.Name = "BtConverter";
            this.BtConverter.Size = new System.Drawing.Size(75, 23);
            this.BtConverter.TabIndex = 4;
            this.BtConverter.Text = "Converter";
            this.BtConverter.UseVisualStyleBackColor = true;
            this.BtConverter.Click += new System.EventHandler(this.BtConverter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 300);
            this.Controls.Add(this.BtConverter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbResultado);
            this.Controls.Add(this.CbMoedaSaida);
            this.Controls.Add(this.CbMoedaEntrada);
            this.Controls.Add(this.TbValor);
            this.Name = "Form1";
            this.Text = "Conversor de Moedas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbValor;
        private System.Windows.Forms.ComboBox CbMoedaEntrada;
        private System.Windows.Forms.ComboBox CbMoedaSaida;
        private System.Windows.Forms.TextBox TbResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtConverter;
    }
}

