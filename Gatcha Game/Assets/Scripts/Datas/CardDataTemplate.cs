using UnityEngine;

namespace Gatcha.Minigame.Data
{
    [CreateAssetMenu(menuName = "Scriptable Objects/Card Data", fileName = "New Card Data")]
    public class CardDataTemplate : ScriptableObject
    {
        #region Unity: Awake
        
        private void Awake()
        {
            SetName();
        }
        
        #endregion
        
        #region Properities
        
        public string CardName;
        public string CardID;
        public Sprite CardSprite;
        public Rarity CardRarity;
        public int CardUnlockLevel;
        public int CardAmount = 2;
        public Type ItemType { get; set; } = Type.Card;

        #endregion

        #region SetName

        private void SetName()
        {
            CardName = this.name;
        }
        
        #endregion

    } 
    
}