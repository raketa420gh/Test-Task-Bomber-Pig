using UnityEngine;

public class VfxObject : MonoBehaviour
{
    private ParticleSystem particleSystem;

    private void Awake()
    {
        particleSystem = GetComponent<ParticleSystem>();

        if (!particleSystem)
        {
            Debug.Log($"ParticleSystem not found");
        }
    }

    public void PlayOneShot()
    {
        particleSystem.Play();
        Destroy(gameObject, particleSystem.main.duration);
    }
}
