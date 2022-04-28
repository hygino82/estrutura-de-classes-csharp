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

        private void btnTimeSpan_Click(object sender, EventArgs e)
        {
            //lblResultado.Text = TimeSpan.FromDays(7.25).ToString();
            //lblResultado.Text = TimeSpan.FromTicks(10000000).ToString();//tempo em nano segundos
            //lblResultado.Text = TimeSpan.TicksPerMinute.ToString();
            TimeSpan inicio = new TimeSpan(1, 0, 0);
            TimeSpan fim = new TimeSpan(2, 25, 0);

            TimeSpan intervalo = fim - inicio;

            TimeSpan outro = fim.Subtract(inicio);

            //lblResultado.Text = intervalo.ToString();
            lblResultado.Text = outro.ToString();

        }

        private void btnDateTime_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            DateTime diaAtual = DateTime.Today;
            //lblResultado.Text = dateTime.ToString();
            //lblResultado.Text = diaAtual.ToString();
            //lblResultado.Text = DateTime.DaysInMonth(2022, 2).ToString();//retorna o número de dias do mês atual
            //lblResultado.Text = DateTime.IsLeapYear(2022).ToString();//retorna se o ano é bissexto
            //lblResultado.Text = DateTime.Now.ToLongDateString();//retorna da data por extenso
            //lblResultado.Text = DateTime.Now.ToShortDateString();//retorna da data por simplificada
            //lblResultado.Text = DateTime.Now.ToLongTimeString();//retorna a hora mp formato long
            //lblResultado.Text = DateTime.Now.ToShortTimeString();//retorna a hora mp formato simplificado
            //lblResultado.Text = DateTime.Now.ToUniversalTime().ToString();//formato universal
            //lblResultado.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");//formata a data de saída

            DateTime data = new DateTime(1985, 01, 10, 14, 35, 30);
            //var adicionar = data.AddYears(2);
            //lblResultado.Text = adicionar.ToString();

            //TimeSpan tempo = new TimeSpan(5, 10, 5, 20);
            //lblResultado.Text = data.DayOfWeek.ToString();
            lblResultado.Text = data.DayOfYear.ToString();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            Color vermelho = Color.Red;
            Color amarelo = Color.Yellow;

            //lblResultado.BackColor = Color.LightGray;//cor do fundo
            //lblResultado.ForeColor = Color.AliceBlue;//cor da fonte

            //Color cor1 = Color.FromArgb(100, Color.DarkGreen);
            //Color cor1 = Color.FromArgb(255, 0, 255, 0);
            Color cor1 = Color.FromArgb(150, 255, 160);
            Color cor2 = Color.FromKnownColor(KnownColor.Control);
            Color cor3 = Color.FromName("DarkRed");


            lblResultado.ForeColor = cor3;
            lblResultado.BackColor = cor1;

            Color cor4 = lblResultado.BackColor;

            btnColor.ForeColor = cor4;
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            Font letra = new Font("Helvetica, Arial, sans-serif", 36, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Pixel);

            lblResultado.Text = "Bem vindo ao C#";
            //lblResultado.Font = letra;

            Font letra2 = new Font(FontFamily.GenericMonospace, 36, FontStyle.Regular, GraphicsUnit.Pixel);
            lblResultado.Font = letra;
        }

        private void btnEnvironment_Click(object sender, EventArgs e)
        {
            //mosta a localização do diretório dos meus documentos
            string meusDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string arqProgramas = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            //Environment.CurrentDirectory = "C:\\";

            string dirAtual = Environment.CurrentDirectory;
            //Environment.NewLine; 

            //Indica o caminho da variável de ambiente
            string varAmb = Environment.GetEnvironmentVariable("JAVA_HOME");

            //lista as unidades de disco do sistema
            string[] discos = Environment.GetLogicalDrives();

            /*lblResultado.Text = "";

            foreach (string disco in discos)
            {
                lblResultado.Text += disco + "\n";
            }*/

            string userName = Environment.UserName;
            string dominio = Environment.UserDomainName;
            int cpu = Environment.ProcessorCount;

            lblResultado.Text = cpu.ToString();

        }
    }
}
