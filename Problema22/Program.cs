Console.Write("Primer número entero: ");
int primero = int.Parse(Console.ReadLine()!);
Console.Write("Segundo número entero: ");
int segundo = int.Parse(Console.ReadLine()!);
Console.Write("Operador (+, -, *, /): ");
string operador = Console.ReadLine()!;
double resultado;

switch (operador)
{
    case "+": resultado = primero + segundo; break;
    case "-": resultado = primero - segundo; break;
    case "*": resultado = primero * segundo; break;
    case "/":
        if (segundo == 0) throw new DivideByZeroException("No se puede dividir entre cero");
        resultado = (double)primero / segundo;
        break;
    default: throw new NotSupportedException("Operador no soportado");
}
Console.WriteLine($"{primero} {operador} {segundo} = {resultado}");
