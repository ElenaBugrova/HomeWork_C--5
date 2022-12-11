// Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

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
if (A<=1)
{
    Console.Write("Нет элементов для подсчета");
}


int [] array = new int [A];
FillArray (array);
int SumElNotEvenIndex=0;
for(int i=1; i<array.Length; i=i+2)
{
    SumElNotEvenIndex = SumElNotEvenIndex +array[i];
}
Console.Write (SumElNotEvenIndex);




