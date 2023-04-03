namespace Lesson3;

public static class Tasks {

    public static void StartFirstTask() {
        Console.Write("Enter an integer: ");
        int input = int.Parse(Console.ReadLine());

        if (input % 2 == 0) Console.WriteLine(input + " is even number");
        else Console.WriteLine(input + " is odd number");
    }

    public static void StartSecondTask() {
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

                switch(input) {
                    case "J":
                        sum += 10;
                        flag = true;
                        break;
                    case "Q":
                        sum += 10;
                        flag = true;
                        break;
                    case "K":
                        sum += 10;
                        flag = true;
                        break;
                    case "A":
                        sum += 10;
                        flag = true;
                        break;
                    default:
                        if(int.TryParse(input, out value)) {
                            sum += value;
                            flag = true;
                        }
                        break;
                }

                //if(input == "J" || input == "Q" || input == "K" || input == "A") {
                //    sum += 10;
                //    flag = true;
                //}
                //else if(int.TryParse(input, out value)) {
                //    sum += value;
                //    flag = true;
                //}
                if(!flag) Console.WriteLine("Error. Try again!!!");

            } while(!flag);

        }

        Console.WriteLine("Result sum: " + sum);
    }

    public static void StartThirdTask() {
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

    public static void StartFourthTask() {
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

    public static void StartFifthTask() {
        Console.Write("Enter the upper limit: ");
        int upperLimit = int.Parse(Console.ReadLine());
        var rand = new Random();
        int guessedNumber = rand.Next(upperLimit + 1);
        string? inputString;
        int inputInt;

        do {
            Console.Write("Enter the estimated number (press enter to exit): ");
            inputString = Console.ReadLine();
            if(inputString == "" || inputString == null) {
                Console.WriteLine(guessedNumber + " is guess number");
                break;
            }
            inputInt = int.Parse(inputString);

            if(inputInt == guessedNumber) {
                Console.WriteLine(guessedNumber + " is guess number");
                break;
            }
            else if(inputInt > guessedNumber) {
                Console.WriteLine("This number is bigger then guessed number");
            }
            else if(inputInt < guessedNumber) {
                Console.WriteLine("This number is less then guessed number");
            }

            Console.WriteLine("Try again");
        } while(true);

    }

}