using System.Collections;
using UnityEngine;
using SurvivalTheLastShelter.Player;
using SurvivalTheLastShelter.Enemies;

namespace SurvivalTheLastShelter.Combat
{
    public sealed class FirearmController : MonoBehaviour
    {
        [SerializeField] private WeaponDefinition weapon;
        [SerializeField] private Transform muzzle;
        [SerializeField] private LayerMask hitMask = ~0;

        private int _currentAmmo;
        private float _cooldownTimer;
        private bool _isReloading;

        public int CurrentAmmo => _currentAmmo;
        public bool IsReloading => _isReloading;

        private void Awake()
        {
            if (weapon != null) _currentAmmo = weapon.MagazineSize;
        }

        private void Update()
        {
            if (_cooldownTimer > 0f) _cooldownTimer -= Time.deltaTime;
        }

        public bool TryFire()
        {
            if (weapon == null || weapon.Type == WeaponType.Melee) return false;
            if (_isReloading || _cooldownTimer > 0f) return false;
            if (_currentAmmo <= 0)
            {
                Reload();
                return false;
            }

            _currentAmmo--;
            _cooldownTimer = weapon.AttackCooldown;

            Vector3 origin = muzzle != null ? muzzle.position : transform.position;
            Vector3 direction = muzzle != null ? muzzle.forward : transform.forward;

            if (Physics.Raycast(origin, direction, out RaycastHit hit, weapon.Range, hitMask))
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
                Intensity = 1.5f,
                Type = SoundType.Gunshot,
                Source = gameObject
            });

            return true;
        }

        public void Reload()
        {
            if (weapon == null || _isReloading) return;
            StartCoroutine(ReloadRoutine());
        }

        private IEnumerator ReloadRoutine()
        {
            _isReloading = true;
            yield return new WaitForSeconds(weapon.ReloadTime);
            int needed = weapon.MagazineSize - _currentAmmo;
            int available = Mathf.Min(needed, weapon.ReserveAmmo);
            _currentAmmo += available;
            _isReloading = false;
        }
    }
}
