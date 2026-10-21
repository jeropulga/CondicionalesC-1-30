Console.Write("Jugada del jugador 1 (piedra, papel, tijera): ");
string jugador1 = Console.ReadLine()!.Trim().ToLower();
Console.Write("Jugada del jugador 2 (piedra, papel, tijera): ");
string jugador2 = Console.ReadLine()!.Trim().ToLower();

if (jugador1 == jugador2)
{
    Console.WriteLine("Empate");
}
else if ((jugador1 == "piedra" && jugador2 == "tijera") ||
         (jugador1 == "tijera" && jugador2 == "papel") ||
         (jugador1 == "papel" && jugador2 == "piedra"))
{
    Console.WriteLine("Gana el jugador 1");
}
else if ((jugador2 == "piedra" || jugador2 == "papel" || jugador2 == "tijera") &&
         (jugador1 == "piedra" || jugador1 == "papel" || jugador1 == "tijera"))
{
    Console.WriteLine("Gana el jugador 2");
}
else
{
    Console.WriteLine("Jugada no válida");
}
