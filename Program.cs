
using System.ComponentModel.DataAnnotations.Schema;

Console.WriteLine("Tamanho do retângulo:");


Console.WriteLine("Largura..: ");
int largura = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Altura...: ");
int altura = Convert.ToInt32(Console.ReadLine());

if (largura < 1 || largura > 10 || altura < 1 || altura > 10)
{
    Console.WriteLine("As medidas devem esta entre 1 e 10");
}
else
{
    int linhaAtual = 1;
    while (linhaAtual <= altura)
    {
        Console.WriteLine();

        int colunaAtual = 1;
        while (colunaAtual <= largura)
        {

            if (linhaAtual == 1 || linhaAtual == altura)
            {
                Console.Write("*");
            }
    else
    {
        if (colunaAtual == 1 || colunaAtual == largura)
        {
            Console.Write("*");
        }
        else
        {
             Console.Write(" ");
        }
    }

            colunaAtual += 1;
        }


    linhaAtual += 1;
      }       
}

