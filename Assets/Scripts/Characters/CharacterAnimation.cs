using UnityEngine;

namespace Raketa420
{
    public class CharacterAnimation : MonoBehaviour
    {
        [SerializeField] private Animator animator;

        public void SetWalkAnimation()
        {
            animator.SetBool("IsWalk", true);
        }

        public void SetIdleAnimation()
        {
            animator.SetBool("IsWalk", false);
        }
    }
}