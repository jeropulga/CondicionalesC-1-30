Console.Write("Velocidad medida en km/h: ");
int velocidad = int.Parse(Console.ReadLine()!);
string sancion;

if (velocidad < 0)
    sancion = "Lectura inválida";
else if (velocidad <= 50)
    sancion = "Sin infracción";
else if (velocidad <= 70)
    sancion = "Multa leve";
else if (velocidad <= 90)
    sancion = "Multa grave";
else
    sancion = "Multa gravísima e inmovilización";

Console.WriteLine(sancion);
