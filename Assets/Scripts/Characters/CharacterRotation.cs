using UnityEngine;

namespace Raketa420
{
    public class CharacterRotation : MonoBehaviour
    {
        [SerializeField] private Transform bodyTransform;

        public void LookAt(Vector3 forwardVector)
        {
            bodyTransform.forward = forwardVector;
        }
    }
}