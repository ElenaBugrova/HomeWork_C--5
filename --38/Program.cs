//Задайте массив вещественных чисел. Найдите разницу между
//максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

Console.Clear();


int [] FillArray (int []array) 
{
    for (int i=0; i<array.Length; i++)
    {
        array[i]=new Random().Next(0, 100);
    }
    Console.WriteLine($"[{String.Join(",",array)}]");
  return array;
}

Console.Write("Введите число элементов в массиве ");
int A = int.Parse (Console.ReadLine ());
if (A<1)
{
    Console.Write("Нет элементов для подсчета");
}


int [] array = new int [A];
FillArray (array);

int Max=array[0]; //ищем максимальное число в массиве
for( int i=1; i<array.Length; i++)
{
    if(Max<array[i])
    {
        Max=array[i];
    }
}
//Console.WriteLine($"Max= {Max}");

int Min=array[0]; //ищем минимальное число
for( int i=1; i<array.Length; i++)
{
    if(Min>array[i])
    {
        Min=array[i];
    }
}
Console.WriteLine($"Max-Min={Max}-{Min}={Max-Min} ");
