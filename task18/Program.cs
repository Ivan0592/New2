// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов,
// заполненный нулями и единицами в
// случайном порядке.
// [1,0,1,1,0,1,0,0]

int count = 8;
int [] mass = new int [count];
for (int i=0; i<count; i++)
{
    mass[i] = new Random().Next(0, 2);
    // Console.Write(mass[i]);
}

Console.Write('[' + String.Join(" ", mass) + ']');

