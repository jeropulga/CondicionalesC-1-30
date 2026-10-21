Console.Write("Categoría del vehículo (M, A, B, C): ");
string categoria = Console.ReadLine()!.Trim().ToUpper();
int tarifa = categoria switch
{
    "M" => 0,
    "A" => 12000,
    "B" => 25000,
    "C" => 38000,
    _ => throw new ArgumentException("Categoría desconocida")
};
Console.WriteLine($"Categoría {categoria} - Tarifa: ${tarifa}");
