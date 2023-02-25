//Задача 29: Напишите программу, 
//которая задаёт массив из 8 элементов
// и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите количество элементов массива");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
for(int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(0,9);
    Console.Write($"{arr[i]} ");
}
Console.WriteLine();
Console.Write('[' + string.Join(", ", arr) + ']');
