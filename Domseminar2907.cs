

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

/*
int [,] Create2dArray (int rows, int columns)
{
int [,] createdArray = new int[rows, columns];
for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
    createdArray[i,j] = new Random().Next(0,10);
return createdArray;
}

void Pechat2dArray (int [,] Array)
{
for (int i = 0; i < Array.GetLength(0); i++)
    {
    for (int j = 0; j < Array.GetLength(1); j++)
        {
        Console.Write (Array[i,j] + " ");
        }
    Console.WriteLine();
    }
Console.WriteLine();
}

void Sortirovkastrok2DArrayPoUbivaniy (int [,] Array)
{int[] stroka = new int[Array.GetLength(1)];
for (int j=0; j<Array.GetLength(0); j++)
    {
        for (int i = 0;i<Array.GetLength(1);i++)
            stroka[i]=Array[j,i];

        int n=0;
        do 
        {
            for (int i = 0; i < (stroka.Length-1); i++)
            {
            int temp = stroka[i];
            if (temp<=stroka[i+1])
            {stroka[i] = stroka[i+1];
            stroka[i+1] = temp;}
            }
        n++;
        } while (n<(stroka.Length-1));
        for (int i = 0;i<Array.GetLength(1);i++)
        Array[j,i]=stroka[i];
        
    }
}

Console.Clear();
Console.Write("Введите размеры матрицы: "); // 5 4 2 1
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int [,] matrix= Create2dArray(size[0], size[1]);
Pechat2dArray(matrix);
for (int i = 0;i<matrix.GetLength(0);i++)
Sortirovkastrok2DArrayPoUbivaniy(matrix);
Pechat2dArray(matrix);
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

/*
int [,] Create2dArray (int rows, int columns)
{
int [,] createdArray = new int[rows, columns];
for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
    createdArray[i,j] = new Random().Next(0,10);
return createdArray;
}

void Pechat2dArray (int [,] Array)
{
for (int i = 0; i < Array.GetLength(0); i++)
    {
    for (int j = 0; j < Array.GetLength(1); j++)
        {
        Console.Write (Array[i,j] + " ");
        }
    Console.WriteLine();
    }
Console.WriteLine();
}

void Pechat1DArray (int [] array)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write (array[i] + " ");
}
Console.WriteLine();
}

void Work (int [,] array)
{int [] sum = new int[array.GetLength(0)];
int temp =0;
int maxsum=0;
int maxsumindex=0;
int minsum=100;
int minsumindex=0;
for (int i = 0;i<array.GetLength(0);i++)
    {    
        temp=0;
        for (int j = 0;j<array.GetLength(1);j++)
            {
            temp=temp+array[i,j];
            }
        sum [i]= temp;
        if (maxsum<sum[i])
            {
            maxsum=sum[i];
            maxsumindex=i+1;
            }
        if (minsum>sum[i])
            {
            minsum=sum[i];
            minsumindex=i+1;
            }            
    }
Console.WriteLine("Наименьшая сумма элементов в "+minsumindex+" строке:"+sum[minsumindex-1]);
}

Console.Clear();
Console.Write("Введите размеры матрицы: "); // 5 4 2 1
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int [,] matrix= Create2dArray(size[0], size[1]);
Console.WriteLine("\n");
Pechat2dArray(matrix);
Work(matrix);
*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


/*
int [,] Create2dArray (int rows, int columns)
{
int [,] createdArray = new int[rows, columns];
for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
    createdArray[i,j] = new Random().Next(0,10);
return createdArray;
}

void Pechat2dArray (int [,] Array)
{
for (int i = 0; i < Array.GetLength(0); i++)
    {
    for (int j = 0; j < Array.GetLength(1); j++)
        {
        Console.Write (Array[i,j] + " ");
        }
    Console.WriteLine();
    }
Console.WriteLine();
}

void ProizvedenieMatrix (int [,] array1,int [,] array2)
{
if (array1.GetLength(1)==array2.GetLength(0))
{   int [,] resultmatrix = new int[array1.GetLength(0),array2.GetLength(1)];
    int temp=0;
    for (int i = 0;i<resultmatrix.GetLength(0);i++)
        {    
            for (int j = 0;j<array2.GetLength(1);j++)
                {
                    for (int k = 0;k<array1.GetLength(1);k++)
                    {
                    temp=temp+array1[i,k]*array2[k,j];
                    }
                resultmatrix[i,j]=temp;
                temp=0;
                }
        }    
    Pechat2dArray(resultmatrix);
}
else
Console.WriteLine("Ошибка. Число столбцов первой матрицы должно быть равно числу строк второй матрицы.");
}



Console.Clear();
Console.Write("Введите размеры первой матрицы: "); // 5 4 2 1
int[] size1 = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
Console.Write("Введите размеры второй матрицы: "); // 5 4 2 1
int[] size2 = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int [,] matrix1= Create2dArray(size1[0], size1[1]);
int [,] matrix2= Create2dArray(size2[0], size2[1]);
Console.WriteLine("\n");
Pechat2dArray(matrix1);
Pechat2dArray(matrix2);
ProizvedenieMatrix(matrix1, matrix2);
*/

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

