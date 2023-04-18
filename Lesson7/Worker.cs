namespace Lesson7;

public struct Worker {
    public Worker(int id, string fullName, int age, int height, string palceOfBirth, DateTime dateOfBirth, DateTime addedDateTime) {
        Id = id;
        FullName = fullName;
        Age = age;
        Height = height;
        PalceOfBirth = palceOfBirth;
        DateOfBirth = dateOfBirth;
        AddedDateTime = addedDateTime;
    }

    public int Id { get; set; }
    public string FullName { get; set; }
    public int Age { get; set; }
    public int Height { get; set; }
    public string PalceOfBirth{ get; set; }
    public DateTime DateOfBirth { get; set; }
    public DateTime AddedDateTime { get; set; }

    public override string? ToString() {
        return
            $"Id: {Id} \n" +
            $"Full Name: {FullName} \n" +
            $"Age: {Age} \n" +
            $"Height: {Height} \n" +
            $"Palce Of Birth: {PalceOfBirth} \n" + 
            $"Date Of Birth: {DateOfBirth.Date} \n" +
            $"Added Date: {AddedDateTime} \n";
    }

}