
Console.Write("\n============================");
Console.Write("\nIngrese el numero del dia:");
Console.Write("\n============================");
int nroDia = int.Parse(Console.ReadLine());
Console.Write("\n===========================");
Console.Write("\nIngrese el numero del mes:");
Console.Write("\n===========================");
int nroMes = int.Parse(Console.ReadLine());
//=====================
//Formulacion de datos.
//=====================
if (nroDia >= 1 && nroDia <= 31 && nroMes >= 1 && nroMes <= 12)
{
    int Dda = 0;
    switch (nroMes)
    {
        case 1:
            Dda = nroDia;
            break;
        //=============================
        case 2:
            Dda = nroDia + 31;
            break;
        //=============================
        case 3:
            Dda = nroDia + 59;
            break;
        //=============================
        case 4:
            Dda = nroDia + 90;
            break;
        //=============================
        case 5:
            Dda = nroDia + 120; 
            break;
        //=============================
        case 6:
            Dda = nroDia + 151;
            break;
        //=============================
        case 7:
            Dda = nroDia + 181;
            break;
        //=============================
        case 8:
            Dda = nroDia + 212;
            break;
        //=============================
        case 9:
            Dda = nroDia + 243;
            break;
        //=============================
        case 10:
            Dda = nroDia + 273;
            break;
        //=============================
        case 11:
            Dda = nroDia + 304;
            break;
        //=============================
        case 12:
            Dda = nroDia + 334;
            break;
        //=============================     
    }
    Console.Write("\n======================================");
    Console.WriteLine("\nEl {0} del {1} es el dia {2} del año.", nroDia, nroMes, Dda);
    Console.Write("\n======================================");
}
else 
{
    Console.WriteLine("\nDatos ingresadoas no validos.");
}

