using EF_Relations.Core.Entity;

namespace ConsoleApp1.Core.Entity;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Surname { get; set; }
    public int Age { get; set; }
    public decimal Grade { get; set; }
    public DateTime RegistrationTime { get; set; }
    public ICollection<GroupStudent> GroupStudents { get; set; }

}
