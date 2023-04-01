namespace Lesson4;

public static class Tasks {
    
    public static void StartFirstAndSecondTask() {
        Console.WriteLine("FIRST TASK");
        Console.Write("Enter a rows count: ");
        int rowsCount = int.Parse(Console.ReadLine());
        Console.Write("Enter a columns count: ");
        int columnsCount = int.Parse(Console.ReadLine());
        var rand = new Random();
        int sum = 0;
        int[,] matrixA = new int[rowsCount,columnsCount];

        for(int i = 0; i < rowsCount; i++) {
            for(int j = 0; j < columnsCount; j++) {
                matrixA[i, j] = rand.Next(15);
                sum += matrixA[i, j];
                Console.Write(matrixA[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("The sum of elements: " + sum);

        Console.WriteLine("\nSECOND TASK");
        int[,] matrixB = new int[rowsCount,columnsCount];
        int[,] matrixC = new int[rowsCount,columnsCount];

        for(int i = 0; i < rowsCount; i++) {
            for(int j = 0; j < columnsCount; j++) {
                matrixB[i, j] = rand.Next(15);
                matrixC[i, j] = matrixA[i, j] + matrixB[i, j];
            }
        }

        Console.WriteLine("Matrix A:");
        PrinrMatrix(matrixA);
        Console.WriteLine("\nMatrix B:");
        PrinrMatrix(matrixB);
        Console.WriteLine("\nResult matrix C:");
        PrinrMatrix(matrixC);
    }

    private static void PrinrMatrix(int[,] matrix) {
        int rowsCount = matrix.GetUpperBound(0) + 1;
        int columnsCount = matrix.Length / rowsCount;

        for(int i = 0; i < matrix.GetUpperBound(0) + 1; i++) {
            for(int j = 0; j < columnsCount; j++) {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

    }
 
}
