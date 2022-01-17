using UnityEngine;

namespace Raketa420
{
    [RequireComponent(typeof(PathfindingMovement))]
    [RequireComponent(typeof(CharacterAnimation))]
    [RequireComponent(typeof(Health))]

    public class Enemy : MonoBehaviour
    {
        private PathfindingMovement movement;
        private CharacterAnimation animation;
        private Health health;

        public EnemyStateMachine stateMachine;
        public EnemyInactionState inactionState;
        public EnemyWalkToRandomPointState walkToRandomPointState;

        public PathfindingMovement Movement => movement;
        public CharacterAnimation Animation => animation;

        private void Update()
        {
            stateMachine.CurrentState.LogicUpdate();
        }

        public void Initialize()
        {
            movement = GetComponent<PathfindingMovement>();
            animation = GetComponent<CharacterAnimation>();
            health = GetComponent<Health>();

            movement.Initialize();
            health.Initialize();

            InitializeStateMachine();
        }

        private void InitializeStateMachine()
        {
            stateMachine = GetComponent<EnemyStateMachine>();
            inactionState = new EnemyInactionState(this, stateMachine);
            walkToRandomPointState = new EnemyWalkToRandomPointState(this, stateMachine);

            stateMachine.Initialize(inactionState);
        }
    }
}