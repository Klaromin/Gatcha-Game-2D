using UnityEngine;


namespace Gatcha.Minigame.Data
{
    [CreateAssetMenu(menuName = "Scriptable Objects/Grid Item Data", fileName = "New Grid Item Data")]
    public class GridItemData : ScriptableObject
    {
        #region Properities
        
        public Type ItemType;
        public int Amount;
        public string ID;
        
        #endregion

    }
}



