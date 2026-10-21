Console.Write("Nota 1 (0 a 100): ");
double nota1 = double.Parse(Console.ReadLine()!);
Console.Write("Nota 2 (0 a 100): ");
double nota2 = double.Parse(Console.ReadLine()!);
Console.Write("Nota 3 (0 a 100): ");
double nota3 = double.Parse(Console.ReadLine()!);
double promedio = (nota1 + nota2 + nota3) / 3;

char letra;
if (promedio >= 90) letra = 'A';
else if (promedio >= 80) letra = 'B';
else if (promedio >= 70) letra = 'C';
else if (promedio >= 60) letra = 'D';
else letra = 'F';

string retroalimentacion = letra switch
{
    'A' => "Desempeño excelente",
    'B' or 'C' => "Buen desempeño, sigue así",
    'D' => "Aprobado, refuerza los temas",
    _ => "Debe presentar plan de mejoramiento"
};
string estado = promedio >= 60 ? "Aprobado" : "Reprobado";
string mencion = promedio == 100 ? " | ¡Mención de honor!" : "";
Console.WriteLine($"Promedio: {promedio:F1} | Letra: {letra} | {retroalimentacion} | {estado}{mencion}");
