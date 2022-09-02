// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] SetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

int GetEvenNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] result = SetArray(4);

System.Console.WriteLine($"[{string.Join(", ", result)}]");
System.Console.WriteLine(GetEvenNumber(result));



// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] SetArray2(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 10);
    }
    return array;
}

int GetSumOfOddIndexes(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (!(i % 2 == 0))
        {
            sum += array[i];
        }
    }
    return sum;
}

int[] result2 = SetArray2(7);

System.Console.WriteLine($"[{string.Join(", ", result2)}]");
System.Console.WriteLine(GetSumOfOddIndexes(result2));



// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] SetArray3(int size){
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 10);
    }
    return array;
}

int GetMinMaxDiff (int[] array){
    int max = array[0];
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max){
            max = array[i];
        }
        else if (array[i] < min){
            min = array[i];
        }
    }
    int diff = max - min;
    return diff;
}

int[] result3 = SetArray3(5);

System.Console.WriteLine($"[{string.Join(", ", result3)}]");
System.Console.WriteLine(GetMinMaxDiff(result3));