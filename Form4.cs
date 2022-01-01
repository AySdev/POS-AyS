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

namespace POS_AyS
{
    public partial class frmUsuarios : Form
    {

        string line;
        string[,] usuario = new string[100, 4];
        int filas = 0;
        string ruta;

        MySqlCommand command;


        clsDatos datos = new clsDatos();
        public frmUsuarios()
        {
            InitializeComponent();
        }

        public void cargar()
        {
            MySqlDataAdapter dAdapter = new MySqlDataAdapter("SELECT * FROM usuarios ", POS_AyS.clsDatos.conexion());
            DataTable dTable = new DataTable();
            dAdapter.Fill(dTable);

            try
            {
                dAdapter = new MySqlDataAdapter("SELECT * FROM usuarios ", POS_AyS.clsDatos.conexion());
                dTable = new DataTable();
                dAdapter.Fill(dTable);
                dtgUsuarios.DataSource = dTable;

                POS_AyS.clsDatos.cerrar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo llenar el Datagridview " + ex.ToString());
                POS_AyS.clsDatos.cerrar();

            }

        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            cargar();
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            datos.eliminar(txtUsuario.Text, txtNombre, txtContrasena, cmbRol);
            datos.usuario(dtgUsuarios);
            txtUsuario.Text = "";
            txtNombre.Text = "";
            txtContrasena.Text = "";
            cmbRol.Text = "";

            cargar();
            POS_AyS.clsDatos.cerrar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            datos.actualizar(txtUsuario, txtNombre, txtContrasena, cmbRol);
            datos.usuario(dtgUsuarios);

            txtUsuario.Text = "";
            txtNombre.Text = "";
            txtContrasena.Text = "";
            cmbRol.Text = "";

            MessageBox.Show("Usuario modificado correctamente.");

            btnCrear.Enabled = true;

            btnGuardar.Enabled = false;

            btnEliminar.Enabled = false;

            cargar();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            String user = "";

            MySqlDataAdapter dAdapter = new MySqlDataAdapter("SELECT * FROM usuarios ", POS_AyS.clsDatos.conexion());
            MySqlCommand usuario = new MySqlCommand("Select usuario From usuarios", POS_AyS.clsDatos.conexion());

            usuario.Parameters.AddWithValue("usuario", user);

            MySqlDataReader user2 = usuario.ExecuteReader();

            DataTable dTable = new DataTable();
            dAdapter.Fill(dTable);

            try
            {
                int cont = 0;
                int sumando = 0;

                for (int i = 0; i < dTable.Rows.Count; i++)
                {
                    sumando = i;
                    if (dTable.Rows[i][0].ToString() == txtUsuario.Text)
                    {
                        MessageBox.Show("Ya existe el usuario");
                        txtUsuario.Text = "";
                        txtNombre.Text = "";
                        txtContrasena.Text = "";
                        cmbRol.Text = "";

                    }
                    else
                    {
                        cont++;
                    }
                }
                if (txtUsuario.Text != "" && txtNombre.Text != "" && txtContrasena.Text != "" && cmbRol.Text != "")
                {
                    if (dTable.Rows.Count == cont)
                    {
                        datos.crear(txtUsuario.Text, txtNombre.Text, txtContrasena.Text, cmbRol.Text);
                        datos.usuario(dtgUsuarios);
                        txtUsuario.Text = "";
                        txtNombre.Text = "";
                        txtContrasena.Text = "";
                        cmbRol.Text = "";
                        MessageBox.Show("Usuario creado correctamente.");

                        cargar();
                    }
                }
                else
                {
                    MessageBox.Show("Los campos no pueden estar vacios");
                }

                POS_AyS.clsDatos.cerrar();
            }
            catch (Exception)
            {

                MessageBox.Show("No se agregó ningún dato.");
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtUsuario.Enabled = false;
            btnGuardar.Enabled = true;
            btnEliminar.Enabled = true;
            string id;
            try
            {
                btnCrear.Enabled = false;
                id = "" + dtgUsuarios.SelectedCells[0].Value;
                txtUsuario.Text = "" + dtgUsuarios.SelectedCells[0].Value;
                txtNombre.Text = "" + dtgUsuarios.SelectedCells[1].Value;
                txtContrasena.Text = "" + dtgUsuarios.SelectedCells[2].Value;
                cmbRol.Text = "" + dtgUsuarios.SelectedCells[3].Value;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnCargaDB_Click(object sender, EventArgs e)
        {

            abrir();

        }



        public void abrir()
        {
            
            OpenFileDialog OpenF = new OpenFileDialog() { Filter = "Archivo CSV|*.csv" };

            if (OpenF.ShowDialog() == DialogResult.OK)
            {
                ruta = Path.GetFullPath(OpenF.FileName);

                POS_AyS.clsDatos.cerrar();

                try
                {

                    DataGridViewTextBoxColumn columna = new DataGridViewTextBoxColumn();


                    dtgUsuarios.Columns.Add(columna);


                    StreamReader archivo = new StreamReader(ruta);
                    dtgUsuarios.DataSource = null;
                    dtgUsuarios.Columns.Clear();

                    dtgUsuarios.ColumnCount = 4;


                    while ((line = archivo.ReadLine()) != null)
                    {
                        string[] columnas = line.Split(',');


                        //DataGridView dtgU = new DataGridView();
                        if (filas == 0)
                        {

                            dtgUsuarios.Columns[0].Name = "Usuario";
                            dtgUsuarios.Columns[1].Name = "Nombre";
                            dtgUsuarios.Columns[2].Name = "Contraseña";
                            dtgUsuarios.Columns[3].Name = "Rol";

                            

                        }

                        filas++;

                        if (filas != 0)
                        {

                            dtgUsuarios.Rows.Add(columnas[0], columnas[1], columnas[2], columnas[3]);
                            usuario[filas, 0] = columnas[0];
                            usuario[filas, 1] = columnas[1];
                            usuario[filas, 2] = columnas[2];
                            usuario[filas, 3] = columnas[3];

                        }
                    }
                    archivo.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Ha ocurrido un error" + ex);
                }
            }
            ruta = string.Empty;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            //int cont = 0;
            //foreach (DataGridViewRow row in dtgUsuarios.Rows)
            //{
            //    cont++;
            //}

            //if (cont)
            //{

            //}

            if (MessageBox.Show("Al continuar se borrará los datos actuales y se importarán los datos del archivo seleccionado.", "Importar archivo CSV", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                datos.eliminarTablaUsuarios();

                string usuario = "";
                string nombre = "";
                string contrasena = "";
                string tipo = "";

                try
                {
                    foreach (DataGridViewRow row in dtgUsuarios.Rows)
                    {

                        usuario = "";
                        nombre = "";
                        contrasena = "";
                        tipo = "";

                        usuario = dtgUsuarios[0, row.Index].Value.ToString();
                        nombre = dtgUsuarios[1, row.Index].Value.ToString();
                        contrasena = dtgUsuarios[2, row.Index].Value.ToString();
                        tipo = dtgUsuarios[3, row.Index].Value.ToString();

                        MySqlCommand agregar = new MySqlCommand("INSERT INTO usuarios (Usuario, Nombre, Contraseña, Tipo) values('" + usuario + "','" + nombre + "','" + contrasena + "','" + tipo + "')", POS_AyS.clsDatos.conexion());

                        if (usuario != "")
                        {
                            agregar.ExecuteNonQuery();

                        }
                        agregar.Parameters.Clear();

                        //agregar.ExecuteNonQuery();

                        //agregar.Parameters.Clear();


                    }

                    MessageBox.Show("Datos agregados correctamente");

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al agregar" + ex);

                }

                dtgUsuarios.DataSource = null;
                dtgUsuarios.Columns.Clear();

                cargar();
                POS_AyS.clsDatos.cerrar();

            }
        }

        private void btnConectarDB_Click(object sender, EventArgs e)
        {
            dtgUsuarios.DataSource = null;
            dtgUsuarios.Columns.Clear();


            cargar();
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;

        }

        public string insertarCSV(string usuario, string nombre, string contrasena, string tipo)
        {
            string salida = "";
            try
            {
                command.Parameters.Clear();
                command = new MySqlCommand("INSERT INTO usuarios (usuario, nombre, contrasena, tipo) values('" + usuario + "','" + nombre + "','" + contrasena + "','" + tipo + "')", POS_AyS.clsDatos.conexion());
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto:" + ex.ToString();

            }
            return salida;
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {


            SaveFileDialog guardar = new SaveFileDialog() { Filter = "ARCHIVO.csv|*.csv" };
            if (guardar.ShowDialog() == DialogResult.OK)
            {
                List<string> filas = new List<string>();

                List<string> columnas = new List<string>();
                foreach (DataGridViewColumn col in dtgUsuarios.Columns)
                {
                    columnas.Add(col.HeaderText);
                }
                //filas.Add(string.Join(";", columnas));

                foreach (DataGridViewRow fila in dtgUsuarios.Rows)
                {
                    try
                    {

                        List<string> celdas = new List<string>();
                        foreach (DataGridViewCell c in fila.Cells)
                            celdas.Add(c.Value.ToString());

                        filas.Add(string.Join(",", celdas));
                    }
                    catch (Exception ex) 
                    {
                        MessageBox.Show("Error" + ex);
                    }
                }

                File.WriteAllLines(guardar.FileName, filas);
            }
        }

    }
}
