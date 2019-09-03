using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Clinica
{
    public partial class home : Form
    {
        private paciente paciente = new paciente();
        private medico medico = new medico();
        private consulta consulta = new consulta();
        private relatorio relatorio = new relatorio();

        public home()
        {
            InitializeComponent();

           // DataTable table = new DataTable();
           //table.Rows.Add(1, 2, 2);


           // dataGridView1.DataSource = table;
        }

        private void home_Load(object sender, EventArgs e)
        {
            
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.paciente.Close();
            this.medico.Close();
            this.consulta.Close();
            this.relatorio.Close();
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            this.medico.Close();
            this.consulta.Close();
            this.relatorio.Close();

            var frmmenu = Application.OpenForms["paciente"];
            if (frmmenu == null)
            {
                this.paciente = new paciente();
                this.paciente.TopLevel = false;
                this.Controls.Add(this.paciente);
                //this.ArrangeFormSize();
                this.paciente.Location = new Point(149, 123);
                this.paciente.Visible = true;
            }
        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            this.paciente.Close();
            this.consulta.Close();
            this.relatorio.Close();

            var frmmenu = Application.OpenForms["medico"];
            if (frmmenu == null)
            {
                this.medico = new medico();
                this.medico.TopLevel = false;
                this.Controls.Add(this.medico);
                //this.ArrangeFormSize();
                this.medico.Location = new Point(149, 123);
                this.medico.Visible = true;
            }
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            this.paciente.Close();
            this.medico.Close();
            this.relatorio.Close();

            var frmmenu = Application.OpenForms["consulta"];
            if (frmmenu == null)
            {
                this.consulta = new consulta();
                this.consulta.TopLevel = false;
                this.Controls.Add(this.consulta);
                //this.ArrangeFormSize();
                this.consulta.Location = new Point(149, 123);
                this.consulta.Visible = true;
            }

        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            this.paciente.Close();
            this.medico.Close();
            this.consulta.Close();

            var frmmenu = Application.OpenForms["relatorio"];
            if (frmmenu == null)
            {
                this.relatorio = new relatorio();
                this.relatorio.TopLevel = false;
                this.Controls.Add(this.relatorio);
                //this.ArrangeFormSize();
                this.relatorio.Location = new Point(149, 123);
                this.relatorio.Visible = true;
            }
        }

       /* 
        private void home_SizeChanged(object sender, EventArgs e)
        {
            this.ArrangeFormSize();
        }

        private void ArrangeFormSize()
        {
            this.paciente.Location = new Point(148, 152);
        }*/

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMax.Visible = false;
            btnNormal.Visible = true;
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMax.Visible = true;
            btnNormal.Visible = false;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
