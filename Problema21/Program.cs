Console.Write("Cantidad de artículos: ");
int cantidad = int.Parse(Console.ReadLine()!);
string palabra = cantidad == 1 ? "artículo" : "artículos";
Console.WriteLine($"Tienes {cantidad} {palabra} en el carrito");
