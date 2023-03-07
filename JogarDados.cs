using System;

class Program
{
    static void Main(string[] args)
    {

        

        // Loop principal do programa
        while (true)
        {

            int numDados6 = 0;
            int numDados12 = 0;
            int numDados20 = 0;

            int[] cont6 = new int[6];
            int[] cont12 = new int[12];
            int[] cont20 = new int[20];

            int[] nBonus6 = new int[6];
            int[] nBonus12 = new int[12];
            int[] nBonus20 = new int[20];
            int somaBonus6 = 0;
            int somaBonus12 = 0;
            int somaBonus20 = 0;
            int somaTudo = 0;
            
            Random r = new Random();


            Console.Write("Quantos D6 voce quer jogar? ");
            numDados6 = int.Parse(Console.ReadLine());

            int[] dados = new int[numDados6];

            Console.WriteLine("Quantos D12 voce quer jogar? ");
            numDados12 = int.Parse(Console.ReadLine());

            int[] D12 = new int[numDados12];

            Console.WriteLine("Quantos D20 voce quer jogar? ");
            numDados20 = int.Parse(Console.ReadLine());

            int[] D20 = new int[numDados20];

            
            int vitoria = numDados6 * 5;
            int empate = numDados6 * 4;


            for (int i = 0; i < dados.Length; i++)
            {
                dados[i] = r.Next(1, 7);
            }

            for (int i = 0; i < D12.Length; i++)
            {
                D12[i] = r.Next(1, 13);
            }

            for (int i = 0; i < D20.Length; i++)
            {
                D20[i] = r.Next(1, 21);
            }


            // Jogar os dados e mostrar os resultado
            Console.Write("dados de 6 lados: \n");
            for (int i = 0; i < dados.Length; i++)
            {
                Console.WriteLine("dado " + (i + 1) + ": " + dados[i]);
            }

            foreach (int resultado in dados)
            {
                cont6[resultado - 1]++; // incrementa o contador correspondente
            }

            for (int i = 0; i < cont6.Length; i++)
            {
                Console.WriteLine($"O valor {i + 1} apareceu {cont6[i]} vezes.");
            }

            Console.WriteLine();
            Console.Write("dados de 12 lados: \n");

            for (int i = 0; i < D12.Length; i++)
            {
                Console.WriteLine("dado " + (i + 1) + ": " + D12[i]);
            }

            foreach (int resultado in D12)
            {
                cont12[resultado - 1]++; // incrementa o contador correspondente
            }

            for (int i = 0; i < cont12.Length; i++)
            {
                Console.WriteLine($"O valor {i + 1} apareceu {cont12[i]} vezes.");
            }


            Console.WriteLine();
            Console.Write("dados de 20 lados: \n");

            for (int i = 0; i < D20.Length; i++)
            {
                Console.WriteLine("dado " + (i + 1) + ": " + D20[i]);
            }
            Console.WriteLine();

            foreach(int resultado in D20)
            {
                cont20[resultado - 1]++; // incrementa o contador correspondente
            }

            for (int i = 0; i < cont20.Length; i++)
            {
                Console.WriteLine($"O valor {i + 1} apareceu {cont20[i]} vezes.");
            }






            foreach (int zerar in nBonus6)
            {
                nBonus6[zerar] = 0;
            }
            foreach (int zerar in nBonus12)
            {
                nBonus12[zerar] = 0;
            }
            foreach (int zerar in nBonus20)
            {
                nBonus20[zerar] = 0;
            }


            for (int i = 0; i < nBonus6.Length; i++)
            {
                if (cont6[i] == 2)
                {
                    nBonus6[i] = 2;
                }             
                if(cont6[i] >= 3)
                {
                    nBonus6[i] = cont6[i] *2;
                
                somaBonus6 += nBonus6[i];               
            }
                for (int i = 0; i < nBonus12.Length; i++)
                {
                    if (cont12[i] == 2)
                    {
                        nBonus12[i] = 2;
                    }
                    if (cont12[i] >= 3)
                    {
                        nBonus12[i] = cont12[i] * 2;
                        somaBonus12 += nBonus12[i];
                    }
                }
                    for (int i = 0; i < nBonus20.Length; i++)
                    {
                        if (cont20[i] =
                        {
                            nBonus20[i] = 2;
                        }
                        if (cont20[i] >= 3)
                        {
                            nBonus20[i] = cont20[i] * 2;

                            somaBonus20 += nBonus20[i];
                        }
                    }

            for (int i = 0; i < nBonus6.Length; i++)
            {
                if (nBonus6[i] > 1)
                {
                    Console.WriteLine($"Você tirou o numero {i + 1} no dado {cont6[i]} vezes. Bônus: {nBonus6[i]}");
                }
            }
            Console.WriteLine($"O seu bônus com D6 foi de: {somaBonus6}");
                for (int i = 0; i < nBonus12.Length; i++)
                {
                    if (nBonus12[i] > 1)
                    {
                        Console.WriteLine($"Você tirou o numero {i + 1} no dado {cont12[i]} vezes. Bônus: {nBonus12[i]}");
                    }
                }
                Console.WriteLine($"O seu bônus com D12 foi de: {somaBonus12}");
                for (int i = 0; i < nBonus20.Length; i++)
                {
                    if (nBonus20[i] > 1)
                    {
                        Console.WriteLine($"Você tirou o numero {i + 1} no dado {cont20[i]} vezes. Bônus: {nBonus20[i]}");
                    }
                }
                Console.WriteLine($"O seu bônus com D6 foi de: {somaBonus20}");


                for (int i = 0; i < dados.Length; i++)
            {
                somaTudo += dados[i];
            }
                for (int i = 0; i < D12.Length; i++)
                {
                    somaTudo += D12[i];
                }
                for (int i = 0; i < D20.Length; i++)
                {
                    somaTudo += D20[i];
                }
                somaTudo += somaBonus;
            

            Console.WriteLine($"Sua pontuação total foi de: {somaTudo}");

            if(somaTudo > vitoria)
            {
                Console.WriteLine("Você ganhou!!!");

            }
            else if(somaTudo > empate)
            {
                Console.WriteLine("O jogo empatou");
            }
            else 
            {
                Console.WriteLine("Você perdeu");
            }




            // Perguntar ao usuário se ele deseja jogar novamente
            Console.Write("Deseja jogar novamente? (s/n) ");
            string resposta = Console.ReadLine().ToLower();
            if (resposta != "s" && resposta != "sim")
            {
                break;
            }


        }


    }

}