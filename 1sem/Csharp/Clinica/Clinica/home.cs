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
        private inicial inicial = new inicial();
        
        public home()
        {
            InitializeComponent();
        }

        private void home_Load(object sender, EventArgs e)
        {
            this.inicial = new inicial();
            this.inicial.TopLevel = false;
            this.Controls.Add(this.inicial);
            this.inicial.Location = new Point(136, 97);
            this.inicial.Visible = true;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.paciente.Close();
            this.medico.Close();
            this.consulta.Close();
            this.relatorio.Close();

            var frmmenu = Application.OpenForms["inicial"];
            if (frmmenu == null)
            {
                this.inicial = new inicial();
                this.inicial.TopLevel = false;
                this.Controls.Add(this.inicial);
                this.inicial.Location = new Point(136, 97);
                this.inicial.Visible = true;
            }
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            this.medico.Close();
            this.consulta.Close();
            this.relatorio.Close();
            this.inicial.Close();

            var frmmenu = Application.OpenForms["paciente"];
            if (frmmenu == null)
            {
                this.paciente = new paciente();
                this.paciente.TopLevel = false;
                this.Controls.Add(this.paciente);
                this.paciente.Location = new Point(136, 97);
                this.paciente.Visible = true;
            }
        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            this.paciente.Close();
            this.consulta.Close();
            this.relatorio.Close();
            this.inicial.Close();

            var frmmenu = Application.OpenForms["medico"];
            if (frmmenu == null)
            {
                this.medico = new medico();
                this.medico.TopLevel = false;
                this.Controls.Add(this.medico);
                this.medico.Location = new Point(136, 97);
                this.medico.Visible = true;
            }
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            this.paciente.Close();
            this.medico.Close();
            this.relatorio.Close();
            this.inicial.Close();

            var frmmenu = Application.OpenForms["consulta"];
            if (frmmenu == null)
            {
                this.consulta = new consulta();
                this.consulta.TopLevel = false;
                this.Controls.Add(this.consulta);
                this.consulta.Location = new Point(136, 97);
                this.consulta.Visible = true;
            }

        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            this.paciente.Close();
            this.medico.Close();
            this.consulta.Close();
            this.inicial.Close();

            var frmmenu = Application.OpenForms["relatorio"];
            if (frmmenu == null)
            {
                this.relatorio = new relatorio();
                this.relatorio.TopLevel = false;
                this.Controls.Add(this.relatorio);
                this.relatorio.Location = new Point(136, 97);
                this.relatorio.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
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

        /**extern* Permite que o metodo seja implementado por uma dll
            A dll user32 permite o envio de comandos do mouse, para no caso, fazer o calculo da sua posição
            e mover o programa quando clicado no painel superior */
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //ao pressionar o botão do mouse é disparado esse evento
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
