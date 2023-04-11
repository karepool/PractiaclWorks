namespace Lesson6;

public static class EmployeeFileService {

    public static void AddEmployee() {
        Employee employee = new Employee();

        Console.WriteLine("Enter the data. ");

        Console.Write("Id: ");
        employee.Id = int.Parse(Console.ReadLine());

        Console.Write("Full name: ");
        employee.FullName = Console.ReadLine();

        Console.Write("Age: ");
        employee.Age = int.Parse(Console.ReadLine());

        Console.Write("Height: ");
        employee.Height = int.Parse(Console.ReadLine());

        Console.Write("Palce of birth: ");
        employee.PalceOfBirth = Console.ReadLine();

        Console.Write("Date of birth: ");
        employee.DateOfBirth = Console.ReadLine();

        employee.AddedDateTime = DateTime.Now;

        WriteToFile(employee);
    }

    public static void PrintEmployeesInfo() {
        int j = 0;
        string[] fileInfo = ReadFromFile();

        for(int i = 0; i < fileInfo.Length; i++) {

            if(fileInfo[i] == "") {
                Console.WriteLine();
                return;
            }

            switch(j) {
                case 0:
                    Console.Write("\nId: ");
                    break;
                case 1:
                    Console.Write("Full name: ");
                    break;
                case 2:
                    Console.Write("Age: ");
                    break;
                case 3:
                    Console.Write("Height: ");
                    break;
                case 4:
                    Console.Write("Palce of birth: ");
                    break;
                case 5:
                    Console.Write("Date of birth: ");
                    break;
                case 6:
                    Console.Write("Added date time: ");
                    break;
            }

            Console.WriteLine(fileInfo[i]);

            if(j == 6) 
                j = 0;
            else 
                j++;
  
        }       
    }

    private static void WriteToFile(Employee employee) {
        using(var sw = new StreamWriter("out.txt", true)) {
            sw.Write(employee.Id + "#" +
                employee.FullName + "#" +
                employee.Age + "#" +
                employee.Height + "#" +
                employee.PalceOfBirth + "#" +
                employee.DateOfBirth + "#" +
                employee.AddedDateTime + "#"
                );
        }
    }

    private static string[] ReadFromFile() { 
        string[] result;
        
        using(var sr = new StreamReader("out.txt")) {
            result = (sr.ReadToEnd()).Split("#"); 
        }

        return result;
    }
}