using System;

namespace textAdventure
{
    public class Item
    {
        protected float weight;
        protected String name;
        protected String desc;
    }

    public class Weapon : Item
    {
        protected float dmg;
        protected float rar;
    }
    public class Sword : Weapon
    {
        void Exist()
        {
            var rnd = new Random();
            weight = 2;
            dmg = rnd.Next(2-4) * rar;
        }
    }
    public class Axe : Weapon
    {
        void Exist()
        {
            var rnd = new Random();
            weight = 4;
            dmg = rnd.Next(2, 5) * rar;
        }
        public Axe(int rar)
        {
            this.Exist();
            //name = n;
            //desc = d;
        }
    }
    public class Spear : Weapon
    {
        void Exist()
        {
            var rnd = new Random();
            weight = 1;
            dmg = rnd.Next(3, 6) * rar;
        }
        public Spear(int rar)
        {
            this.Exist();
            //name = n;
            //desc = d;
        }
    }
    public class UseItem : Item
    {

    }
    public class PuzItem : Item
    {
        int solvesID = 0;
    }
}
