// Задача 26: Напишите программу, которая
// принимает на вход число и выдаёт количество
// цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
string A1 = A.ToString();
Console.Write("Цифр в числе " + A1.Length);
