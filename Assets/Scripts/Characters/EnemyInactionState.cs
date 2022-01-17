using UnityEngine;

namespace Raketa420
{
    public class EnemyInactionState : EnemyState
    {
        private float timer = 0f;
        private float waitingTime = 3f;

        public EnemyInactionState(Enemy enemy, EnemyStateMachine stateMachine) : base(enemy, stateMachine)
        {
        }

        public override void Enter()
        {
            base.Enter();
            enemy.Animation.SetIdleAnimation();
            timer = 0f;
        }

        public override void LogicUpdate()
        {
            base.LogicUpdate();

            timer += Time.deltaTime;

            if (timer > waitingTime)
            {
                enemy.stateMachine.ChangeState(enemy.walkToRandomPointState);
            }
        }
    }
}

