// Задача 42: Напишите программу, которая будет
// преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


// int Recurse (int number)
// {
//     int result =number/2;
//     while (result>0)
//     {
//     result = result -Recurse(result);

//     }
// }
// Console.Write("Введите число ")
// int mainNumber = Convert.ToInt32(Console.ReadLine());

void BinaryView(int number)
{
    if(number == 0)
    {
        return;
    }
    BinaryView(number/2);
    Console.Write(number%2);
}

Console.WriteLine("Введите число" );
int number = Convert.ToInt32(Console.ReadLine());
BinaryView(number);