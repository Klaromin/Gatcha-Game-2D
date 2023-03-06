using UnityEngine;

namespace Gatcha.Minigame.Data
{
    public class Configuration
    {
        #region GridItemConfig
    
        public static class GridItemConfig
        {
            public static int Card { get; } = 8;
            public static int Gold { get; } = 3;
            public static int Gem { get; } = 1;
        }
    
        #endregion
    
        #region GatchaSpriteConfig

        public static class GatchaSpriteConfig
        {
            public static Sprite CommonFrame { get; } = Resources.Load<Sprite>("Art/ItemSlot/common_card_slot");
            public static Sprite RareFrame { get; } = Resources.Load<Sprite>("Art/ItemSlot/rare_card_slot");
            public static Sprite EpicFrame { get; } = Resources.Load<Sprite>("Art/ItemSlot/epic_card_slot");
        }
    
        #endregion
    }
}




