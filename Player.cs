using System;
using System.Collections.Generic;

namespace textAdventure
{
    class Player
    {
        //stats
        public float maxHp;
        public float maxMana;
        public float maxEncumbrance;
        public float hp;
        public float mana;
        public float encumbrance;
        public float str;
        public float wis;
        public float agi;
        public Random rnd = new Random();
        public String archetype;
        public String name;

        //inventory
        protected List<Item> inv;

        public Player(String n, String a)
        {
            archetype = a;
            name = n;
            Wake();
        }

        public void Wake()
        {
            switch (archetype)
            {
                case "bruiser":
                    inv = new List<Item>();
                    inv.Add(new Axe(1));
                    maxHp = rnd.Next(120, 135);
                    maxMana = rnd.Next(50, 60);
                    maxEncumbrance = rnd.Next(120, 135);
                    hp = maxHp;
                    mana = maxMana;
                    str = rnd.Next(8, 10);
                    wis = rnd.Next(1, 4);
                    agi = rnd.Next(5, 7);
                    // need to add formula to determine encumbrance
                    break;

                case "clairvoyant":
                    inv = new List<Item>();
                    inv.Add(new Axe(1));
                    maxHp = rnd.Next(120, 135);
                    maxMana = rnd.Next(50, 60);
                    maxEncumbrance = rnd.Next(120, 135);
                    hp = maxHp;
                    mana = maxMana;
                    str = rnd.Next(8, 10);
                    wis = rnd.Next(1, 4);
                    agi = rnd.Next(5, 7);
                    // need to add formula to determine encumbrance
                    break;

                case "bowman":
                    inv = new List<Item>();
                    inv.Add(new Axe(1));
                    maxHp = rnd.Next(120, 135);
                    maxMana = rnd.Next(50, 60);
                    maxEncumbrance = rnd.Next(120, 135);
                    hp = maxHp;
                    mana = maxMana;
                    str = rnd.Next(8, 10);
                    wis = rnd.Next(1, 4);
                    agi = rnd.Next(5, 7);
                    // need to add formula to determine encumbrance
                    break;
            }
        }

    }
}