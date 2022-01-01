using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Reflection;
using System.Data.Common;
using MySql.Data.MySqlClient;

namespace POS_AyS
{

    class clsDatos
    {
        MySqlCommand command;
        MySqlCommand command2;
        MySqlConnection connect;
        MySqlDataReader reader;
        MySqlDataAdapter dAdapter;
        MySqlDataAdapter dAdapter2;
        DataTable dTable;
        DataTable dTable2;

        public static MySqlConnection conexion()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("Database=ayspos; Data Source=localhost; User Id=root; Password=AySpos;");
                conn.Open();
                return conn;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static MySqlConnection getConexion()
        {
            string conn = "Database=ayspos; Data Source=localhost; User Id=root; Password=AySpos;" ;

            MySqlConnection conexion = new MySqlConnection(conn);

            return conexion;
        }

        public static MySqlConnection cerrar()
        {
            MySqlConnection cerrar = new MySqlConnection("Database=ayspos; Data Source=localhost; User Id=root; Password=AySpos;");
            cerrar.Close();
            return cerrar;
        }

        public string crear(string usuario, string nombre, string contrasena, string tipo)
        {
            string salida = "";
            try
            {
                command = new MySqlCommand("Insert into usuarios(usuario,nombre,contrasena,tipo) values('" + usuario + "','" + nombre + "','" + contrasena + "','" + tipo + "')", POS_AyS.clsDatos.conexion());
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto:" + ex.ToString();

            }
            return salida;
        }


        public void actualizar(TextBox txtUsuario, TextBox txtNombre, TextBox txtContrasena, ComboBox cmbTipo)
        {
            try
            {
                command = new MySqlCommand("UPDATE usuarios set nombre='" + txtNombre.Text + "',contrasena= '" + txtContrasena.Text + "',tipo='" + cmbTipo.Text + "' WHERE usuario= '" + txtUsuario.Text + "'", POS_AyS.clsDatos.conexion());
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conectó" + ex.ToString());
            }

        }

        public void actualizarCliente(TextBox txtCedula, TextBox txtCliente, TextBox txtDireccion, ComboBox cmbVend, TextBox txtPlazo, TextBox txtescuento)
        {
            frmClientes clientes = new frmClientes();
            int cedu = POS_AyS.clsVariables.varCedula;

            try
            {
                command = new MySqlCommand("UPDATE clientes set cedula= '" + txtCedula.Text + "',nombre = '" + txtCliente.Text + "',direccion ='" + txtDireccion.Text + "',vendedor = '" + cmbVend.Text + "', plazo= '" + txtPlazo.Text + "', dcto='" + txtescuento.Text + "' WHERE cedula= '"+ cedu + "'", POS_AyS.clsDatos.conexion());
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conectó" + ex.ToString());

            }
        }

        public string pResgitrada(TextBox usuario)
        {
            try
            {
                int contador = 0;
                
                command = new MySqlCommand("Select * from usuarios where usuario= '" + usuario.Text + "'", conexion());
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    contador++;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar: " + ex.ToString());
            }

            string usuar = Convert.ToString(usuario.Text);

            return usuar;
        }

        public void usuario(DataGridView dtg)
        {
            try
            {         
                
                dAdapter = new MySqlDataAdapter("Select * from usuario", connect);
                dTable = new DataTable();
                dAdapter.Fill(dTable);
                dtg.DataSource = dTable;

            }
            catch (Exception)
            {

                //MessageBox.Show("No se pudo llenar el DataGrid");
            }
        }

        public void cliente(DataGridView dtg2)
        {
            try
            {

                dAdapter2 = new MySqlDataAdapter("Select * from clientes", connect);
                dTable2 = new DataTable();
                dAdapter2.Fill(dTable2);
                dtg2.DataSource = dTable2;

            }
            catch (Exception)
            {

                //MessageBox.Show("No se pudo llenar el DataGrid");
            }
        }

        public void ConexionCrear()
        {

        }
        public void eliminar(string txtUsuario, TextBox txtNombre, TextBox txtContrasena, ComboBox cmbRol)
        {
            int confirm = 0;
            string borrar = "DELETE FROM usuarios WHERE usuario='" + txtUsuario + "'";
            MySqlCommand command = new MySqlCommand(borrar, conexion());
            //command.Parameters.AddWithValue("usuario", txtUsuario);
            confirm = command.ExecuteNonQuery();

            if (confirm == 1)
            {
                MessageBox.Show("se elimino correctamente");
            }
            else
            {
                MessageBox.Show("No se encontro el usuario");
            }
        }

