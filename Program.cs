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

int eleccion;

do
{
    Console.WriteLine("Ingrese el primer número:");
    string? entrada1 = Console.ReadLine();
    if (!int.TryParse(entrada1, out int a))
    {
        Console.WriteLine("Entrada no válida. Intente de nuevo.");
        continue;
    }

    Console.WriteLine("Ingrese el segundo número:");
    string? entrada2 = Console.ReadLine();
    if (!int.TryParse(entrada2, out int b))
    {
        Console.WriteLine("Entrada no válida. Intente de nuevo.");
        continue;
    }

    Console.WriteLine("-1 Sumar \n-2 Restar \n-3 Multiplicar \n-4 Dividir \n-0 Salir");
    string? decision = Console.ReadLine();
    if (!int.TryParse(decision, out eleccion))
    {
        Console.WriteLine("Entrada no válida. Intente de nuevo.");
        continue;
    }

    int resultado = 0;

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


int Sumar(int a , int b)
{
    return a + b;
}
int Restar(int a , int b)
{
    return a - b;
}
int Multiplicar(int a , int b)
{
    return a * b;
}
int Dividir(int a , int b)
{
    return a / b;
}
