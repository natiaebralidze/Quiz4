using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Employee
    {
        private string firstName;
        private string lastName;
        private int maxSalary;

        private Department department;

        public string getFirstName()
        {
            return firstName;
        }

        public void setFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        public string getLasttName()
        {
            return lastName;
        }

        public void setLastName(string lasttName)
        {
            this.lastName = lastName;
        }

        public Department getDepartment()
        {
            return department;
        } 
        
        public void addEmployeeToDep(Department dep)
        {
            this.department = dep;
        }

        public void removeEmployeeFromDep()
        {
            this.department = null;
        }

        public Employee(string firstName, string lastName, int maxSalary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.maxSalary = maxSalary;
        }
    }
}
