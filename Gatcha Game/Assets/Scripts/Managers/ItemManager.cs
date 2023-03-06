using System;
using System.Collections.Generic;
using System.Linq;
using Gatcha.Minigame.Data;
using UnityEngine;
using Random = UnityEngine.Random;
using Type = Gatcha.Minigame.Data.Type;

namespace Gatcha.Minigame.Presentation
{
    public class ItemManager : MonoBehaviour
    {
        #region Public properities
        
        public static ItemManager Instance { get; private set; } //bir düzene oturt.
        
        public List<CardDataTemplate> AllCardData;
        private List<CardDataTemplate> UnlockedCardData { get; set; }
        private List<CurrencyDataTemplate> AllCurrencyData { get; set; }
        public List<string> SelectedItemDataIdList;
        public readonly List<IPrize> PrizeDataList = new();
        
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
            
            AllCardData = Resources.LoadAll<CardDataTemplate>("Item Data/Card Data").ToList();
            UnlockedCardData = AllCardData.Where(card => card.CardUnlockLevel <= LevelManager.Instance.PlayerLevel).ToList();
            AllCurrencyData = Resources.LoadAll<CurrencyDataTemplate>("Item Data/Currency Data").ToList();
            SetPrizeDataList();
            SetItemIDData();
        }

        #endregion
        
        #region SetItemIDData

        private void SetItemIDData()
        {
            var gem = PrizeDataList.Where(prize => prize.ItemType == Type.Gem); 
            var gold = PrizeDataList.Where(prize => prize.ItemType == Type.Gold);
            
            for (int i = 0; i < Configuration.GridItemConfig.Gold; i++)
            {
                var currencyData = gold.ElementAt(Random.Range(0, gold.Count()));
                SelectedItemDataIdList.Add(currencyData.ItemID);
            }
            for (int i = 0; i < Configuration.GridItemConfig.Card; i++)
            {
                var cardData = UnlockedCardData.ElementAt(Random.Range(0, UnlockedCardData.Count()));
                SelectedItemDataIdList.Add(cardData.CardID);
            }
            for (int i = 0; i < Configuration.GridItemConfig.Gem; i++)
            {
                var currencyData = gem.ElementAt(Random.Range(0, gem.Count()));
                SelectedItemDataIdList.Add(currencyData.ItemID);
            }
            SelectedItemDataIdList = SelectedItemDataIdList.OrderBy(item => Guid.NewGuid()).ToList(); 
        }
        
        #endregion

        #region SetPrizeDataList

        private void SetPrizeDataList()
        {
            foreach (var cardDataTemplate in UnlockedCardData)
            {
                var cardData = new CardData()
                {
                    ItemID = cardDataTemplate.CardID,
                    ItemAmount = cardDataTemplate.CardAmount,
                    ItemType = cardDataTemplate.ItemType,
                    ItemRarity = cardDataTemplate.CardRarity,
                    ItemSprite = cardDataTemplate.CardSprite,
                    ItemUnlockLevel = cardDataTemplate.CardUnlockLevel
                };
                PrizeDataList.Add(cardData);
            }
            foreach (var currencyDataTemplate in AllCurrencyData)
            {
                var currencyData = new CurrencyData()
                {
                    ItemID = currencyDataTemplate.CurrencyID,
                    ItemAmount = currencyDataTemplate.CurrencyAmount,
                    ItemType = currencyDataTemplate.CurrencyType,
                    ItemSprite = currencyDataTemplate.CurrencySprite,
                    ItemRarity = currencyDataTemplate.CurrencyRarity
                };
                PrizeDataList.Add(currencyData);
            }
        }

        #endregion
    }
}