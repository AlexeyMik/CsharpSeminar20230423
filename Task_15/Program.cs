// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нетSee https://aka.ms/new-console-template for more information
Console.Write("Введите номер дня недели (от 1 до 7): ");
int iday = Convert.ToInt32(Console.ReadLine());
if (iday < 1 || iday>7)
{
    Console.WriteLine($"Введено число: {iday} не номер дня недели");
}
else if (iday>5)
{
    Console.WriteLine($"{iday} выходной день");
}
else
{
    Console.WriteLine($"{iday} рабочий день");
}