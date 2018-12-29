using WarriorWars.Enum;

namespace WarriorWars.Equipment
{
    class Armor
    {
        private int GOOD_GUY_ENDURANCE = 5;
        private int BAD_GUY_ENDURANCE = 5;        
        private int endurance;
        public int Endurance
        {          
            get
            { 
                return endurance;
            }
            
        }
        public Armor(Faction faction)
        {
            switch(faction)
            {
                case(Faction.GOOD_GUY):
                    endurance = GOOD_GUY_ENDURANCE;
                    break;
                case(Faction.BAD_GUY):
                    endurance = BAD_GUY_ENDURANCE;
                    break;
                default:
                    break;
            }
        }

    }
}