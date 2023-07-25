// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// void InputMatrixDouble(double[,] matrix)
// {
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
// matrix[i, j] = Convert.ToDouble(new Random().Next(-100,1000))/100;
// Console.Write($"{matrix[i, j]} \t");
// }
// Console.WriteLine();
// }
// }

// Console.Clear();
// Console.Write("Введите размеры матрицы через пробел: "); // 5 4 2 1
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// double[,] matrix = new double[size[0], size[1]];
// InputMatrixDouble(matrix);
// Console.WriteLine("\n");


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


// void InputMatrixInt(int[,] matrix)
// {
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
// matrix[i, j] = new Random().Next(0, 10);
// Console.Write($"{matrix[i, j]} \t");
// }
// Console.WriteLine();
// }
// }

// Console.Clear();
// Console.Write("Введите размеры матрицы через пробел: "); // 5 4 2 1
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// InputMatrixInt(matrix);
// Console.WriteLine("\n");

// Console.Write("Введите позицию элемента в двумерном массиве: "); // 5 4 2 1
// int[] position = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// if ((position[0]<size[0])&&(position[1]<size[1]))
// Console.WriteLine(matrix[position[0], position[1]]);
// else
// Console.WriteLine("Такого числа нет в массиве");


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6;
// 3.

// void InputMatrixInt(int[,] matrix)
// {
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
// matrix[i, j] = new Random().Next(0, 10);
// Console.Write($"{matrix[i, j]} \t");
// }
// Console.WriteLine();
// }
// }

// Console.Clear();
// Console.Write("Введите размеры матрицы через пробел: "); // 5 4 2 1
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// InputMatrixInt(matrix);
// Console.WriteLine("\n");

// double [] sredarifm=new double[size[0]];
// double sumstolb =0;
// for (int i=0; i<size[1]; i++)
//     {sumstolb=0;
//         for (int j=0; j<size[0]; j++)
//         {sumstolb=sumstolb+matrix[j,i];
//         }
//     sredarifm[i] = sumstolb/size[0];
//     Console.Write($"{sredarifm[i]} \t");    
//     }
