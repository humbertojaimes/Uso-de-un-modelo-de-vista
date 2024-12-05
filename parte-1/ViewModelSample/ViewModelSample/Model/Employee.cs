namespace ViewModelSample.Model;

public class Employee
{
    public int Id { get; set; }
    
    public string Name { get; set; }
    
    public IEnumerable<Employee> DirectReports { get; set; }
    
}