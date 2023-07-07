
Console.WriteLine("Введите три числа: ");

    int a=Convert.ToInt32(Console.ReadLine());
    int b=Convert.ToInt32(Console.ReadLine());
    int c=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    
    if (a >= b)
    {
        if (c>=a) Console.WriteLine(c);
        else Console.WriteLine(a);
    }
    else 
    {
        if (c>=b) Console.WriteLine(c);
        else Console.WriteLine(b);
    }
