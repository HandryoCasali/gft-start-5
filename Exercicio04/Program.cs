using Exercicio04.models;

namespace Exercicio04
{
    public class Program
    {
        public static void Main()
        {
            var vip = new Vip();
            vip.Valor = 1000m;
            vip.ValorAdicional = 200m;
            vip.imprimeValor();
           
        }
    }
}