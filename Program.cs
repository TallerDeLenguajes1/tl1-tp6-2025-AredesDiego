int eleccion;

do
{
    Console.WriteLine("Ingrese el primer número:");
    string? entrada1 = Console.ReadLine();
    if (!double.TryParse(entrada1, out double a))
    {
        Console.WriteLine("Entrada no válida. Intente de nuevo.");
        continue;
    }

    Console.WriteLine("Ingrese el segundo número:");
    string? entrada2 = Console.ReadLine();
    if (!double.TryParse(entrada2, out double b))
    {
        Console.WriteLine("Entrada no válida. Intente de nuevo.");
        continue;
    }

    Console.WriteLine("-1 Sumar \n-2 Restar \n-3 Multiplicar \n-4 Dividir \n-5 Valor Absoluto \n-6 Cuadrado \n-7 raizCuadrada \n-8 seno \n-9 coseno \n-10 parteEnteraDeTipoFloat \n-0 Salir");
                            
    string? decision = Console.ReadLine();
    if (!int.TryParse(decision, out eleccion))
    {
        Console.WriteLine("Entrada no válida. Intente de nuevo.");
        continue;
    }

    double resultado = 0;

    switch (eleccion)
    {
        case 1:
            resultado = Sumar(a, b);
            break;
        case 2:
            resultado = Restar(a, b);
            break;
        case 3:
            resultado = Multiplicar(a, b);
            break;
        case 4:
            resultado = Dividir(a, b);
            break;
        case 5:
            resultado = valorAbsoluto(a);
            break;
        case 6:
            resultado = cuadrado(a);
            break;
        case 7:
            resultado = raizCuadrada(a);
            break;
        case 8:
            resultado = seno(a);
            break;
        case 9:
            resultado = coseno(a);
            break;
        case 10:
            resultado = (int)parteEnteraDeTipoFloat(a);
            break;

        case 0:
            Console.WriteLine("Saliendo...");
            return;
        default:
            Console.WriteLine("Opción no válida. Intente de nuevo.");
            continue;
    }

    Console.WriteLine($"Resultado: {resultado}");
    Console.WriteLine("Presione cualquier tecla para continuar o '0' para salir.");
    string? salir = Console.ReadLine();
    if (salir == "0")
        break;

} while (true);


double Sumar(double a , double b)
{
    return a + b;
}
double Restar(double a , double b)
{
    return a - b;
}
double Multiplicar(double a , double b)
{
    return a * b;
}
double Dividir(double a , double b)
{
    return a / b;
}

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
double parteEnteraDeTipoFloat(double numero)
{
    return (int)Math.Floor(numero);
}
double maximo(double a, double b)
{
    if (a > b)
        return a;
    return b;
}
double minimo(double a, double b)
{
    if (a > b)
        return a;
    return b;
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

