// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int i = 0;
int sum = 0;
int b = 0;
int x = 0;
int c = 0;

if(a >= 10 && a <=99)
{
    i = a / 10;
    b = a % 10;
    sum = i + b;
    Console.WriteLine("Результат сложения всех чисел в числе: " + sum);
}
else if(a >= 100 && a <= 999)
{
    i = a / 100;
    x = (a / 10) % 10;
    b = a % 10;
    sum = i + x + b;
    Console.WriteLine("Результат сложения всех чисел в числе: " + sum);
}
else if(a >= 1000 && a <= 9999)
{
    i = a / 1000;
    x = (a / 100) % 10;
    b = a % 10;
    c = (a / 10) % 10;
    sum = i + x + b + c;
    Console.WriteLine("Результат сложения всех чисел в числе: " + sum);
}
