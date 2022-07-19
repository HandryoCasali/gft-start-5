namespace Exercicio04.models
{
    public class Ingresso
    {
        private Decimal _valor;
        public Decimal Valor { 
            protected get 
            {
                return _valor;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Propriedade Valor não pode ser negativo.");
                }
                _valor = value;
            }
            }
        
        public virtual void imprimeValor()
        {
            Console.WriteLine($"Valor do Ingresso: R${Valor:0.00}");
            
        }
    }
}