double[] CrateArray(int sise, int min, int value)
{
    double[] arr = new Double[sise];
    for (int i = 0; i < sise; i++)
    {
        arr[i] = new Random().NextDouble() * 100;;
    }

    Console.WriteLine(String.Join(" ", arr));

    return arr;
}

void PrintDiffMinMax(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.WriteLine(arr[i]);
    }

    double difference = arr.Max() - arr.Min();
    System.Console.WriteLine($"Минимальное значение массива= {arr.Min()}, максимальное значение массива= {arr.Max()}");
    System.Console.WriteLine($"Разница между  значениями массива составляет= {difference}");
    double[] arr2 = CrateArray(10, 1, 5);
}

double[] arr2 = CrateArray(5, 1, 10);
PrintDiffMinMax(arr2);

