using System;

public class Dados
{
	public Dados()
	{

        int numDados = 0;
        int numLados = 0;
        int[] cont = new int[numLados];

        int[] nBonus = new int[numLados];
        int somaBonus = 0;
        int somaTudo = 0;

        int[] dados = new int[numDados];
        Random r = new Random();

        int vitoria = numDados6 * 5;
        int empate = numDados6 * 4;

        public Dados(int numDados, int numLados)
        {
            this.numDados = numDados;
            this.numLados = numLados;
        }

        int Sortear()
        {
            for (int i = 0; i < dados.Length; i++)
            {
                dados[i] = r.Next(1, numLados + 1);
            }
            return dados;
        }
        int Resultado()
        {
            Sortear();
            Console.Write($"dados de {numLados} lados: \n");
            for (int i = 0; i < dados.Length; i++)
            {
                Console.WriteLine("dado " + (i + 1) + ": " + dados[i]);
            }

            foreach (int resultado in dados)
            {
                cont6[resultado - 1]++; // incrementa o contador correspondente
            }

            for (int i = 0; i < cont.Length; i++)
            {
                Console.WriteLine($"O valor {i + 1} apareceu {cont[i]} vezes.");
            }

        }

        public int Exibir()
        {
            Resultado();
            foreach (int zerar in nBonus)
            {
                nBonus[zerar] = 0;
            }

            for (int i = 0; i < nBonus.Length; i++)
            {
                if (cont[i] == 2)
                {
                    nBonus[i] = 2;
                }
                if (cont[i] >= 3)
                {
                    nBonus[i] = cont[i] * 2;

                    somaBonus += nBonus[i];
                }
            }
            for (int i = 0; i < nBonus.Length; i++)
            {
                if (nBonus[i] > 1)
                {
                    Console.WriteLine($"Você tirou o numero {i + 1} no dado {cont[i]} vezes. Bônus: {nBonus6[i]}");
                }
            }
            for (int i = 0; i < dados.Length; i++)
            {
                somaTudo += dados[i];
            }
            Console.WriteLine($"Sua pontuação total foi de: {somaTudo}");
            if (somaTudo > vitoria)
            {
                Console.WriteLine("Você ganhou!!!");

            }
            else if (somaTudo > empate)
            {
                Console.WriteLine("O jogo empatou");
            }
            else
            {
                Console.WriteLine("Você perdeu");
            }
        }
}
