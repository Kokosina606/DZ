

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// void VvodMassiva (int [] array)
// { for (int i = 0; i < array.Length; i++)
// array [i]=new Random (). Next (100,1000);
// }
// void SchetchikPolozhit (int [] array)
// {
// int n=0;
// for (int i = 0; i < array.Length; i++)
// {if ((array [i]%2)==0)
// n++;}
// Console.WriteLine("Количество четных чисел: "+n);
// }


// Console.Clear();
// Console.Write("Введите кол-во элементов в массиве: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// VvodMassiva(array);
// Console.WriteLine($"[{string.Join(", ", array)}]");
// SchetchikPolozhit(array);




// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-9, 10); //[-9;9]
// }

// void SumNechet(int[] array)
// {
//     int sumnechet=0;
//     for (int i=0; i<array.Length; i=i+2)
//     sumnechet=sumnechet+array[i];
//     Console.WriteLine("Сумма нечетных элементов массива: "+sumnechet);
// }

// Console.Clear();
// Console.Write("Введите кол-во элементов в массиве: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"[{string.Join(", ", array)}]");
// SumNechet(array);
// Console.WriteLine("Конец программы 36");


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

void InputArrayDouble(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Convert.ToDouble(new Random().Next(10,1000))/100; //[-9;9]
}


Console.Clear();
Console.Write("Введите кол-во элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArrayDouble(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {if (array[i]>max)
    {max=array[i];}} 
    Console.WriteLine("Максимальное число в массиве:"+max);
double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {if (array[i]<min)
    {min=array[i];}}
    Console.WriteLine("Минимальное число в массиве:"+min);
Console.WriteLine("Разница между минимальным и максимальным значением составляет: "+Math.Round(Convert.ToDouble(max-min),2));