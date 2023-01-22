// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите число: ");
long a = Convert.ToInt32(Console.ReadLine());
if (a > 1000)
{
    while (a > 1000)
    {
        a = a / 10;
    }
    a = a % 10;
    
    Console.WriteLine(a);
}
else if (a > 100 && a < 1000)
{
    a = a % 10;
    Console.WriteLine(a);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}