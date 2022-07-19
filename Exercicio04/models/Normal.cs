namespace Exercicio04.models
{
    public class Normal : Ingresso
    {
        public override void imprimeValor()
        {
            Console.WriteLine($"Valor do ingresso Normal: R${Valor:0.00}");
        }
    }
}