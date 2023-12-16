
// с помощью интернета пришел к варианту ниже.

       // Вводим исходное число

        Console.WriteLine("Enter natural number: ");

        int num = Convert.ToInt32(Console.ReadLine());



        // Преобразуем число в строку

        string numberString = num.ToString();



        // Получаем количество цифр в числе

        int length = numberString.Length;



        // Создаем массив нужного размера

        int[] digits = new int[length];



        // Заполняем массив цифрами числа

        for (int i = 0; i < length; i++)

        {

            digits[i] = int.Parse(numberString[i].ToString());
            System.Console.Write(digits[i] + " ");

        }



       

       



        
