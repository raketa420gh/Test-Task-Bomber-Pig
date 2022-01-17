namespace Raketa420
{
    public class PlayerCharacterInactionState : PlayerCharacterState
    {
        public PlayerCharacterInactionState(PlayerCharacter playerCharacter, PlayerCharacterStateMachine stateMachine) : base(playerCharacter, stateMachine)
        {
        }

        public override void Enter()
        {
            base.Enter();
            playerCharacter.Animation.SetIdleAnimation();
        }

        public override void LogicUpdate()
        {
            base.LogicUpdate();

            if (!playerCharacter.Input.IsEnabled)
                return;

            if (playerCharacter.Input.IsJoystickDragged())
            {
                stateMachine.ChangeState(playerCharacter.walkState);
            }
        }
    }
}

