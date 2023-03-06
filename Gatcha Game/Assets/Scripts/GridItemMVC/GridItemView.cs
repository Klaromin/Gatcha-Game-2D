using Gatcha.Minigame.Data;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gatcha.Minigame.Presentation
{
    public class GridItemView : BaseView<GridItemModel>
    {
        #region Private properities
        
        [SerializeField] private TextMeshProUGUI _gridItemNumber;
        [SerializeField] private Image _gridItemFrame;
        [SerializeField] private Image _gridItemImage;
        [SerializeField] private TextMeshProUGUI _gridItemAmount;
        private CardDataTemplate _cardDataTemplate;
        private CurrencyDataTemplate _currencyDataTemplate;
        private IPrize _prize;
        
        #endregion

        #region MVC: Init | DeInit
        
        public override void Init()
        {
            SetGridItemData();
            InitFrame();
            InitItemImage();
            InitAmountText();
            InitGridItemNumberText();
        }
        
        public override void DeInit()
        {
            DeInitFrame();
            DeInitImage();
            DeInitAmountText();
            DeInitGridItemNumberText();
        }
        
        #endregion
            
        #region MVC: InitFrame 
        
        private void InitFrame()
        {
            //type'a göre bak sonra çerçeve ver.
            if (_prize.ItemRarity == Rarity.Common)
            {
                _gridItemFrame.sprite = Configuration.GatchaSpriteConfig.CommonFrame;
            }
            if (_prize.ItemRarity == Rarity.Rare)
            {
                _gridItemFrame.sprite = Configuration.GatchaSpriteConfig.RareFrame;
            }
            if (_prize.ItemRarity == Rarity.Epic)
            {
                _gridItemFrame.sprite = Configuration.GatchaSpriteConfig.EpicFrame;
            }
        }
        
        #endregion
        
        #region MVC: InitItemImage
        
        private void InitItemImage()
        {
            _gridItemImage.sprite =  _prize.ItemSprite;
        }
        
        #endregion
        
        #region MVC:  InitAmountText
        
        private void InitAmountText()
        {
            _gridItemAmount.text = _prize.ItemAmount.ToString();
        }

        #endregion
        
        #region MVC: InitGridItemNumberText
        
        private void InitGridItemNumberText()
        {
            _gridItemNumber.text = Model.Number.ToString();
        }
        
        #endregion
        
        #region MVC: DeInitFrame

        private void DeInitFrame()
        {
            _gridItemFrame.sprite = null;
        }
        
        #endregion
        
        #region MVC: DeInitItemImage

        private void DeInitImage()
        {
            _gridItemImage.sprite = null;
        }

        #endregion
        
        #region MVC: DeInitAmountText

        private void DeInitAmountText()
        {
            _gridItemAmount.text = null;
        }
        
        #endregion
        
        #region MVC: DeInitGridItemNumberText
        
        private void DeInitGridItemNumberText()
        { 
            _gridItemAmount.text = null;
        }
        
        #endregion

        #region SetItemID | SetGridItemData
        
        private void SetGridItemData()
        {
            _prize = ItemManager.Instance.PrizeDataList.Find(prize => prize.ItemID == Model.ItemID);
        }

        #endregion
    }
}