namespace Lesson2;

public class Program {
    
    public static void Main(string[] args) {
        //Первое задание 
        string fullName = "Sarah Smit";
        int age = 20;
        string email = "sarah_smit@gmail.com";
        double mathScores = 99;
        double programmingScores = 80;
        double physicsScores = 101;

        string patternInfo = "Full Name: {0, 20} \nAge: {1, 18} \nEmail: {2, 34} \nMath Scores: {3, 10} \nProgramming Scores: {4, 3} \nPhysics Scores: {5, 9} ";
        Console.WriteLine(patternInfo, fullName, age, email, mathScores, programmingScores, physicsScores + "\n");
        Console.WriteLine("Press any key to continue\n");
        Console.ReadKey();

        //Второе задание
        double sumOfScores = mathScores + programmingScores + physicsScores;
        double averageScore = sumOfScores / 3;
        string formatedAverageScore = string.Format("{0:f1}", averageScore);
        Console.WriteLine($"Sum of Scores: {sumOfScores,9} \nAverage Scores: {formatedAverageScore,9}");
    }

}