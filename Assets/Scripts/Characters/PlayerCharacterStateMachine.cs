using UnityEngine;

namespace Raketa420
{
    public class PlayerCharacterStateMachine : MonoBehaviour
    {
        public PlayerCharacterState CurrentState { get; private set; }

        public void Initialize(PlayerCharacterState startingState)
        {
            CurrentState = startingState;
            startingState.Enter();
        }

        public void ChangeState(PlayerCharacterState newState)
        {
            CurrentState.Exit();
            CurrentState = newState;
            newState.Enter();
        }
    }
}
