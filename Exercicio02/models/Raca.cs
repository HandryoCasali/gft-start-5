namespace Exercicio02.models
{
    public abstract class Raca
    {
        public int Forca { get; set; } 
        public int Destreza { get; set; } 
        public int Constituicao { get; set; } 
        public int Inteligencia { get; set; } 
        public int Sabedoria { get; set; } 
        public int Carisma { get; set; }
        
        public Raca(int forca, int destreza, int constituicao, int inteligencia, int sabedoria, int carisma )
        {
            Forca = forca;
            Destreza = destreza;
            Constituicao = constituicao;
            Inteligencia = inteligencia;
            Sabedoria = sabedoria;
            Carisma = carisma;
        }
    }
}