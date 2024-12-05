namespace ViewModelSample.Model;

public class Employees
{
    public static IEnumerable<Employee> All { get; }
    
    static Employees()
    {
        All =
        [
            new Employee() { Id = 1, Name = "John", DirectReports = new List<Employee>() },
            new Employee() { Id = 2, Name = "Jane", DirectReports = new List<Employee>() },
            new Employee() { Id = 3, Name = "Sam", DirectReports = new List<Employee>() },
            new Employee() { Id = 4, Name = "Lucy", DirectReports = new List<Employee>() },
            new Employee() { Id = 5, Name = "Tom", DirectReports = new List<Employee>() }
        ];
        
        All.ElementAt(1).DirectReports = new List<Employee>() { All.ElementAt(0) };
        All.ElementAt(2).DirectReports = new List<Employee>() { All.ElementAt(0) };
        All.ElementAt(3).DirectReports = new List<Employee>() { All.ElementAt(0) };
        All.ElementAt(4).DirectReports = new List<Employee>() { All.ElementAt(0) };
    }
    
}