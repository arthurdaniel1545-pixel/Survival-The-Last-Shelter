using System.Collections.Generic;
using UnityEngine;
using SurvivalTheLastShelter.Enemies;

namespace SurvivalTheLastShelter.Enemies
{
    public sealed class BlindCreature : EnemyAIController
    {
        [SerializeField] private float hearingRadius = 18f;
        [SerializeField] private float investigationDuration = 4f;

        private float _investigationTimer;

        protected override void Awake()
        {
            maxHealth = 80f;
            moveSpeed = 4f;
            attackDamage = 25f;
            detectionRange = 0f;
            base.Awake();
        }

        protected override void Patrol()
        {
            SoundEvent loudest = FindLoudestSound();
            if (loudest != null && Vector3.Distance(transform.position, loudest.Position) <= hearingRadius * loudest.Intensity)
            {
                LastKnownPosition = loudest.Position;
                _investigationTimer = investigationDuration;
                State = EnemyState.Investigate;
            }
        }

        protected override void Chase()
        {
            Investigate();
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
                State = EnemyState.Investigate;
            }
        }

        protected override void Investigate()
        {
            _investigationTimer -= Time.deltaTime;
            MoveTowards(LastKnownPosition, moveSpeed);

            SoundEvent loudest = FindLoudestSound();
            if (loudest != null && Vector3.Distance(transform.position, loudest.Position) <= hearingRadius * loudest.Intensity)
            {
                LastKnownPosition = loudest.Position;
                _investigationTimer = investigationDuration;
            }

            if (_investigationTimer <= 0f)
            {
                State = EnemyState.Patrol;
            }
        }

        private SoundEvent FindLoudestSound()
        {
            SoundEvent best = null;
            float bestScore = 0f;
            foreach (SoundEvent sound in SoundEventSystem.Events)
            {
                if (sound == null) continue;
                float distance = Vector3.Distance(transform.position, sound.Position);
                if (distance > hearingRadius) continue;
                float score = sound.Intensity / Mathf.Max(0.1f, distance);
                if (score > bestScore)
                {
                    bestScore = score;
                    best = sound;
                }
            }
            return best;
        }

        private void MoveTowards(Vector3 destination, float speed)
        {
            Vector3 direction = destination - transform.position;
            direction.y = 0f;
            if (direction.sqrMagnitude < 0.01f) return;
            transform.position += direction.normalized * speed * Time.deltaTime;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), 10f * Time.deltaTime);
        }
    }
}
