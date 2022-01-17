using UnityEngine;
using System.Collections;

namespace Raketa420
{
    [RequireComponent(typeof(BombVFX))]

    public class Bomb : MonoBehaviour
    {
        [SerializeField] private float explosionRadius = 5f;
        [SerializeField] private float delayBeforeExplosion = 2f;
        [SerializeField] private float explodeForce = 1000f;
        [SerializeField] private int damageAmount = 250;
        private BombVFX vfx;

        private void Awake()
        {
            vfx = GetComponent<BombVFX>();
        }

        private void OnDrawGizmos()
        {
            Gizmos.DrawWireSphere(transform.position, explosionRadius);
            Gizmos.color = Color.red;
        }

        private void Start()
        {
            StartCoroutine(nameof(ExplodeAfterDelayRoutine), delayBeforeExplosion);
        }

        private void Explode()
        {
            Collider[] collidersToMove = Physics.OverlapSphere(transform.position, explosionRadius);

            foreach (Collider nearbyObject in collidersToMove)
            {
                var rigidBody = nearbyObject.GetComponent<Rigidbody>();

                if (rigidBody != null)
                {
                    rigidBody.AddExplosionForce(explodeForce, transform.position, explosionRadius);
                }
            }

            Collider[] collidersToDamage = Physics.OverlapSphere(transform.position, explosionRadius);

            foreach (Collider nearbyObject in collidersToDamage)
            {
                var damagable = nearbyObject.GetComponent<IDamagable>();

                if (damagable != null)
                {
                    damagable.TakeDamage(damageAmount);
                }
            }

            vfx.PlayExplosionVFX(transform.position);
            Destroy(gameObject);
        }

        private IEnumerator ExplodeAfterDelayRoutine(float delay)
        {
            yield return new WaitForSeconds(delay);

            Explode();

            yield break;
        }
    }
}
