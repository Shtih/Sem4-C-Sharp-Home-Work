//единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

Console.WriteLine("Введите количество элементов массива");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
for(int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(0,9);
    //Console.Write($"{arr[i]} ");
}
Console.WriteLine('[' + string.Join(", ", arr) + ']');

