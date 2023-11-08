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
        private List<Job> jobsList;
        private Connection conexion = new Connection();

        public List<Job> JobsList
        {
            get
            {
                if (jobsList == null)
                    jobsList = new List<Job>();

                return jobsList;
            }
            set { jobsList = value; }
        }

        public void InitListaJobs()
        {
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

                    foreach (Job existingJob in jobsList)
                        if (newJob.JobId == existingJob.JobId)
                            return;

                    jobsList.Add(newJob);
                }
                reader.Close();

                conexion.CerrarConexion();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void CrearNuevoJob(string jobTitle, decimal? minSalary, decimal? maxSalary)
        {
            try
            {
                conexion.NuevaConexion();

                Job nuevoJob = new Job(jobTitle, minSalary, maxSalary);

                InsertJob(nuevoJob);
                JobsList.Add(nuevoJob);

                conexion.CerrarConexion();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void InsertJob(Job job)
        {
            string query = 
                          @"INSERT INTO jobs(job_title, min_salary, max_salary)
                          VALUES (@ptitle, @pminsalary, @pmaxsalary);
                          SELECT SCOPE_IDENTITY();";

            SqlCommand insertar = new SqlCommand(query, conexion.Conexion);

            SqlParameter ptitle = new SqlParameter("@ptitle", SqlDbType.VarChar, 35);
            insertar.Parameters.Add(ptitle);
            ptitle.Value = job.JobTitle;

            SqlParameter pminsalary = new SqlParameter("@pminsalary", SqlDbType.Decimal);
            insertar.Parameters.Add(pminsalary);
            pminsalary.Precision = 8;
            pminsalary.Scale = 2;
            pminsalary.Value = DALNulls.NullToDBNullDecimal(job.MinSalary);

            SqlParameter pmaxsalary = new SqlParameter("@pmaxsalary", SqlDbType.Decimal);
            insertar.Parameters.Add(pmaxsalary);
            pmaxsalary.Precision = 8;
            pmaxsalary.Scale = 2;
            pmaxsalary.Value = DALNulls.NullToDBNullDecimal(job.MaxSalary);

            //Recuperamos el id del nuevo insert para guardarlo en el programa
            string id = insertar.ExecuteScalar().ToString();
            job.JobId = int.Parse(id);
        }
    }
}
