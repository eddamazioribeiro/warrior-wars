using WarriorWars.Enum;

namespace WarriorWars.Equipment
{
    class Weapon
    {
        private const int GOOD_GUY_DAMAGE = 6;
        private const int BAD_GUY_DAMAGE = 5;
        private int damage;
        public int Damage
        {          
            get
            { 
                return damage;
            }
            
        }
        
        private WeaponTypes weaponType;
        public WeaponTypes WeaponType
        {
            get
            {
                return weaponType;
            }

        }

        public Weapon(Faction faction, WeaponTypes weaponType)
        {
            this.weaponType = weaponType;

            int typeModifier;

            switch(weaponType)
            {
                case WeaponTypes.AXE:
                    typeModifier = 4;
                    break;
                case WeaponTypes.SWORD:
                    typeModifier = 3;
                    break;
                case WeaponTypes.BOW:
                    typeModifier = 2;
                    break;
                case WeaponTypes.STAFF:
                    typeModifier = -1;
                    break;
                default:
                    typeModifier = 0;
                    break;
            }

            switch(faction)
            {
                case Faction.GOOD_GUY:
                    damage = GOOD_GUY_DAMAGE;
                    break;
                case Faction.BAD_GUY:
                    damage = BAD_GUY_DAMAGE;
                    break;
                default:
                    break;                    

            }

            damage += typeModifier;
        }

    }
}