// Задача 29: Напишите программу, которая задаёт
// массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int count = 8;
int [] mass = new int [count];
for (int i=0; i<count; i++)
{
    mass[i] = new Random().Next(0, 100);
   
}

Console.Write('[' + String.Join(", ", mass) + ']');