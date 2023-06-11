using System.ComponentModel.DataAnnotations;

namespace Lesson8;

public static class Task1 {
    public static void StartTask() {
        var listInt = new List<int>();
        RandomListInitialization(listInt, 100);
        PrintList(listInt);
        RangeDelete(listInt, 25, 50);
        PrintList(listInt);
    }

    private static void RandomListInitialization(List<int> listInt, int count) {
        var rnd = new Random();
        for(int i = 0; i <= count; i++) 
            listInt.Add(rnd.Next(0, 100));
    }

    private static void PrintList(List<int> listInt) {
        foreach(var number in listInt)
            Console.Write(number + " ");
        Console.WriteLine();
    }

    private static void RangeDelete(List<int> listInt, int lowerBound, int upperBound) {
        listInt.RemoveAll(x => (x > lowerBound && x < upperBound));
    }
}