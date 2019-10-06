using System;
using System.Collections.Generic;
using System.Text;

namespace textAdventure
{
    public class Room
    {
        public String name;
        private bool[] exits = new bool[4] { false, false, false, false };
        public List<WorldObject> present = new List<WorldObject>;
        public Room( String n , bool[] neswexits )
        {
            //FOR EXITS, ARRAY INDEX 0 NORTH, 1 EAST, 2 SOUTH, 3 WEST
            exits = neswexits;
            name = n;
            
        }
        public bool isValidExit( String direction )
        {
            switch ( direction )
            {
                case "n":
                    return exits[0];
                case "e":
                    return exits[1];
                case "s":
                    return exits[2];
                case "w":
                    return exits[3];
                default: return false;
            }
        }
    }
}
