using System;

public class Program
{
    public static void Main()
    {
        // Uncomment the task you want to run
        
        // Task 1: One-dimensional array
        Task1();

        // Task 2: Two-dimensional array
        // Task2();

        // Task 3: Square matrix
        // Task3();

        // Task 4: Jagged array
        // Task4();
    }

    // Task 1: One-dimensional array
    static void Task1()
    {
        Console.Write("Введіть розмірність масиву: ");
        int n = int.Parse(Console.ReadLine());
        
        int[] array = new int[n];
        Random rand = new Random();
        
        Console.WriteLine("Масив:");
        for (int i = 0; i < n; i++)
        {
            array[i] = rand.Next(1, 100); // Генерація випадкових чисел для масиву
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        
        Console.Write("Введіть число для порівняння: ");
        int comparisonNumber = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Номери елементів, більших за задане число:");
        for (int i = 0; i < n; i++)
        {
            if (array[i] > comparisonNumber)
            {
                Console.WriteLine($"Індекс: {i}, Значення: {array[i]}");
            }
        }
    }

    // Task 2: Two-dimensional array
    static void Task2()
    {
        Console.Write("Введіть розмірність масиву (n): ");
        int n = int.Parse(Console.ReadLine());

        double[,] array = new double[n, n];
        Random rand = new Random();
        
        Console.WriteLine("Масив:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = rand.NextDouble() * 100; // Генерація випадкових чисел для масиву
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }

        // Пошук першого мінімального та останнього максимального елементів
        int minIndexI = 0, minIndexJ = 0, maxIndexI = 0, maxIndexJ = 0;
        double minValue = array[0, 0], maxValue = array[0, 0];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (array[i, j] < minValue)
                {
                    minValue = array[i, j];
                    minIndexI = i;
                    minIndexJ = j;
                }
                if (array[i, j] >= maxValue)
                {
                    maxValue = array[i, j];
                    maxIndexI = i;
                    maxIndexJ = j;
                }
            }
        }

        // Обмін місцями
        double temp = array[minIndexI, minIndexJ];
        array[minIndexI, minIndexJ] = array[maxIndexI, maxIndexJ];
        array[maxIndexI, maxIndexJ] = temp;

        Console.WriteLine("Масив після обміну:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    // Task 3: Square matrix
    static void Task3()
    {
        Console.Write("Введіть розмірність масиву (n): ");
        int n = int.Parse(Console.ReadLine());

        int[,] array = new int[n, n];
        Random rand = new Random();
        
        Console.WriteLine("Масив:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = rand.Next(1, 100); // Генерація випадкових чисел для масиву
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }

        // Підрахунок норми матриці
        int norm = 0;
        for (int i = 0; i < n; i++)
        {
            int rowMax = array[i, 0];
            for (int j = 1; j < n; j++)
            {
                if (array[i, j] > rowMax)
                {
                    rowMax = array[i, j];
                }
            }
            norm += rowMax;
        }

        Console.WriteLine("Норма матриці: " + norm);
    }

    // Task 4: Jagged array
    static void Task4()
    {
        Console.Write("Введіть кількість рядків у східчастому масиві: ");
        int n = int.Parse(Console.ReadLine());
        
        int[][] jaggedArray = new int[n][];
        Random rand = new Random();
        
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введіть кількість елементів у рядку {i + 1}: ");
            int m = int.Parse(Console.ReadLine());
            jaggedArray[i] = new int[m];
            for (int j = 0; j < m; j++)
            {
                jaggedArray[i][j] = rand.Next(1, 100); // Генерація випадкових чисел для масиву
            }
        }

        Console.Write("Введіть початок інтервалу: ");
        int intervalStart = int.Parse(Console.ReadLine());
        Console.Write("Введіть кінець інтервалу: ");
        int intervalEnd = int.Parse(Console.ReadLine());
        
        int[] sums = new int[n];
        
        for (int i = 0; i < n; i++)
        {
            int sum = 0;
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                if (jaggedArray[i][j] < intervalStart || jaggedArray[i][j] > intervalEnd)
                {
                    sum += jaggedArray[i][j];
                }
            }
            sums[i] = sum;
        }

        Console.WriteLine("Суми елементів для кожного рядка, що не потрапляють в заданий інтервал:");
        for (int i = 0; i < sums.Length; i++)
        {
            Console.WriteLine($"Рядок {i + 1}: {sums[i]}");
        }
    }
}

