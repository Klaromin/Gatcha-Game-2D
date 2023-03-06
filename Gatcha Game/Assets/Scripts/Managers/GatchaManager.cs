using System;
using System.Threading.Tasks;
using Gatcha.Minigame.Data;
using UnityEngine;

namespace Gatcha.Minigame.Presentation
{
    public class GatchaManager : MonoBehaviour
    {
        [SerializeField] private RewardPopUpPanel _popup;
        [SerializeField] private GatchaView _gatchaView;
        private GameState _state;
        public GameState State => _state;
        private GatchaController _gatchaController;
        public static GatchaManager Instance { get; private set; }
        
        #region Unity: Awake | OnDisable | Start
        
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
        }

        private void Start()
        {
            InitializeInnerMVC();
        }

        private void OnDisable()
        {
            DeInitializeInnerMVC();
        }

        #endregion

        #region Event: UpdateGameState | HandlePicking | HandleReward
        
        public void UpdateGameState(GameState newState)
        {
            _state = newState;
            switch (newState)
            {
                case GameState.Initial:
                    break;
                case GameState.Picking:
                    HandlePicking();
                    break;
                case GameState.Reward:
                    HandleReward();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(newState), newState, null);
            }
        }

        private async void HandlePicking()
        {
            RewardManager.Instance.SetPrizeItem();
            Debug.Log(RewardManager.Instance.PrizeId);
            await Task.Delay(3000);
            UpdateGameState(GameState.Reward);
        }
        
        private async void HandleReward()
        {
            _popup.Show();
            await Task.Delay(5000);
            UpdateGameState(GameState.Initial);
        }
    
        #endregion

        #region MVC: InitializeInnerMVC
        
        private void InitializeInnerMVC()
        {
            var model = new GatchaModel();
            var view = _gatchaView;
            var controller = new GatchaController(model, view);
            _gatchaController = controller;
            _gatchaController.Init();
        }   
        
        #endregion
        
        #region DeInitializeInnerMVC

        private void DeInitializeInnerMVC()
        {
            _gatchaController = null;
        }
        
        #endregion

    }
}