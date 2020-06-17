namespace Aula19Dojo2
{
    public class Ingresso
    {
        
        public float IngressoPreco { get; set; }

        public void imprimirValor(){
            System.Console.WriteLine($"O preço do ingresso é: {IngressoPreco}");
        }

    }
}