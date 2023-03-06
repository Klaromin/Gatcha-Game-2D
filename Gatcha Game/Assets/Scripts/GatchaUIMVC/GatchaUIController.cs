namespace Gatcha.Minigame.Presentation
{
    public class GatchaUIController : BaseController<GatchaUIModel, GatchaUIView>
    {
       
        #region Constructor
    
        public GatchaUIController(GatchaUIModel model, GatchaUIView view) : base(model, view)
        {
        }
    
        #endregion
    }
}