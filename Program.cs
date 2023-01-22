// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

long a = Convert.ToInt32(Console.ReadLine());
if (a > 1000)
{
    while (a > 1000)
    {
        a = a / 10;
    }
    a = a % 10;
    
    Сonsole.WriteLine(a);
}
else if (a > 100 && a < 1000)
{
    a = a % 10;
    Сonsole.WriteLine(a);
}
else
{
    Сonsole.WriteLine("Третьей цифры нет");
}