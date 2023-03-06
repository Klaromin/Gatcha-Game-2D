using UnityEngine;
using UnityEngine.UI;
using Gatcha.Minigame.Data;

namespace Gatcha.Minigame.Presentation
{
    public class GatchaUIView : BaseView<GatchaUIModel>
    {
        [SerializeField] private Button _gatchaButton;
        
        #region MVC: Inity | DeInit
        
        public override void Init()
        {
            AddEvents();
        }

        public override void DeInit()
        {
            RemoveEvents();
        }
        
        #endregion
        
        #region OnGameStarted

        private void OnGameStarted()
        {
            if (GatchaManager.Instance.State == GameState.Initial)
            {
                GatchaManager.Instance.UpdateGameState(GameState.Picking);
            }
        }
        
        #endregion

        #region Events: Add Events | Remove Events

        private void AddEvents()
        {
            _gatchaButton.onClick.AddListener(OnGameStarted);
        }

        private void RemoveEvents()
        {
            _gatchaButton.onClick.RemoveAllListeners();
        }

        #endregion

    }
}