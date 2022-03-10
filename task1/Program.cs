Console.WriteLine("Введите пятизначное число");
string number = Convert.ToString(Console.ReadLine());
char[] s = number.ToCharArray();
Array.Reverse(s);
string checkout = new string(s);
if (number == checkout)
{
  Console.WriteLine("число является палиндромом");  
}
else if (number != checkout)
{
    Console.WriteLine("число не является палиндромом");
}
