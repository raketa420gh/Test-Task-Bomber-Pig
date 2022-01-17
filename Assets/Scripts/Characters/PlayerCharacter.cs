using UnityEngine;

namespace Raketa420
{
    [RequireComponent(typeof(CharacterMovement))]
    [RequireComponent(typeof(CharacterRotation))]
    [RequireComponent(typeof(CharacterAnimation))]
    [RequireComponent(typeof(Health))]
    [RequireComponent(typeof(BombSpawner))]

    public class PlayerCharacter : MonoBehaviour
    {
        [SerializeField] private UserInput input;
        private CharacterMovement movement;
        private CharacterRotation rotation;
        private CharacterAnimation animation;
        private Health health;
        private BombSpawner spawner;

        public PlayerCharacterStateMachine stateMachine;
        public PlayerCharacterInactionState inactionState;
        public PlayerCharacterWalkState walkState;

        public UserInput Input => input;
        public CharacterMovement Movement => movement;
        public CharacterRotation Rotation => rotation;
        public CharacterAnimation Animation => animation;

        private void Update()
        {
            stateMachine.CurrentState.LogicUpdate();
        }

        public void Initialize()
        {
            movement = GetComponent<CharacterMovement>();
            rotation = GetComponent<CharacterRotation>();
            animation = GetComponent<CharacterAnimation>();
            health = GetComponent<Health>();

            movement.Initialize();
            health.Initialize();

            InitializeStateMachine();
        }

        private void InitializeStateMachine()
        {
            stateMachine = GetComponent<PlayerCharacterStateMachine>();
            inactionState = new PlayerCharacterInactionState(this, stateMachine);
            walkState = new PlayerCharacterWalkState(this, stateMachine);

            stateMachine.Initialize(inactionState);
        }
    }
}

