using System.Globalization;

Console.Write("Peso en kg: ");
double peso = double.Parse(
    Console.ReadLine()!.Replace(',', '.'),
    CultureInfo.InvariantCulture
);

Console.Write("Estatura en metros: ");
double estatura = double.Parse(
    Console.ReadLine()!.Replace(',', '.'),
    CultureInfo.InvariantCulture
);

if (estatura <= 0)
{
    Console.WriteLine("La estatura debe ser mayor que cero.");
}
else
{
    double imc = peso / (estatura * estatura);
    string categoria;

    if (imc < 18.5)
        categoria = "Bajo peso";
    else if (imc < 25)
        categoria = "Peso normal";
    else if (imc < 30)
        categoria = "Sobrepeso";
    else
        categoria = "Obesidad";

    Console.WriteLine($"IMC: {imc:F1} - {categoria}");
}