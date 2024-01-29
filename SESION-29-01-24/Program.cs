
    int nro;
    Console.Title = "BUSQUEDA DE NUMEROS PARES";
    Console.Write("/\nIngrese un numero");
    nro = int.Parse(Console.ReadLine());    
    if (nro < 0)
    {
        Console.Write("\n\tNumero Negativo..... Ingrese un numero positivo");
    }
    else if (nro % 2 == 0)
    {
        Console.Write("\n\tEl numero (" + nro + ") es par.");
        if (nro >= 10 && nro <= 100)
        {
            Console.Write("\n\tEl numero (" + nro + ") se encuentra en el rango[10 - 100]");
        }
    }
    else
    {
        Console.Write("El numero ingresado es impar..");

    }
    Console.ReadKey();  
