using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class DeleteParticleSystemAfterCompletion : MonoBehaviour
{
    private void Start()
    {
        Destroy(gameObject, GetComponent<ParticleSystem>().main.duration + 1.0f);
    }
}
