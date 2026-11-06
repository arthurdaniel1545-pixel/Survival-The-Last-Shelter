using UnityEngine;

namespace SurvivalTheLastShelter.Enemies
{
    public sealed class MutantEnemy : EnemyAIController
    {
        [SerializeField] private float heavyAttackMultiplier = 1.8f;
        [SerializeField] private float chaseSpeedMultiplier = 1.25f;

        protected override void Awake()
        {
            maxHealth = 150f;
            moveSpeed = 3.2f;
            attackDamage = 22f;
            detectionRange = 16f;
            base.Awake();
        }

        protected override void Patrol()
        {
            // Mutant patrols less and reacts aggressively.
            if (Target != null && IsTargetVisible(Target))
            {
                State = EnemyState.Chase;
            }
        }

        protected override void Chase()
        {
            if (Target == null)
            {
                State = EnemyState.Patrol;
                return;
            }

            float distance = Vector3.Distance(transform.position, Target.position);
            if (distance <= attackRange)
            {
                State = EnemyState.Attack;
                return;
            }

            MoveTowards(Target.position, moveSpeed * chaseSpeedMultiplier);
        }

        protected override void Attack()
        {
            if (Target == null)
            {
                State = EnemyState.Patrol;
                return;
            }

            if (Vector3.Distance(transform.position, Target.position) > attackRange * 1.2f)
            {
                State = EnemyState.Chase;
            }
        }

        protected override void Investigate()
        {
            State = EnemyState.Patrol;
        }

        private void MoveTowards(Vector3 destination, float speed)
        {
            Vector3 direction = destination - transform.position;
            direction.y = 0f;
            if (direction.sqrMagnitude < 0.01f) return;
            transform.position += direction.normalized * speed * Time.deltaTime;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), 6f * Time.deltaTime);
        }
    }
}
