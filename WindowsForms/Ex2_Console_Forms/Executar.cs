using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Console_Foms
{
    public class Executar
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Mainform());
        }
    }

    public class Mainform : Form
    {
        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;

        public Mainform()
        {
            this.Text = "Sistema de Muitas Telas";
            this.Size = new Size(500, 400);
            this.StartPosition = FormStartPosition.CenterParent;

            // Criando o controle de Abas
            tabControl = new TabControl { Dock = DockStyle.Fill };

            // Criando as páginas
            tabPage1 = new TabPage { Text = "Tela 1" };
            tabPage2 = new TabPage { Text = "Tela 2" };

            // Adicionando as abas ao controle de abas
            tabControl.TabPages.Add(tabPage1);
            tabControl.TabPages.Add(tabPage2);

            // Adicionando o controle de abas ao formulário
            this.Controls.Add(tabControl);
        }
    }

    public class Tela1 : Form
    {
        public Tela1()
        {
            this.Text = "Tela 1";
            this.Size = new Size(300, 300);
            this.StartPosition = FormStartPosition.CenterParent;
            this.BackColor = Color.LightPink;

            Label label = new Label { Text = "Tela 1" };
            label.Location = new Point(100, 100);
            this.Controls.Add(label);
        }
    }

    public class Tela2 : Form
    {
        public Tela2()
        {
            this.Text = "Tela 2";
            this.Size = new Size(300, 300);
            this.StartPosition = FormStartPosition.CenterParent;
            this.BackColor = Color.LightPink;

            Label label2 = new Label { Text = "Tela 2" };
            label2.Location = new Point(100, 100);
            this.Controls.Add(label2);
        }
    }
}
