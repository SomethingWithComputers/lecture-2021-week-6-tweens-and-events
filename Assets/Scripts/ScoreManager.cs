using System;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int _score = 0;
    
    void Start()
    {
        Enemy.OnKilled += onEnemyKilled;
    }

    private void OnDisable()
    {
        Enemy.OnKilled -= onEnemyKilled;
    }

    private void onEnemyKilled(Enemy enemy)
    {
        _score += 1;
        Debug.Log("Current score: "+ _score);
        // Update the score on the HUD
    }
}
