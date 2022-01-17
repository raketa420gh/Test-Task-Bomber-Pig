using UnityEngine;

namespace Raketa420
{
    public class PlayerCharacterWalkState : PlayerCharacterState
    {
        public PlayerCharacterWalkState(PlayerCharacter playerCharacter, PlayerCharacterStateMachine stateMachine) : base(playerCharacter, stateMachine)
        {
        }

        public override void Enter()
        {
            base.Enter();
            playerCharacter.Animation.SetWalkAnimation();
        }

        public override void LogicUpdate()
        {
            base.LogicUpdate();

            if (!playerCharacter.Input.IsEnabled)
                return;

            var moveDirection =
               new Vector3(playerCharacter.Input.GetInputDirection().x, 0, playerCharacter.Input.GetInputDirection().y);

            playerCharacter.Movement.Move(moveDirection);

            if (!playerCharacter.Input.IsJoystickDragged())
            {
                stateMachine.ChangeState(playerCharacter.inactionState);
            }
            else
            {
                playerCharacter.Rotation.LookAt(moveDirection);
            }
        }
    }
}
