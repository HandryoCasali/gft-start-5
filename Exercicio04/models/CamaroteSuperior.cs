namespace Exercicio04.models
{
    public class CamaroteSuperior : Vip
    {
        private Decimal _taxaAdicional;
        public Decimal TaxaAdicional 
        {
            protected get
            {
                return _taxaAdicional;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Taxa adicional não pode ser negativa.");
                }
                _taxaAdicional = value;
            }
        }

        public override Decimal ObterValor()
        {
            return Valor + ValorAdicional + TaxaAdicional;
        }

        public override void imprimeValor()
        {
            Console.WriteLine($"Valor do ingresso VIP no Camarote Superior: R${ObterValor():0.00}");
        }
        
        
    }
}