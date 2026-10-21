Console.Write("Día de la semana: ");
string dia = Console.ReadLine()!.Trim().ToLower();
Console.Write("¿Es estudiante? (s/n): ");
bool estudiante = Console.ReadLine()!.Trim().ToLower() == "s";
int tarifa;

if (dia == "martes")
    tarifa = 7000;
else if (dia == "sábado" || dia == "sabado" || dia == "domingo")
    tarifa = 15000;
else if (dia == "lunes" || dia == "miércoles" || dia == "miercoles" || dia == "jueves" || dia == "viernes")
    tarifa = estudiante ? 9000 : 12000;
else
    throw new ArgumentException("Día no reconocido");

Console.WriteLine($"Tarifa: ${tarifa}");
