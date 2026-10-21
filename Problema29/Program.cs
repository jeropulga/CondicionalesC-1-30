Console.Write("Rol (admin, instructor, aprendiz): ");
string rol = Console.ReadLine()!.Trim().ToLower();
Console.Write("Hora de llegada (0 a 23): ");
int hora = int.Parse(Console.ReadLine()!);

bool permitido = rol switch
{
    "admin" => hora >= 0 && hora <= 23,
    "instructor" => hora >= 6 && hora <= 21,
    "aprendiz" => hora >= 6 && hora <= 18,
    _ => false
};
Console.WriteLine(permitido ? "Acceso permitido" : "Acceso denegado");
