// НАпишите программу, кот на вход принимает два числа и проверяет, 
//является ли первое число квадратом второго
//a=25, b=5 да
//a=2, b=10 нет
//a=9, b=-3 да
//a=-3, b=9 нет

Console.Clear();
Console.Write("Введите значение a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b: ");
int b = Convert.ToInt32(Console.ReadLine());
int c = b * b;
if (a == c) 
Console.WriteLine($"да");
else
Console.WriteLine($"нет");
