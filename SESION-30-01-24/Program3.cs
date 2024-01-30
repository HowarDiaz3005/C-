Console.Write("/\n=================="); 
Console.Write("/\nIngrese su nombre:");
Console.Write("/\n==================");
String name = Console.ReadLine();
Console.Write("/\n==================");
Console.Write("/\nIngrese su edad:");
Console.Write("/\n==================");
String ed = Console.ReadLine();
Console.Write("/\n==================");
Console.Write("/\nIngrese su sexo ( Hombre = H | Mujer = F):");
Console.Write("/\n==============--====");
String sex = Console.ReadLine();
 //======================
 // Formulacion de datos.
 //======================
 if (sex == "M" || sex == "m")
{
    Console.WriteLine("\nEl Sr. {0} ha sido registrado ",name); // v
}
 else
{
    Console.WriteLine("La Sr. {0} ha sido registrada", name); // m
}
 Console.WriteLine("\n\n");
Console.WriteLine("\n------>Terminado");
Console.ReadKey();