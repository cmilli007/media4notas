// See https://aka.ms/new-console-template for more information
Console.WriteLine("----Media----");
Console.WriteLine("Digite suas notas,a seguir: ");
Console.Write("");
double nota1, nota2 , nota3 , nota4 , media;
string  resultado;
Console.Write("Nota 1°bimestre: ");
nota1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Nota 2°bimestre: ");
nota2= Convert.ToDouble(Console.ReadLine());

Console.Write("Nota 3°bimestre: ");
nota3 = Convert.ToDouble(Console.ReadLine());

Console.Write("Nota 4°bimestre: ");
nota4 = Convert.ToDouble(Console.ReadLine());

if (nota1 < 0 || nota1 > 10
 || nota2 < 0 || nota2 > 10
 || nota3 < 0 || nota3 > 10
 || nota4 < 0 || nota4 > 10)
{

}
    else
{
    media = (nota1 + nota2 + nota3 + nota4) / 4;

if (media < 5)
    {
        resultado = "Reprovado";
    }
    else if (media > 6)
    {
        resultado = "Aprovado";
    }
    else
    {
        resultado = "Em recuperação";
    }
Console.WriteLine($"Você ficou com média {media}");
Console.WriteLine($"{resultado:resultado}");
}
    