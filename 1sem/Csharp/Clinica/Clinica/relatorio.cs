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
using System.Globalization;

namespace Clinica
{
    public partial class relatorio : Form
    {
        public relatorio()
        {
            InitializeComponent();
        }

        private void relatorio_Load(object sender, EventArgs e)
        {
            carregaGridConsultas();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ocultaGeral();
            btnData.Visible = true;
            dateTimePicker1.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ocultaGeral();
            btnPaciente.Visible = true;
            labelPaciente.Visible = true;
            txtPaciente.Visible = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ocultaGeral();
            btnMedico.Visible = true;
            labelMedico.Visible = true;
            txtMedico.Visible = true;
        }

        private void ocultaGeral()
        {
            btnData.Visible = false;
            btnMedico.Visible = false;
            btnPaciente.Visible = false;
            labelMedico.Visible = false;
            labelPaciente.Visible = false;
            dateTimePicker1.Visible = false;
            txtMedico.Visible = false;
            txtPaciente.Visible = false;
        }

        private void carregaGridConsultas(string medico = null, string paciente = null, string data = null)
        {
            string linha = "text";
            string[] linhas;
            DateTime dataConsulta, dataAtual = DateTime.Today;

            DataTable tableConsulta = new DataTable();
            tableConsulta.Columns.Add("Data");
            tableConsulta.Columns.Add("Hora");
            tableConsulta.Columns.Add("Médico");
            tableConsulta.Columns.Add("Paciente");

            if (!(File.Exists("consultas.txt")))
            {
                FileStream arq = new FileStream("consultas.txt", FileMode.Create);
                arq.Close();
            }

            StreamReader ler = new StreamReader("consultas.txt");

            while (linha != null)
            {
                linha = ler.ReadLine();

                if(linha != null)
                {
                    linhas = linha.Split(';');

                    if (medico == null && paciente == null && data == null)
                    {
                        tableConsulta.Rows.Add(linhas[1], linhas[2], getNomeMedico(int.Parse(linhas[3])), getNomePaciente(int.Parse(linhas[4])));
                    } else if(medico != null && getNomeMedico(int.Parse(linhas[3])).Contains(medico))
                    {
                        tableConsulta.Rows.Add(linhas[1], linhas[2], getNomeMedico(int.Parse(linhas[3])), getNomePaciente(int.Parse(linhas[4])));
                    } else if(paciente != null && getNomePaciente(int.Parse(linhas[4])).Contains(paciente))
                    {
                        dataConsulta = DateTime.ParseExact(linhas[1], "dd/MM/yyyy", new CultureInfo("pt-br"), DateTimeStyles.None);
                        if (dataConsulta <= dataAtual)
                        {
                            tableConsulta.Rows.Add(linhas[1], linhas[2], getNomeMedico(int.Parse(linhas[3])), getNomePaciente(int.Parse(linhas[4])));
                        }

                    } else if (data != null && data == linhas[1])
                    {
                        tableConsulta.Rows.Add(linhas[1], linhas[2], getNomeMedico(int.Parse(linhas[3])), getNomePaciente(int.Parse(linhas[4])));
                    }
                }
            }

            ler.Close();
            dataGridView1.DataSource = tableConsulta;
        }

        private string getNomeMedico(int codigoMedico)
        {
            string linha = "text";
            string[] linhas;

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
                    linhas = linha.Split(';');
                    if (int.Parse(linhas[0]) == codigoMedico)
                    {
                        ler.Close();
                        return linhas[1];
                    }
                }
            }
            ler.Close();
            return null;
        }

        private string getNomePaciente(int codigoPaciente)
        {
            string linha = "text";
            string[] linhas;

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
                    linhas = linha.Split(';');
                    if (int.Parse(linhas[0]) == codigoPaciente)
                    {
                        ler.Close();
                        return linhas[1];
                    }
                }
            }
            ler.Close();
            return null;
        }

        private void btnData_Click(object sender, EventArgs e)
        {

            if(dateTimePicker1.Value.ToShortDateString() != "")
            {
                carregaGridConsultas(null,null, dateTimePicker1.Value.ToShortDateString());
            } else
            {
                carregaGridConsultas(null, null, null);
            }
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            if (txtPaciente.Text != "")
            {
                carregaGridConsultas(null, txtPaciente.Text, null);
            }
            else
            {
                carregaGridConsultas(null, null, null);
            }
        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            if (txtMedico.Text != "")
            {
                carregaGridConsultas(txtMedico.Text, null, null);
            }
            else
            {
                carregaGridConsultas(null, null, null);
            }
        }
    }
}
