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
            txtNomeP.Focus();
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


            if(txtNomeP.Text == "")
            {
                MessageBox.Show("Informe o nome do paciente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeP.Focus();
                return;
            }

            if (txtEnderecoP.Text == "")
            {
                MessageBox.Show("Informe o endereço do paciente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEnderecoP.Focus();
                return;
            }
            if (TextNoFormatting(txtTelefoneP) == "")
            {
                MessageBox.Show("Informe o telefone do paciente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefoneP.Focus();
                return;
            }

            if (TextNoFormatting(txtDtP) == "")
            {
                MessageBox.Show("Informe a data de nascimento do paciente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDtP.Focus();
                return;
            }

            if (!(File.Exists("pacientes.txt")))
            {
                FileStream arq = new FileStream("medicos.txt", FileMode.Create);
                arq.Close();
            }

            StreamReader ler = new StreamReader("pacientes.txt");

            while (linha != null)
            {
                linha = ler.ReadLine();

                if (linha != null)
                {
                    linhas = linha.Split(';');
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

            MessageBox.Show("Paciente incluido com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtDtP.Text = "";
            txtEnderecoP.Text = "";
            txtNomeP.Text = "";
            txtTelefoneP.Text = "";
            carregaGrid();
        }

        private string TextNoFormatting(MaskedTextBox _mask)
        {
            _mask.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            String retString = _mask.Text;
            _mask.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            return retString;
        }
    }
}
