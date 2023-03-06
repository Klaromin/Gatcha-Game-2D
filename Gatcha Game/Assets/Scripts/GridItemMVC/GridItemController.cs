using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gatcha.Minigame.Presentation
{
    public class GridItemController : BaseController<GridItemModel, GridItemView>
    {
        #region Constructor
        
        public GridItemController(GridItemModel model, GridItemView view) : base(model, view)
        {
        }
        
        #endregion


    }
}

