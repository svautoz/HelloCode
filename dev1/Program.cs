/*Задача
---
Cформировать случайным образом целочисленный массив A из натуральных двузначных чисел. 
Создать на его основе масив B, отбрасывая те, которые 
- нарушают порядок возрастания
- больше среднего арифметического элементов A
- чётные
*/

int arr_size = 10;
int[] array= new int[arr_size];
int[] arrayB= new int[arr_size];
Console.Write("Введите первое число: ");
int minValue = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int maxValue = int.Parse(Console.ReadLine());


int[] CreateArray(int minValue, int maxValue)
{
    int[] array= new int[arr_size];
    for(int i=0; i<arr_size;i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
        Console.WriteLine(array[i]);
    }
    
    return array;
}

int[] MakeBArrayASC(int[] arrayA)
{
    int[] arrayB= new int[arrayA.Length];
    int max = arrayA[0];
    arrayB[0] = max;
    int index = 1;
    for(int i=1; i<arrayA.Length; i++)
    {
        if(arrayA[i]>max)
        {
            max = arrayA[i]; 
            arrayB[index++] = arrayA[i];
        }
    }
    return arrayB;
}

int[] MakeBArrayMean(int[] arrayA)
{
    int[] arrayB= new int[arrayA.Length];
    float mean = 0;
    for(int i=0; i<arrayA.Length; i++)
    {
        mean +=arrayA[i];
    }
    mean = mean/arrayA.Length;
    int index = 0;
    for(int i=0; i<arrayA.Length; i++)
    {
        if(arrayA[i]<=mean)
        {
            arrayB[index++] = arrayA[i];
        }
    }
    return arrayB;
}

int[] MakeBArrayEven(int[] arrayA)
{
    int[] arrayB= new int[arrayA.Length];
    int index = 0;
    for(int i=0; i<arrayA.Length; i++)
    {
        if(arrayA[i]%2!=0)
        {
            arrayB[index++] = arrayA[i];
        }
    }
    return arrayB;
}

void PrintArray(int[] array)
{
    Console.WriteLine();
    for(int i=0;i<array.Length;i++)
    {
        Console.Write(array[i] + " ");
    }
}

array = CreateArray(minValue, maxValue);

arrayB = MakeBArrayASC(array);
PrintArray(arrayB);

arrayB = MakeBArrayMean(array);
PrintArray(arrayB);

arrayB = MakeBArrayEven(array);
PrintArray(arrayB);

