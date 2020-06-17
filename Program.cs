using System;

namespace Aula19Dojo2
{
    class Program
    {
        static void Main(string[] args)
        {
            IngressoVip ingresso = new IngressoVip();

            ingresso.IngressoPreco = 50f;
            ingresso.imprimirValor();
            ingresso.JuntarValor();

            System.Console.WriteLine($"A diferença de preço dos ingressos é: {ingresso.valorAdicional}");
            


        }
    }
}
