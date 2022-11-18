// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.WriteLine("Введите 1 число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 2 число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 3 число: ");
int numberC = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB) {
    if (numberA < numberC){
        Console.WriteLine(numberC);
    }
    else {
        Console.WriteLine(numberA);
    }
}
else {
    if (numberB < numberC){
    Console.WriteLine(numberC);
    }
    else {
    Console.WriteLine(numberB);
    }
}