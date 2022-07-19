using System;
namespace Exercicio02.models
{
    public class Humano : Raca
    {
        public Humano (int forca, int destreza, int constituicao, int inteligencia, int sabedoria, int carisma) 
        : base(forca, destreza,  constituicao,  inteligencia,  sabedoria,  carisma)
        {
            Forca = forca + 1;
            Destreza = destreza + 1;
            Constituicao = constituicao + 1;
            Inteligencia = inteligencia + 1;
            Sabedoria = sabedoria + 1;
            Carisma = carisma + 1;
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