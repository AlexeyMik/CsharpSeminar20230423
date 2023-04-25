//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
Console.Write("Введите натуральное число:");
int isource = Convert.ToInt32(Console.ReadLine());
if (isource < 100)
{
    Console.WriteLine($"Введено число: {isource} меньше 100");
}
else
{
    int i = isource;
    while (i > 999)
    {
        i = i / 10;
    };
    int result = i % 10 % 10;
    Console.WriteLine($"Третья слева цифра число {isource} равна {result}");
}