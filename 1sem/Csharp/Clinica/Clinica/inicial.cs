using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Clinica
{
    public partial class inicial : Form
    {
        public inicial()
        {
            InitializeComponent();
        }

        private void inicial_Load(object sender, EventArgs e)
        {
            buscaInformacoesMedicos();
            buscaInformacoesPacientes();
            buscaInformacoesConsultas();
        }

        private void buscaInformacoesPacientes()
        {
            string linha = "text";
            int count = 0;

            if (!(File.Exists("pacientes.txt")))
            {
                FileStream arq = new FileStream("pacientes.txt", FileMode.Create);
                arq.Close();
            }

            StreamReader ler = new StreamReader("pacientes.txt");

            while (linha != null)
            {
                linha = ler.ReadLine();

                if (linha != null)
                {
                    count++;
                }
            }

            ler.Close();
            labelUsuario.Text = count.ToString();
        }

        private void buscaInformacoesMedicos()
        {
            string linha = "text";
            int count = 0;

            if (!(File.Exists("medicos.txt")))
            {
                FileStream arq = new FileStream("medicos.txt", FileMode.Create);
                arq.Close();
            }

            StreamReader ler = new StreamReader("medicos.txt");

            while (linha != null)
            {
                linha = ler.ReadLine();

                if (linha != null)
                {
                    count++;
                }
            }

            ler.Close();
            labelMedico.Text = count.ToString();
        }

        private void buscaInformacoesConsultas()
        {
            string linha = "text";
            int count = 0;

            if (!(File.Exists("consultas.txt")))
            {
                FileStream arq = new FileStream("consultas.txt", FileMode.Create);
                arq.Close();
            }

            StreamReader ler = new StreamReader("consultas.txt");

            while (linha != null)
            {
                linha = ler.ReadLine();

                if (linha != null)
                {
                    count++;
                }
            }

            ler.Close();
            labelConsulta.Text = count.ToString();
        }
    }
}
