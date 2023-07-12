
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да


// Console.Write("Введите пятизначное число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int N1 = (N%100000-N%10000)/10000;
// int N2 = (N%10000-N%1000)/1000;
// int N4 = (N%100-N%10)/10;
// int N5 = (N%10-N%1);
// int N0 = (N%1000000-N%100000)/100000;

// if (N0 != 0||N1==0)
//     Console.WriteLine("Введено неверное число");
// else if (N1==N5 && N2==N4)
//         Console.WriteLine("Число является палиндромом");
// else
//         Console.WriteLine("Число не является  палиндромом");
// Console.WriteLine("");        





// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.Write("Ax = ");
// int Ax = Convert.ToInt32(Console.ReadLine());
// Console.Write("Ay = ");
// int Ay = Convert.ToInt32(Console.ReadLine());
// Console.Write("Az = ");
// int Az = Convert.ToInt32(Console.ReadLine());
// Console.Write("Bx = ");
// int Bx = Convert.ToInt32(Console.ReadLine());
// Console.Write("By = ");
// int By = Convert.ToInt32(Console.ReadLine());
// Console.Write("Bz = ");
// int Bz = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow(Ax - Bx, 2) + Math.Pow(Ay - By, 2) + Math.Pow(Az - Bz, 2)), 3));
// Console.WriteLine("");





// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= n; i++)
//     Console.WriteLine($"{Math.Pow(i, 3)}");
// Console.WriteLine("");

