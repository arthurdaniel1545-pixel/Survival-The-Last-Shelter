using UnityEngine;
using SurvivalTheLastShelter.Characters;
using SurvivalTheLastShelter.Player;

namespace SurvivalTheLastShelter.Player
{
    public sealed class PlayerCharacterVisual : MonoBehaviour
    {
        [SerializeField] private CharacterSex sex = CharacterSex.Male;
        [SerializeField] private CharacterModelCatalog modelCatalog;
        [SerializeField] private CharacterAnimationSet animationSet = new CharacterAnimationSet();
        [SerializeField] private PlayerMovementController movementController;
        [SerializeField] private PlayerSurvivalStats survivalStats;

        [Header("Attachment points")]
        [SerializeField] private Transform headSocket;
        [SerializeField] private Transform backSocket;
        [SerializeField] private Transform rightHandSocket;
        [SerializeField] private Transform leftHandSocket;

        public CharacterSex Sex => sex;
        public CharacterAnimationSet AnimationSet => animationSet;

        public void SetSex(CharacterSex value)
        {
            sex = value;
        }

        public CharacterModelCatalog.CharacterModelEntry GetModelEntry()
        {
            return modelCatalog != null ? modelCatalog.Get(sex) : null;
        }

        public string GetRelativeModelPath()
        {
            CharacterModelCatalog.CharacterModelEntry entry = GetModelEntry();
            return entry != null ? entry.RelativeModelPath : string.Empty;
        }

        public Transform HeadSocket => headSocket;
        public Transform BackSocket => backSocket;
        public Transform RightHandSocket => rightHandSocket;
        public Transform LeftHandSocket => leftHandSocket;
    }
}
