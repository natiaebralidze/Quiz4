using Task6;

Department dep1 = new Department("IT", 15);
Department dep2 = new Department("Business", 10);
Department dep3 = new Department("Finances", 1);

Employee emp1 = new Employee("Natia", "Ebralidze", 110000);
Employee emp2 = new Employee("Nika", "Sanaia", 9500);
Employee emp3 = new Employee("Vincxa", "Racxa", 1800);
Employee emp4 = new Employee("Bill", "Gates", 135000);
Employee emp5 = new Employee("Steven", "King", 24000);
Employee emp6 = new Employee("Ucnobi", "Pirovneba", 12500);
Employee emp7 = new Employee("Khvicha", "Kvaratskhelia", 214000);

List<Department> departmentsList = new List<Department>();
departmentsList.Add(dep1);
departmentsList.Add(dep2);

List<Employee> empList = new List<Employee>();
empList.Add(emp1);
empList.Add(emp2);

HrManagment hrManagment = new HrManagment(departmentsList, empList);
hrManagment.addDep(dep3);
hrManagment.addEmp(emp3);
hrManagment.addEmp(emp4);
hrManagment.addEmp(emp5);
hrManagment.addEmp(emp6);
hrManagment.addEmp(emp7);

hrManagment.addEmpToDep(emp1, dep1);
hrManagment.addEmpToDep(emp2, dep3);
hrManagment.addEmpToDep(emp3, dep2);
hrManagment.addEmpToDep(emp4, dep1);
hrManagment.addEmpToDep(emp5, dep3);
hrManagment.addEmpToDep(emp6, dep2);
hrManagment.addEmpToDep(emp7, dep1);

Console.WriteLine();
hrManagment.removeEmpFromDep(emp2);
hrManagment.addEmpToDep(emp5, dep3);

Console.WriteLine();
hrManagment.PrintDepartments();

Console.WriteLine();
foreach (Department h in hrManagment.getDepartments())
{
    hrManagment.printEmpsByDepartment(h);
}

Console.WriteLine();
hrManagment.printDepartmentEmpsCount();


