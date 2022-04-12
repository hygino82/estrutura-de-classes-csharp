using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassesImportantes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMessageBox_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("oi piazada");
            //MessageBox.Show("Minha menssagem", "Titulo da menssagem");
            //MessageBox.Show("Texto da mensagem","Título",MessageBoxButtons.YesNo);
            //MessageBox.Show("Texto da mensagem", "Título", MessageBoxButtons.YesNoCancel);
            /*var res = MessageBox.Show("Texto da mensagem", "Título", MessageBoxButtons.OKCancel);
            if (res == DialogResult.OK)
            {
                lblResultado.Text = "Clicou em OK";
            }
            else if (res == DialogResult.Cancel)
            {
                lblResultado.Text = "Clicou em Cancelar";
            }*/
            //MessageBox.Show("Mensagem", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

            MessageBox.Show("Mensagem", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
        }

        private void btnAleatorio_Click(object sender, EventArgs e)
        {
            Random r = new Random(DateTime.Now.Millisecond);

            var valor = r.Next(10, 100);
            var valor2 = r.NextDouble() * 1000;
            //gera números decimais aleatórios com três algarismos na parte inteira

            lblResultado.Text = "Número: " + valor2;
        }
    }
}
