﻿
namespace InventorySystem
{
    
    // Class that inherits Items characteristics
    public class Equipment : Items
    {
        // Unique characteristics, representing the equipment stats
        private int magicPoints, strengthPoints, dexterityPoints;
        private bool equipped;

        // Equipment / Items constructor
        public Equipment(int mag, int str, int dex, string name, string desc, int FixedPosition, int originalPrice, int price, int qnt, Rarity rarity, ItemType itemType) 
        : base (name, desc, FixedPosition, originalPrice, price, qnt, rarity, itemType)
        {
            this.magicPoints = mag;
            this.strengthPoints = str;
            this.dexterityPoints = dex;
            this.equipped = false;
        }

        // Function that receives the hero attributes and returns it, incremented or decremented by the equipment stats
        // Also set the equipment property equipped accordingly
        public int[] CalculateAttribute(int magic, int strength, int dexterity, bool isEquipped)
        {
                int newMagic = isEquipped ? magic + this.magicPoints : magic - this.magicPoints;
                int newStrength = isEquipped ? strength + this.strengthPoints : strength - this.strengthPoints;
                int newDexterity = isEquipped ? dexterity + this.dexterityPoints : dexterity - this.dexterityPoints;

                SetEquipped(isEquipped);

                return new int[] {newMagic, newStrength, newDexterity};        
        }

        // Getters
        public int GetMagic()
        {
            return this.magicPoints;
        }

        public int GetStrength()
        {
            return this.strengthPoints;
        }

        public int GetDexterity()
        {
            return this.dexterityPoints;
        }

        public bool GetEquipped()
        {
            return this.equipped;
        }

        // Setters
        public void SetEquipped(bool isEquipped)
        {
            this.equipped = isEquipped;
        }
    }
}
