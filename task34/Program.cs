int[] NewArray(int sise, int min, int value)
{
    int[] arr = new int[sise];
    for (int i = 0; i < sise; i++)
    {
        arr[i] = new Random().Next(min, value);
        

    }

    Console.WriteLine(String.Join(" ",arr));
    return arr;
}

void EvenNum(int[] array)
{
    int res = 0;
    for (int i = 0; i < array.Length; i++)
    {
       
        if (array[i]%2==0)
        {
            res++;

        }
        
        }

    

        Console.WriteLine("четных чисел:"+ res );
        
        
}
        
    
        
        
    

int[] arr1= NewArray(10,100,300);
EvenNum(arr1);