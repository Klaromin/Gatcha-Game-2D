using Gatcha.Minigame.Data;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gatcha.Minigame.Presentation
{
    public class RewardPopUpPanel : MonoBehaviour
    {
        #region SerializeFields
        
        [SerializeField] private Image _rewardImage;
        [SerializeField] private TextMeshProUGUI _rewardText;
        [SerializeField] private Animator _animator;
        private IPrize _prize;
    
        #endregion
    
        #region InitReward
    
        private void InitReward()
        {
            _prize = RewardManager.Instance.GetPrizeData();
            InitRewardImage();
            InitRewardText();
        }
    
        #endregion
    
        #region Show
        
        public void Show()
        {
            gameObject.SetActive(true);
            _animator.SetTrigger("pop");
            InitReward();
        }
        
        #endregion
        
        #region InitRewardImage
        
        private void InitRewardImage()
        {
            _rewardImage.sprite = _prize.ItemSprite;
        }
        
        #endregion
    
        #region InitRewardText
    
        private void InitRewardText()
        {
            if (_prize.ItemType == Type.Card)
            {
                var cardData = (CardData)_prize;
                _rewardText.text = "You have won " + _prize.ItemAmount + " " + cardData.ItemRarity + " " + "Card.";
            }
            else
            {
                var currencyData = (CurrencyData)_prize;
                _rewardText.text = "You have won " + _prize.ItemAmount + " " + currencyData.ItemType + ". ";
            }
        }
    
        #endregion
    }
}