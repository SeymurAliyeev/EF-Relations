using ConsoleApp1.Core.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Relations.Core.Entity;

public class GroupStudent
{
    public int GroupId { get; set; }
    public int StudentId { get; set; }
    public Group Group { get; set; }
    public Student Student { get; set; }
}
