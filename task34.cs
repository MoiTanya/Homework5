// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int EvenNumber (int[] array)
{
    int count =  0;
    for (int i=0; i<array.Length; i++)
    {
        if (array[i]%2==0) count++;
    }
    return count;
}

int[] RandomArray (int size)
{   
    int[] Array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Array[i] = new Random().Next(1000);
    }
    return Array;
}

Console.WriteLine("Введите размер массива");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int[] NewArray = RandomArray(sizeArray);
int countEven = EvenNumber(NewArray);
Console.WriteLine(String.Join(',', NewArray)+$"-> {countEven}");