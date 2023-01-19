// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// (без использования Math.Pow)
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень, в которую хотите возвести: ");
int b = Convert.ToInt32(Console.ReadLine());
int i = 1;
int c = 1;

for (i = 1; i <= b; i++)
{
    c = c * a;
}

Console.WriteLine("Число равняется: " + c);