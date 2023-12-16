int num = new Random().Next(1, 100001);
int amount =0;
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


while(num >= 1)
{
    num = num / 10;
    amount++;
}





int[] array = new int[amount];

for(int i = 0; i < array.Length; i++)
{
    if (num >= 10000)
    {
        array[0] = num / 10000;
    }
    System.Console.Write(array[i] + " ");
};