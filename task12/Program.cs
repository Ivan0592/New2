// Задача №14. Работа в группах
// Напишите программу, которая принимает на вход
// число и проверяет, кратно ли оно одновременно
// 7 и 23
// ●
// 14 -> нет
// ●
// 46 -> нет
// ●
// 161 -> да

System.Console.WriteLine("Введите число\t");
int number1= Convert.ToInt32 (Console.ReadLine());
if (number1%7==0 && number1%23==0) {
    System.Console.Write($"Числo {number1} кратнo 7 и 23 ");
}
else {
    System.Console.Write($"Числo {number1} не кратнo 7 и 23 ");
}


// Задача №16. Работа в группах
// Напишите программу, которая принимает на вход два
// числа и проверяет, является ли одно число квадратом
// другого.
// ●
// 5, 25 -> да
// ●
// -4, 16 -> да
// ●
// 25, 5 -> да
// ●
// 8,9 -> нет

System.Console.WriteLine("Введите первое число");
int numberA= Convert.ToInt32 (Console.ReadLine());

System.Console.WriteLine("Введите второе число");
int numberB= Convert.ToInt32 (Console.ReadLine());

if (numberA*numberA==numberB || numberB*numberB==numberA ) {
    System.Console.Write($"Да");
}
else { 
    
    System.Console.Write($"Нет");
}