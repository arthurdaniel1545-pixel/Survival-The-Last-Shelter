using UnityEngine;

namespace SurvivalTheLastShelter.Characters
{
    /// <summary>
    /// Data definition for the common zombie enemy.
    /// The TeenZombie GLB currently contains no animation clips in its glTF data,
    /// so animation work remains pending until a rigged replacement is verified.
    /// </summary>
    [CreateAssetMenu(fileName = "ZombieEnemy", menuName = "Survival/Enemies/Zombie")]
    public sealed class ZombieEnemyDefinition : ScriptableObject
    {
        [SerializeField] private string enemyId = "zombie_common";
        [SerializeField] private string displayName = "Common Zombie";
        [SerializeField] private string relativeModelPath = "Assets/Art/Characters/Enemies/TeenZombie.glb";
        [SerializeField] private bool hasVerifiedAnimations = false;
        [SerializeField] private string[] requiredClips = { "Idle", "Walk", "Run", "Attack", "Hit", "Death" };

        public string EnemyId => enemyId;
        public string DisplayName => displayName;
        public string RelativeModelPath => relativeModelPath;
        public bool HasVerifiedAnimations => hasVerifiedAnimations;
        public string[] RequiredClips => requiredClips;
    }
}
