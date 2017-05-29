using System;
using System.Collections.Generic;

namespace rpg_game_code
{
    public class rpg_class
    {
        public string typePlayer;
        public string error = "";
        public int lvl = 0;
        public float Intelligence = 0.0f;
        public float Power = 0.0f;
        public float Strength = 0.0f;
        public int Stamina = 0;
        public rpg_class(string playerType)
        {
            this.typePlayer = playerType;
            if(playerType == "mage" || playerType == "Mage")
            {
                this.typePlayer = "Mage";
                this.lvl = 1;
                this.Intelligence = 5.0f;
                this.Power = 3.0f;
                this.Strength = 2.0f;
                this.Stamina = 4;
            }

            else if(playerType == "warrior" || playerType == "Warrior")
            {
                this.typePlayer = "Warrior";
                this.lvl = 1;
                this.Intelligence = 1.0f;
                this.Power = 2.0f;
                this.Strength = 6.0f;
                this.Stamina = 6;
            }

            else if(playerType == "priest" || playerType == "Priest")
            {
                this.typePlayer = "Priest";
                this.lvl = 1;
                this.Intelligence = 4.0f;
                this.Power = 5.0f;
                this.Strength = 0.5f;
                this.Stamina = 6;
            }
            else
            {
                this.error = "Erro";
            }
            
        }
        public string getPlayerType()
        {
            return this.typePlayer;
        }
        public int getLvL()
        {
            return this.lvl;
        }
        public float getIntelligence()
        {
            return this.Intelligence;
        }
        public float getPower()
        {
            return this.Power;
        }
        public float getStrength()
        {
            return this.Strength;
        }
        public int getStamina()
        {
            return this.Stamina;
        }
        public string getError()
        {
            return this.error;
        }
    }
}