using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MarcVallverduConexionBaseDatos.DAL;

namespace MarcVallverduConexionBaseDatos
{
    public class DALJobs
    {
        private Connection conexion = new Connection();

        public List<Job> InitListaJobs()
        {
            List<Job> jobsList = new List<Job>();

            try
            {
                conexion.NuevaConexion();

                string query = "SELECT * FROM jobs";

                SqlCommand command = new SqlCommand(query, conexion.Conexion);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Job newJob = new Job();

                    newJob.JobId = (int)reader["job_id"];
                    newJob.JobTitle = reader["job_title"].ToString();
                    newJob.MinSalary = DALNulls.DBNullToNullDecimal((decimal)reader["min_salary"]);
                    newJob.MaxSalary = DALNulls.DBNullToNullDecimal((decimal)reader["max_salary"]);

                    jobsList.Add(newJob);
                }
                reader.Close();

                conexion.CerrarConexion();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return jobsList;
        }

        public void CrearNuevoJob(string jobTitle, decimal? minSalary, decimal? maxSalary)
        {
            try
            {
                conexion.NuevaConexion();

                Job nuevoJob = new Job(jobTitle, minSalary, maxSalary);

                string query =
                                @"INSERT INTO jobs(job_title, min_salary, max_salary)
                                VALUES (@ptitle, @pminsalary, @pmaxsalary);
                                SELECT SCOPE_IDENTITY();";

                SqlCommand insertar = new SqlCommand(query, conexion.Conexion);

                SqlParameter ptitle = new SqlParameter("@ptitle", SqlDbType.VarChar, 35);
                insertar.Parameters.Add(ptitle);
                ptitle.Value = nuevoJob.JobTitle;

                SqlParameter pminsalary = new SqlParameter("@pminsalary", SqlDbType.Decimal);
                insertar.Parameters.Add(pminsalary);
                pminsalary.Precision = 8;
                pminsalary.Scale = 2;
                pminsalary.Value = DALNulls.NullToDBNullDecimal(nuevoJob.MinSalary);

                SqlParameter pmaxsalary = new SqlParameter("@pmaxsalary", SqlDbType.Decimal);
                insertar.Parameters.Add(pmaxsalary);
                pmaxsalary.Precision = 8;
                pmaxsalary.Scale = 2;
                pmaxsalary.Value = DALNulls.NullToDBNullDecimal(nuevoJob.MaxSalary);

                //Recuperamos el id del nuevo insert para guardarlo en el programa
                string id = insertar.ExecuteScalar().ToString();
                nuevoJob.JobId = int.Parse(id);

                conexion.CerrarConexion();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
