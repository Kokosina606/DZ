Console.Clear();

Console.WriteLine("Введите число: ");

    int N =Convert.ToInt32(Console.ReadLine());
    int i =1;

      Console.WriteLine("Чётные числа от 1 до " + N + ":");
    
    while (i <= N)
    {
      if (i % 2 !=1)
      {Console.WriteLine(i + ",");
      i++;}
      else
      i++;
    }
