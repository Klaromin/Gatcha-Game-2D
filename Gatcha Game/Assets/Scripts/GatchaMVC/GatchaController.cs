using System;
using Gatcha.Minigame.Data;
namespace Gatcha.Minigame.Presentation
{
    public class GatchaController : BaseController<GatchaModel, GatchaView>
    {
        private GatchaUIController _gatchaUIController;
        
        #region Constructor
        
        public GatchaController(GatchaModel model, GatchaView view) : base(model, view)
        {
        }
        
        #endregion
        
        #region MVC: OnInit | OnDeInit

        protected override void OnInit()
        {
            InitializeInnerMVCs();
        }

        protected override void OnDeInit()
        {
            DeInitializeInnerMVCs();
        }

        #endregion
        
        #region MVC: InitializeInnerMVCs | DeInitializeInnerMVCs

        private void InitializeInnerMVCs()
        {
            InitializeGatchaUI();
        }
        
        private void DeInitializeInnerMVCs()
        {
            DeInitializeGatchaUI();
        }
        
        #endregion

        #region MVC: InitializeGatchaUI |  DeInitializeGatchaUI
        private void InitializeGatchaUI()
        {
            GatchaUIView view = View._GatchaUIView;
            GatchaUIModel model = new GatchaUIModel();
            GatchaUIController controller = new GatchaUIController(model, view);
            _gatchaUIController = controller;
            controller.Init();
        }
        
        private void DeInitializeGatchaUI()
        {
            _gatchaUIController = null;
        }
        
        #endregion

    }
    
}