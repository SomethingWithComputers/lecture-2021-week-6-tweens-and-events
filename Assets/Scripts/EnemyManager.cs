using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] private GameObject _prefabEnemy = null;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 spawnLocation = new Vector3(Random.Range(-8.0f, 8.0f), transform.position.y,
                Random.Range(-10.0f, 10.0f));
            Instantiate(_prefabEnemy, spawnLocation, Quaternion.identity);
        }
    }
}
