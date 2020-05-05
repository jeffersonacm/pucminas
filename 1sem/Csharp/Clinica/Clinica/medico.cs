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
    public partial class medico : Form
    {
        public medico()
        {
            InitializeComponent();
            carregaGrid();
        }
    
        public void carregaGrid()
        {
            string linha = "text";
            string[] linhas;

            DataTable table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("Nome");
            table.Columns.Add("Telefone");
            table.Columns.Add("Especialidade");

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
                    table.Rows.Add(linhas[0], linhas[1], linhas[2], linhas[3]);
                }
            }

            ler.Close();
            dataGridView1.DataSource = table;
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            string linha = "text";
            string[] linhas;
            int maior = 0, aux = 0, i = 0;

            if (txtNome.Text == "")
            {
                MessageBox.Show("Informe o nome do Médico!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return;
            }
            
            if (TextNoFormatting(txtTelefone) == "")
            {
                MessageBox.Show("Informe o telefone do Médico!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefone.Focus();
                return;
            }

            if (cmbEspecialidade.Text == "")
            {
                MessageBox.Show("Informe a especialidade do Médico!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbEspecialidade.Focus();
                return;
            }

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
                    Console.WriteLine();

                    aux = int.Parse(linhas[0]);

                    if (i == 0)
                    {
                        maior = aux;
                    }
                    else if (maior < aux)
                    {
                        maior = aux;
                    }
                }
                i++;
            }
            maior++;

            ler.Close();

            StreamWriter escrever = new StreamWriter("medicos.txt", true);
            escrever.WriteLine(maior + ";" + txtNome.Text + ";" + txtTelefone.Text + ";" + cmbEspecialidade.Text);
            escrever.Close();

            MessageBox.Show("Médico incluido com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtNome.Text = "";
            txtTelefone.Text = "";
            cmbEspecialidade.Text = "";
            carregaGrid();

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
