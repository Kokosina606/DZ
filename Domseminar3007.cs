
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

/*
void ShowNumbers (int N)
{
    Console.Write($"{N} ");
    if (N>1)
    {N-=1;
    ShowNumbers(N);}
}

Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
ShowNumbers(N);
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

/*
int SumNumbers (int N,int M,int Sum)
{
    if (Math.Min(N,M)!=Math.Max(N,M))
    {Sum+=Math.Min(N,M);
        if (Math.Min(N,M)==N)
        N+=1;
        else
        M+=1;
    return SumNumbers(Math.Min(N,M),Math.Max(N,M),Sum);}
    else return Sum+N;
}

Console.WriteLine("Введите два числа через пробел:");
int[] Numbers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
Console.WriteLine("Сумма элементов: "+SumNumbers(Numbers[0],Numbers[1],0));
*/


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

/*

int Ackerman (int M, int N)
{
    if (M==0)
    return (N+1);
    else if (N==0)
    return Ackerman (M-1,1);
    else
    return Ackerman(M-1,Ackerman(M,N-1));
}

Console.WriteLine("Введите два числа через пробел:");
int[] Numbers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
Console.WriteLine("A(m,n): "+Ackerman(Numbers[0],Numbers[1]));
/*
