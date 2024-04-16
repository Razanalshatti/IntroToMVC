namespace WebApplication1.Models
{
    public class Employee
    {

        public int employeeID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string department { get; set; }
    }

    public static class EmployeeData
    {
        public static List<Employee> Employees = new List<Employee>
        {
            new Employee { employeeID = 1, firstName = "Razan",lastName = "alshatti",email = "R@gmail.com",department = "IT" },
            new Employee { employeeID = 2, firstName = "Nada",lastName = "alshaibani",email = "N@gmail.com",department = "IT" },
            new Employee { employeeID = 3, firstName = "Aseel",lastName = "abdulghafour",email = "A@gmail.com",department = "IT"}       
        };
    }
}


