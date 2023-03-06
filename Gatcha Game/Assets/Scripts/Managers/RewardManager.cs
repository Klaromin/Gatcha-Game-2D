using System.Linq;
using Gatcha.Minigame.Data;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Gatcha.Minigame.Presentation
{
    public class RewardManager : MonoBehaviour
    {
        #region Properities
        
        public static RewardManager Instance { get; private set; }
        private string _prizeId;
        public string PrizeId => _prizeId;
        
        #endregion
        
        #region Unity: Awake
        
        private void Awake()
        {
            if (Instance != null && Instance != this) 
            { 
                Destroy(this); 
            } 
            else 
            { 
                Instance = this;
            }
        }
        
        #endregion

        #region GetPrizeData
        
        public IPrize GetPrizeData()
        {
            return ItemManager.Instance.PrizeDataList.Find(prize => prize.ItemID == _prizeId);
        }
        
        #endregion

        #region Pick Prize Item
        
        public void SetPrizeItem()
        {
            _prizeId = ItemManager.Instance.SelectedItemDataIdList.ElementAt(Random.Range(0, ItemManager.Instance.SelectedItemDataIdList.Count));
        }
        
        #endregion
    }
}