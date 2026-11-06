using UnityEngine;

namespace SurvivalTheLastShelter.Combat
{
    public enum WeaponType
    {
        Melee,
        Pistol,
        Rifle,
        Shotgun
    }

    [CreateAssetMenu(fileName = "Weapon", menuName = "Survival/Combat/Weapon")]
    public sealed class WeaponDefinition : ScriptableObject
    {
        [SerializeField] private string weaponId;
        [SerializeField] private string displayName;
        [SerializeField] private WeaponType type = WeaponType.Melee;
        [SerializeField] private float damage = 10f;
        [SerializeField] private float range = 2f;
        [SerializeField] private float attackCooldown = 0.8f;
        [SerializeField] private int magazineSize = 0;
        [SerializeField] private int reserveAmmo = 0;
        [SerializeField] private float reloadTime = 1.5f;
        [SerializeField] private float staminaCost = 5f;

        public string WeaponId => weaponId;
        public string DisplayName => displayName;
        public WeaponType Type => type;
        public float Damage => damage;
        public float Range => range;
        public float AttackCooldown => attackCooldown;
        public int MagazineSize => magazineSize;
        public int ReserveAmmo => reserveAmmo;
        public float ReloadTime => reloadTime;
        public float StaminaCost => staminaCost;
    }
}
