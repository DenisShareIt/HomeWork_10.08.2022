//Удалить вторую цифру трехзначного числа

Console.WriteLine("Введите трехзначное число: ");
int N = int.Parse(Console.ReadLine());
if (N >= 100 && N < 1000)
{
    int last = N % 10;
    int first = N / 100;
    int result = first * 10 + last;
    Console.WriteLine("Число с удаленной второй цифрой: " + result);
}
else
    Console.WriteLine("Число не трехзначное");