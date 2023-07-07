Console.WriteLine("Введите два числа: ");

    int a=Convert.ToInt32(Console.ReadLine());
    int b=Convert.ToInt32(Console.ReadLine());
        if (a>b)
            Console.WriteLine("max " + a); 
        else if (a==b)
            Console.WriteLine("egual");
        else
            Console.WriteLine("max " + b);
