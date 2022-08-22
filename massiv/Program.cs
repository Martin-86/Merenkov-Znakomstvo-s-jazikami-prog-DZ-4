//
//
// Тут работает если просто ввести подряд цифры без отрицательных. На пример 12345


// Console.WriteLine("Введите цифры ");
// int a = Convert.ToInt32(Console.ReadLine());
// string str = a.ToString();
// int[] b = new int[str.Length];
// for( int i=0; i< str.Length; i++)
// {
//     b[i] = int.Parse(str[i].ToString());
// }

// Console.Write("Ответ - " );

// int p = 0;
// while(p < b.Length - 1)
// {
//     Console.Write(b[p]+ ",");
//     p++;
// }
// Console.Write(b[b.Length - 1]+ ".");
// Console.WriteLine();
//____________________________________________________________________
//
//
// Тут можно и с отрицательными, но нужно задать размер массива и цифры вводить по отдельность.

Console.WriteLine("Введите размер массива ");
int l = Convert.ToInt32(Console.ReadLine());

void FillArray(int[] collection)
{   
    int length = l;
    int index = 0;
    while (index < l)           
        {   
            Console.WriteLine("Введите число ");
            int a = Convert.ToInt32(Console.ReadLine());
            collection[index] = a;
            //index = index + 1;
            index++;
        }
}


void PrintArray(int[] col)
{
    Console.Write("Ваш массив ");
    int count = col.Length; 
    int position = 0;
    while(position < count - 1)
    {
        Console.Write(col[position] + ",");
        position++;
    }
    Console.Write(col[l - 1] + ".");
    Console.WriteLine();
}

int[] array = new int [l];

FillArray(array);
PrintArray(array);
Console.WriteLine();





// int[] b = new int[l];
// for( int i = 0; i<l; i++)
//     {
//         Console.WriteLine("Введите число ");
//         int a = Convert.ToInt32(Console.ReadLine());
//         b[i] = a;
//     }
// return b;

// void FillArray(int[] collection)     // неясно как присвоилось имя collection? или это просто для внуттреннего пользования этой функции?
// {                                    // FillArray(array);из строки 49 и void вроде как вызвали функцию
//                                     // в строке 5 и параметры подтянулись из строки 47???
   
//     int length = collection.Length;  // Массив с именем collection принял условие из строки 47?
//     int index = 0;                      
//     while (index < length)           
//     {
//         collection[index] = new Random().Next(1, 10);
//         //index = index + 1;
//         index++;
//     }
// }



// int pp = 0;
// while(pp < b.Length - 1)
// {
//     Console.Write(b[pp]+ ",");
//     pp++;
// }
// Console.Write(b[b.Length - 1]+ ".");
// Console.WriteLine();


// string str = a.ToString();
// int[] b = new int[str.Length];
// for( int i=0; i< str.Length; i++)
// {
//     b[i] = int.Parse(str[i].ToString());
// }

// Console.Write("Ответ - " );

// int p = 0;
// while(p < b.Length - 1)
// {
//     Console.Write(b[p]+ ",");
//     p++;
// }
// Console.Write(b[b.Length - 1]+ ".");
// Console.WriteLine();