        public void eliminarCliente(int cedula, TextBox txtCliente, TextBox txtDireccion, ComboBox cmbVend, TextBox txtPlazo, TextBox txtDcto)
        {
            int confirm = 0;
            string borrar = "DELETE FROM clientes WHERE nit='" + cedula + "'";
            MySqlCommand command = new MySqlCommand(borrar, conexion());
            //command.Parameters.AddWithValue("usuario", txtUsuario);
            confirm = command.ExecuteNonQuery();

            if (confirm == 1)
            {
                MessageBox.Show("Se elimino correctamente");
            }
            else
            {
                MessageBox.Show("No se encontro el cliente");
            }
        }

        public string crearProducto(string codigo, string producto, int valor)
        {
            string salida = "";
            try
            {
                command = new MySqlCommand("Insert into inventario(codigo,producto,valor) values('" + codigo + "','" + producto + "','" + valor + "')", POS_AyS.clsDatos.conexion());
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto:" + ex.ToString();

            }
            return salida;
        }

        public void eliminarProducto(string txtCodInventario, TextBox txtProducto, TextBox txtValor)
        {
            int confirm = 0;
            string borrar = "DELETE FROM inventario WHERE codigo='" + txtCodInventario + "'";
            MySqlCommand command = new MySqlCommand(borrar, conexion());
            confirm = command.ExecuteNonQuery();

            if (confirm == 1)
            {
                MessageBox.Show("Producto eliminado correctamente");
            }
            else
            {
                MessageBox.Show("No se encontro el producto");
            }
        }

        public void actualizarInventario(TextBox txtCodInventario, TextBox txtProducto, TextBox txtValor)
        {

            int cod = POS_AyS.clsVariables.varCodProducto;

            try
            {
                command = new MySqlCommand("UPDATE inventario set codigo='" + txtCodInventario.Text + "',producto= '" + txtProducto.Text + "',valor='" + txtValor.Text + "' WHERE codigo= '" + cod + "'", POS_AyS.clsDatos.conexion());
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conectó" + ex.ToString());
            }

        }

        public void inventario(DataGridView dtg)
        {
            try
            {

                dAdapter = new MySqlDataAdapter("Select * from inventario", connect);
                dTable = new DataTable();
                dAdapter.Fill(dTable);
                dtg.DataSource = dTable;

            }
            catch (Exception)
            {

                //MessageBox.Show("No se pudo llenar el DataGrid");
            }
        }

        public void eliminarTablaUsuarios()
        {
            int confirm = 0;
            string borrar = "DELETE FROM usuarios";

            MySqlCommand command = new MySqlCommand(borrar, conexion());

            confirm = command.ExecuteNonQuery();

            if (confirm != 0)
            {
                MessageBox.Show("se elimino correctamente");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        public void eliminarTablaClientes()
        {
            int confirm = 0;
            string borrar = "DELETE FROM clientes";

            MySqlCommand command = new MySqlCommand(borrar, conexion());

            confirm = command.ExecuteNonQuery();

            if (confirm != 0)
            {
                MessageBox.Show("se elimino correctamente");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        public void eliminarTablaInventario()
        {
            int confirm = 0;
            string borrar = "DELETE FROM inventario";

            MySqlCommand command = new MySqlCommand(borrar, conexion());

            confirm = command.ExecuteNonQuery();

            if (confirm != 0)
            {
                MessageBox.Show("se elimino correctamente");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }



        public void cargarASQL(DataGridView dtg)
        {
            frmUsuarios usuarios = new frmUsuarios();
            
            try
            {

                int confirm = 0;
                string borrar = "DELETE FROM usuarios list";
                MySqlCommand command = new MySqlCommand(borrar, conexion());
                confirm = command.ExecuteNonQuery();

                if (confirm == 1)
                {
                    MessageBox.Show("Producto eliminado correctamente");
                }
                else
                {
                    MessageBox.Show("No se encontro el producto");
                }

            }
            catch (Exception)
            {

                //MessageBox.Show("No se pudo llenar el DataGrid");
            }
        }     

    }

}
