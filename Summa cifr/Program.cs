Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
string str = a.ToString();
int[] b = new int[str.Length];
for( int i=0; i< str.Length; i++)
{
    b[i] = int.Parse(str[i].ToString());
}

int p = 0;
int sum = 0;
int temp = 0;
while(p < b.Length)
{
    temp = sum + b[p];
    sum = temp;
    p++;
}

Console.Write("Ответ - " + sum);
Console.WriteLine();