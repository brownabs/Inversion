using System;

namespace MonsterHunt
{
    public class Vampire : Monster, IPenetrate
    {

        public void Stab(string attack)
        {
            if (attack == "Silver")
            {
                Console.WriteLine("You just killed the Vampire");
            }
        }
    }
}

