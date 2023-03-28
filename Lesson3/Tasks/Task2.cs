namespace Lesson3.Tasks;

public class Task2 {

    public static void Start() {
        Console.Write("Enter the number of cards: ");

        int numberOfCards = int.Parse(Console.ReadLine());
        int sum = 0;
        string input;
        int value;
        bool flag;

        for(int i = 0; i < numberOfCards; i++) {
            flag = false;

            do {
                Console.Write("Enter the card value (Jack - J, Queen - Q, King - K, Ace - A): ");
                input = Console.ReadLine();

                if(input == "J" || input == "Q" || input == "K" || input == "A") {
                    sum += 10;
                    flag = true;
                }
                else if(int.TryParse(input, out value)) {
                    sum += value;
                    flag = true;
                }
                if(!flag) Console.WriteLine("Error. Try again!!!");

            } while(!flag);

        }

        Console.WriteLine("Result sum: " + sum);
    }

}