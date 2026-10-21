Console.Write("Valor de la compra: $");
decimal compra = decimal.Parse(Console.ReadLine()!);
Console.Write("¿Es cliente frecuente? (s/n): ");
bool frecuente = Console.ReadLine()!.Trim().ToLower() == "s";
decimal porcentaje;

if (compra < 100000)
    porcentaje = 0;
else if (compra < 200000)
    porcentaje = 5;
else if (compra < 500000)
    porcentaje = 10;
else
    porcentaje = 15;

if (frecuente && compra >= 100000)
    porcentaje += 5;

decimal total = compra * (1 - porcentaje / 100);
Console.WriteLine($"Compra: ${compra:N0}");
Console.WriteLine($"Descuento: {porcentaje}%");
Console.WriteLine($"Total a pagar: ${total:N0}");
