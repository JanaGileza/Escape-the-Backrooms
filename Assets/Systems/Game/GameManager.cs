using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public EnemyData LastEnemyThatKilledPlayer;
    public static GameManager Instance;

    void Awake()
    {
        Instance = this;
        LastEnemyThatKilledPlayer = null;
    }

    void OnEnable()
    {
        EnemyBehavior.OnEnemyKilledPlayer += HandlePlayerDeath;
    }

    void OnDisable()
    {
        EnemyBehavior.OnEnemyKilledPlayer -= HandlePlayerDeath;
    }

    void HandlePlayerDeath(EnemyData enemyData)
    {
        LastEnemyThatKilledPlayer = enemyData;
        SceneLoader.Instance.LoadScene(Scenes.GameOver);
    }
}

