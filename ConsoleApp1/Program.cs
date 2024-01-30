using ConsoleApp1.Core.Entity;
using EF_Relations.DataAccess;

AppDbContext context = new AppDbContext();
Console.WriteLine("Create");

Student student1 = new()
{
    Name = "Seymur",
    Surname = "Aliyev",
    Age = 27,
    Grade = 92,
    RegistrationTime = DateTime.Now.AddDays(1)
};
Student student2 = new()
{
    Name = "Ulvi",
    Surname = "Kerimov",
    Age = 20,
    Grade = 88,
    RegistrationTime = DateTime.Now.AddDays(1)
};
Student student3 = new()
{
    Name = "Ferhad",
    Surname = "Huseynov",
    Age = 34,
    Grade = 85,
    RegistrationTime = DateTime.Now.AddDays(1)
};

await context.Students.AddAsync(student1);
await context.Students.AddAsync(student2);
await context.Students.AddAsync(student3);
context.SaveChanges();

Group group1 = new()
{
    Name = "P238",
    Description = "Backend",
    Capacity = 10
};
Group group2 = new()
{
    Name = "P248",
    Description = "Backend",
    Capacity = 15
};
Group group3 = new()
{
    Name = "P258",
    Description = "Backend",
    Capacity = 18
};

context.Groups.Add(group1);
context.Groups.Add(group2);
context.Groups.Add(group3);
context.SaveChanges();


Console.WriteLine("Update");

//Group group = context.Groups.FirstOrDefault(g => g.Id == 3);
//Console.WriteLine(group.Capacity);

//Group group = context.Groups.FirstOrDefault(g => g.Name == "P238");
//Console.WriteLine(group.Id);

//Group group = context.Groups.Find(4);
//Console.WriteLine(group.Name);

//Group group = context.Groups.Single(g => g.Name == "P238");
//Console.WriteLine(group.Id);

//Student student = context.Students.FirstOrDefault(s => s.Name == "Seymur");
//Console.WriteLine(student.Id);

//Student student = context.Students.FirstOrDefault(s => s.Name == "Seymur");
//student1.Name = "Samir";
//await context.SaveChangesAsync();
//Console.WriteLine(context.Entry(student1).State);




