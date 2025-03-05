using System;
using System.Drawing;
using System.Windows.Forms;

namespace Console_Foms
{
    class Program
    {
        [STAThread]
        static void Testes(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Calculadora());
        }
    }

    public class Calculadora : Form
    {
        private System.ComponentModel.IContainer componentes = null;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;

        public Calculadora()
        {
            this.componentes = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Calculadora";

            // Instanciar os componentes
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();

            // Configuração do Label
            this.label1.AutoSize = true;
            this.label1.Name = "label1";
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.Text = "Digite os números";

            // Configuração do TextBox1
            this.textBox1.Location = new System.Drawing.Point(30, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 27);

            // Configuração do TextBox2
            this.textBox2.Location = new System.Drawing.Point(150, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 27);

            // Configuração dos botões
            this.button1.Location = new System.Drawing.Point(30, 120);
            this.button1.Name = "btnSoma";
            this.button1.Size = new System.Drawing.Size(100, 27);
            this.button1.Text = "Soma";
            this.button1.Click += new System.EventHandler(this.button1_Click);

            this.button2.Location = new System.Drawing.Point(150, 120);
            this.button2.Name = "btnSubtrair";
            this.button2.Size = new System.Drawing.Size(100, 27);
            this.button2.Text = "Subtrair";
            this.button2.Click += new System.EventHandler(this.button2_Click);

            this.button3.Location = new System.Drawing.Point(270, 120);
            this.button3.Name = "btnMultiplicar";
            this.button3.Size = new System.Drawing.Size(100, 27);
            this.button3.Text = "Multiplicar";
            this.button3.Click += new System.EventHandler(this.button3_Click);

            this.button4.Location = new System.Drawing.Point(390, 120);
            this.button4.Name = "btnDividir";
            this.button4.Size = new System.Drawing.Size(100, 27);
            this.button4.Text = "Dividir";
            this.button4.Click += new System.EventHandler(this.button4_Click);

            // Adicionando os controles ao Form
            this.Controls.Add(label1);
            this.Controls.Add(textBox1);
            this.Controls.Add(textBox2);
            this.Controls.Add(button1);
            this.Controls.Add(button2);
            this.Controls.Add(button3);
            this.Controls.Add(button4);

            // Estilizando os controles
            textBox1.BackColor = Color.LightPink;
            textBox1.ForeColor = Color.Black;

            textBox2.BackColor = Color.LightPink;
            textBox2.ForeColor = Color.Black;

            button1.BackColor = Color.DarkBlue;
            button1.ForeColor = Color.LightBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.BorderColor = Color.DarkBlue;

            button2.BackColor = Color.BlueViolet;
            button2.ForeColor = Color.Black;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatAppearance.BorderColor = Color.BlueViolet;

            button3.BackColor = Color.Violet;
            button3.ForeColor = Color.Black;
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatAppearance.BorderColor = Color.Violet;

            button4.BackColor = Color.DarkViolet;
            button4.ForeColor = Color.Black;
            button4.FlatStyle = FlatStyle.Flat;
            button4.FlatAppearance.BorderSize = 2;
            button4.FlatAppearance.BorderColor = Color.DarkViolet;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                num1 = Convert.ToInt32(textBox1.Text);
                num2 = Convert.ToInt32(textBox2.Text);

                MessageBox.Show("A soma dos dois números é: " + (num1 + num2));
            }
            catch (Exception)
            {
                MessageBox.Show("Erro: Digite apenas números válidos.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                num1 = Convert.ToInt32(textBox1.Text);
                num2 = Convert.ToInt32(textBox2.Text);

                MessageBox.Show("A subtração dos números é: " + (num1 - num2));
            }
            catch (Exception)
            {
                MessageBox.Show("Erro: Digite apenas números válidos.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                num1 = Convert.ToInt32(textBox1.Text);
                num2 = Convert.ToInt32(textBox2.Text);

                MessageBox.Show("A multiplicação dos números é: " + (num1 * num2));
            }
            catch (Exception)
            {
                MessageBox.Show("Erro: Digite apenas números válidos.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                num1 = Convert.ToInt32(textBox1.Text);
                num2 = Convert.ToInt32(textBox2.Text);

                // Tratando a divisão por zero
                if (num2 == 0)
                {
                    MessageBox.Show("Erro: Divisão por zero.");
                }
                else
                {
                    MessageBox.Show("A divisão dos dois números é: " + (num1 / num2));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro: Digite apenas números válidos.");
            }
        }
    }
}
