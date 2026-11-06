using UnityEngine;

namespace SurvivalTheLastShelter.Enemies
{
    public sealed class ZombieEnemy : EnemyAIController
    {
        [SerializeField] private float attackCooldown = 1.2f;
        private float _attackTimer;

        protected override void Patrol()
        {
            if (patrolPoints == null || patrolPoints.Length == 0) return;

            Transform point = patrolPoints[PatrolIndex];
            MoveTowards(point.position, moveSpeed * 0.6f);

            if (Vector3.Distance(transform.position, point.position) < 1f)
            {
                PatrolIndex = (PatrolIndex + 1) % patrolPoints.Length;
            }

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

            if (!IsTargetVisible(Target))
            {
                LastKnownPosition = Target.position;
                State = EnemyState.Investigate;
                return;
            }

            MoveTowards(Target.position, moveSpeed);
        }

        protected override void Attack()
        {
            if (Target == null)
            {
                State = EnemyState.Patrol;
                return;
            }

            _attackTimer -= Time.deltaTime;
            if (_attackTimer <= 0f)
            {
                // Damage application is prepared for future combat integration.
                _attackTimer = attackCooldown;
            }

            if (Vector3.Distance(transform.position, Target.position) > attackRange * 1.2f)
            {
                State = EnemyState.Chase;
            }
        }

        protected override void Investigate()
        {
            MoveTowards(LastKnownPosition, moveSpeed * 0.7f);
            if (Vector3.Distance(transform.position, LastKnownPosition) < 1.5f)
            {
                State = EnemyState.Patrol;
            }

            if (Target != null && IsTargetVisible(Target))
            {
                State = EnemyState.Chase;
            }
        }

        private void MoveTowards(Vector3 destination, float speed)
        {
            Vector3 direction = (destination - transform.position);
            direction.y = 0f;
            if (direction.sqrMagnitude < 0.01f) return;
            transform.position += direction.normalized * speed * Time.deltaTime;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), 8f * Time.deltaTime);
        }
    }
}
