Console.WriteLine("Введите пятизначное число");
string number = Convert.ToString(Console.ReadLine());
char[] s = number.ToCharArray();
Array.Reverse(s);
if (Convert.ToString(s) == number)
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число не является палиндромом");
}
