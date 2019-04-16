using System;
using MonsterHunt;

namespace MonsterHunt
{
    class Program
    {
        public static void Main()
        {
            Hunter VonRimmersmark = new Hunter("Erich", "Von Rimmersmark");

            Mummy tuts = new Mummy();
            Wight MrUgly = new Wight();
            Vampire Dracula = new Vampire();

            VonRimmersmark.Ignite(tuts);
            VonRimmersmark.SplashWater(MrUgly);
            VonRimmersmark.WieldSilver(Dracula);

            Console.WriteLine((VonRimmersmark));
        }
    }
}
