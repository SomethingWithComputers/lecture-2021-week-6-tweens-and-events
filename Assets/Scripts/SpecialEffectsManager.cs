using UnityEngine;

public class SpecialEffectsManager : MonoBehaviour
{
    [SerializeField] private GameObject _prefabPoof = null;

    private void Start()
    {
        Enemy.OnSpawned += onEnemySpawned;
        Enemy.OnKilled += onEnemyKilled;
    }

    private void onEnemyKilled(Enemy enemy)
    {
        // An enemy died
        Instantiate(_prefabPoof, enemy.transform.position, Quaternion.identity);
    }

    private void OnDisable()
    {
        Enemy.OnSpawned -= onEnemySpawned;
        Enemy.OnKilled -= onEnemyKilled;
    }

    private void onEnemySpawned(Vector3 spawnLocation)
    {
        Instantiate(_prefabPoof, spawnLocation, Quaternion.identity);
    }
}
