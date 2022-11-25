// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numsText = Convert.ToString(number);

if (numsText.Length == 5 & numsText[0] == numsText[4] & numsText[1] == numsText[3]){
    Console.WriteLine("Зеркальные числа ");
}
else{
    Console.WriteLine("Условия задачи не выполнены!");
}
