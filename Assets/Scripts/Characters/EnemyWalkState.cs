using UnityEngine;

namespace Raketa420
{
    public class EnemyWalkToRandomPointState : EnemyState
    {
        private float interactDistance = 0.75f;

        public EnemyWalkToRandomPointState(Enemy enemy, EnemyStateMachine stateMachine) : base(enemy, stateMachine)
        {
        }

        public override void Enter()
        {
            base.Enter();
            enemy.Animation.SetWalkAnimation();
            enemy.Movement.MoveTo(GetRandomPoint());
        }

        public override void LogicUpdate()
        {
            base.LogicUpdate();

            if (Vector3.Distance(enemy.transform.position, enemy.Movement.AiPath.destination) < interactDistance)
            {
                enemy.stateMachine.ChangeState(enemy.inactionState);
            }
        }

        private Vector3 GetRandomPoint()
        {
            var randomX = Random.Range(-9.5f, 9.5f);
            var randomZ = Random.Range(-6f, 6f);
            var randomPosition = new Vector3(randomX, 0, randomZ);

            return randomPosition;
        }
    }
}
