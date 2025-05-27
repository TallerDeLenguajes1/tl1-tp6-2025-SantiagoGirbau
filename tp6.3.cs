// See https://aka.ms/new-console-template for more information
float a;
float b;


string input;
do
{
    Console.WriteLine("Escriba la operación a realizar suma, resta, mult, div, abs, cuad, raiz, V2 para funciones extra o exit para salir \n");
    input = Console.ReadLine();
    switch (input)
    {
        case "suma":
            a = LeerNumero();
            b = LeerNumero();
            Console.WriteLine("Resultado = " + suma(a, b));
            break;
        case "resta":
            a = LeerNumero();
            b = LeerNumero();
            Console.WriteLine("Resultado = " + resta(a, b));
            break;
        case "mult":
            a = LeerNumero();
            b = LeerNumero();
            Console.WriteLine("Resultado = " + multiplicacion(a, b));
            break;
        case "div":
            a = LeerNumero();
            b = LeerNumero();
            if (b == 0)
            {
                Console.WriteLine("NO EXISTE LA DIVISIÓN EN CERO");
            }
            else
            {
                Console.WriteLine("Resultado = " + division(a, b));
            }
            break;
        case "V2":
            a = LeerNumero();
            Console.WriteLine("Resultado = " + raizCuadrada(a));
            break;
            Console.WriteLine("Escriba un numero para calcular el ABS, CUADRADO, RAÍZ, SENO COSENO y PARTE REAL:\n");

            a = LeerNumero();

            Console.WriteLine("Valor Absoluto = " + abs(a));

            Console.WriteLine("Cuadrado = " + cuadrado(a));

            Console.WriteLine("Raríz cuadrada = " + raizCuadrada(a));

            Console.WriteLine("Seno = " + seno(a));

            Console.WriteLine("Coseno = " + coseno(a));

            Console.WriteLine("Parte real = " + parteEntera(a));

            Console.WriteLine("Escriba dos numeros para calcular el mayor y el menor:\n");

            a = LeerNumero();
            b = LeerNumero();

            if (a != b)
            {
                Console.WriteLine("El mayor es: " + Mayor(a, b));
                Console.WriteLine("El menor es: " + Menor(a, b));
            }
            else
            {
                Console.WriteLine("Los números son iguales\n");
            }
            break;
        case "exit":
            break;
        default:
            Console.WriteLine("No es una opción válida");
            break;
    }
} while (input != "exit");



float LeerNumero()
{
    float a;
    bool Resultado;
    do
    {
        Console.WriteLine("Escriba un numero: ");
        Resultado = float.TryParse(Console.ReadLine(), out a);
        if (!Resultado)
        {
            Console.WriteLine("No es un número válido");
        }
    } while (!Resultado);
    return a;
}

float suma(float a, float b)
{
    return a + b;
}

float resta(float a, float b)
{
    return a - b;
}

float multiplicacion(float a, float b)
{
    return a * b;
}

float division(float a, float b)
{

    return a / b;
}

float cuadrado(float a)
{
    return a * a;
}

double raizCuadrada(float a)
{
    if (a < 0)
    {
        Console.WriteLine("Es raíz compleja\n");
        return 0;
    }
    else
    {
        return Math.Sqrt(a);
    }

}
double seno(float a)
{
    return Math.Sin(a);
}

double coseno(float a)
{
    return Math.Cos(a);
}

int parteEntera(float a)
{
    int x = (int)a;
    return x;
}

float Mayor(float a, float b)
{

    if (a > b)
    {
        return a;
    }
    else
    {
        return b;
    }
}

float Menor(float a, float b)
{
    if (a < b)
    {
        return a;
    }
    else
    {
        return b;
    }
}
