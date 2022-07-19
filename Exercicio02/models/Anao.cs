using System;

namespace Exercicio02.models
{
    public class Anao : Raca
    {
        public Anao (int forca, int destreza, int constituicao, int inteligencia, int sabedoria, int carisma) 
        : base(forca, destreza,  constituicao,  inteligencia,  sabedoria,  carisma)
        {
            Constituicao = constituicao + 2;
            Forca = forca + 2;
            Sabedoria = sabedoria + 2;
        }

        public void imprimeAtributos()
        {
            Console.WriteLine(
@$"Forca: {Forca}
Destreza: {Destreza}
Constituicao: {Constituicao}
Inteligencia: {Inteligencia}
Sabedoria: {Sabedoria}
Carisma: {Carisma}
");
        }
    }
}