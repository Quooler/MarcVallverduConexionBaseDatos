using MarcVallverduConexionBaseDatos.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarcVallverduConexionBaseDatos
{
    public class DALEmployees
    {
        private Connection conexion = new Connection();

        public List<Employee> InitListaEmployees()
        {
            List<Employee> employeesList = new List<Employee>();

            try
            {
                conexion.NuevaConexion();

                string query = "SELECT * FROM employees";
                SqlCommand command = new SqlCommand(query, conexion.Conexion);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Employee newEmployee = new Employee();

                    newEmployee.EmployeeId = (int)reader["employee_id"];
                    newEmployee.FirstName = DALNulls.DBNullToNullString(reader["first_name"]).ToString();
                    newEmployee.LastName = reader["last_name"].ToString();
                    newEmployee.Email = reader["email"].ToString();
                    newEmployee.PhoneNumber = DALNulls.DBNullToNullString(reader["phone_number"]).ToString();
                    newEmployee.HireDate = (DateTime)reader["hire_date"];
                    newEmployee.JobId = (int)reader["job_id"];
                    newEmployee.Salary = (decimal)reader["salary"];                   
                    newEmployee.ManagerId = DALNulls.DBNullToNullInt(reader["manager_id"]);                       
                    newEmployee.DepartmentId = DALNulls.DBNullToNullInt(reader["department_id"]);

                    employeesList.Add(newEmployee);
                }
                reader.Close();

                conexion.CerrarConexion();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return employeesList;
        }

        public List<Employee> FiltrarListaEmployees(string nombre, string apellido, string ciudad)
        {
            List<Employee> listaFiltrada = new List<Employee>();

            try
            {
                conexion.NuevaConexion();

                //Query que se adapta según los valores de los parámetros
                string query = 
                                @"SELECT employee_id, first_name, last_name 
                                FROM employees e
                                INNER JOIN departments d 
                                ON e.department_id = d.department_id
                                INNER JOIN locations l 
                                ON d.location_id = l.location_id
                                WHERE ";

                if (nombre != null)
                    query += "e.first_name = '" + nombre + "' AND ";
                if (apellido != null)
                    query += "e.last_name = '" + apellido + "' AND ";
                if (ciudad != null)
                    query += "l.city = '" + ciudad + "'";

                //Eliminamos los últimos carácteres para evitar problemas de sintáxis
                if (query.EndsWith(" "))
                    query = query.Remove(query.Length - 4, 4);
                           
                SqlCommand command = new SqlCommand(query, conexion.Conexion);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Employee empleadoFiltro = new Employee();

                    empleadoFiltro.EmployeeId = (int)reader["employee_id"];
                    empleadoFiltro.FirstName = DALNulls.DBNullToNull(reader["first_name"]).ToString();
                    empleadoFiltro.LastName = reader["last_name"].ToString();

                    listaFiltrada.Add(empleadoFiltro);
                }
                reader.Close();

                conexion.CerrarConexion();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return listaFiltrada;
        }

        /* MÉTODOS PARA CREAR UN NUEVO EMPLOYEE
        public void CrearNuevoEmployee(string firstName, string lastName,
                                       string email, string phoneNumber,
                                       int jobId, decimal salary, 
                                       int? managerId, int? departmentId)
        {
            try
            {
                conexion.NuevaConexion();

                Employee nuevoJob = new Employee(firstName, lastName, email, phoneNumber, 
                                                 DateTime.Now, jobId, salary, managerId, departmentId);

                InsertEmployee(nuevoJob);
                EmployeesList.Add(nuevoJob);

                conexion.CerrarConexion();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void InsertEmployee(Employee employee)
        {
            string query = @"
            INSERT INTO employees(first_name, last_name, email, phone_number
            hire_date, job_id, salary, manager_id, department_id)
            VALUES (@pfirstname, @plastname, @pemail, @pphonenumber, 
            @phiredate, @pjobid, @pmanagerid, @pdepartmentid);
            SELECT SCOPE_IDENTITY();";

            SqlCommand insertar = new SqlCommand(query, conexion.Conexion);

            SqlParameter pfirstname = new SqlParameter("@pfirstname", SqlDbType.VarChar, 20);
            insertar.Parameters.Add(pfirstname);
            pfirstname.Value = employee.FirstName;

            SqlParameter plastname = new SqlParameter("@plastname", SqlDbType.VarChar, 25);
            insertar.Parameters.Add(plastname);
            plastname.Value = employee.LastName;

            SqlParameter pemail = new SqlParameter("@pemail", SqlDbType.VarChar, 100);
            insertar.Parameters.Add(pemail);
            pemail.Value = DALNulls.NullToDBNull(employee.Email);

            SqlParameter pphonenumber = new SqlParameter("@pphonenumber", SqlDbType.VarChar, 20);
            insertar.Parameters.Add(pphonenumber);
            pphonenumber.Value = DALNulls.NullToDBNull(employee.PhoneNumber);

            SqlParameter phiredate = new SqlParameter("@phiredate", SqlDbType.DateTime);
            insertar.Parameters.Add(phiredate);
            phiredate.Value = DALNulls.NullToDBNull(employee.HireDate);

            SqlParameter pjobid = new SqlParameter("@pjobid", SqlDbType.Int);
            insertar.Parameters.Add(pjobid);
            pjobid.Value = DALNulls.NullToDBNullInt(employee.JobId);

            SqlParameter psalary = new SqlParameter("@psalary", SqlDbType.Decimal);
            insertar.Parameters.Add(psalary);
            psalary.Precision = 8;
            psalary.Scale = 2;
            psalary.Value = DALNulls.NullToDBNullDecimal(employee.Salary);

            SqlParameter pmanagerid = new SqlParameter("@pmanagerid", SqlDbType.Int);
            insertar.Parameters.Add(pmanagerid);
            pmanagerid.Value = DALNulls.NullToDBNullInt(employee.ManagerId);

            SqlParameter pdepartmentid = new SqlParameter("@pdepartmentid", SqlDbType.Int);
            insertar.Parameters.Add(pdepartmentid);
            pdepartmentid.Value = DALNulls.NullToDBNullInt(employee.DepartmentId);

            //Recuperamos el id del nuevo insert para guardarlo en el programa
            string id = insertar.ExecuteScalar().ToString();
            employee.EmployeeId = int.Parse(id);
        }*/
    }
}
