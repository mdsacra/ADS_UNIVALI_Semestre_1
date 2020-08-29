namespace Calculadora
{
    partial class calc
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.soma = new System.Windows.Forms.Button();
            this.subtr = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // soma
            // 
            this.soma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.soma.Location = new System.Drawing.Point(104, 85);
            this.soma.Name = "soma";
            this.soma.Size = new System.Drawing.Size(60, 23);
            this.soma.TabIndex = 0;
            this.soma.Text = "+";
            this.soma.UseVisualStyleBackColor = true;
            this.soma.Click += new System.EventHandler(this.soma_Click);
            // 
            // subtr
            // 
            this.subtr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.subtr.Location = new System.Drawing.Point(104, 114);
            this.subtr.Name = "subtr";
            this.subtr.Size = new System.Drawing.Size(60, 23);
            this.subtr.TabIndex = 1;
            this.subtr.Text = "-";
            this.subtr.UseVisualStyleBackColor = true;
            this.subtr.Click += new System.EventHandler(this.subtr_Click);
            // 
            // mult
            // 
            this.mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.mult.Location = new System.Drawing.Point(104, 143);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(60, 23);
            this.mult.TabIndex = 2;
            this.mult.Text = "*";
            this.mult.UseVisualStyleBackColor = true;
            this.mult.Click += new System.EventHandler(this.mult_Click);
            // 
            // div
            // 
            this.div.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.div.Location = new System.Drawing.Point(104, 172);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(60, 23);
            this.div.TabIndex = 3;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // num1
            // 
            this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.num1.Location = new System.Drawing.Point(12, 35);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(100, 23);
            this.num1.TabIndex = 4;
            // 
            // num2
            // 
            this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.num2.Location = new System.Drawing.Point(154, 35);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(100, 23);
            this.num2.TabIndex = 5;
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.result.Location = new System.Drawing.Point(84, 215);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(100, 26);
            this.result.TabIndex = 6;
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calc
            // 
            this.ClientSize = new System.Drawing.Size(266, 261);
            this.Controls.Add(this.result);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.div);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.subtr);
            this.Controls.Add(this.soma);
            this.Name = "calc";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mais;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button dividir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button vezes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button menos;
        private System.Windows.Forms.Button soma;
        private System.Windows.Forms.Button subtr;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.TextBox result;
    }
}

