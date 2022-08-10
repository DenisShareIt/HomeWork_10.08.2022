Console.WriteLine("Введите трехзначное число: ");
int N = int.Parse(Console.ReadLine());
int last = N % 10;

if (N / 100 == 0)
{
   Console.WriteLine("число двухзначное"); 
}
else
{
    Console.WriteLine("Третья цифра числа: " + last);
}