/*

int[] UniqueRandom1099 (int size)
{
    int [] uniqueRandArray =new int [size];
        for (int i = 0; i < size; i++)
        {
        uniqueRandArray[i]=new Random().Next(10,99);
        if (i!=0)
        {
            for (int ran = 0; ran < i; ran++)
            {
                while (uniqueRandArray[ran]==uniqueRandArray[i])
                {
                    uniqueRandArray[ran]=new Random().Next(10,99);
                }
            }
        } 
    
    }
    return uniqueRandArray;
}

int [,,] Create3dArrayBezPovtorov (int rows, int columns, int planes)
{
int [,,] createdArray = new int[rows, columns, planes];
int r=0;
int[]rand=UniqueRandom1099(rows*columns*planes);

for (int k = 0; k < planes; k++)
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
        if ((r>=0)&&(r<(rows*columns*planes)))
        {createdArray[i,j,k] = rand[r];
        r++;}
return createdArray;
}

void Pechat3dArraySIndeksom (int [,,] Array)
{
for (int k = 0; k < Array.GetLength(2); k++)
    {
    for (int i = 0; i < Array.GetLength(0); i++)
        {
        for (int j = 0; j < Array.GetLength(1); j++)
            {
            Console.Write (Array[i,j,k] + "("+i+","+j+","+k+")");
            }
        Console.WriteLine();
        }
    Console.WriteLine();
    }
Console.WriteLine();    
}

Console.Clear();
Console.Write("Введите размеры 3-мерного массива: "); // 5 4 2 1
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
if ((size[0]* size[1]* size[2])>90)
System.Console.WriteLine("Невозможно заполнить массив уникальными значениями");
else
{
int [,,] matrix= Create3dArrayBezPovtorov(size[0], size[1], size[2]);
Console.WriteLine("\n");
Pechat3dArraySIndeksom(matrix);
}
*/

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

/*
void Pechat2dArray (int [,] Array)
{
for (int i = 0; i < Array.GetLength(0); i++)
    {
    for (int j = 0; j < Array.GetLength(1); j++)
        {
        if(Array[i,j]<10)
        Console.Write ("0"+Array[i,j] + " ");
        else
        Console.Write (Array[i,j] + " ");
        }
    Console.WriteLine();
    }
Console.WriteLine();
}

int[,] array = new int[4, 4];
int count=1;
for (int i = 0; i < array.GetLength(1); i++) 
{array[0,i]=count;
count++;}
for (int j = 1; j < array.GetLength(0); j++)
{array[j,(array.GetLength(0)-1)]=count;
count++;}
for (int i = (array.GetLength(1)-1); i > 0; i--) 
{array[3,i-1]=count;
count++;}
for (int j = (array.GetLength(0)-1); j > 1; j--)
{array[j-1,0]=count;
count++;}

for (int i = 0; i < (array.GetLength(1)-2); i++) 
{array[1,i+1]=count;
count++;}
for (int j = 1; j < array.GetLength(0)-2; j++)
{array[j+1,(array.GetLength(0)-2)]=count;
count++;}
for (int i = (array.GetLength(1)-2); i > 1; i--) 
{array[2,i-1]=count;
count++;}
Pechat2dArray(array);
*/


