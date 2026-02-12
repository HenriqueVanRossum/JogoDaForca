using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaForca
{
    public class DesenharForca
    {
        public void Desenhar(int erro)
        {
            switch (erro)
            {

                case 0:
                    Console.Clear(); 
                    Console.WriteLine();
                    Console.WriteLine();
                    break;     
                case 1:
                    Console.Clear();
                    Console.WriteLine(" (x.x)");
                    Console.WriteLine();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("(x.x)\n /");
                    Console.WriteLine();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("(x.x)\n /|");
                    Console.WriteLine();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("(x.x)\n /|\\");
                    Console.WriteLine();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("(x.x)\n /|\\\n  |");
                    Console.WriteLine();
                    break;
                case 6:
                    Console.Clear();
                    Console.WriteLine("(x.x)\n /|\\\n  |\n /");
                    Console.WriteLine();
                    break;
                case 7:
                    Console.Clear();
                    Console.WriteLine("(x.x)\n /|\\\n  |\n / \\");
                    Console.WriteLine();
                    break;

                default:
                    Console.WriteLine("Voce perdeu!");
                    Environment.Exit(1); 
                    break;
            }
        }
    }
}


