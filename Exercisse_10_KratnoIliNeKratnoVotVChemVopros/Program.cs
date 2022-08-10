//Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine("Введите число ");
int Number = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число для проверки на кратность ");
int MultipleNumber = int.Parse(Console.ReadLine());
int Remainder = (MultipleNumber % Number);


if (MultipleNumber % Number == 0)
{
    Console.WriteLine("Заданное число кратно " + Number);
}
else
{
    Console.WriteLine("Число не кратно заданному, Остаток равен: " + Remainder);
}

