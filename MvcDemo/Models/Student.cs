using System.ComponentModel;

namespace MvcDemo.Models;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    [DisplayName("Date of birth")]
    public DateTime DateOfBirth { get; set; }
}
