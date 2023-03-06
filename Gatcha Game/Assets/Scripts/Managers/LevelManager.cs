using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Gatcha.Minigame.Data;

public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance { get; private set; }
    // private int _playerLevel; 
    private PlayerData _playerData;
    public int PlayerLevel => _playerData.PlayerLevel;
    
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
        _playerData = Resources.Load<PlayerData>("Player Data/Player Data");
        // PlayerLevel = _playerData.PlayerLevel;
    }

    private void Start()
    {
        Debug.Log(PlayerLevel);
    }
}
