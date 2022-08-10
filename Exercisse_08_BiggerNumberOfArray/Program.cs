//Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
Console.WriteLine("Введите число от 10 до 99: ");
int N = int.Parse(Console.ReadLine());
int first = (N / 10);
int second = (N % 10);

if (N >= 10 && N <= 99 && first > second)
{
    Console.WriteLine("Данная цифра числа больше: " + first);
}
if (N >= 10 && N <= 99 && first < second)
{

    Console.WriteLine("Данная цифра числа больше: " + second);
}
else 
{
    Console.WriteLine("Цифры числа равны " ); 
}