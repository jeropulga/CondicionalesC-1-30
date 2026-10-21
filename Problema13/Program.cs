Console.Write("Ingresa el código del país (dos letras): CO, MX, AR, PE, CL : ");
string codigo = Console.ReadLine()!.Trim().ToUpper();
string pais = codigo switch
{
    "CO" => "Colombia",
    "MX" => "México",
    "AR" => "Argentina",
    "PE" => "Perú",
    "CL" => "Chile",
    _ => "País no registrado"
};
Console.WriteLine(pais);
