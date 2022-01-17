using UnityEngine;

namespace Raketa420
{
    public class BombVFX : MonoBehaviour
    {
        [SerializeField] private VfxObject explosionVFX;

        public void PlayExplosionVFX(Vector3 position)
        {
            var vfxObject = Instantiate(explosionVFX, position, Quaternion.identity);
            vfxObject.PlayOneShot();
        }
    }
}