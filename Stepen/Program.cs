// int f = 1;
// while (f != 0)
// {
//     Console.WriteLine("Введите число 1");
//     int number1 = Convert.ToInt32(Console.ReadLine());

//     Console.WriteLine("Введите число 2");
//     int number2 = Convert.ToInt32(Console.ReadLine());

//     Console.WriteLine("Ответ " + (Math.Pow(number1, number2)));
//     Console.WriteLine();
//     f++;
// }

int f = 1;
while (f != 0)
{
    Console.WriteLine("Введите число 1");
    int number1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите число 2");
    int number2 = Convert.ToInt32(Console.ReadLine());

    int a = number1;
    int b = number1;
    int c = number2;
    int d = 0;
    int temp = c;
    int count = 0;
    if (number2 != 0)
    {                      
        while (count < number2 - 1)           
        {
            d = a * b;  
            a = d;
            count++;       
        }
        
        Console.WriteLine("Ответ " + a);
        Console.WriteLine("");
    }
    if (number2 == 0)
    {
        Console.WriteLine("Ответ " + 1);
        Console.WriteLine("");
    }
    f++;
}