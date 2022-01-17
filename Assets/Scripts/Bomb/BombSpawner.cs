using UnityEngine;

namespace Raketa420
{
    public class BombSpawner : MonoBehaviour
    {
        [SerializeField] private Bomb bombPrefab;
        [SerializeField] private Transform spawnPoint;

        public void Spawn()
        {
            var bombObject = Instantiate(bombPrefab, spawnPoint.position, Quaternion.identity);
        }
    }
}

