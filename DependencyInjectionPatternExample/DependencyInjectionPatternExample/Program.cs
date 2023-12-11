namespace DependencyInjectionPatternExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeBL employeeBl = new EmployeeBL(new EmployeeDAL());
            //Injecting the Dependency Object as an Argument to the Constructor
            List<Employee> ListEmployee = employeeBl.GetAllEmployees();
            foreach (Employee emp in ListEmployee)
            {
                Console.WriteLine($"ID = {emp.Id}, Name = {emp.Name}, Department = {emp.Department}");
            }

        }
    }
}