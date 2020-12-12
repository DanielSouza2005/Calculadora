using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        String n1, n2, operacao, memoria;

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }
        private void btn0_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }
        private void btn_Virgula_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }



        //Operações
        private void btn_Multiplicacao_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                n1 = textBox1.Text;
                textBox1.Text = "";
                operacao = "multiplicacao";
            }
        }
        private void btn_Divisao_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                n1 = textBox1.Text;
                textBox1.Text = "";
                operacao = "divisao";
            }
        }
        private void btn_Porcentagem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                n1 = textBox1.Text;
                textBox1.Text = "";
                operacao = "porcentagem";
            }
        }
        private void btn_Potenciacao_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                n1 = textBox1.Text;
                textBox1.Text = "";
                operacao = "potenciacao";
                n2 = "";
                if (operacao == "potenciacao")
                {
                    textBox1.Text =
                        Convert.ToString(Convert.ToDouble(n1)*(Convert.ToDouble(n1)));
                } 
            }
        }
        private void btn_Radiciacao_Click(object sender, EventArgs e)
        {  
            if (textBox1.Text != "")
            {
                double raiz = Convert.ToDouble(textBox1.Text);

                textBox1.Text = "";
                operacao = "raizQuadrada";
                n2 = "";
                if (operacao == "raizQuadrada")
                {
                    if (raiz >= 0)
                        textBox1.Text =
                         Convert.ToString(Math.Sqrt(Convert.ToDouble(raiz)));
                    else
                        MessageBox.Show("Não existe raiz quadrada de número negativo!");
                }
            }
        }
        private void btn_Soma_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                n1 = textBox1.Text;
                textBox1.Text = "";
                operacao = "soma";
            }
        }
        private void btn_Subtracao_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                n1 = textBox1.Text;
                textBox1.Text = "";
                operacao = "subtracao";
            }
        }


        private void btn_C_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void btn_MC_Click(object sender, EventArgs e)
        {
            lbl_M.Visible = false;
            memoria = "";
        }

        private void btn_MS_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                lbl_M.Visible = true;
                memoria = textBox1.Text;
            }
            
        }

        private void btn_MR_Click(object sender, EventArgs e)
        {
              textBox1.Text = memoria;                        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_M.Visible = false;
        }

        private void lbl_Ajuda_Click(object sender, EventArgs e)
        {
            fm_Ajuda janelaDeAjuda = new fm_Ajuda();
            janelaDeAjuda.Show();
        }

        private void btn_CE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            operacao = "";
            n1 = "";
            n2 = "";
        }


        private void btn_Igual_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                n2 = textBox1.Text;

                if (operacao == "porcentagem")
                {
                    textBox1.Text =
                        Convert.ToString(Convert.ToDouble(n1) * Convert.ToDouble(n2) / 100);
                }
                    
                if (operacao == "soma")
                {
                    textBox1.Text =
                          Convert.ToString(Convert.ToDouble(n1) + Convert.ToDouble(n2));
                }
                    
                if (operacao == "subtracao")
                {
                    textBox1.Text =
                          Convert.ToString(Convert.ToDouble(n1) - Convert.ToDouble(n2));
                }
                    
                if (operacao == "multiplicacao")
                {
                    textBox1.Text =
                          Convert.ToString(Convert.ToDouble(n1) * Convert.ToDouble(n2));
                }

                          
                if (operacao == "divisao")
                {
                    if (n2 != "0")
                    {
                        textBox1.Text = Convert.ToString(Convert.ToDouble(n1) / Convert.ToDouble(n2));
                    }
                    else
                    {
                        MessageBox.Show("Não se divide por zero!");
                        textBox1.Text = "";
                    }
                       
                }
              
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

 
    }
}
