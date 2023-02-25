// Задача 26: Напишите программу, 
//которая принимает на вход число и 
//выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
String str = Convert.ToString(number);
int result = Convert.ToInt32(str.Length);
Console.WriteLine($"Длина нашего числа: {result}");