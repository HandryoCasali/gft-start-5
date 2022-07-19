
namespace Exercicio01
{
    public class Program
    {
        public static void Main()
        {
            int numeroDigitado;
            bool entrada = true;
            do
            {
                Console.WriteLine($"Digite um numero entre 0 e 400");
                
                numeroDigitado = int.Parse(Console.ReadLine());
                if(numeroDigitado < 0 || numeroDigitado >= 400)
                {
                    System.Console.WriteLine("Numero precisa ser maior que 0 e menor que 400");
                    entrada = false;
                }
            } while (!entrada);
            Console.Write($"Numero {numeroDigitado} em Numero Romano: ");
            
            ImprimirNumeroEmRomano(numeroDigitado);
        }

        public static void ImprimirNumeroEmRomano(int numero)
        {
            int[] num = new int[]{1, 4, 5, 9, 10, 40, 50, 90,
                            100, 400, 500, 900, 1000};

            string[] letras = new string[]{"I", "IV", "V", "IX", "X", "XL",
            "L", "XC", "C", "CD", "D", "CM", "M"};

            for(int i = 12; i >= 0; i-- )
            {
                int div = (int)(numero / num[i]);
                numero %= num[i];

                for(int j = div; div > 0; div--)
                {
                    Console.Write(letras[i]);
                }
            }
        }
    }
}