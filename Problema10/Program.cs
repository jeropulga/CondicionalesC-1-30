using System.Globalization;

Console.WriteLine("Tipo de dato: texto, entero, decimal o booleano");
Console.Write("Tipo: ");
string tipo = Console.ReadLine()!.Trim().ToLower();
Console.Write("Valor: ");
string valor = Console.ReadLine()!;
object dato;

switch (tipo)
{
    case "texto": dato = valor; break;
    case "entero": dato = int.Parse(valor); break;
    case "decimal": dato = double.Parse(valor, CultureInfo.CurrentCulture); break;
    case "booleano": dato = bool.Parse(valor); break;
    default: dato = new DateTime(); break;
}

switch (dato)
{
    case string texto: Console.WriteLine($"Texto de {texto.Length} caracteres"); break;
    case int entero: Console.WriteLine($"Entero: {entero}"); break;
    case double decimalNumero: Console.WriteLine($"Decimal: {decimalNumero}"); break;
    case bool booleano: Console.WriteLine($"Booleano: {booleano}"); break;
    default: Console.WriteLine("Tipo no reconocido"); break;
}
