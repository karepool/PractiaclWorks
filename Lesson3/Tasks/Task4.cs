namespace Lesson3.Tasks;

public class Task4 {

    public static void Start() {
        Console.Write("Enter the length: ");
        int minValue = int.MaxValue;
        int length = int.Parse(Console.ReadLine());
        int inputNumber;

        for(int i = 0; i < length; i++) {
            Console.Write("Enter the number: ");
            inputNumber = int.Parse(Console.ReadLine());
            if(inputNumber < minValue) minValue = inputNumber;
        }

        Console.WriteLine(minValue + " is min value");
    }

}