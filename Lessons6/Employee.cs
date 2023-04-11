namespace Lesson6;

public class Employee {
    
    public Employee() => Id = ++_counter;

    public int Id { get; set; }
    public string? FullName { get; set; }
    public string? PalceOfBirth { get; set; }
    public int Age { get; set; }
    public int Height { get; set; }
    public string? DateOfBirth { get; set; }
    public DateTime AddedDateTime { get; set; }

    private static int _counter;
}
