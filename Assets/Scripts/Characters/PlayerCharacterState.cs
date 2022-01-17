using UnityEngine;

namespace Raketa420
{
    public abstract class PlayerCharacterState
    {
        protected PlayerCharacter playerCharacter;
        protected PlayerCharacterStateMachine stateMachine;

        protected PlayerCharacterState(PlayerCharacter playerCharacter, PlayerCharacterStateMachine stateMachine)
        {
            this.playerCharacter = playerCharacter;
            this.stateMachine = stateMachine;
        }

        public virtual void Enter()
        {
        }

        public virtual void HandleInput()
        {
        }

        public virtual void LogicUpdate()
        {
        }

        public virtual void Exit()
        {
        }
    }
}