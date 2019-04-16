using System;

namespace MonsterHunt
{
    public class Mummy : Monster, ICombustable
    {
        public void Burn(string attack)
        {
            if (attack == "Fire")
            {
                Console.WriteLine("You just killed the Mummy");
            }
        }
    }
}