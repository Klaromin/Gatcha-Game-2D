using UnityEngine;

namespace Gatcha.Minigame.Data
{
    public class CardData : IPrize
    {
        public Type ItemType { get; set; }
        public int ItemAmount { get; set; }
        public string ItemID { get; set; }
        public Rarity ItemRarity { get; set; }
        public int ItemUnlockLevel { get; set; }
        public Sprite ItemSprite { get; set; }
    }
}

