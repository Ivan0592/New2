// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите размерность двумерного массива m x n");
Console.Write("Введите m: ");
int m =  Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n =  Convert.ToInt32(Console.ReadLine());

double [,] matrix = new double [m,n];
for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        matrix[i,j] = new Random().Next(0,11);
        Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

 Console.Write("Введите номер индекса строки: ");
 int A = Convert.ToInt32(Console.ReadLine());
 Console.Write("Введите номер индекса колонны: ");
 int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
if(A < m && B < n)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Число " + matrix[A, B]);
    Console.ForegroundColor = ConsoleColor.White;
}
    else Console.WriteLine("Такого элемента нет! ");

for(int i = 0; i < m; i++)
{
    
    for(int j = 0; j < n; j++)
    {
        if(i == A && j == B) Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(matrix[i,j] + " ");
        Console.ForegroundColor = ConsoleColor.White;
    }
}    
Console.WriteLine();

