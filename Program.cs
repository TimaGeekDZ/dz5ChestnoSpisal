// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

/*
int[] createRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i ++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}
void writeArr(int[] array)
{
    Console.Write("Generated array containing numbers: ");
    for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
}
int countEvenNumbers(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        count++;
            
    }
    return count;
}
int[] randomArr = createRandomArray(10, 100, 999);
writeArr(randomArr);
int countEvenNums = countEvenNumbers(randomArr);
Console.WriteLine($"There are {countEvenNums} even numbers in the array");
*/

// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

/*
int[] createRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i ++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}
void writeArr(int[] array)
{
    Console.Write("Generated array containing numbers: ");
    for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
}
int sumElementsAtOddIndices(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 > 0)
        sum += array[i];
            
    }
    return sum;
}
int[] randomArr = createRandomArray(10, 100, 999);
writeArr(randomArr);
int sumElAtOddInd = sumElementsAtOddIndices(randomArr);
Console.WriteLine($"sum of odd array elements is equal to {sumElAtOddInd}");
*/
/*
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] createRandomArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];

    for(int i = 0; i < size; i ++)
    {
        array[i] = Math.Round(new Random().Next(minValue, maxValue) + new Random().NextDouble(), 2);
    }
    return array;
}

void writeArr(double[] array)
{
    Console.Write("Generated array containing numbers: ");
    for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
}

double findMax(double[] array)
{
    double max = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] > max)
        max = array[i];
    }
    return max;
}

double findMin(double[] array)
{
    double min = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] < min)
        min = array[i];
    }
    return min;
}

double differenceMinWithMax(double min, double max)
{
    double dif = 0;
    if((min < 0 && max < 0))
    {
        min *= -1;
        dif = max + min;       
    }
    else dif = max - min;
    if(dif < 0)
    dif *= -1;
    return Math.Round(dif, 2);
}

double[] randomArr = createRandomArray(10, -10, 10);

double maxElement = findMax(randomArr);

double minElement = findMin(randomArr);

double difMinMax =  differenceMinWithMax(minElement, maxElement);

writeArr(randomArr);

Console.WriteLine($"Max element in this array is equal to {maxElement}, min is equal to {minElement}");

Console.WriteLine($"Difference {minElement} with {maxElement} is equal to {difMinMax}");
*/