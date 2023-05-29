// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// Диапазон [-10, 10]. Обратите внимание на вещественных чисел
// Для примера возьмём диапазон побольше. [3 7 22 2 78] -> 76
double[] RandomArray (int sizeArr)
{   
    double[] Array = new double[sizeArr];
    Random x = new Random();
    for (int i = 0; i < sizeArr; i++)
    {
        double r = x.Next(-10,11);
        Array[i] = r/10;
    }
    return Array;
}

double MaxElement (double[] array)
{
    double max =array[0];
    for (int i=0; i<array.Length; i++)
    {
        if (max<array[i]) max=array[i];
    }
    return max;
}

double MinElement (double[] array)
{
    double min =array[0];
    for (int i=0; i<array.Length; i++)
    {
        if (min>array[i]) min=array[i];
    }
    return min;
}
Console.WriteLine("Введите размер массива");
int sizeArray = Convert.ToInt32(Console.ReadLine());
double[] NewArray = RandomArray(sizeArray);
double min = MinElement(NewArray);
double max = MaxElement(NewArray);
Console.WriteLine($"Минимальный элемент -> {min}");
Console.WriteLine($"Максимальный элемент -> {max}");
double subtraction = MaxElement(NewArray) - MinElement(NewArray);

Console.WriteLine(String.Join("; ", NewArray)+$" -> {subtraction}");