Console.WriteLine("Введите трехзначное число: ");
int N = int.Parse(Console.ReadLine());

if (N >= 100 && N <= 1000)
{
  int second = N % 100;
  int result = second / 10;

  Console.WriteLine("Вторая цифра трехзначного числа: " + result);
}
else 
{
 Console.WriteLine("Не является трехзначным числом");
}
