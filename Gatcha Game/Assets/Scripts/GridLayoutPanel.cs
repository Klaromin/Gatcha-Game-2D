using UnityEngine;

namespace Gatcha.Minigame.Presentation
{
    public class GridLayoutPanel : MonoBehaviour
    {
        [SerializeField] private GridItemView _gridItemView;
        
        #region Unity: Start
    
        private void Start()
        {
            InitInnerMVCs();
        }
    
        #endregion
    
        #region MVC: InitInnerMVCs
        
        private void InitInnerMVCs()
        {
            var counter = 1;
            foreach (var itemID in ItemManager.Instance.SelectedItemDataIdList)
            {
                GridItemModel model = new GridItemModel(itemID, counter);
                GridItemView view = Instantiate(_gridItemView, transform);
                GridItemController gridItemController = new GridItemController(model, view);
                counter++;
                gridItemController.Init();
            }
        }
    
        #endregion
    }
}