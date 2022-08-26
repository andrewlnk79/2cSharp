int[] CrateArray(int sise, int min, int value)
{
    int[] arr = new int[sise];
    for (int i = 0; i < sise; i++)
    {
        arr[i] = new Random().Next(min, value + 1);
    }

    Console.WriteLine(String.Join(" ", arr));

    return arr;
}

int NotEvenNumber(int[] array)
{
    int res = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 >0)
        {
            res+=array[i];
        }

        Console.WriteLine(res+" ");
    }

    return res;
}
int[] arr2= CrateArray(20,1,20);
NotEvenNumber(arr2);