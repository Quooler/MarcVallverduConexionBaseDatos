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
        static public SqlConnection connection = null;
        static public GestorJobs gestorJobs = new GestorJobs();
        static public string CONNECTION_STRING = (
                    @"Data source = 79.143.90.12,54321;
                    Initial Catalog = MarcVallverduDatabaseEmployees;Persist Security Info=true;
                    User Id = sa;Password = 123456789");
        public FormMenuPrincipal()
        {
            InitializeComponent();
            ActualizarDatos();
        }

        private void ActualizarDatos()
        {
            ltbListaJobs.Items.Clear();
            foreach (Job job in gestorJobs.JobsList)
                ltbListaJobs.Items.Add(job);
        }

        private void butAbrirConexion_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(CONNECTION_STRING);
                connection.Open();

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
            gestorJobs.InitJobsList(connection);
            ActualizarDatos();
        }

        private void butCloseConnection_Click(object sender, EventArgs e)
        {
            connection.Close();

            CerrarConnexionEvents();
        }

        private void CerrarConnexionEvents()
        {
            butCloseConnection.Enabled = false;
            butNewJob.Enabled = false;
            labConexion.Text = "¡Connexión cerrada!";
            pgbConnection.Value = 0;
            ActualizarDatos();
        }

        private void butNewJob_Click(object sender, EventArgs e)
        {
            FormCreateJob nuevoJob = new FormCreateJob();
            nuevoJob.ShowDialog();
            ActualizarDatos();
        }

        private void butCloseApp_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
