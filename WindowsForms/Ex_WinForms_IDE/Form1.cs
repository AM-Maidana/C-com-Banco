using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ex_WinForms_IDE;

public partial class Form1 : Form
{
    public Form1() // Construtor
        {
            InitializeComponent();

            // Alterações no estilo do formulário
            this.BackColor = Color.FromArgb(45, 45, 48); // Fundo escuro
            this.ForeColor = Color.White; // Texto branco

            // Alterações em botões
            button1.BackColor = Color.DarkBlue;
            button1.ForeColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.BorderColor = Color.DarkBlue;
        }

        // Agora o método button1_Click está dentro da classe!
        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                num1 = Convert.ToInt32(textBox1.Text);
                num2 = Convert.ToInt32(textBox2.Text);

                MessageBox.Show("A soma dos dois números é: " + (num1 + num2)
                + "\nA subtração dos números é: " + (num1 - num2)
                + "\nA divisão dos números é: " + (num1 / num2)
                + "\nA multiplicação dos números é: " + (num1 * num2));
            }
            catch (Exception)
            {
                MessageBox.Show("Erro: Digite apenas números válidos.");
            }
        }
    }
