// Пробовал решить в том числе с помощью интернета
// Не представляю как это сделать.


double[] array = new double[3];

double max = 0;
double min = array[0];

double difference = 0;
Random = new Random ();

for(int i = 0; i < array.Length; i++)
{
    array[i] = Random.NextDouble() * 100;
    System.Console.Write(array[i] + " ");
    if(array[i] > max)
    {
        array[i] = max;
    };
    if(array[i] < min)
    {
        array[i] = min;
    };
};



Console.WriteLine();
Console.WriteLine($"разница равна {difference = max - min}");
