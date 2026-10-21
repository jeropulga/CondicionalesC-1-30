Console.Write("Usuario: ");
string usuario = Console.ReadLine()!;

if (usuario != "aprendiz")
{
    Console.WriteLine("Usuario no encontrado");
}
else
{
    Console.Write("Contraseña: ");
    string clave = Console.ReadLine()!;
    if (clave == "Sena2026")
        Console.WriteLine("Bienvenido");
    else
        Console.WriteLine("Contraseña incorrecta");
}
