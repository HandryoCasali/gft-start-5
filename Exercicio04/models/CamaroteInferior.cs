namespace Exercicio04.models
{
    public class CamaroteInferior : Vip
    {
        public string? Localizacao { get; set; }
        
        
        public void imprimeLocalizacao()
        {
            Console.WriteLine($"Localização do ingresso: {Localizacao}");
        }
    }
}