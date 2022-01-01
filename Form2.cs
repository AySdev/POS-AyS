using Microsoft.VisualBasic.Compatibility.VB6;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.IO;
using System.Windows.Forms;

namespace POS_AyS
{
    public partial class frmInicio : Form
    {

        string ruta = Application.StartupPath + "\\Base de Datos\\usuario.csv";
        string line;

        public frmInicio()
        {
            InitializeComponent();
        }

        private void pnlInicio_Paint(object sender, PaintEventArgs e)
        {
            //frmInicio frmIn = new frmInicio();
            //frmLogin frmLog = new frmLogin();
            //frmIn.lblUser.Text = frmLog.txtUser.Text;
        }
        private void AbrirformFactura<MiForm>() where MiForm : Form, new()
        {
            Form formFactura;
            formFactura = pnlInicio.Controls.OfType<MiForm>().FirstOrDefault();
            if (formFactura == null)
            {
                formFactura = new MiForm();
                formFactura.TopLevel = false;
                formFactura.FormBorderStyle = FormBorderStyle.None;
                formFactura.Dock = DockStyle.Fill;
                pnlInicio.Controls.Add(formFactura);
                pnlInicio.Tag = formFactura;
                formFactura.Show();
                formFactura.BringToFront();
            }
            else
            {
                formFactura.BringToFront();
            }
        }

        private void btnFact_Click(object sender, EventArgs e)
        {
            AbrirformFactura<frmFactura>();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            pnlPrincipal.BringToFront();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Está Seguro que desea cerrar sesión?", " AyS Software", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); ;

            if (dr == DialogResult.Yes)
            {
                frmLogin mostrar = new frmLogin();
                mostrar.Show();

                this.Hide();

            }

        }

        private void pagInicio_Load(object sender, EventArgs e)
        {
            lblUser.Text = clsVariables.usuario;
            frmLogin frmLog = new frmLogin();
        }

        public void pagInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void btnUsersEdit_Click(object sender, EventArgs e)
        {
            AbrirformUsuarios<frmUsuarios>();
        }
        private void AbrirformUsuarios<MiForm3>() where MiForm3 : Form, new()
        {

            Form formUsuarios;
            formUsuarios = pnlInicio.Controls.OfType<MiForm3>().FirstOrDefault();
            if (formUsuarios == null)
            {
                formUsuarios = new MiForm3();
                formUsuarios.TopLevel = false;
                formUsuarios.FormBorderStyle = FormBorderStyle.None;
                formUsuarios.Dock = DockStyle.Fill;
                pnlInicio.Controls.Add(formUsuarios);
                pnlInicio.Tag = formUsuarios;
                formUsuarios.Show();
                formUsuarios.BringToFront();
            }
            else
            {
                formUsuarios.BringToFront();
            }
        }
        public void pnlPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            AbrirformInventario<frmInventario>();
        }
        private void AbrirformInventario<MiForm4>() where MiForm4 : Form, new()
        {

            Form formInventario;
            formInventario = pnlInicio.Controls.OfType<MiForm4>().FirstOrDefault();
            if (formInventario == null)
            {
                formInventario = new MiForm4();
                formInventario.TopLevel = false;
                formInventario.FormBorderStyle = FormBorderStyle.None;
                formInventario.Dock = DockStyle.Fill;
                pnlInicio.Controls.Add(formInventario);
                pnlInicio.Tag = formInventario;
                formInventario.Show();
                formInventario.BringToFront();
            }
            else
            {
                formInventario.BringToFront();
            }
        }

        private void frmInicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirformCliente<frmClientes>();
        }

        private void AbrirformCliente<MiForm>() where MiForm : Form, new()
        {
            Form formCliente;
            formCliente = pnlInicio.Controls.OfType<MiForm>().FirstOrDefault();
            if (formCliente == null)
            {
                formCliente = new MiForm();
                formCliente.TopLevel = false;
                formCliente.FormBorderStyle = FormBorderStyle.None;
                formCliente.Dock = DockStyle.Fill;
                pnlInicio.Controls.Add(formCliente);
                pnlInicio.Tag = formCliente;
                formCliente.Show();
                formCliente.BringToFront();
            }
            else
            {
                formCliente.BringToFront();
            }
        }

        private void btnAcerca_Click(object sender, EventArgs e)
        {

            AbrirformAcerca<frmAcerca>();


            //clsCaracteristicas caracteristicas = new clsCaracteristicas();

            //caracteristicas.video();

            //caracteristicas.cpu();

            //caracteristicas.os();

        }
        private void AbrirformAcerca<MiForm4>() where MiForm4 : Form, new()
        {

            Form formAcerca;
            formAcerca = pnlInicio.Controls.OfType<MiForm4>().FirstOrDefault();
            if (formAcerca == null)
            {
                formAcerca = new MiForm4();
                formAcerca.TopLevel = false;
                formAcerca.FormBorderStyle = FormBorderStyle.None;
                formAcerca.Dock = DockStyle.Fill;
                pnlInicio.Controls.Add(formAcerca);
                pnlInicio.Tag = formAcerca;
                formAcerca.Show();
                formAcerca.BringToFront();
            }
            else
            {
                formAcerca.BringToFront();
            }
        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }
        //public void AbrirformLogin<MiForm2>() where MiForm2 : Form, new()
        //{
        //    //Abrimos el Login del panel
        //    Form formLogin;
        //    formLogin = pnlLogin.Controls.OfType<MiForm2>().FirstOrDefault();
        //    if (formLogin == null)
        //    {
        //        formLogin = new MiForm2();
        //        formLogin.TopLevel = false;
        //        formLogin.FormBorderStyle = FormBorderStyle.None;
        //        formLogin.Dock = DockStyle.Fill;
        //        pnlLogin.Controls.Add(formLogin);
        //        pnlLogin.Tag = formLogin;
        //        formLogin.Show();
        //        formLogin.BringToFront();
        //    }
        //    else
        //    {
        //        formLogin.BringToFront();
        //    }
        //}
    }
}
