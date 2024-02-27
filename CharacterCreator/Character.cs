using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CharacterCreator
{
    public class Character
    {
        public string name, charClass, perk;
        public int dexterity, strength, health; 

        public Character(string _name, string _charClass, int _dexterity, int _strength, int _health, string _perk)
        {
            name = _name;
            charClass = _charClass;
            dexterity = _dexterity;
            strength = _strength;
            health = _health;
            perk = _perk;
        }
    }
}
