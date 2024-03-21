using System;

namespace BatalhaPokemon
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string condicao = "";
            string pokeInm = "Beedrill";
            int vidaInm = 100;
            int vidaPok = 100;
            int ataquePok = 0;
            int ataqueInm = 0;

            Random rng = new Random();

            Console.WriteLine("Bem vindo a batalha: ");
            Console.WriteLine();
            Console.WriteLine(@"
                                  ,'\
    _.----.        ____         ,'  _\   ___    ___     ____
_,-'       `.     |    |  /`.   \,-'    |   \  /   |   |    \  |`.
\      __    \    '-.  | /   `.  ___    |    \/    |   '-.   \ |  |
 \.    \ \   |  __  |  |/    ,','_  `.  |          | __  |    \|  |
   \    \/   /,' _`.|      ,' / / / /   |          ,' _`.|     |  |
    \     ,-'/  /   \    ,'   | \/ / ,`.|         /  /   \  |     |
     \    \ |   \_/  |   `-.  \    `'  /|  |    ||   \_/  | |\    |
      \    \ \      /       `-.`.___,-' |  |\  /| \      /  | |   |
       \    \ `.__,'|  |`-._    `|      |__| \/ |  `.__,'|  | |   |
        \_.-'       |__|    `-._ |              '-.|     '-.| |   |
                                `'                            '-._|
");
            Console.WriteLine();
            Console.WriteLine("Você estáva acampando a beira de um lago... \nQuando escutou um barrulho estranho e foi verificar...");
            Console.WriteLine("Na sua frente salta um " + pokeInm);
            Console.WriteLine("Ele parece zangado e começa a te atacar! O que você faz? ");
            Console.WriteLine("lutar agora? s:sim / n:não ");
            condicao = Console.ReadLine();

            if (condicao == "s")
            {
                Console.WriteLine("Qual Pokemon Você Escolhe? ");
                string namePok = Console.ReadLine();
                Console.WriteLine("A batalha começa e seu " + namePok + " Tem: " + vidaPok + " HP ");

                while (vidaPok >= 1 && vidaInm >= 1 && condicao == "s")
                {
                        ataquePok = rng.Next(10, 30);
                        Console.WriteLine(namePok + " ataca e causa: " + ataquePok);
                        vidaInm -= ataquePok;
                        Console.WriteLine(pokeInm + " agora tem: " + vidaInm + " HP ");

                        ataqueInm = rng.Next(10, 30);
                        Console.WriteLine(pokeInm + " ataca e causa: " + ataqueInm);
                        vidaPok -= ataqueInm;
                        Console.WriteLine(namePok + " agora tem: " + vidaPok + " HP ");
                        Console.WriteLine();

                    if (vidaPok <= 0 || vidaInm <= 0)
                    {

                        if(vidaPok > vidaInm)
                        {
                            Console.WriteLine(namePok + " Venceu a luta!");
                        }
                        else
                        {
                            Console.WriteLine(pokeInm + " Venceu a luta!");
                        }

                        Console.WriteLine("A luta não pode continuar!");
                        Console.WriteLine("Aperte ENTER para finalizar!");

                    } else
                    {

                        Console.WriteLine("Você quer continuar lutando? s:sim / n:não");
                        condicao = Console.ReadLine();

                    }

                    if(condicao == "n")
                    {
                        Console.WriteLine("Você chama seu " + namePok + " de volta e corre para fugir... ");
                        Console.WriteLine("Aperte ENTER para finalizar!");
                    }

                }
            }
            else
            {
                Console.WriteLine("Você corre rápido e consegue fujir!");
                Console.WriteLine("Aperte qualquer tecla para finalizar!");
            }
            Console.ReadKey();
        }
    }
}