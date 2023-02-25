// Задача 30: Напишите программу, 
//которая выводит массив из 
//8 элементов, заполненный нулями и 
//единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void Array8()
{
    int[] tempArray = new int [8];
    for(int i = 0; 1 < 8; i++)
    {
        tempArray[i] = new Random().Next(0, 2);
        Console.Write(tempArray[i]);
    }   
}
Array8();