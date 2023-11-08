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
        private DALJobs dalJobs = FormMenuPrincipal.dalJobs;
        private string jobTitle = null;
        private decimal? minSalary = null;
        private decimal? maxSalary = null;
        public FormCreateJob()
        {
            InitializeComponent();
        }

        private void txbJobTitle_TextChanged(object sender, EventArgs e)
        {
            jobTitle = txbJobTitle.Text;
        }
        private void txbMinSalary_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txbMinSalary.Text, out decimal minSalaryTry))
                minSalary = minSalaryTry;
            else 
                minSalary = null;         
        }
        private void txbMaxSalary_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txbMaxSalary.Text, out decimal maxSalaryTry))
                maxSalary = maxSalaryTry;
            else
                maxSalary = null;
        }
        private void butSubmit_Click(object sender, EventArgs e)
        {

            if (jobTitle == null)
                MessageBox.Show("¡El valor del campo Job Title tiene que tener un valor!");

            dalJobs.CrearNuevoJob(jobTitle, minSalary, maxSalary);
            Close();
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
