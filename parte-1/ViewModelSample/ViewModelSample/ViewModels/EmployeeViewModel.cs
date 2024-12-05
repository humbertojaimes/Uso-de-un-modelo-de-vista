using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using ViewModelSample.Model;

namespace ViewModelSample.ViewModels;

public class EmployeeViewModel : ObservableObject
{
    
    private int id;
    
    public int Id
    {
        get => id;
        set => SetProperty(ref id, value);
    }
    
    private string name;
    
    public string Name
    {
        get => name;
        set => SetProperty(ref name, value);
    }
    
    private bool isSupervisor;
    
    public bool IsSupervisor
    {
        get => isSupervisor;
        set => SetProperty(ref isSupervisor, value);
    }
    
    private ObservableCollection<CompanyProject> activeProjects;
    
    public ObservableCollection<CompanyProject> ActiveProjects
    {
        get => activeProjects;
        set => SetProperty(ref activeProjects, value);
    }

    
    public EmployeeViewModel(Employee employee)
    {
        
        Id = employee.Id;
        Name = employee.Name;
        IsSupervisor = !employee.DirectReports.Any();
        ActiveProjects = new (CompanyProjects.All
            .Where(p => p.OwnerId == Id)
            .Where(p => p.IsActive));
    }
}