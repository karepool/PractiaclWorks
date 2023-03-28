namespace Lesson3.Tasks;

public class Task1 {

    public static void Start() {
        Console.Write("Enter an integer: ");
        int input = int.Parse(Console.ReadLine());

        if (input % 2 == 0) Console.WriteLine(input + " is even number");
        else Console.WriteLine(input + " is odd number");
    }

}