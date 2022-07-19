using System;
using System.Collections.Generic;
using Exercicio02.models;
using System.Linq;

namespace Exercicio02
{
    public class Program
    {
        public static void Main()
        {
            List<int> atributos = new List<int>();
            bool entradaCorreta = true;
            do  
            {
                Console.WriteLine($"Digite os 6 valores entre 3 e 18 para os atributos do seu personagem: ");
                Console.Write("Força: ");
                atributos.Add(int.Parse(Console.ReadLine()));
                Console.Write("Destreza: ");
                atributos.Add(int.Parse(Console.ReadLine()));
                Console.Write("Constituição: ");
                atributos.Add(int.Parse(Console.ReadLine()));
                Console.Write("Inteligencia: ");
                atributos.Add(int.Parse(Console.ReadLine()));
                Console.Write("Sabedoria: ");
                atributos.Add(int.Parse(Console.ReadLine()));
                Console.Write("Carisma: ");
                atributos.Add(int.Parse(Console.ReadLine()));
                
                if(atributos.Min() < 3 || atributos.Max() > 18)
                {
                    Console.WriteLine($"Precisa ser valores entre 3 e 18");
                    entradaCorreta = false;
                }

                
            } while (!entradaCorreta);

            
            string opcaoRaca = "";
            do
            {
                Console.WriteLine($"Escolha uma das opcoes de raça abaixo:");
                Console.WriteLine($"1 - Anao");
                Console.WriteLine($"2 - Elfo");
                Console.WriteLine($"3 - Humano");
                Console.Write($"Digite sua opção: ");

                opcaoRaca = Console.ReadLine().Trim();
                
                switch(opcaoRaca)
                {
                    case "1":
                        var anao = new Anao(atributos[0], atributos[1], atributos[2], atributos[3], atributos[4], atributos[5]);
                        Console.WriteLine($"Seus atributos são: ");
                        
                        anao.imprimeAtributos();
                        break;

                    case "2":
                        var elfo = new Elfo(atributos[0], atributos[1], atributos[2], atributos[3], atributos[4], atributos[5]);
                        Console.WriteLine($"Seus atributos são: ");
                        elfo.imprimeAtributos();
                        break;

                    case "3":
                        var humano = new Humano(atributos[0], atributos[1], atributos[2], atributos[3], atributos[4], atributos[5]);
                        Console.WriteLine($"Seus atributos são: ");
                        humano.imprimeAtributos();
                        break;
                
                    default:
                        Console.WriteLine("Opção inválida. Digite apenas entre 1, 2 ou 3.");
                        break;
                }
            } while (opcaoRaca != "1" && opcaoRaca != "2" && opcaoRaca != "3");

        }

    }
}