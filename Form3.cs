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
    public partial class frmFactura : Form
    {
        string line;
        string[,] facturar = new string[5, 4];
        int filas = 0;
        double Cantidadfactura;
        double Total;
        double Iva = 0;
        double Subtotal = 0;

        string nit = "";
        string cliente = "";
        string direccion = "";
        string vendedor = "";
        string contado = "";
        string credito = "";
        string dias = "";
        string descuento = "";
        string plazo = "";


        public frmFactura()
        {
            InitializeComponent();
        }

        //public void cargar()
        //{
        //    MySqlDataAdapter dAdapter = new MySqlDataAdapter("SELECT * FROM usuarios ", POS_AyS.clsDatos.conexion());
        //    DataTable dTable = new DataTable();
        //    dAdapter.Fill(dTable);

        //    try
        //    {
        //        dAdapter = new MySqlDataAdapter("SELECT * FROM usuarios ", POS_AyS.clsDatos.conexion());
        //        dTable = new DataTable();
        //        dAdapter.Fill(dTable);

        //        POS_AyS.clsDatos.cerrar();

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("No se puedo llenar el Datagridview " + ex.ToString());
        //        POS_AyS.clsDatos.cerrar();

        //    }
        //}

        private void frmFactura_Load(object sender, EventArgs e)
        {

        }

        //Rellenamos los combo box con los datos seleccionados en otro

        private void MostrarDato1(CsvDatos csvDato)
        {
            cmbDescripcion.Text = csvDato.Columna3;
            cmbValor.Text = csvDato.Columna4;
        }
        private void MostrarDato(CsvDatos csvDato)
        {
            cmbCod.Text = csvDato.ComboDisplayMember;
            cmbValor.Text = csvDato.Columna4;
        }

        private void MostrarDatoCliente1(CsvClientes csvCliente)
        {
            cmbNit.Text = csvCliente.Columna5;
            cmbDireccion.Text = csvCliente.Columna7;
            cmbVendedor.Text = csvCliente.Columna8;
            cmbDias.Text = csvCliente.Columna9;
            cmbDcto.Text = csvCliente.Columna10;
        }

        private void MostrarDatoCliente2(CsvClientes csvCliente)
        {
            cmbCliente.Text = csvCliente.Columna6;
            cmbDireccion.Text = csvCliente.Columna7;
            cmbVendedor.Text = csvCliente.Columna8;
            cmbDias.Text = csvCliente.Columna9;
            cmbDcto.Text = csvCliente.Columna10;
        }

        private void cmbCod_SelectedValueChanged(object sender, EventArgs e)
        {
            LimpiarDatos();
            var csvRenglon = (this.cmbCod.SelectedItem as CsvDatos);
            MostrarDato(csvRenglon);
        }

        private void cmbDescripcion_SelectedValueChanged(object sender, EventArgs e)
        {
            LimpiarDatos();
            var csvRenglon1 = (this.cmbDescripcion.SelectedItem as CsvDatos);
            MostrarDato1(csvRenglon1);
        }
        private void cmbNit_SelectedValueChanged(object sender, EventArgs e)
        {
            LimpiarDatos();
            var csvRenglon2 = (this.cmbNit.SelectedItem as CsvClientes);
            MostrarDatoCliente1(csvRenglon2);
        }
        private void cmbCliente_SelectedValueChanged(object sender, EventArgs e)
        {
            LimpiarDatos();
            var csvRenglon3 = (this.cmbCliente.SelectedItem as CsvClientes);
            MostrarDatoCliente2(csvRenglon3);
        }
        private void LimpiarDatos()
        {
            cmbCod.Text = string.Empty;
            cmbDescripcion.Text = string.Empty;
            cmbValor.Text = string.Empty;
        }

        private void LimpiarDatosCliente()
        {
            cmbNit.Text = string.Empty;
            cmbCliente.Text = string.Empty;
            cmbDireccion.Text = string.Empty;
            cmbVendedor.Text = string.Empty;
        }
        public static int contFila = 0;
        public static double subTotal = 0;
        public static double IVA = 19;
        public static double dcto = 0;
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {

        

            
        }
        public static double subTotalRemove = 0;

        public class CsvDatos
        {
            public int Renglon { get; set; }
            public int Renglon2 { get; set; }
            public int Renglon3 { get; set; }
            public string ComboDisplayMember { get; set; }
            public string ComboDisplayMember2 { get; set; }
            public string Columna3 { get; set; }
            public string Columna4 { get; set; }
        }

        public class CsvClientes 
        {
            public int Renglon4 { get; set; }
            public int Renglon5 { get; set; }
            public int Renglon6 { get; set; }
            public int Renglon7 { get; set; }
            public int Renglon8 { get; set; }
            public int Renglon9 { get; set; }
            public string Columna5 { get; set; }
            public string Columna6 { get; set; }
            public string Columna7 { get; set; }
            public string Columna8 { get; set; }
            public string Columna9 { get; set; }
            public string Columna10 { get; set; }
        }

        private void cmbCod_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void rbtnCredito_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void rbtnCredito_CheckedChanged(object sender, EventArgs e)
        {
            //if (rbtnCredito.Checked != false)
            //{
            //    txtDias.Enabled = true;
            //}
            //else
            //{
            //    txtDias.Enabled = false;
            //}
        }
        public static double subTotalFin;
        private void btnEliminarProd_Click_1(object sender, EventArgs e)
        {
            if (dtgFacturar.CurrentRow == null)
            {
                MessageBox.Show("No has seleccionado ningún producto para eliminar.");
                return;
            }
            else
            {
                double subTotalRemove = Convert.ToDouble(dtgFacturar.CurrentRow.Cells[2].Value) * Convert.ToDouble(dtgFacturar.CurrentRow.Cells[3].Value);
                if (subTotalRemove == subTotalRemove)
                {
                    subTotalFin = subTotal - subTotalRemove;

                    txtSubtotal.Text = Convert.ToString(subTotalFin);
                    txtIva.Text = Convert.ToString((subTotalFin / 100) * IVA);
                    txtTotal.Text = Convert.ToString(Convert.ToDouble(txtIva.Text) + Convert.ToDouble(txtSubtotal.Text));

                    subTotal = subTotalFin;

                    dtgFacturar.Rows.Remove(dtgFacturar.CurrentRow);
                    
                    contFila = contFila - 1;

                    if (subTotal <= 0)
                    {
                        txtSubtotal.Text = "0";
                        txtIva.Text = "0";
                        txtTotal.Text = "0";
                    }
                }
            }

        }

        private void btnFacturar_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog() { Filter = ".face|.face" }; //"usuarios.csv|.csv"
            if (guardar.ShowDialog() == DialogResult.OK)
            {
                List<string> filas = new List<string>();

                List<string> cabeceras = new List<string>();
                foreach (DataGridViewColumn col in dtgFacturar.Columns)
                {
                    cabeceras.Add(col.HeaderText);

                }

                filas.Add(string.Join(" ", nit, cliente, direccion, vendedor, contado, credito, dias, "\n", "Código", "   Descripción   ", "Valor Unitario", "Cantidad"));

                foreach (DataGridViewRow fila in dtgFacturar.Rows)
                {

                    try
                    {
                        List<string> Celda = new List<string>();
                        foreach (DataGridViewCell Cell in fila.Cells)
                        {

                            Celda.Add(Cell.Value.ToString());
                        }
                        filas.Add(string.Join("     -     ", Celda));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex);
                    }
                }
                filas.Add(string.Join(" ", "SubTotal: ", Subtotal, "Iva: ", Iva, "\n", Total));
                File.WriteAllLines(guardar.FileName, filas);

            }
            LimpiarDatosCliente();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbNit.Text != "" && cmbCliente.Text != "" && cmbCod.Text != "" && cmbDescripcion.Text != "" && cmbValor.Text != "")
            {

                if (txtCantidad.Text != "" && txtCantidad.Text != "0")
                {

                    dtgFacturar.Rows.Add(cmbCod.Text, cmbDescripcion.Text, cmbValor.Text, txtCantidad.Text);

                    nit = "Nit: " + cmbNit.Text;
                    cliente = "Nombre: " + cmbCliente.Text;
                    direccion = "DIrección: " + cmbDireccion.Text;
                    vendedor = "Vendedor: " + cmbVendedor.Text;
                    descuento = "Descuento: " + cmbDcto.Text;
                    plazo = "Plazo: " + cmbDias;

                    double importe = Convert.ToDouble(dtgFacturar.Rows[contFila].Cells[2].Value) * Convert.ToDouble(dtgFacturar.Rows[contFila].Cells[3].Value);

                    contFila++;

                    subTotal = Convert.ToDouble(txtSubtotal.Text);
                    dcto = subTotal / 100 * Convert.ToDouble(cmbDcto.Text);

                    subTotal = subTotal + importe;

                    //No logré hacer que se sumen las filas y columnas cada vez que se agregan, solo se opera el último dato agregado
                    txtSubtotal.Text = Convert.ToString(subTotal);
                    txtIva.Text = Convert.ToString((subTotal / 100) * IVA);
                    txtTotal.Text = Convert.ToString(Convert.ToDouble(txtIva.Text) + (Convert.ToDouble(txtSubtotal.Text) - Convert.ToInt32(txtDcto.Text)));
                    txtDcto.Text = Convert.ToString(cmbDcto.Text);
                }
                else
                {
                    MessageBox.Show("Debes ingresar la cantidad de productos.");
                }

                cmbCod.Text = "";
                cmbDescripcion.Text = "";
                cmbValor.Text = "";
                txtCantidad.Text = "";
            }
            else
            {
                MessageBox.Show("Los campos estaban vacíos, no se crearon datos.");
            }
        }
    }
}