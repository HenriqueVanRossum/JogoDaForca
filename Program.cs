namespace JogoDaForca;

class Program
{
    static void Main(string[] args)
    {
        var listaLetrasErradas = new List<char>();
        var listaLetras = new List<char>();
        DesenharForca desenho = new DesenharForca();
        string[] listaPalavrasSecretas =
        {
            "casa",
            "bola",
            "gato",
            "livro",
            "mesa",
            "carro",
            "flor",
            "vento",
            "peixe",
            "nuvem",
            "porta",
            "amigo",
            "jogo",
            "tempo",
            "papel"
        };
        Random numSorteio = new Random();
        
        string palavraSecreta = listaPalavrasSecretas[numSorteio.Next(listaPalavrasSecretas.Length -1)].ToUpper();
        int erro = 0;
        int control = 0;
        foreach (var letra in palavraSecreta)
        {
            listaLetras.Add('_');
            Console.Write(listaLetras[control]);
            control++;
        }
        while (!palavraSecreta.ToUpper().Equals(string.Concat(listaLetras)))
        {

            Console.Write("Digite uma letra: ");
            var palpiteLetra = char.Parse(Console.ReadLine()!.ToUpper());
            desenho.Desenhar(erro);

            if (!palavraSecreta.Contains(palpiteLetra))
            {
                erro++;
                desenho.Desenhar(erro);
                listaLetrasErradas.Add(palpiteLetra);
            }
            else
            {
                var controle = 0;
                foreach (var letra in palavraSecreta)
                {
                    if (palpiteLetra == letra)
                    {
                        listaLetras[controle] = palpiteLetra;
                    }
                    controle++;
                }
            }
            Console.WriteLine();

            foreach (var letra in listaLetrasErradas)
            {
                Console.Write(letra + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            foreach (var letra in listaLetras)
            {
                Console.Write(letra + " ");
            }
        }

        Console.WriteLine("Voce ganhou!");

    }
}