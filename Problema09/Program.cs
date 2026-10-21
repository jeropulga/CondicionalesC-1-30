Console.Write("Ingresa un año: ");
int anio = int.Parse(Console.ReadLine()!);
bool esBisiesto = (anio % 4 == 0 && anio % 100 != 0) || anio % 400 == 0;

Console.WriteLine(esBisiesto ? "Bisiesto" : "No bisiesto");
