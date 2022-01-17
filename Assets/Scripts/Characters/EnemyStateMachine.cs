using UnityEngine;

namespace Raketa420
{
    public class EnemyStateMachine : MonoBehaviour
    {
        public EnemyState CurrentState { get; private set; }

        public void Initialize(EnemyState startingState)
        {
            CurrentState = startingState;
            startingState.Enter();
        }

        public void ChangeState(EnemyState newState)
        {
            CurrentState.Exit();
            CurrentState = newState;
            newState.Enter();
        }
    }
}
