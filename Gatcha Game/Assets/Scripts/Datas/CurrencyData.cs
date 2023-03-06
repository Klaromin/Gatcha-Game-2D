using UnityEngine;

namespace Gatcha.Minigame.Data
{
    public class CurrencyData : IPrize
    {
        public Type ItemType { get; set; }
        public int ItemAmount { get; set; }
        public string ItemID { get; set; }
        public Sprite ItemSprite { get; set; }
        public Rarity ItemRarity { get; set; }
    }
}