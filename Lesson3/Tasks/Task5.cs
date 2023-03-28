namespace Lesson3.Tasks;

public class Task5 {
    
    public static void Start() {
        Console.Write("Enter the upper limit: ");
        int upperLimit = int.Parse(Console.ReadLine());
        var rand = new Random();
        int guessedNumber = rand.Next(upperLimit + 1);
        string input;

        do {
            Console.Write("Enter the estimated number (enter 'exit' to exit): ");
            input = Console.ReadLine();
        
            if(int.Parse(input) == guessedNumber) {
                Console.WriteLine(guessedNumber + " is guess number");
                break;
            }
            
            Console.WriteLine("Try again");
 
        } while(input != "exit");

    }

}