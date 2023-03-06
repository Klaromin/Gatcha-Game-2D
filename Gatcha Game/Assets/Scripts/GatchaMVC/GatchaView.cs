using UnityEngine;

namespace Gatcha.Minigame.Presentation
{
    public class GatchaView : BaseView<GatchaModel>
    {
        [SerializeField] private GatchaUIView _gatchaUIView;
        public GatchaUIView _GatchaUIView => _gatchaUIView;
        
        #region MVC: Init | DeInit
    
        public override void Init()
        {
            
        }

        public override void DeInit()
        {
            
        }
    
        #endregion
    }
}