// Exercício do site URI "Notas Com Validação"

int X = 1;

while (X == 1)
{
    double Nota1 = double.Parse(Console.ReadLine());
    while (Nota1 < 0.0 || Nota1 > 10.0)
    {
        Console.WriteLine("nota invalida");
        Nota1 = double.Parse(Console.ReadLine());
    }
    double Nota2 = double.Parse(Console.ReadLine());
    while (Nota2 < 0.0 || Nota2 > 10.0)
    {
        Console.WriteLine("nota invalida");
        Nota2 = double.Parse(Console.ReadLine());
    }
    double media = (Nota1 + Nota2) / 2.0;
    Console.WriteLine("media = " + media.ToString("F2"));

    Console.WriteLine("novo calculo (1-sim 2-nao)");
    X = int.Parse(Console.ReadLine());
    while (X != 1 && X != 2)
    {
        Console.WriteLine("novo calculo (1-sim 2-nao)");
        X = int.Parse(Console.ReadLine());
    }
}


