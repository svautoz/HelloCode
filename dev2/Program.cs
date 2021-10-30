/* Задача
---
Имеется числовой массив A заполненный числами из отрезка [minValue; maxValue]. Создать на его основе масив B, отбрасывая те, которые нарушают порядок
- возрастания
- элементы, больше 8
- знакочередования
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
    int[] arrayB= new int[arr_size];
    int max = arrayA[0];
    arrayB[0] = max;
    int index = 1;
    for(int i=1; i<arr_size; i++)
    {
        if(arrayA[i]>max)
        {
            max = arrayA[i]; 
            arrayB[index++] = arrayA[i];
        }
    }
    return arrayB;
}

int[] MakeBArrayMore(int[] arrayA)
{
    int[] arrayB= new int[arr_size];
    int index = 0;
    for(int i=0; i<arr_size; i++)
    {
        if(arrayA[i]<=8)
        {
            arrayB[index++] = arrayA[i];
        }
    }
    return arrayB;
}

int[] MakeBArraySign(int[] arrayA)
{
    int[] arrayB= new int[arr_size];
    int sign = 0;
    if(arrayA[0]>0) sign = 1;
    arrayB[0] = arrayA[0];
    int index = 1;
    for(int i=1; i<arr_size; i++)
    {
        if((arrayA[i]>0) && (sign==0))
        {
            sign = 1; 
            arrayB[index++] = arrayA[i];
        }
        if((arrayA[i]<0) && (sign==1))
        {
            sign = 0; 
            arrayB[index++] = arrayA[i];
        }
    }
    return arrayB;
}

array = CreateArray(minValue, maxValue);

arrayB = MakeBArrayASC(array);
Console.WriteLine();
for(int i=0;i<arrayB.Length;i++)
{
    Console.Write(arrayB[i] + " ");
}


arrayB = MakeBArrayMore(array);
Console.WriteLine();
for(int i=0;i<arrayB.Length;i++)
{
    Console.Write(arrayB[i] + " ");
}

arrayB = MakeBArraySign(array);
Console.WriteLine();
for(int i=0;i<arrayB.Length;i++)
{
    Console.Write(arrayB[i] + " ");
}

