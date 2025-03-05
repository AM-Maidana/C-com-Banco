namespace Ex_WinForms_IDE;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;



    private System.Windows.Forms.Label label1; // Criação de um atributo com tipo de uma classe específica para texto
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Button button1; // criação de um atribuo com o tipo de uma classe específica para botao



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
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "Calculadora!";

        //Inicializar as variaveis
        this.label1 = new System.Windows.Forms.Label();
        this.textBox1 = new System.Windows.Forms.TextBox();
        this.textBox2 = new System.Windows.Forms.TextBox();

        this.button1 = new System.Windows.Forms.Button();

        // Configuração do Label1
        this.label1.AutoSize = true; // Ajusta o tamanho
        this.label1.Location = new System.Drawing.Point(30, 30); // Define a posição
        this.label1.Name = "teste 2 do label"; // 
        this.label1.Size = new System.Drawing.Size(90, 20); //

        this.label1.Text = "Digite um numero"; // texto

        //Configuração do textbox
        this.textBox1.Location = new System.Drawing.Point(30,60);
        this.textBox1.Name = "textBox 1";
        this.textBox1.Size = new System.Drawing.Size(100,27);

        //Configuração do textbox 2
        this.textBox2.Location = new System.Drawing.Point(30,90);
        this.textBox2.Name = "textBox2";
        this.textBox2.Size = new System.Drawing.Size(100,27);


        //Configuração do botão
        this.button1.Location = new System.Drawing.Point(30, 120);
        this.button1.Name = "Btn1"; // nome do btn
        this.button1.Size = new System.Drawing.Size(100,27);
        this.button1.Text = "Calcular"; // texto do btn
        this.button1.Click += new System.EventHandler(this.button1_Click); // define o evento do clique do btn


        this.Controls.Add(label1);
        this.Controls.Add(textBox1);
        this.Controls.Add(textBox2);
        this.Controls.Add(button1);


    }

    #endregion
}
