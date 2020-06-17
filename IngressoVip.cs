namespace Aula19Dojo2
{
    public class IngressoVip : Ingresso
    {
        
        
        public float valorAdicional = 100f;

        public void JuntarValor(){

            float valorTotal = IngressoPreco + valorAdicional;
            System.Console.WriteLine($"O preço do ingresso vip é: {valorTotal}");

            

        }

    }
}