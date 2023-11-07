using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarcVallverduConexionBaseDatos
{
    public partial class FormCreateJob : Form
    {
        private SqlConnection connection = FormMenuPrincipal.connection;
        private GestorJobs gestorJobs = FormMenuPrincipal.gestorJobs;
        private string jobTitle = null;
        private decimal? minSalary = 0;
        private decimal? maxSalary = 0;
        public FormCreateJob()
        {
            InitializeComponent();
        }

        private void txbJobTitle_TextChanged(object sender, EventArgs e)
        {
            jobTitle = txbJobTitle.Text;
        }

        private void butSubmit_Click(object sender, EventArgs e)
        {
            if(minSalary != null || 
               maxSalary != null)
            {
                if (!decimal.TryParse(txbMinSalary.Text, out decimal minSalary) ||
                !decimal.TryParse(txbMaxSalary.Text, out decimal maxSalary))
                    MessageBox.Show("¡El valor del campo Min Salary tiene que ser decimal!");
                else
                {
                    gestorJobs.CrearNuevoJob(jobTitle, minSalary, maxSalary, connection);
                    Close();
                }
            }
            else
            {
                gestorJobs.CrearNuevoJob(jobTitle, minSalary, maxSalary, connection);
                Close();
            }
        }

        private void butCloseConnection_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
