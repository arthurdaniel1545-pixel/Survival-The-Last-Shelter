using UnityEngine;

namespace SurvivalTheLastShelter.Enemies
{
    public enum EnemyState
    {
        Patrol,
        Chase,
        Attack,
        Investigate,
        Dead
    }

    public abstract class EnemyAIController : MonoBehaviour
    {
        [SerializeField] protected float maxHealth = 50f;
        [SerializeField] protected float moveSpeed = 2.5f;
        [SerializeField] protected float attackRange = 1.5f;
        [SerializeField] protected float attackDamage = 10f;
        [SerializeField] protected float detectionRange = 12f;
        [SerializeField] protected Transform[] patrolPoints;

        protected float CurrentHealth;
        protected EnemyState State = EnemyState.Patrol;
        protected Transform Target;
        protected Vector3 LastKnownPosition;
        protected int PatrolIndex;

        protected virtual void Awake()
        {
            CurrentHealth = maxHealth;
        }

        protected virtual void Update()
        {
            if (State == EnemyState.Dead) return;

            switch (State)
            {
                case EnemyState.Patrol: Patrol(); break;
                case EnemyState.Chase: Chase(); break;
                case EnemyState.Attack: Attack(); break;
                case EnemyState.Investigate: Investigate(); break;
            }
        }

        protected abstract void Patrol();
        protected abstract void Chase();
        protected abstract void Attack();
        protected abstract void Investigate();

        public virtual void TakeDamage(float amount)
        {
            if (State == EnemyState.Dead) return;
            CurrentHealth -= Mathf.Max(0f, amount);
            if (CurrentHealth <= 0f)
            {
                State = EnemyState.Dead;
            }
        }

        protected bool IsTargetVisible(Transform targetTransform)
        {
            if (targetTransform == null) return false;
            float distance = Vector3.Distance(transform.position, targetTransform.position);
            if (distance > detectionRange) return false;
            Vector3 direction = (targetTransform.position - transform.position).normalized;
            if (Physics.Raycast(transform.position + Vector3.up, direction, out RaycastHit hit, detectionRange))
            {
                return hit.transform == targetTransform;
            }
            return true;
        }
    }
}
