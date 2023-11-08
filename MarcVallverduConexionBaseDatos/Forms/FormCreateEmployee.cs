using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarcVallverduConexionBaseDatos.Forms
{
    public partial class FormCreateEmployee : Form
    {
        private DALEmployees DALEmployees = FormMenuPrincipal.dalEmployees;
        /*private int employeeId;
        private string firstName;
        private string lastName;
        private string email;
        private string phoneNumber;
        private DateTime hireDate;
        private int jobId;
        private decimal salary;
        private int? managerId;
        private int? departmentId;*/

        public FormCreateEmployee()
        {
            InitializeComponent();
        }

        private void butSubmit_Click(object sender, EventArgs e)
        {
            /*if (lastName == null || email == null || jobId == null || salary == null)
                MessageBox.Show("¡Rellena correctamente los campos obligatorios (*)!");

            DALEmployees.CrearNuevoEmployee(jobTitle, minSalary, maxSalary);
            Close();*/
        }
    }
}
