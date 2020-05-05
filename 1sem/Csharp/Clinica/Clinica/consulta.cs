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
    public partial class consulta : Form
    {
        public consulta()
        {
            InitializeComponent();
        }

        private void consulta_Load(object sender, EventArgs e)
        {
            carregaGridPaciente();
            carregaGridConsulta();
        }

        private void carregaGridPaciente(string filtro = null)
        {
            string linha = "text";
            string[] linhas;

            DataTable table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("Nome");
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

                    if(filtro == null)
                    {
                        table.Rows.Add(linhas[0], linhas[1], linhas[4]);
                    }
                    else if (linhas[1].Contains(filtro))
                    {
                        table.Rows.Add(linhas[0], linhas[1], linhas[4]);
                    }
                }
            }

            ler.Close();
            dataGridView1.DataSource = table;
        }

        private void carregaMedicos()
        {
            string linha = "text";
            string[] linhas;

            if (!(File.Exists("medicos.txt")))
            {
                FileStream arq = new FileStream("medicos.txt", FileMode.Create);
                arq.Close();
            }

            StreamReader ler = new StreamReader("medicos.txt");
            /* Instâcia da classe dictionary, para no caso, armazenar uma cadeira de caracteres. */
            Dictionary<string, string> medicos = new Dictionary<string, string>();
            while (linha != null)
            {
                linha = ler.ReadLine();

                if (linha != null)
                {
                    linhas = linha.Split(';');
                    medicos.Add(linhas[0], linhas[1]);
                } 
            }

            cmbMedico.DataSource = new BindingSource(medicos, null);
            cmbMedico.DisplayMember = "Value";
            cmbMedico.ValueMember = "Key";
            cmbMedico.SelectedValue = "";
            ler.Close();
        }

        private void cmbMedico_Click_1(object sender, EventArgs e)
        {
            carregaMedicos();
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            carregaGridPaciente(txtPaciente.Text);
        }

        private void btnCadastra_Click(object sender, EventArgs e)
        {
            string linha = "text";
            string[] linhas;
            int maior = 0, aux = 0, i = 0;

            if (txtCoPaciente.Text == "")
            {
                MessageBox.Show("Informe o paciente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCoPaciente.Focus();
                return;
            }

            if (dateTimePicker2.Value.ToShortDateString() == "")
            {
                MessageBox.Show("Informe a data da consulta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePicker2.Focus();
                return;
            }
            if (cmbMedico.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Informe o médico!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbMedico.Focus();
                return;
            }

            if (cmbHorario.Text == "")
            {
                MessageBox.Show("Informe o horário da consulta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbHorario.Focus();
                return;
            }

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

            StreamWriter escrever = new StreamWriter("consultas.txt", true);
            escrever.WriteLine(maior + ";" + dateTimePicker2.Value.ToShortDateString() + ";" + cmbHorario.SelectedItem.ToString() +
                               ";" + cmbMedico.SelectedValue.ToString() + ";" + txtCoPaciente.Text + ";");
            escrever.Close();

            MessageBox.Show("Consulta incluida com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtPaciente.Text = "";
            txtCoPaciente.Text = "";
            txtEspecialidade.Text = "";
            cmbMedico.SelectedValue = "";
            cmbHorario.SelectedIndex = -1;
            carregaGridConsulta();
        }

        private void cmbMedico_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int select;
            select = int.Parse(cmbMedico.SelectedValue.ToString());

            if (!buscaDisponibilidadeMedico(select, dateTimePicker2.Value.ToShortDateString()))
            {
                return;
            }
            
            buscaEspecialidade(select);
            buscaHora();
        }

        private Boolean buscaDisponibilidadeMedico(int codigoMedico, string dataConsulta)
        {
            string linha = "text";
            string[] linhas;
            int count=0;

            cmbHorario.SelectedIndex = -1;

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
                    linhas = linha.Split(';');
                    if (int.Parse(linhas[3]) == codigoMedico && linhas[1] == dataConsulta)
                    {
                        count++;
                    }
                }
            }
            ler.Close();

            if(count >= 2)
            {
                MessageBox.Show("O médico selecionado possui o número máximo de consultas no dia informado","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbMedico.SelectedValue = "";
                return false;
            }


            return true;
        }

        private void buscaEspecialidade(int select)
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
                    if (int.Parse(linhas[0]) == select)
                    {
                        txtEspecialidade.Text = linhas[3];
                    }
                }
            }
            ler.Close();
        }

        private void buscaHora()
        {
            cmbHorario.Items.Clear();
            string[] hora = new string[8] { "09:00 - 09:30", "10:00 - 10:30", "11:00 - 11:30", "13:00 - 13:30",
                                            "14:00 - 14:30", "15:00 - 15:30", "16:00 - 16:30", "17:00 - 17:30" };

            for(int i=0; i < hora.Length; i++)
            {
                cmbHorario.Items.Add(hora[i]);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCoPaciente.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtPaciente.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void carregaGridConsulta()
        {
            string linha = "text";
            string[] linhas;

            DataTable tableConsulta = new DataTable();
            tableConsulta.Columns.Add("Id");
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

                if (linha != null)
                {
                    linhas = linha.Split(';');
                    tableConsulta.Rows.Add(linhas[0], linhas[1], linhas[2], getNomeMedico(int.Parse(linhas[3])), getNomePaciente(int.Parse(linhas[4])));
                }
            }

            ler.Close();
            dataGridView2.DataSource = tableConsulta;
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
                    //MessageBox.Show("PACIENTE TXT: " + linhas[0] + "PARAM: " + codigoPaciente);
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

        private void cmbHorario_SelectionChangeCommitted(object sender, EventArgs e)
        {
            buscaDisponibilidadeHora();
        }

        private Boolean buscaDisponibilidadeHora()
        {
            string linha = "text", selectData, selectHora;
            int selectMedico;
            string[] linhas;
            int count = 0;

            if (cmbMedico.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Selecione o médico para buscar os horários", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbHorario.SelectedIndex = -1;
                return false;
            }

            selectMedico = int.Parse(cmbMedico.SelectedValue.ToString());
            selectHora = cmbHorario.SelectedItem.ToString();
            selectData = dateTimePicker2.Value.ToShortDateString();

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
                    linhas = linha.Split(';');
                    if (int.Parse(linhas[3]) == selectMedico && linhas[1] == selectData && selectHora == linhas[2])
                    {
                        count++;
                    }
                }
            }
            ler.Close();

            if (count >= 1)
            {
                MessageBox.Show("Ja possui uma consulta cadastrada para este médico no horario selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbHorario.SelectedIndex = -1;
                return false;
            }

            return true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int codigoConsulta;
            string linha = "text";
            string[] linhas;

            if(txtConsultaSelecionada.Text == "")
            {
                MessageBox.Show("Selecione no grid a consulta que deseja excluir!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            codigoConsulta = int.Parse(txtConsultaSelecionada.Text);

            FileStream arqui = new FileStream("consultasTemp.txt", FileMode.Create);
            arqui.Close();

            if (!(File.Exists("consultas.txt")))
            {
                FileStream arq = new FileStream("consultas.txt", FileMode.Create);
                arq.Close();
            }

            StreamReader ler = new StreamReader("consultas.txt");
            StreamWriter escreve = new StreamWriter("consultasTemp.txt");

            while (linha != null)
            {
                linha = ler.ReadLine();

                if (linha != null)
                {
                    linhas = linha.Split(';');

                    if(int.Parse(linhas[0]) != codigoConsulta)
                    {
                        escreve.WriteLine(linha);
                    }
                }
            }

            escreve.Close();
            ler.Close();
            //Deleta o arquivo original
            File.Delete("consultas.txt");
            //Copia o arquivo modificado, com o mesmo nome do arquivo original
            File.Copy("consultasTemp.txt", "consultas.txt");
            //Exclui o arquivo temporário
            File.Delete("consultasTemp.txt");
            carregaGridConsulta();
            txtConsultaSelecionada.Text = "";
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtConsultaSelecionada.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int codigoConsulta;
            string linha = "text";
            string[] linhas;

            carregaMedicos();

            if (txtConsultaSelecionada.Text == "")
            {
                MessageBox.Show("Selecione no grid a consulta que deseja alterar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            codigoConsulta = int.Parse(txtConsultaSelecionada.Text);

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
                    linhas = linha.Split(';');

                    if (int.Parse(linhas[0]) == codigoConsulta)
                    {
                        dateTimePicker2.Text = linhas[1];
                        cmbMedico.SelectedValue = linhas[3];

                        if(!cmbMedico.SelectedIndex.Equals(-1))
                        {
                            buscaEspecialidade(int.Parse(cmbMedico.SelectedValue.ToString()));
                            buscaHora();
                        }

                        cmbHorario.SelectedIndex = cmbHorario.FindStringExact(linhas[2]);
                        txtCoPaciente.Text = linhas[4];
                        txtPaciente.Text = getNomePaciente(int.Parse(linhas[4]));

                        btnConfirmar.Visible = true;
                        btnCancelar.Visible = true;
                        btnCadastra.Visible = false;
                        btnAlterar.Visible = false;
                        btnExcluir.Visible = false;
                    }
                }
            }

            ler.Close();

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string linha = "text";
            string[] linhas;
            int codigoConsulta;

            codigoConsulta = int.Parse(txtConsultaSelecionada.Text);

            if (txtCoPaciente.Text == "")
            {
                MessageBox.Show("Informe o paciente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCoPaciente.Focus();
                return;
            }

            if (dateTimePicker2.Value.ToShortDateString() == "")
            {
                MessageBox.Show("Informe a data da consulta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePicker2.Focus();
                return;
            }
            if (cmbMedico.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Informe o médico!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbMedico.Focus();
                return;
            }

            if (cmbHorario.Text == "")
            {
                MessageBox.Show("Informe o horario da consulta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbHorario.Focus();
                return;
            }

            if (!(File.Exists("consultas.txt")))
            {
                FileStream arq = new FileStream("consultas.txt", FileMode.Create);
                arq.Close();
            }

            FileStream arqui = new FileStream("consultasTemp.txt", FileMode.Create);
            arqui.Close();

            StreamReader ler = new StreamReader("consultas.txt");
            StreamWriter escreve = new StreamWriter("consultasTemp.txt");

            while (linha != null)
            {
                linha = ler.ReadLine();

                if (linha != null)
                {
                    linhas = linha.Split(';');

                    if (int.Parse(linhas[0]) != codigoConsulta)
                    {
                        escreve.WriteLine(linha);
                    } else
                    {
                        escreve.WriteLine(codigoConsulta + ";" + dateTimePicker2.Value.ToShortDateString() + ";" + cmbHorario.SelectedItem.ToString() +
                               ";" + cmbMedico.SelectedValue.ToString() + ";" + txtCoPaciente.Text + ";");
                    }
                }
            }

            escreve.Close();
            ler.Close();
            //Deleta o arquivo original
            File.Delete("consultas.txt");
            //Copia o arquivo modificado, com o mesmo nome do arquivo original
            File.Copy("consultasTemp.txt", "consultas.txt");
            //Exclui o arquivo temporário
            File.Delete("consultasTemp.txt");
            carregaGridConsulta();

            MessageBox.Show("Consulta alterada com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtConsultaSelecionada.Text = "";
            txtPaciente.Text = "";
            txtCoPaciente.Text = "";
            txtEspecialidade.Text = "";
            cmbMedico.SelectedValue = "";
            cmbHorario.SelectedIndex = -1;
            carregaGridConsulta();

            btnConfirmar.Visible = false;
            btnCancelar.Visible = false;
            btnCadastra.Visible = true;
            btnAlterar.Visible = true;
            btnExcluir.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnConfirmar.Visible = false;
            btnCancelar.Visible = false;
            btnCadastra.Visible = true;
            btnAlterar.Visible = true;
            btnExcluir.Visible = true;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if(btnCadastra.Visible == false)
            {
                cmbMedico.SelectedValue = "";
                txtEspecialidade.Text = "";
                cmbHorario.SelectedIndex = -1;
            }
        }
    } 
}
