// Задача 13: Напишите программу, которая выводит
// третью цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры
// нет
// 32679 -> 6

Console.WriteLine("Введите первое число");
int number= Convert.ToInt32 (Console.ReadLine());
string numberText = Convert.ToString(number);
if (number > -100 & number < 100) {
    Console.WriteLine($"Третьей цифры нет!");
}
else if (number < -99){
    Console.WriteLine($"Это 3 цифра числа {number} получается {numberText[3]} ");
}
else{
Console.WriteLine($"Третья цифра числа {number} получается {numberText[2]}");
}