// Напишите прогр, кот б выдавать название дня недели по заданному номеру
//3-среда
//5 - пятница

Console.Clear();
Console.WriteLine("Напишите номер дня недели: ");
int x = Convert.ToInt32(Console.ReadLine());

if (x == 1)
Console.WriteLine("Понедельник");
if (x == 2)
Console.WriteLine("Вторник");
if (x == 3)
Console.WriteLine("Среда");
if (x == 4)
Console.WriteLine("Четверг");
if (x == 5)
Console.WriteLine("Пятница");
if (x == 6)
Console.WriteLine("Суббота");
if (x == 7)
Console.WriteLine("Воскресенье");
if (x > 7)
Console.WriteLine("Ошибка ввода");
if (x < 1)
Console.WriteLine("Ошибка ввода");