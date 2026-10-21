Console.Write("Estatura en metros: ");
double estatura = double.Parse(Console.ReadLine()!);
Console.Write("Edad: ");
int edad = int.Parse(Console.ReadLine()!);
Console.Write("¿Va acompañada por un adulto? (s/n): ");
bool acompanada = Console.ReadLine()!.Trim().ToLower() == "s";

bool puedeSubir = estatura >= 1.40 && (edad >= 12 || acompanada);
Console.WriteLine(puedeSubir ? "Puede subir" : "No puede subir");
