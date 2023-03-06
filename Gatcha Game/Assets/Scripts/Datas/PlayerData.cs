using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;


namespace Gatcha.Minigame.Data
{
    [CreateAssetMenu(menuName = "Scriptable Objects/Player Data", fileName = "New Player Data")]
    
    public class PlayerData : ScriptableObject
    {
       public int PlayerLevel;
    }

}
