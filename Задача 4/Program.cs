// Напишите прогр, кот принимает на вход трехзначное число и на выходе показывает
// послед цифру этого числа
//456-> 6
//782-> 2
//918 -> 8

Console.Clear();
Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
if(x<100)
{
    Console.Write("Число не трехзначное");
}
else
{
x = x % 10;
Console.WriteLine($"Число {x}");
}