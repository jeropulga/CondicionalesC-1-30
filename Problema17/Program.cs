Console.Write("Comando (play, pause, stop, next): ");
string comando = Console.ReadLine()!.Trim().ToLower();
string mensaje = comando switch
{
    "play" => "Reproduciendo...",
    "pause" => "En pausa",
    "stop" => "Detenido",
    "next" => "Siguiente canción",
    _ => "Comando no reconocido"
};
Console.WriteLine(mensaje);
