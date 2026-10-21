Console.Write("Ingresa la nota final (0 a 5): ");
decimal nota = decimal.Parse(Console.ReadLine()!);
string estado = nota >= 3.0m ? "Aprobado" : "Reprobado";
Console.WriteLine($"Nota: {nota} - {estado}");
