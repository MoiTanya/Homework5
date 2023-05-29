// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] RandomArray (int sizeArr, int sizeElem)
{   
    int[] Array = new int[sizeArr];
    for (int i = 0; i < sizeArr; i++)
    {
        Array[i] = new Random().Next(sizeElem);
    }
    return Array;
}

int SumOddNumber (int[] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((i+1)%2!=0)
        summ = summ + array[i];
    }
    return summ;
}

Console.WriteLine("Введите размер массива");
int sizeArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размерность элементов массива");
int sizeElement = Convert.ToInt32(Console.ReadLine());
int[] NewArray = RandomArray(sizeArray, sizeElement);
int summ = SumOddNumber(NewArray);
Console.WriteLine(String.Join(',', NewArray)+$"-> {summ}");