namespace Lesson8;

public static class Task2 {
    public static void StartTask() {
        var phoneBook = new Dictionary<String, String>();
        
        while(true) {
            Console.WriteLine("1 - add note\n2 - find note by number\nother - exit");
            switch(Console.ReadLine()) {
                case "1":
                    AddNote(phoneBook);
                    break;

                case "2":
                    FindNote(phoneBook);
                    break;
                default: return;
            }
        }

    }

    public static void AddNote(Dictionary<String, String> phoneBook) {
        String fullName, number, checkNumber;
        Console.Write("Enter Full Name: ");
        fullName = Console.ReadLine();

        do {
            Console.WriteLine("Enter number: ");
            number = Console.ReadLine();

            if(number == "" || phoneBook.TryGetValue(number, out checkNumber))
                break;

            phoneBook.Add(number, fullName);
        } while(true);    
    }

    public static void FindNote(Dictionary<String, String> phoneBook) {
        Console.Write("Enter the number: ");
        String fullName;
        if(phoneBook.TryGetValue(Console.ReadLine(), out fullName)) {
            Console.WriteLine("Full name: " + fullName);
        }
        else
            Console.WriteLine("The number not found");
    }
    
}