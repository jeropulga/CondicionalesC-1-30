Console.Write("Ingresa el nivel de batería (0 a 100): ");
int nivel = int.Parse(Console.ReadLine()!);

if (nivel < 15)
{
    Console.WriteLine("Batería baja: conecte el cargador");
}
Console.WriteLine($"Nivel actual: {nivel} %");
