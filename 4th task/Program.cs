int natNum = new Random().Next(1, 100001);
int num = 0;
int amount = 0;

// if(num >= 10000)
// {
//     amount = 5;
// }
// else if(num >= 1000)
// {
//     amount = 4;
// }
// else if(num >= 100)
// {
//     amount = 3;
// }
// else if(num >= 10)
// {
//     num = 2;
// }
// else if(num >= 1)
// {
//     num = 1;
// }


while(natNum >= 1)
{
    num = natNum / 10;
    amount++;
}





int[] array = new int[amount];

for(int i = 0; i < array.Length; i++)
{
    if (natNum >= 10000)
    {
        array[0] = natNum / 10000;
    }
    System.Console.Write(array[i] + " ");
};