using System;
using System.Collections.Generic;

namespace MonsterHunt
{
    public class Hunter 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<string> Weapons { get; } = new List<string>() {
        "Silver", "Fire", "Holy Water"
    };

        public Hunter(string first, string last)
        {
            FirstName = first;
            LastName = last;
        }


        public void SplashWater(IMelt taco)
        {
            taco.Douse("Holy Water");  // Kills with holy water
        }

        public void Ignite(ICombustable taco)
        {
            taco.Burn("Fire");  // Kills with fire
        }

        public void WieldSilver(IPenetrate taco)
        {
            taco.Stab("Silver");   // Stabs with silver knife
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} kills monsters with the following weapons: {String.Join(", ", Weapons)}";
        }
    }
}