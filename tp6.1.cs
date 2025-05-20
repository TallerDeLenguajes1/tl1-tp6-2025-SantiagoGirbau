// See https://aka.ms/new-console-template for more information
int a;
int b=0;

Console.WriteLine("Escriba el número a invertir");
if (!int.TryParse(Console.ReadLine(), out a))
{
Console.WriteLine("Debe ser un entero!");
}else{
    while (a>=10)
    {
        b=10*b+a%10;
        Console.WriteLine("b = "+b);
        a=a/10;
    }
    b=10*b+a%10;
    Console.WriteLine("Resultado: "+b);
}



