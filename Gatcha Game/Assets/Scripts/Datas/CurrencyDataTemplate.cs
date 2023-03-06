using UnityEngine;

namespace Gatcha.Minigame.Data
{
    [CreateAssetMenu(menuName = "Scriptable Objects/Reward Data", fileName = "New Reward Data")]
    public class CurrencyDataTemplate : ScriptableObject
    {
        #region Unity: Awake
        
        private void Awake()
        {
            SetName();
        }
        
        #endregion

        #region Properities
        
        public string CurrencyID;
        public string CurrencyName;
        public Type CurrencyType;
        public int CurrencyAmount;
        public Sprite CurrencySprite;
        public Type ItemType { get; set; }
        public Rarity CurrencyRarity;

        #endregion
    
        #region SetName

        private void SetName()
        {
            CurrencyName = this.name;
        }

        #endregion
       
    }

}