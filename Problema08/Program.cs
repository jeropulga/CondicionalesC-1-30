Console.Write("Ingresa una letra minúscula: ");
string entrada = Console.ReadLine()!;

if (entrada.Length != 1 || !char.IsLetter(entrada[0]) || entrada[0] > 'z')
{
    Console.WriteLine("No es una letra");
}
else if ("aeiou".Contains(entrada[0]))
{
    Console.WriteLine("Es vocal");
}
else
{
    Console.WriteLine("Es consonante");
}
