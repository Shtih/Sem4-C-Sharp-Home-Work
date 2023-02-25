//Задача 25: Напишите цикл, 
//который принимает на вход два числа 
//(A и B) и возводит число A в 
//натуральную степень B.

Console.WriteLine("Введите число А: ");
double A = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число B: ");
double B = Convert.ToDouble(Console.ReadLine());
double C = Math.Pow(A, B);
Console.WriteLine(C);