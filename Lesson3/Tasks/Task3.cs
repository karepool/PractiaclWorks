namespace Lesson3.Tasks;

public class Task3 {
    public static void Start() {
        Console.Write("Enter thr number: ");
        int inputNumber = int.Parse(Console.ReadLine());
        bool isComposite = false;
        int i = 1;

        while(++i < inputNumber) {
            if(inputNumber % i == 0) {
                isComposite = true;
                break;
            }
        }

        if(isComposite) Console.WriteLine(inputNumber + " is composite");
        else Console.WriteLine(inputNumber + " is prime");
    }

}