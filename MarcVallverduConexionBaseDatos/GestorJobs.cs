using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarcVallverduConexionBaseDatos
{
    public class GestorJobs
    {
        private List<Job> jobsList;

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

        public void InitJobsList(SqlConnection connection)
        {
            string query = "SELECT * FROM jobs";
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                int jobId = (int)reader["job_id"];
                string jobTitle = reader["job_title"].ToString();
                decimal? minSalary = (decimal)reader["min_salary"];
                decimal? maxSalary = (decimal)reader["max_salary"];

                Job job = new Job(jobId, jobTitle, minSalary, maxSalary);

                foreach (Job existingJob in jobsList)
                    if (jobId == existingJob.JobId)
                        return;
                
                jobsList.Add(job);
            }
            reader.Close();
        }

        public void CrearNuevoJob(string jobTitle, decimal? minSalary, decimal? maxSalary, SqlConnection connection)
        {
            try
            {
                Job nuevoJob = new Job(jobTitle, minSalary, maxSalary);

                string query = $"INSERT INTO jobs (job_title, min_salary, max_salary) " +
                               $"VALUES ('{nuevoJob.JobTitle}', {nuevoJob.MinSalary}, {nuevoJob.MaxSalary}); " +
                               $"SELECT SCOPE_IDENTITY();";

                SqlCommand command = new SqlCommand(query, connection);

                string id = command.ExecuteScalar().ToString();
                nuevoJob.JobId = int.Parse(id);

                JobsList.Add(nuevoJob);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
