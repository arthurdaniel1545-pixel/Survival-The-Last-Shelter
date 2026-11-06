using System.Collections;
using UnityEngine;
using SurvivalTheLastShelter.Player;
using SurvivalTheLastShelter.Enemies;

namespace SurvivalTheLastShelter.Combat
{
    public sealed class MeleeCombatController : MonoBehaviour
    {
        [SerializeField] private WeaponDefinition weapon;
        [SerializeField] private PlayerSurvivalStats survivalStats;
        [SerializeField] private Transform attackOrigin;
        [SerializeField] private LayerMask hitMask = ~0;

        private float _cooldownTimer;

        private void Update()
        {
            if (_cooldownTimer > 0f) _cooldownTimer -= Time.deltaTime;
        }

        public bool TryAttack()
        {
            if (weapon == null || weapon.Type != WeaponType.Melee) return false;
            if (_cooldownTimer > 0f) return false;
            if (survivalStats != null && survivalStats.Stamina.Current < weapon.StaminaCost) return false;

            _cooldownTimer = weapon.AttackCooldown;
            if (survivalStats != null) survivalStats.Stamina.Current = Mathf.Max(0f, survivalStats.Stamina.Current - weapon.StaminaCost);

            Vector3 origin = attackOrigin != null ? attackOrigin.position : transform.position + Vector3.up;
            Vector3 direction = attackOrigin != null ? attackOrigin.forward : transform.forward;

            if (Physics.SphereCast(origin, 0.4f, direction, out RaycastHit hit, weapon.Range, hitMask))
            {
                EnemyAIController enemy = hit.collider.GetComponentInParent<EnemyAIController>();
                if (enemy != null)
                {
                    enemy.TakeDamage(weapon.Damage);
                }
            }

            SoundEventSystem.Emit(new SoundEvent
            {
                Position = origin,
                Intensity = 0.6f,
                Type = SoundType.Impact,
                Source = gameObject
            });

            return true;
        }
    }
}
