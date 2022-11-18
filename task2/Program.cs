// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Ввести число от 1 до 7: ");
int сегодня = Convert.ToInt32(Console.ReadLine());

if(сегодня == 1) {
    Console.WriteLine("Сегодня понедельник");
}
else if(сегодня == 2) {
    Console.WriteLine("Сегодня вторник");
}
else if(сегодня == 3) {
    Console.WriteLine("Сегодня среда");
}
else if(сегодня == 4) {
    Console.WriteLine("Сегодня четверг");
}
else if(сегодня == 5) {
    Console.WriteLine("Сегодня пятница");
}
else if(сегодня == 6) {
    Console.WriteLine("Сегодня суббота");
}
else if(сегодня == 7) {
    Console.WriteLine("Сегодня воскресенье");
}
else {
Console.WriteLine("Дней всего 7!");
}


