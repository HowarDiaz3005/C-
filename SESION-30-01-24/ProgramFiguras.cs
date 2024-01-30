Console.Write("\n============================");
Console.Write("\nBIENVENIDO A SU CALCULA DIBUJO");
Console.Write("\n============================");
Console.Write("\n1- Equilatero\n2- Isósceles\n3-Rectángulo");
Console.Write("\n===========================");
int op = int.Parse(Console.ReadLine());
switch (op)
{
    case 1:
        Console.Write("\nIngrese el tamaño de un lado del Equilatero");
        int lado1 = int.Parse(Console.ReadLine());
        //======================
        // Formulacion de datos.
        //======================}
        int result1 = (lado1 *3);
        Console.Write("\nEl perimetro del Equilatero es:"+ result1);
        break;
    //=================================================================
    case 2:
        Console.Write("\nIngrese el tamaño de un lado del Isósceles");
        int lado2 = int.Parse(Console.ReadLine());
        Console.Write("\nIngrese la base de su  Triangulo Isósceles");
        int lado3 = int.Parse(Console.ReadLine());
        //======================
        // Formulacion de datos.
        //======================}
        int result2 = ((lado2 * 2)+ lado3);
        Console.Write("\nEl perimetro del Equilatero es:" + result2);
        break;
    //=================================================================
    case 3:
        Console.Write("\nIngrese el tamaño de un lado del");
        int lado3 = int.Parse(Console.ReadLine());
        //======================
        // Formulacion de datos.
        //======================}
        int result3 = (lado3 * 3);
        Console.Write("\nEl perimetro del Equilatero es:" + result3);
        break;
    //=================================================================
}

