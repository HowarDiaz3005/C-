//==================================================
//Inicializando variables....
Double Rad;
Double Peri, A, Vol1;
Double pi = 3.1416;
//==================================================
//==================================================
Console.WriteLine("Ingrese el radio");
Rad = Double.Parse(Console.ReadLine());
//==================================================
//==================================================
Peri = (2 * pi * Rad);
A = (pi * Rad * Rad);
Vol1 = (4 * pi * Rad * Rad * Rad / 3);
//==================================================
//==================================================
Console.WriteLine("El perimetro de la circunferencia :" + Peri);
Console.WriteLine("El area del circulo :" + A);
Console.WriteLine("El volumen de la esfera es :" + Vol1);
//==================================================
//==================================================