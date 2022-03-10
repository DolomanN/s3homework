int b = 1;
Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
while (b <= a)
{
    Console.WriteLine((b * b * b));
    b++;
}
          
Console.ReadKey();
