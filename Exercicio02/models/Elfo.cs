using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio02.models
{
    public class Elfo : Raca
    {
        public Elfo (int forca, int destreza, int constituicao, int inteligencia, int sabedoria, int carisma) 
        : base(forca, destreza,  constituicao,  inteligencia,  sabedoria,  carisma)
        {
            Destreza = destreza + 2;
            Carisma = carisma + 2;
            Inteligencia = inteligencia + 2;
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
