using EF_Relations.Core.Entity;

namespace ConsoleApp1.Core.Entity;

public class Group
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public int Capacity { get; set; }
    public ICollection<GroupStudent> GroupStudents { get; set; }
    
}
