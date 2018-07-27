using System;
using System.Collections.Generic;
using System.Text;

namespace OOPgame
{
    public class Battle
    {
        public static void StartFight(Warrior warriorOne,Warrior warriorTwo)
        {
            while (true)
            {
                if (GetAttackResult(warriorOne,warriorTwo) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }

                if (GetAttackResult(warriorTwo,warriorOne) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }

        }


        public static string GetAttackResult(Warrior warriorA,Warrior warriorB)
        {
            double warAAttakAmt = warriorA.Attack();
            double warBblkAmt = warriorB.Block();

            double dmgTwoWarB = warAAttakAmt - warBblkAmt;

            if (dmgTwoWarB > 0)
            {
                warriorB.Health = warriorB.Health - dmgTwoWarB;
            }
            else
            {
                dmgTwoWarB = 0;
            }
            Console.WriteLine("{0} Attacks {1} and Deals {2} Damage ",warriorA.Name,warriorB.Name,dmgTwoWarB);

            Console.WriteLine("{0} Has {1} Health",warriorB.Name,warriorB.Health);

            if (warriorB.Health <= 0)
            {
                Console.WriteLine("{0} has Die and {1} is Victorius",warriorB.Name,warriorA.Name);
                return "Game Over";
            }
            else
            {
                return "Fight Again";
            }
            
        }


    }
}
