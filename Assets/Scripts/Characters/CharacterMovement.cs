using UnityEngine;

namespace Raketa420
{
    [RequireComponent(typeof(CharacterController))]

    public class CharacterMovement : MonoBehaviour
    {
        [SerializeField] private float speed = 5f;
        private CharacterController controller;
        private float gravity = 9.81f;

        private void Update()
        {
            if (!controller.isGrounded)
            {
                Move(Vector3.down * gravity);
            }
        }

        public void Initialize()
        {
            controller = GetComponent<CharacterController>();
        }

        public void Move(Vector3 direction)
        {
            controller.Move(direction * speed * Time.deltaTime);
        }
    }
}