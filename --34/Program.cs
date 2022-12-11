//Задача 34: Задайте массив заполненный случайными положительными
//трёхзначными числами. Напишите программу, которая покажет количество
//чётных чисел в массиве.
//[345, 897, 568, 234] -> 2




int [] FillArray (int []array) // создаем метод по заполнению массива случайными числами от 100 до999
{
    for (int i=0; i<array.Length; i++)
    {
        array[i]=new Random().Next(99, 1000);
    }
    Console.WriteLine($"[{String.Join(",",array)}]");
  return array;
}

int [] array = new int [12];
FillArray (array);

int CountEven=0;
for (int i=0; i<array.Length;i++)
    {
        if(array[i]%2==0)
        {
            CountEven++;
        }
    }
Console.WriteLine($"Количество четных элементов {CountEven}");