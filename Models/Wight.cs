using System;

namespace MonsterHunt
{
    public class Wight : Monster, IMelt
    {
           public void Douse(string attack)
        {
            if (attack == "Holy Water")
            {
                Console.WriteLine("You just killed the Wight");
            }
        }
    }
}
