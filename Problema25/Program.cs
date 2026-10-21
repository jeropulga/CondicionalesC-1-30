Console.Write("Índice de calidad del aire (ICA): ");
int ica = int.Parse(Console.ReadLine()!);
string categoria;

if (ica < 0)
    categoria = "Valor inválido";
else if (ica <= 50)
    categoria = "Buena";
else if (ica <= 100)
    categoria = "Moderada";
else if (ica <= 150)
    categoria = "Dañina para grupos sensibles";
else if (ica <= 200)
    categoria = "Dañina";
else
    categoria = "Muy dañina";

Console.WriteLine(categoria);
