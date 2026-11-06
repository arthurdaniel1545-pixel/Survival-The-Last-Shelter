using UnityEngine;

namespace SurvivalTheLastShelter.Building
{
    public sealed class Fortification : MonoBehaviour
    {
        [SerializeField] private float maxHealth = 100f;
        [SerializeField] private float repairAmountPerSecond = 5f;

        private float _currentHealth;

        private void Awake()
        {
            _currentHealth = maxHealth;
        }

        public void TakeDamage(float amount)
        {
            _currentHealth = Mathf.Max(0f, _currentHealth - Mathf.Max(0f, amount));
        }

        public void Repair(float amount)
        {
            _currentHealth = Mathf.Min(maxHealth, _currentHealth + Mathf.Max(0f, amount));
        }

        public float CurrentHealth => _currentHealth;
        public float MaxHealth => maxHealth;
        public bool IsDestroyed => _currentHealth <= 0f;
    }
}
