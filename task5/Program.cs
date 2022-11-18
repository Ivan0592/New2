// Задача 2: Напишите программу, которая на вход принимаетConsole.WriteLine("Введите 1 число: "); два числа и выдаёт, какое число большее,
//  а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3



int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 2 число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB){
    Console.Write($"max = {numberA}, min = {numberB}");
}
else if (numberA < numberB) {
 Console.Write($"max = {numberB}, min = {numberA}");
}
else {
     Console.Write($"max = min = {numberA}");
}