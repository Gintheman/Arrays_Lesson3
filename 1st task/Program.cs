int[] array = new int[10];

int[] array2 = new int[new Random().Next(20, 91)];  

int count = 0;

for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 101);
    System.Console.Write(array[i] + " ");

    if (array[i] >= 20 && array[i] <= 90)
    {
        count++;
    }

};

Console.WriteLine();
Console.WriteLine(count);