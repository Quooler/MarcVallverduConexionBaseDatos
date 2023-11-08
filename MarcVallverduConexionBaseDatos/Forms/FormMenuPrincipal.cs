using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarcVallverduConexionBaseDatos
{
    public partial class FormMenuPrincipal : Form
    {
        static private Connection conexion = new Connection();
        static public DALJobs dalJobs = new DALJobs();
        static public DALEmployees dalEmployees = new DALEmployees();
        
        static private string filtroNombre = null;
        static private string filtroApellido = null;
        static private string filtroCiudad = null;

        public FormMenuPrincipal()
        {
            InitializeComponent();
            ActualizarDatos();
        }

        private void ActualizarDatos()
        {
            ltbListaJobs.Items.Clear();
            dalJobs.InitListaJobs();

            ltbListaEmployees.Items.Clear();
            dalEmployees.InitListaEmployees();
        }

        private void butAbrirConexion_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.NuevaConexion();

                //Este método ejecuta cambios en la interfaz del menú
                AbrirConnexionEvents();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void AbrirConnexionEvents()
        {
            butCloseConnection.Enabled = true;
            butNewJob.Enabled = true;
            pgbConnection.PerformStep();
            labConexion.Text = "¡Connexión abierta!";
            labConexion.Visible = true;

            //Inicializamos las listas para ver todos los componentes
            dalJobs.InitListaJobs();
            dalEmployees.InitListaEmployees();
            ActualizarDatos();
        }

        private void butCloseConnection_Click(object sender, EventArgs e)
        {
            conexion.CerrarConexion();

            //Este método ejecuta cambios en la interfaz del menú
            CerrarConnexionEvents();
        }

        private void CerrarConnexionEvents()
        {
            butCloseConnection.Enabled = false;
            butNewJob.Enabled = false;
            labConexion.Text = "¡Connexión cerrada!";
            pgbConnection.Value = 0;
            ltbListaJobs.Items.Clear();
            ltbListaEmployees.Items.Clear();
        }

        private void butNewJob_Click(object sender, EventArgs e)
        {
            FormCreateJob nuevoJob = new FormCreateJob();
            nuevoJob.ShowDialog();
            ActualizarDatos();
        }

        private void txbNombre_TextChanged(object sender, EventArgs e)
        {
            filtroNombre = txbNombre.Text;
        }

        private void txbApellido_TextChanged(object sender, EventArgs e)
        {
            filtroApellido = txbApellido.Text;
        }

        private void cbbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtroCiudad = cbbCiudad.Text;
        }

        private void butFiltrarEmployees_Click(object sender, EventArgs e)
        {
            if (filtroNombre != null || filtroApellido != null || filtroCiudad != null)
            {
                ltbListaEmployees.Items.Clear();

                foreach (Employee empleado in dalEmployees.FiltrarListaEmployees(filtroNombre, filtroApellido, filtroCiudad))
                    ltbListaEmployees.Items.Add(empleado);

                cbbCiudad.Text = null;
                filtroCiudad = null;
            }
            else
                ActualizarDatos();
        }

        private void butCloseApp_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
