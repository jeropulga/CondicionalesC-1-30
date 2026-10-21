Console.Write("Día de la semana (1 lunes, 7 domingo): ");
int dia = int.Parse(Console.ReadLine()!);
string resultado = dia switch
{
    >= 1 and <= 5 => "Día hábil",
    6 or 7 => "Fin de semana",
    _ => "Día inválido"
};
Console.WriteLine(resultado);
