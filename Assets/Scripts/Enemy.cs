using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public static event Action<Vector3> OnSpawned = delegate {  };
    public static event Action<Enemy> OnKilled = delegate {  };
    
    [SerializeField] private float _duration = 0.32f;
    private void Start()
    {
        LeanTween.scale(gameObject, new Vector3(1, 1, 1), _duration).setEaseOutBack();

        OnSpawned(transform.position);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            LeanTween.scale(gameObject, Vector3.zero, _duration).setEaseInOutCubic().setOnComplete(() =>
            {
                OnKilled(this);
                Destroy(gameObject);
            });
            
        }
    }
}
