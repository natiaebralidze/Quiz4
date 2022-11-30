using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class HrManagment
    {
        private List<Department> departmentsList;
        private List<Employee> empList;
        
        public List<Department> getDepartments()
        {
            return departmentsList;
        }

        public void addDep(Department dep)
        {
            this.departmentsList.Add(dep);
        }

        public void addEmp(Employee emp)
        {
            this.empList.Add(emp);
        }

        private int getEmpsCount(Department dep)
        {
            int empsCount = 0;
            foreach (Employee emp in this.empList)
            {
                if (emp.getDepartment() != null && emp.getDepartment().getDepartmentName().Equals(dep.getDepartmentName()))
                {
                    empsCount++;
                }
            }
            return empsCount;
        }

        private Boolean checkAddEmpToDep(Department dep)
        {
            Boolean isPosibleToadd = false;
            if (this.getEmpsCount(dep) < dep.getEmpsMaxCount())
            {
                isPosibleToadd = true;
            }
            return isPosibleToadd;
        }

        public void addEmpToDep(Employee emp, Department dep)
        {
            if(checkAddEmpToDep(dep))
            {
                emp.addEmployeeToDep(dep);
                Console.WriteLine("Employee Added!");
            } else
            {
                Console.WriteLine("Cannot add employee to this department!. EMPLOYEE MAX COUNT LIMIT VIOLATED!");
            }
        }

        public void removeEmpFromDep(Employee emp)
        {
            emp.removeEmployeeFromDep();
            Console.WriteLine("Employee Rmoved from department!");
        }

        public void PrintDepartments()
        {
            Console.WriteLine("Available Departments are: ");
            foreach (Department dep in this.departmentsList)
            {
                Console.WriteLine(dep.getDepartmentName());
            }
        }

        public void printEmpsByDepartment(Department dep)
        {
            Console.WriteLine("Employees in " + dep.getDepartmentName() + " are:");
            foreach(Employee emp in this.empList)
            {
                if(emp.getDepartment() != null && emp.getDepartment().getDepartmentName().Equals(dep.getDepartmentName()))
                {
                    Console.WriteLine("first: " + emp.getFirstName() + ", Last: " + emp.getLasttName());
                }
            }
        }

        public void printDepartmentEmpsCount()
        {
            foreach(Department dep in this.departmentsList)
            {
                Console.WriteLine("Count of employees in " + dep.getDepartmentName() + " is " + this.getEmpsCount(dep));
            }
        }

        public HrManagment(List<Department> depsList, List<Employee> empsList)
        {
            this.departmentsList = depsList;
            this.empList = empsList;
        }
    }
}
