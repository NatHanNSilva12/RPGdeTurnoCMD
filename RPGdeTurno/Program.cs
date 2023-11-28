using System;

namespace RPGdeTurno
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerHp = 40;
            int enemyHp = 25;

            int playerAttack = 5;
            int enemyAttack = 7;

            int healAmount = 5;

            Random random = new Random();

            while(playerHp > 0 && enemyHp > 0)
            {
                Console.WriteLine("-- Seu turno --");
                Console.WriteLine("Hp do player - " +playerHp+ ". Hp do inimigo - " +enemyHp);
                Console.WriteLine("Aperte 'a' para atacar ou 'h' para curar");
                
                string choise = Console.ReadLine();

                if(choise == "a")
                {
                    enemyHp -= playerAttack;
                    Console.WriteLine("Voce atacou o inimigo e deu " + playerAttack + " dano");
                }
                else
                {
                    playerHp += healAmount;
                    Console.WriteLine("Voce restaurou " + healAmount + "pontos de vida");
                }

                if (enemyHp > 0)
                {
                    Console.WriteLine("-- Turno do inimigo --");
                    int enemyChoise = random.Next(0, 2);

                    if(enemyChoise == 0)
                    {
                        playerHp -= enemyAttack;
                        Console.WriteLine("O inimigo atacou e deu " + enemyAttack + "de dano");

                    }
                    else
                    {
                        enemyHp += healAmount;
                        Console.WriteLine("O inimigo restaurou " + healAmount + "de vida");
                    }

                }
            }

            if(playerHp > 0)
            {
                Console.WriteLine("Parabens, voce ganhou!");
            }

            else
            {
                Console.WriteLine("Voce perdeu hahaha");
            }

        }
    }
}
