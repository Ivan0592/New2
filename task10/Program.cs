// Задача №11. Работа в группах
// Напишите программу, которая выводит случайное
// трехзначное число и удаляет вторую цифру этого
// числа.
// ●
// 456 -> 46
// ●
// 782 -> 72
// ●
// 918 -> 98


int digit = new Random().Next(100, 1000);
System.Console.WriteLine(digit);
int digit1 = digit/100;
int digit2 = digit%10;

Console.WriteLine ($"{digit1*10+digit2}");
