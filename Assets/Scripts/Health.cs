using UnityEngine;

namespace Raketa420
{
    public class Health : MonoBehaviour, IDamagable
    {
        [SerializeField] private int maxHealth = 100;
        private int currentHealth;

        public void Initialize()
        {
            currentHealth = maxHealth;
        }

        public void TakeDamage(int damageAmount)
        {
            if (damageAmount > 0)
            {
                ChangeHealth(-damageAmount);
            }
        }

        private void ChangeHealth(int amount)
        {
            currentHealth += amount;

            if (currentHealth <= 0)
            {
                Destroy(gameObject);
            }

            if (currentHealth >= maxHealth)
            {
                currentHealth = maxHealth;
            }
        }
    }
}
