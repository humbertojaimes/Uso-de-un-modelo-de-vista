namespace ViewModelSample.Model;

public class CompanyProjects
{
    public static IEnumerable<CompanyProject> All { get; }
    
    static CompanyProjects()
    {
        All =
        [
            new CompanyProject() { Id = 1, OwnerId = 1, Name = "Project 1", IsActive = true},
            new CompanyProject() { Id = 2, OwnerId = 1, Name = "Project 2", IsActive = true},
            new CompanyProject() { Id = 3, OwnerId = 2, Name = "Project 3", IsActive = true},
            new CompanyProject() { Id = 4, OwnerId = 2, Name = "Project 4", IsActive = false},
            new CompanyProject() { Id = 5, OwnerId = 3, Name = "Project 5", IsActive = false},
            new CompanyProject() { Id = 6, OwnerId = 3, Name = "Project 6", IsActive = true},
            new CompanyProject() { Id = 7, OwnerId = 4, Name = "Project 7", IsActive = true},
            new CompanyProject() { Id = 8, OwnerId = 4, Name = "Project 8", IsActive = false},
            new CompanyProject() { Id = 9, OwnerId = 5, Name = "Project 9", IsActive = true},
            new CompanyProject() { Id = 10, OwnerId = 5, Name = "Project 10", IsActive = true}
        ];
    }
    
}