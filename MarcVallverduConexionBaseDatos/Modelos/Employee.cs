using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcVallverduConexionBaseDatos
{
    public class Employee
    {
        private int employeeId;
        private string firstName;
        private string lastName;
        private string email;
        private string phoneNumber;
        private DateTime hireDate;
        private int jobId;
        private decimal salary;
        private int? managerId;
        private int? departmentId;

        public int EmployeeId { get { return employeeId; } set { employeeId = value; } }
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string PhoneNumber { get {  return phoneNumber; } set {  phoneNumber = value; } }
        public DateTime HireDate { get {  return hireDate; } set {  hireDate = value; } }
        public int JobId { get { return jobId; } set {  jobId = value; } }
        public decimal Salary { get {  return salary; } set {  salary = value; } }
        public int? ManagerId { get { return managerId; } set { managerId = value; } }
        public int? DepartmentId { get { return departmentId; } set { departmentId = value; } }

        public Employee() { }
        public Employee(string firstName, string lastName,
                string email, string phoneNumber, DateTime hireDate,
                int jobId, decimal salary, int? managerId, int? departmentId)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.hireDate = hireDate;
            this.jobId = jobId;
            this.salary = salary;
            this.managerId = managerId;
            this.departmentId = departmentId;
        }

        public override string ToString()
        {
            return firstName + " " + lastName;
        }
    }
}
