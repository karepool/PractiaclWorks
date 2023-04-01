namespace Lesson5;

public class Program { 

    public static void Main(string[] args) {
        //FIRST TASK
        Console.WriteLine("Enter the text: ");
        string input = Console.ReadLine();

        PrintWords(SplitText(input));

        //SECOND TASK
        Console.WriteLine("\n" + ReverseWords(input));
    }

    public static string[] SplitText(string text) => text.Split(' ');

    public static void PrintWords(string[] words) {
        foreach(string word in words)
            Console.WriteLine(word);
    }

    public static string ReverseWords(string text) {
        string[] words = SplitText(text);
        string temp;
        string result = "";

        for(int i = 0; i < words.Length / 2; i++) {
            temp = words[i];
            words[i] = words[words.Length - 1 - i];
            words[words.Length - 1 - i] = temp;
        }

        foreach(string word in words)
            result += word + " ";

        return result;
    }

}