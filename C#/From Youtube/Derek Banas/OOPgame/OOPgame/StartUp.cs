using System;

namespace OOPgame
{
    public class StartUp
    {
        public static void Main()
        {
            Warrior maximus = new Warrior("Maximus", 1000, 120, 40);
            Warrior bob = new Warrior("Bob", 1000, 120, 40);

            Battle.StartFight(maximus, bob);
        }
    }
}
