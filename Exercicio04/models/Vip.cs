namespace Exercicio04.models
{
    public class Vip : Ingresso
    {
        private Decimal _valorAdicional;
        
        public Decimal ValorAdicional 
        { 
            protected get
            {
                return _valorAdicional;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("ValorAdicional não pode ser negativo.");
                }
                _valorAdicional = value;
            }
        }
        
        public virtual Decimal ObterValor()
        {
            return Valor + ValorAdicional ;
        }


        public override void imprimeValor()
        {
            Console.WriteLine($"Valor do ingresso VIP: R${ObterValor():0.00}");
        }
    }
}