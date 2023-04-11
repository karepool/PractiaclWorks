using System.Diagnostics;

namespace Lesson6;

public class Program {
    public static void Main(string[] args) {
        var employeeFileService = new EmployeeFileService("out.txt");
        while(true) {
            Console.WriteLine("\nChoose:\n\t1 - Add Employee to file\n\t2 - Show information from the file");
            switch(Console.ReadLine()) {
                case "1":
                    employeeFileService.AddEmployee();
                    break;      
                case "2":
                    employeeFileService.PrintEmployeesInfo();
                    break;
                default: return;
            }
        }
    }
}