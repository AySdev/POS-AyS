using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Reflection;
using System.Data.Common;
using MySql.Data.MySqlClient;

/// <summary>
/// Autor: Andrés Manrique
/// Fecha: 3 Nov 2020
/// Propósito: Crear un sistema POS como final de la materia Herramientas de Programación 1
/// </summary>

namespace POS_AyS
{
    public partial class frmLogin : Form
    {
        //Ruta del csv.
        string ruta = Application.StartupPath + "\\Base de Datos\\usuario.csv";

        public frmLogin()
        {
            InitializeComponent();

        }

        //public string userDetail;

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Usuario")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.LightGray;
                lblError1.Visible = false;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Usuario";
                txtUser.ForeColor = Color.DimGray;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Contraseña")
            {
                txtPass.Text = "";
                txtPass.UseSystemPasswordChar = true;
                txtPass.ForeColor = Color.LightGray;
                lblError1.Visible = false;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Contraseña";
                txtPass.UseSystemPasswordChar = false;
                txtPass.ForeColor = Color.DimGray;
                btnHide.Visible = false;
                btnShow.Visible = true;
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (txtPass.UseSystemPasswordChar == false && txtPass.Text == "Contraseña")
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
                btnHide.Visible = false;
                btnShow.Visible = true;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtPass.UseSystemPasswordChar == true)
            {
                txtPass.UseSystemPasswordChar = false;
                btnHide.Visible = true;
                btnShow.Visible = false;
            }
        }

        public void btnIngresar_Click(object sender, EventArgs e)
        {
            string rol = "", nombre = "";

            clsDatos datos = new clsDatos();
            MySqlDataAdapter dAdapter = new MySqlDataAdapter("SELECT COUNT(*) FROM usuarios WHERE usuario='" + txtUser.Text + "' AND contraseña ='" + txtPass.Text + "'", POS_AyS.clsDatos.conexion());
            MySqlCommand tipo = new MySqlCommand("SELECT tipo, nombre FROM usuarios WHERE usuario='" + txtUser.Text + "'", POS_AyS.clsDatos.conexion());


            tipo.Parameters.AddWithValue("tipo", rol);
            tipo.Parameters.AddWithValue("nombre", nombre);


            MySqlDataReader registro = tipo.ExecuteReader();
            
            DataTable dTable = new DataTable();
            dAdapter.Fill(dTable);

            frmInicio abrir = new frmInicio();

            try
            {
                if (dTable.Rows[0][0].ToString() == "1")
                {
                    if (registro.Read())
                    {
                        rol = registro["tipo"].ToString();
                        nombre = registro["nombre"].ToString();

                        clsVariables.usuario = nombre;

                        abrir.Show();
                        this.Hide();

                        if (rol == "Administrador")
                        {
                            abrir.btnUsersEdit.Visible = true;
                            abrir.btnInventario.Visible = true;
                            abrir.btnFact.Visible = true;
                            abrir.btnClientes.Visible = true;
                        }

                        if (rol == "Vendedor")
                        {
                            abrir.btnFact.Visible = true;
                            abrir.btnClientes.Visible = true;
                        }
                    }
                    
                }
                else
                {
                    //Nos muestra el mensaje de error de usuario y contraseña.
                    lblError1.Visible = true;
                }

            }
            catch (Exception)
            {
                //Nos muestra el mensaje de error de usuario y contraseña.
                MessageBox.Show("No se ha podido iniciar sesión, hay problema con la base de datos.");
                this.Close();
            }


            //if (datos.Ok())
            //{

            //    MessageBox.Show("Conectado");
            //}

            //else
            //{
            //    MessageBox.Show("No se conectó");
            //}

            //Validamos con el archivo de usuario si el usuario existe
            //if (txtUser.Text != "" && txtPass.Text != "")
            //{
            //    StreamReader archivo = new StreamReader(ruta);
            //    while ((line = archivo.ReadLine()) != null)
            //    {
            //        string[] columnas = line.Split(';');
            //        if (txtUser.Text == columnas[0] && txtPass.Text == columnas[2])
            //        {
            //            clsVariables.usuario = columnas[1];
            //            frmInicio abrir = new frmInicio();
            //            abrir.Show();
            //            this.Hide();
            //            txtUser.Text = columnas[0];
            //            txtPass.Text = columnas[2];

            //            //Validamos el rol y dependiendo de eso mostramos u ocultamos botones
            //            if (columnas[3] == "Administrador")
            //            {
            //                abrir.btnUsersEdit.Visible = true;
            //                abrir.btnInventario.Visible = true;
            //                abrir.btnFact.Visible = true;
            //                abrir.btnClientes.Visible = true;
            //            }

            //            if (columnas[3] == "Vendedor")
            //            {
            //                abrir.btnFact.Visible = true;
            //                abrir.btnClientes.Visible = true;
            //            }

            //            if (columnas[3] == "Facturación")
            //            {
            //                abrir.btnFact.Visible = true;
            //            }

            //            if (columnas[3] == "Bodega")
            //            {
            //                abrir.btnInventario.Visible = true;
            //            }

            //        }
            //        else
            //        {
            //            //Nos muestra el mensaje de error de usuario y contraseña.
            //            lblError1.Visible = true;
            //        }
            //    }
            //    archivo.Close();
            //}
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            clsDatos datos = new clsDatos();
        }
    }
}
