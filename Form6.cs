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
    public partial class frmClientes : Form
    {
        clsDatos datos = new clsDatos();
        public int varCedula;
        string ruta;
        string line;
        string[,] producto = new string[100, 6];
        int filas = 0;

        public frmClientes()
        {
            InitializeComponent();
        }

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            if (txtCedula.Text == "" || txtCliente.Text == "" || txtDireccion.Text == "" || cmbVend.Text == "" || txtPlazo.Text == "" || txtDcto.Text == "")
            {
                MessageBox.Show("Uno o más campos estaban vacíos. \n Todos lo campos son obligatorios. \n No se crearon datos.");
            }
            else
            {
                dtgClientes.Rows.Add(txtCedula.Text, txtCliente.Text, txtDireccion.Text, cmbVend.Text, txtPlazo.Text, txtDcto.Text, txtPlazo.Text );
                txtCedula.Text = "";
                txtCliente.Text = "";
                txtDireccion.Text = "";
                cmbVend.Text = "";
                txtPlazo.Text = "";
                txtDcto.Text = "";
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            datos.eliminarCliente(Convert.ToInt32(txtCedula.Text), txtCliente, txtDireccion, cmbVend, txtPlazo, txtDcto);
            datos.usuario(dtgClientes);
            txtCedula.Text = "";
            txtCliente.Text = "";
            txtDireccion.Text = "";
            cmbVend.Text = "";
            txtPlazo.Text = "";
            txtDcto.Text = "";

            cargarClientes();
            POS_AyS.clsDatos.cerrar();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            cargarClientes();
            btnGuardar.Enabled = false;
        }

        public void cargarClientes()
        {
            MySqlDataAdapter dAdapter = new MySqlDataAdapter("SELECT * FROM clientes ", POS_AyS.clsDatos.conexion());
            DataTable dTable = new DataTable();
            dAdapter.Fill(dTable);

            try
            {
                dAdapter = new MySqlDataAdapter("SELECT * FROM clientes ", POS_AyS.clsDatos.conexion());
                dTable = new DataTable();
                dAdapter.Fill(dTable);
                dtgClientes.DataSource = dTable;

                POS_AyS.clsDatos.cerrar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo llenar el Datagridview " + ex.ToString());
                POS_AyS.clsDatos.cerrar();

            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnCrearCliente.Enabled = false;
            btnGuardar.Enabled = true;
            btnEliminarCliente.Enabled = false;
            string id;
            try
            {
                id = "" + dtgClientes.SelectedCells[0].Value;
                txtCedula.Text = "" + dtgClientes.SelectedCells[0].Value;
                txtCliente.Text = "" + dtgClientes.SelectedCells[1].Value;
                txtDireccion.Text = "" + dtgClientes.SelectedCells[2].Value;
                cmbVend.Text = "" + dtgClientes.SelectedCells[3].Value;
                txtPlazo.Text = "" + dtgClientes.SelectedCells[4].Value;
                txtDcto.Text = "" + dtgClientes.SelectedCells[5].Value;

                clsVariables.varCedula = Convert.ToInt32(txtCedula.Text);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            datos.actualizarCliente(txtCedula, txtCliente, txtDireccion, cmbVend, txtPlazo, txtDcto);
            datos.cliente(dtgClientes);
            txtCedula.Text = "";
            txtCliente.Text = "";
            txtDireccion.Text = "";
            cmbVend.Text = "";
            txtPlazo.Text = "";
            txtDcto.Text = "";
            MessageBox.Show("Cliente modificado correctamente.");

            cargarClientes();

            btnCrearCliente.Enabled = true;
            btnEliminarCliente.Enabled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            btnCrearCliente.Enabled = false;
            btnLimpair.Enabled = true;

            if (txtCedula.Text != "")
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM clientes WHERE cedula='" + txtCedula.Text + "'", clsDatos.conexion());
                command.Parameters.AddWithValue("cedula", txtCedula.Text);
                MySqlDataReader registro = command.ExecuteReader();
                if (registro.Read())
                {
                    txtCedula.Text = registro["cedula"].ToString();
                    txtCliente.Text = registro["nombre"].ToString();
                    txtDireccion.Text = registro["direccion"].ToString();
                    cmbVend.Text = registro["vendedor"].ToString();
                    txtPlazo.Text = registro["plazo"].ToString();
                    txtDcto.Text = registro["dcto"].ToString();
                }
                else
                {
                    MessageBox.Show("El usuario no se encuentra o está mal escrito.");
                }
                
            }
            if (txtCliente.Text != "")
            {
                MySqlCommand commandCliente = new MySqlCommand("SELECT * FROM clientes WHERE nombre='" + txtCliente.Text + "'", clsDatos.conexion());
                commandCliente.Parameters.AddWithValue("cedula", txtCliente.Text);
                MySqlDataReader registroCliente = commandCliente.ExecuteReader();
                if (registroCliente.Read())
                {
                    txtCedula.Text = registroCliente["cedula"].ToString();
                    txtCliente.Text = registroCliente["nombre"].ToString();
                    txtDireccion.Text = registroCliente["direccion"].ToString();
                    cmbVend.Text = registroCliente["vendedor"].ToString();
                    txtPlazo.Text = registroCliente["plazo"].ToString();
                    txtDcto.Text = registroCliente["dcto"].ToString();
                }
                else
                {
                    MessageBox.Show("El usuario no se encuentra o está mal escrito.");
                }
                clsDatos.cerrar();
            }
        }

        private void btnLimpair_Click(object sender, EventArgs e)
        {
            txtCliente.Text = "";
            txtCedula.Text = "";
            txtDcto.Text = "";
            txtDireccion.Text = "";
            txtPlazo.Text = "";
            cmbVend.Text = "";
            btnCrearCliente.Enabled = true;
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


                    dtgClientes.Columns.Add(columna);


                    StreamReader archivo = new StreamReader(ruta);
                    dtgClientes.DataSource = null;
                    dtgClientes.Columns.Clear();

                    dtgClientes.ColumnCount = 6;


                    while ((line = archivo.ReadLine()) != null)
                    {
                        string[] columnas = line.Split(',');


                        //DataGridView dtgU = new DataGridView();
                        if (filas == 0)
                        {

                            dtgClientes.Columns[0].Name = "Cédula";
                            dtgClientes.Columns[1].Name = "Nombre";
                            dtgClientes.Columns[2].Name = "Dirección";
                            dtgClientes.Columns[3].Name = "Vendedor";
                            dtgClientes.Columns[4].Name = "Plazo";
                            dtgClientes.Columns[5].Name = "Dcto";

                        }

                        filas++;

                        if (filas != 0)
                        {

                            dtgClientes.Rows.Add(columnas[0], columnas[1], columnas[2], columnas[3], columnas[4], columnas[5]);
                            producto[filas, 0] = columnas[0];
                            producto[filas, 1] = columnas[1];
                            producto[filas, 2] = columnas[2];
                            producto[filas, 3] = columnas[3];
                            producto[filas, 4] = columnas[4];
                            producto[filas, 5] = columnas[5];

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

            if (MessageBox.Show("Al continuar se borrará los datos actuales y se importarán los datos del archivo seleccionado.", "Importar archivo CSV", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                datos.eliminarTablaClientes();

                string cedula = "";
                string nombre = "";
                string direccion = "";
                string vendedor = "";
                string plazo = "";
                string dcto = "";

                try
                {
                    foreach (DataGridViewRow row in dtgClientes.Rows)
                    {
                        cedula = dtgClientes[0, row.Index].Value.ToString();
                        nombre = dtgClientes[1, row.Index].Value.ToString();
                        direccion = dtgClientes[2, row.Index].Value.ToString();
                        vendedor = dtgClientes[3, row.Index].Value.ToString();
                        plazo = dtgClientes[4, row.Index].Value.ToString();
                        dcto = dtgClientes[5, row.Index].Value.ToString();

                        MySqlCommand agregar = new MySqlCommand("INSERT INTO clientes (Cédula, Nombre, Dirección, Vendedor,Plazo,Dcto) values('" + cedula + "','" + nombre + "','" + direccion + "','" + vendedor + "','" + plazo + "','" + dcto + "')", POS_AyS.clsDatos.conexion());

                        agregar.ExecuteNonQuery();

                        agregar.Parameters.Clear();

                    }

                    MessageBox.Show("Datos agregados correctamente");

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al agregar" + ex);

                }

                dtgClientes.DataSource = null;
                dtgClientes.Columns.Clear();

                cargarClientes();
                POS_AyS.clsDatos.cerrar();

            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {


            SaveFileDialog guardar = new SaveFileDialog() { Filter = "ARCHIVO.csv|*.csv" };
            if (guardar.ShowDialog() == DialogResult.OK)
            {
                List<string> filas = new List<string>();

                List<string> columnas = new List<string>();
                foreach (DataGridViewColumn col in dtgClientes.Columns)
                {
                    columnas.Add(col.HeaderText);
                }
                //filas.Add(string.Join(";", columnas));

                foreach (DataGridViewRow fila in dtgClientes.Rows)
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
                        MessageBox.Show("Error al agregar" + ex);

                    }
                }

                File.WriteAllLines(guardar.FileName, filas);
            }
        }
    }
}
