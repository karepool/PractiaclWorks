using System.Diagnostics;

namespace Lesson6;

public class Program {
    public static void Main(string[] args) {
        while(true) {
            Console.WriteLine("\nChoose:\n\t1 - Add Employee to file\n\t2 - Show information from the file");
            switch(Console.ReadLine()) {
                case "1":
                    EmployeeFileService.AddEmployee();
                    break;      
                case "2":
                    EmployeeFileService.PrintEmployeesInfo();
                    break;
                default: return;
            }
        }
    }
}