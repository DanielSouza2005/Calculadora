namespace Calculadora
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_Ajuda = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_MC = new System.Windows.Forms.Button();
            this.btn_MR = new System.Windows.Forms.Button();
            this.btn_MS = new System.Windows.Forms.Button();
            this.btn_CE = new System.Windows.Forms.Button();
            this.btn_C = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn_Virgula = new System.Windows.Forms.Button();
            this.btn_Multiplicacao = new System.Windows.Forms.Button();
            this.btn_Subtracao = new System.Windows.Forms.Button();
            this.btn_Soma = new System.Windows.Forms.Button();
            this.btn_Divisao = new System.Windows.Forms.Button();
            this.btn_Porcentagem = new System.Windows.Forms.Button();
            this.btn_Potenciacao = new System.Windows.Forms.Button();
            this.btn_Radiciacao = new System.Windows.Forms.Button();
            this.btn_Igual = new System.Windows.Forms.Button();
            this.lbl_M = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Ajuda
            // 
            this.lbl_Ajuda.AutoSize = true;
            this.lbl_Ajuda.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ajuda.Location = new System.Drawing.Point(364, 27);
            this.lbl_Ajuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Ajuda.Name = "lbl_Ajuda";
            this.lbl_Ajuda.Size = new System.Drawing.Size(63, 22);
            this.lbl_Ajuda.TabIndex = 0;
            this.lbl_Ajuda.Text = "Ajuda";
            this.lbl_Ajuda.Click += new System.EventHandler(this.lbl_Ajuda_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(18, 61);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(400, 58);
            this.textBox1.TabIndex = 1;
            // 
            // btn_MC
            // 
            this.btn_MC.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MC.Location = new System.Drawing.Point(18, 137);
            this.btn_MC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_MC.Name = "btn_MC";
            this.btn_MC.Size = new System.Drawing.Size(70, 69);
            this.btn_MC.TabIndex = 2;
            this.btn_MC.Text = "MC";
            this.btn_MC.UseVisualStyleBackColor = true;
            this.btn_MC.Click += new System.EventHandler(this.btn_MC_Click);
            // 
            // btn_MR
            // 
            this.btn_MR.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MR.Location = new System.Drawing.Point(94, 137);
            this.btn_MR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_MR.Name = "btn_MR";
            this.btn_MR.Size = new System.Drawing.Size(70, 69);
            this.btn_MR.TabIndex = 3;
            this.btn_MR.Text = "MR";
            this.btn_MR.UseVisualStyleBackColor = true;
            this.btn_MR.Click += new System.EventHandler(this.btn_MR_Click);
            // 
            // btn_MS
            // 
            this.btn_MS.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MS.Location = new System.Drawing.Point(172, 137);
            this.btn_MS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_MS.Name = "btn_MS";
            this.btn_MS.Size = new System.Drawing.Size(70, 69);
            this.btn_MS.TabIndex = 4;
            this.btn_MS.Text = "MS";
            this.btn_MS.UseVisualStyleBackColor = true;
            this.btn_MS.Click += new System.EventHandler(this.btn_MS_Click);
            // 
            // btn_CE
            // 
            this.btn_CE.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CE.Location = new System.Drawing.Point(272, 137);
            this.btn_CE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_CE.Name = "btn_CE";
            this.btn_CE.Size = new System.Drawing.Size(70, 69);
            this.btn_CE.TabIndex = 5;
            this.btn_CE.Text = "CE";
            this.btn_CE.UseVisualStyleBackColor = true;
            this.btn_CE.Click += new System.EventHandler(this.btn_CE_Click);
            // 
            // btn_C
            // 
            this.btn_C.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_C.Location = new System.Drawing.Point(350, 137);
            this.btn_C.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_C.Name = "btn_C";
            this.btn_C.Size = new System.Drawing.Size(70, 69);
            this.btn_C.TabIndex = 6;
            this.btn_C.Text = "C";
            this.btn_C.UseVisualStyleBackColor = true;
            this.btn_C.Click += new System.EventHandler(this.btn_C_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(172, 234);
            this.btn9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(70, 69);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(94, 234);
            this.btn8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(70, 69);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(18, 234);
            this.btn7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(70, 69);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(172, 313);
            this.btn6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(70, 69);
            this.btn6.TabIndex = 12;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(94, 313);
            this.btn5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(70, 69);
            this.btn5.TabIndex = 11;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(18, 313);
            this.btn4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(70, 69);
            this.btn4.TabIndex = 10;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(172, 391);
            this.btn3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(70, 69);
            this.btn3.TabIndex = 15;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(94, 391);
            this.btn2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(70, 69);
            this.btn2.TabIndex = 14;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(18, 391);
            this.btn1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(70, 69);
            this.btn1.TabIndex = 13;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(16, 469);
            this.btn0.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(148, 69);
            this.btn0.TabIndex = 16;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click_1);
            // 
            // btn_Virgula
            // 
            this.btn_Virgula.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Virgula.Location = new System.Drawing.Point(172, 469);
            this.btn_Virgula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Virgula.Name = "btn_Virgula";
            this.btn_Virgula.Size = new System.Drawing.Size(70, 69);
            this.btn_Virgula.TabIndex = 17;
            this.btn_Virgula.Text = ",";
            this.btn_Virgula.UseVisualStyleBackColor = true;
            this.btn_Virgula.Click += new System.EventHandler(this.btn_Virgula_Click);
            // 
            // btn_Multiplicacao
            // 
            this.btn_Multiplicacao.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Multiplicacao.Location = new System.Drawing.Point(272, 391);
            this.btn_Multiplicacao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Multiplicacao.Name = "btn_Multiplicacao";
            this.btn_Multiplicacao.Size = new System.Drawing.Size(70, 69);
            this.btn_Multiplicacao.TabIndex = 20;
            this.btn_Multiplicacao.Text = "*";
            this.btn_Multiplicacao.UseVisualStyleBackColor = true;
            this.btn_Multiplicacao.Click += new System.EventHandler(this.btn_Multiplicacao_Click);
            // 
            // btn_Subtracao
            // 
            this.btn_Subtracao.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Subtracao.Location = new System.Drawing.Point(272, 313);
            this.btn_Subtracao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Subtracao.Name = "btn_Subtracao";
            this.btn_Subtracao.Size = new System.Drawing.Size(70, 69);
            this.btn_Subtracao.TabIndex = 19;
            this.btn_Subtracao.Text = "-";
            this.btn_Subtracao.UseVisualStyleBackColor = true;
            this.btn_Subtracao.Click += new System.EventHandler(this.btn_Subtracao_Click);
            // 
            // btn_Soma
            // 
            this.btn_Soma.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Soma.Location = new System.Drawing.Point(272, 234);
            this.btn_Soma.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Soma.Name = "btn_Soma";
            this.btn_Soma.Size = new System.Drawing.Size(70, 69);
            this.btn_Soma.TabIndex = 18;
            this.btn_Soma.Text = "+";
            this.btn_Soma.UseVisualStyleBackColor = true;
            this.btn_Soma.Click += new System.EventHandler(this.btn_Soma_Click);
            // 
            // btn_Divisao
            // 
            this.btn_Divisao.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Divisao.Location = new System.Drawing.Point(272, 469);
            this.btn_Divisao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Divisao.Name = "btn_Divisao";
            this.btn_Divisao.Size = new System.Drawing.Size(70, 69);
            this.btn_Divisao.TabIndex = 21;
            this.btn_Divisao.Text = "/";
            this.btn_Divisao.UseVisualStyleBackColor = true;
            this.btn_Divisao.Click += new System.EventHandler(this.btn_Divisao_Click);
            // 
            // btn_Porcentagem
            // 
            this.btn_Porcentagem.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Porcentagem.Location = new System.Drawing.Point(350, 234);
            this.btn_Porcentagem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Porcentagem.Name = "btn_Porcentagem";
            this.btn_Porcentagem.Size = new System.Drawing.Size(70, 69);
            this.btn_Porcentagem.TabIndex = 22;
            this.btn_Porcentagem.Text = "%";
            this.btn_Porcentagem.UseVisualStyleBackColor = true;
            this.btn_Porcentagem.Click += new System.EventHandler(this.btn_Porcentagem_Click);
            // 
            // btn_Potenciacao
            // 
            this.btn_Potenciacao.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Potenciacao.Location = new System.Drawing.Point(350, 313);
            this.btn_Potenciacao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Potenciacao.Name = "btn_Potenciacao";
            this.btn_Potenciacao.Size = new System.Drawing.Size(70, 69);
            this.btn_Potenciacao.TabIndex = 24;
            this.btn_Potenciacao.Text = "X^2";
            this.btn_Potenciacao.UseVisualStyleBackColor = true;
            this.btn_Potenciacao.Click += new System.EventHandler(this.btn_Potenciacao_Click);
            // 
            // btn_Radiciacao
            // 
            this.btn_Radiciacao.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Radiciacao.Location = new System.Drawing.Point(350, 391);
            this.btn_Radiciacao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Radiciacao.Name = "btn_Radiciacao";
            this.btn_Radiciacao.Size = new System.Drawing.Size(70, 69);
            this.btn_Radiciacao.TabIndex = 23;
            this.btn_Radiciacao.Text = "Sqrt";
            this.btn_Radiciacao.UseVisualStyleBackColor = true;
            this.btn_Radiciacao.Click += new System.EventHandler(this.btn_Radiciacao_Click);
            // 
            // btn_Igual
            // 
            this.btn_Igual.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Igual.Location = new System.Drawing.Point(350, 469);
            this.btn_Igual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Igual.Name = "btn_Igual";
            this.btn_Igual.Size = new System.Drawing.Size(70, 69);
            this.btn_Igual.TabIndex = 25;
            this.btn_Igual.Text = "=";
            this.btn_Igual.UseVisualStyleBackColor = true;
            this.btn_Igual.Click += new System.EventHandler(this.btn_Igual_Click);
            // 
            // lbl_M
            // 
            this.lbl_M.AutoSize = true;
            this.lbl_M.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_M.Location = new System.Drawing.Point(14, 29);
            this.lbl_M.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_M.Name = "lbl_M";
            this.lbl_M.Size = new System.Drawing.Size(22, 19);
            this.lbl_M.TabIndex = 26;
            this.lbl_M.Text = "M";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 547);
            this.Controls.Add(this.lbl_M);
            this.Controls.Add(this.btn_Igual);
            this.Controls.Add(this.btn_Potenciacao);
            this.Controls.Add(this.btn_Radiciacao);
            this.Controls.Add(this.btn_Porcentagem);
            this.Controls.Add(this.btn_Divisao);
            this.Controls.Add(this.btn_Multiplicacao);
            this.Controls.Add(this.btn_Subtracao);
            this.Controls.Add(this.btn_Soma);
            this.Controls.Add(this.btn_Virgula);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn_C);
            this.Controls.Add(this.btn_CE);
            this.Controls.Add(this.btn_MS);
            this.Controls.Add(this.btn_MR);
            this.Controls.Add(this.btn_MC);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_Ajuda);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Ajuda;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_MC;
        private System.Windows.Forms.Button btn_MR;
        private System.Windows.Forms.Button btn_MS;
        private System.Windows.Forms.Button btn_CE;
        private System.Windows.Forms.Button btn_C;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn_Virgula;
        private System.Windows.Forms.Button btn_Multiplicacao;
        private System.Windows.Forms.Button btn_Subtracao;
        private System.Windows.Forms.Button btn_Soma;
        private System.Windows.Forms.Button btn_Divisao;
        private System.Windows.Forms.Button btn_Porcentagem;
        private System.Windows.Forms.Button btn_Potenciacao;
        private System.Windows.Forms.Button btn_Radiciacao;
        private System.Windows.Forms.Button btn_Igual;
        private System.Windows.Forms.Label lbl_M;
    }
}

