namespace Lesson8;

public class Task3 {
    public static void StartTask() {
        var numbers = new HashSet<int>();
        int input;

        while (true) {
            Console.WriteLine("Enter the number (other - exit): ");
            if(int.TryParse(Console.ReadLine(), out input)) {
                if(numbers.Contains(input)) {
                    Console.WriteLine("Error. Repetition");
                    continue;
                }       
                numbers.Add(input);
                Console.WriteLine("Saved");
                foreach(int number in numbers)
                    Console.Write(number + " ");
            }
            else break;
        }

    }
}