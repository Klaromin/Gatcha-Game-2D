
namespace Gatcha.Minigame.Presentation
{
    public class GridItemModel : BaseModel
    {
        public GridItemModel(string itemId, int counter)
        {
            Number = counter;
            ItemID = itemId;
        }
        #region Properities
        
        public string ItemID;
        public int Number;
        
        #endregion
    }
}