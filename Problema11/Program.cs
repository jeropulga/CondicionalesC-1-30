Console.Write("Estado (Rojo, Amarillo, Verde): ");
string entrada = Console.ReadLine()!;
if (!Enum.TryParse<EstadoSemaforo>(entrada, true, out EstadoSemaforo estado) || !Enum.IsDefined(estado))
{
    Console.WriteLine("Estado no reconocido");
}
else
{
    switch (estado)
    {
        case EstadoSemaforo.Rojo: Console.WriteLine("Deténgase"); break;
        case EstadoSemaforo.Amarillo: Console.WriteLine("Precaución, prepárese para detenerse"); break;
        case EstadoSemaforo.Verde: Console.WriteLine("Avance"); break;
    }
}

enum EstadoSemaforo { Rojo, Amarillo, Verde }
