// Задача 26: Напишите программу, 
//которая принимает на вход число и 
//выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int TotalNumbers(int number)
{
    int count = 0;
    if(number == 0)
    {
        count = 1;
    }
    while(number > 0)
    {
        number/=10; // ==number = number / 10
        count++;
    }
    return count;
}
Console.WriteLine("Введите число А: ");
int A = Math.Abs(Convert.ToInt32(Console.ReadLine())); // в этом случае число берется без знака
Console.WriteLine($"Количество чисел в числе А составило: {TotalNumbers(A)}");