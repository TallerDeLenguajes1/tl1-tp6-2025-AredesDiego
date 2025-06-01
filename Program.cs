/*Console.WriteLine("Ingrese valor del número:");
string? entrada = Console.ReadLine();

if (!string.IsNullOrEmpty(entrada))
{
    int numero = int.Parse(entrada);

    if (numero > 0)
    {
        int invertido = 0;
        while (numero > 0)
        {
            int digito = numero % 10;
            invertido = (invertido * 10) + digito;
            numero /= 10;
        }
         Console.WriteLine($"Número invertido: {invertido}");
    }
}
else
{
    Console.WriteLine("No ingresaste ningún número.");
}
*/

Console.WriteLine("-1 Sumar \n-2 Restar \n-3 Multiplicar \n-4 Dividir \n-0 Salir \n Ponga su respuesta:");
string? entrada = Console.ReadLine();

if (!int.TryParse(entrada, out int numero))
{
    Console.WriteLine("\nEntrada no válida. Intente de nuevo.\n");
}
    
Console.WriteLine("Ingrese el número:");
string? entrada2 = Console.ReadLine();

if (!int.TryParse(entrada2, out int b))
{
    Console.WriteLine("Entrada no válida. Intente de nuevo.\n");
}

Console.WriteLine("Ingrese el Primer número:");
string? entrada3 = Console.ReadLine();

if (!int.TryParse(entrada3, out int c))
{
    Console.WriteLine("Entrada no válida. Intente de nuevo.\n");
}

Console.WriteLine("Ingrese el segundo número:");
string? entrada4 = Console.ReadLine();

if (!int.TryParse(entrada4, out int d))
{
    Console.WriteLine("Entrada no válida. Intente de nuevo.\n");
}

Console.WriteLine("Su numero maximo es:" + maximo(c,d));
Console.WriteLine("Su numero maximo es:" + minimo(c,d));

double valorAbsoluto(double numero)
{
    return Math.Abs(numero);
}
double cuadrado(double numero)
{
    return numero * numero;
}
double raizCuadrada(double numero)
{
    return Math.Sqrt(numero);
}
double seno(double numero)
{
    return Math.Sin(numero);
}
double coseno(double numero)
{
    return Math.Cos(numero);
}
int parteEnteraDeTipoFloat(double numero)
{
    return (int)Math.Floor(numero);
}
int maximo(int a, int b)
{
    if (a > b)
        return a;
    return b;
}
int minimo(int a, int b)
{
    if (a > b)
        return a;
    return b;
}