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
    public partial class frmInventario : Form
    {

        string[,] producto = new string[100, 4];
        string line;
        string[,] productos = new string[5, 4];
        int filas = 0;
        string ruta;

        clsDatos datos = new clsDatos();


        public frmInventario()
        {
            InitializeComponent();
        }

        public void cargar()
        {
            MySqlDataAdapter dAdapter = new MySqlDataAdapter("SELECT * FROM inventario ", POS_AyS.clsDatos.conexion());
            DataTable dTable = new DataTable();
            dAdapter.Fill(dTable);

            try
            {
                dAdapter = new MySqlDataAdapter("SELECT * FROM inventario ", POS_AyS.clsDatos.conexion());
                dTable = new DataTable();
                dAdapter.Fill(dTable);
                dtgInventario.DataSource = dTable;


                POS_AyS.clsDatos.cerrar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el Datagridview " + ex.ToString());
                POS_AyS.clsDatos.cerrar();

            }
        }


        private void btnAgregarInventario_Click(object sender, EventArgs e)
        {
            String cod = "";

            MySqlDataAdapter dAdapter = new MySqlDataAdapter("SELECT * FROM inventario ", POS_AyS.clsDatos.conexion());
            MySqlCommand codigo = new MySqlCommand("Select codigo From inventario", POS_AyS.clsDatos.conexion());

            codigo.Parameters.AddWithValue("codigo", cod);

            MySqlDataReader user2 = codigo.ExecuteReader();

            DataTable dTable = new DataTable();
            dAdapter.Fill(dTable);

            try
            {
                int cont = 0;
                int sumando = 0;

                for (int i = 0; i < dTable.Rows.Count; i++)
                {
                    sumando = i;
                    if (dTable.Rows[i][0].ToString() == txtCodInventario.Text)
                    {
                        MessageBox.Show("Ya existe el producto");
                        txtCodInventario.Text = "";
                        txtProducto.Text = "";
                        txtValor.Text = "";

                    }
                    else
                    {
                        cont++;
                    }
                }
                if (dTable.Rows.Count == cont)
                {
                    if ( txtCodInventario.Text != "" && txtProducto.Text != "" && txtValor.Text != "")
                    {
                        datos.crearProducto(txtCodInventario.Text, txtProducto.Text, Convert.ToInt32(txtValor.Text));
                        datos.usuario(dtgInventario);
                        txtCodInventario.Text = "";
                        txtProducto.Text = "";
                        txtValor.Text = "";

                        MessageBox.Show("Producto creado correctamente.");

                        cargar();
                    }
                    else
                    {
                        MessageBox.Show("Los campos no pueden estar vacios");
                    }
                }
                

                POS_AyS.clsDatos.cerrar();
            }
            catch (Exception)
            {

                MessageBox.Show("No se agregó ningún producto.");
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            cargar();
            btnEliminarProdInventario.Enabled = false;
            btnGuardarInventario.Enabled = false;
        }

        private void btnEliminarProdInventario_Click(object sender, EventArgs e)
        {
            datos.eliminarProducto(txtCodInventario.Text, txtProducto, txtValor);
            datos.usuario(dtgInventario);
            txtCodInventario.Text = "";
            txtProducto.Text = "";
            txtValor.Text = "";

            cargar();
            POS_AyS.clsDatos.cerrar();

            btnAgregar.Enabled = true;
            btnGuardarInventario.Enabled = false;
            btnEliminarProdInventario.Enabled = false;
            btnModificar.Enabled = true;
        }

        private void btnGuardarInventario_Click(object sender, EventArgs e)
        {

            datos.actualizarInventario(txtCodInventario, txtProducto, txtValor);
            datos.inventario(dtgInventario);

            txtCodInventario.Text = "";
            txtProducto.Text = "";
            txtValor.Text = "";

            MessageBox.Show("Producto modificado correctamente.");

            btnEliminarProdInventario.Enabled = true;

            btnGuardarInventario.Enabled = false;

            btnAgregar.Enabled = true;

            cargar();

        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            btnEliminarProdInventario.Enabled = true;
            btnAgregar.Enabled = false;
            btnGuardarInventario.Enabled = true;
            btnModificar.Enabled = false;
            string id;

            try
            {
                btnAgregar.Enabled = false;
                id = "" + dtgInventario.SelectedCells[0].Value;
                txtCodInventario.Text = "" + dtgInventario.SelectedCells[0].Value;
                txtProducto.Text = "" + dtgInventario.SelectedCells[1].Value;
                txtValor.Text = "" + dtgInventario.SelectedCells[2].Value;
                
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


                    dtgInventario.Columns.Add(columna);


                    StreamReader archivo = new StreamReader(ruta);
                    dtgInventario.DataSource = null;
                    dtgInventario.Columns.Clear();

                    dtgInventario.ColumnCount = 4;


                    while ((line = archivo.ReadLine()) != null)
                    {
                        string[] columnas = line.Split(',');


                        //DataGridView dtgU = new DataGridView();
                        if (filas == 0)
                        {

                            dtgInventario.Columns[0].Name = "Código";
                            dtgInventario.Columns[1].Name = "Descripción";
                            dtgInventario.Columns[2].Name = "valor";
                            dtgInventario.Columns[3].Name = "Cantidad";



                        }

                        filas++;

                        if (filas != 0)
                        {

                            dtgInventario.Rows.Add(columnas[0], columnas[1], columnas[2], columnas[3]);
                            producto[filas, 0] = columnas[0];
                            producto[filas, 1] = columnas[1];
                            producto[filas, 2] = columnas[2];
                            producto[filas, 3] = columnas[3];

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
                datos.eliminarTablaInventario();

                string codigo = "";
                string descripción = "";
                string valor = "";
                string cantidad = "";

                try
                {

                    foreach (DataGridViewRow row in dtgInventario.Rows)
                    {

                        //agregar.Parameters.Clear();

                        codigo = dtgInventario[0, row.Index].Value.ToString();
                        descripción = dtgInventario[1, row.Index].Value.ToString();
                        valor = dtgInventario[2, row.Index].Value.ToString();
                        cantidad = dtgInventario[3, row.Index].Value.ToString();

                        MySqlCommand agregar = new MySqlCommand("INSERT INTO productos (Código, Descripción, valor, Cantidad) values('" + codigo + "','" + descripción + "','" + valor + "','" + cantidad + "')", POS_AyS.clsDatos.conexion());

                        agregar.ExecuteNonQuery();

                        agregar.Parameters.Clear();

                    }

                    MessageBox.Show("Datos agregados correctamente");

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al agregar" + ex);

                }

                dtgInventario.DataSource = null;
                dtgInventario.Columns.Clear();

                cargar();
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
                foreach (DataGridViewColumn col in dtgInventario.Columns)
                {
                    columnas.Add(col.HeaderText);
                }
                //filas.Add(string.Join(";", columnas));

                foreach (DataGridViewRow fila in dtgInventario.Rows)
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
