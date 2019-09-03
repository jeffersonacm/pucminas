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
    public partial class paciente : Form
    {
        public paciente()
        {
            InitializeComponent();
        }

        private void paciente_Load(object sender, EventArgs e)
        {
            carregaGrid();
        }

        private void carregaGrid()
        {
            string linha = "text";
            string[] linhas;

            DataTable table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("Nome");
            table.Columns.Add("Endereço");
            table.Columns.Add("Telefone");
            table.Columns.Add("Data de Nascimento");

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
                    table.Rows.Add(linhas[0], linhas[1], linhas[2], linhas[3], linhas[4]);
                }
            }

            ler.Close();
            dataGridView1.DataSource = table;
        }

        private void btnCadastroP_Click(object sender, EventArgs e)
        {
            string linha = "text";
            string[] linhas;
            int maior = 0, aux = 0, i=0;

            StreamReader ler = new StreamReader("pacientes.txt");

            while (linha != null)
            {
                linha = ler.ReadLine();

                if (linha != null)
                {
                    linhas = linha.Split(';');
                    Console.WriteLine();
                    //MessageBox.Show((linhas[1]));

                    aux = int.Parse(linhas[0]);

                    if (i == 0)
                    {
                        maior = aux;
                    }  else if (maior < aux)
                    {
                        maior = aux;
                    }
                }
                i++;
            }
             maior++;

            ler.Close();

            StreamWriter escrever = new StreamWriter("pacientes.txt", true);
            escrever.WriteLine(maior+";"+txtNomeP.Text+";"+txtEnderecoP.Text + ";" + txtTelefoneP.Text + ";" + txtDtP.Text);
            escrever.Close();
            carregaGrid();
        }

        private void txtNomeP_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.Clear();
            if (txtNomeP.Text.Trim() == "")
            {
                txtNomeP.BackColor = Color.Red;
                errorProvider1.SetError(txtNomeP, "Digite o nome do paciente");
                txtNomeP.Focus();
            } else
            {
                txtNomeP.BackColor = Color.White;
                txtEnderecoP.Focus();
            }
        }

        private void txtEnderecoP_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.Clear();
            if (txtEnderecoP.Text.Trim() == "")
            {
                txtEnderecoP.BackColor = Color.Red;
                errorProvider1.SetError(txtEnderecoP, "Digite o nome do paciente");
                txtEnderecoP.Focus();
            }
            else
            {
                txtEnderecoP.BackColor = Color.White;
                txtTelefoneP.Focus();
            }
        }

        private void txtTelefoneP_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.Clear();
            if (txtTelefoneP.Text.Trim() == "")
            {
                txtTelefoneP.BackColor = Color.Red;
                errorProvider1.SetError(txtTelefoneP, "Digite o nome do paciente");
                txtTelefoneP.Focus();
            }
            else
            {
                txtTelefoneP.BackColor = Color.White;
                txtDtP.Focus();
            }
        }

        private void txtDtP_Validating(object sender, CancelEventArgs e)
        {
            
            errorProvider1.Clear();
            if (txtDtP.Text.Trim() == "")
            {
                txtDtP.BackColor = Color.Red;
                errorProvider1.SetError(txtDtP, "Digite o nome do paciente");
                txtDtP.Focus();
            }
            else
            {
                txtDtP.BackColor = Color.White;
                btnCadastroP.Focus();
            }
        }
    }
}
