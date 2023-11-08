using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcVallverduConexionBaseDatos
{
    public class Job
    {
        private int jobId;
        private string jobTitle;
        private decimal? minSalary;
        private decimal? maxSalary;

        public int JobId { get { return jobId; } set { jobId = value; } }
        public string JobTitle { get { return jobTitle; } set { jobTitle = value; } }
        public decimal? MinSalary { get { return minSalary; } set { minSalary = value; } }
        public decimal? MaxSalary { get { return maxSalary; } set { maxSalary = value; } }

        public Job() { }
        public Job(string jobTitle, decimal? minSalary, decimal? maxSalary)
        {
            this.jobTitle = jobTitle;
            this.minSalary = minSalary;
            this.maxSalary = maxSalary;
        }

        public override string ToString()
        {
            return "Job ID: " + jobId +
                   "\tJob title: " + jobTitle +
                   "\tMin. salary: " + minSalary +
                   "\tMax. salary: " + maxSalary;
        }
    }
}
