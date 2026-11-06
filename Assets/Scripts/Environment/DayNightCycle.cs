using UnityEngine;

namespace SurvivalTheLastShelter.Environment
{
    public sealed class DayNightCycle : MonoBehaviour
    {
        [SerializeField] private float dayLengthSeconds = 1200f;
        [SerializeField] private Light sun;
        [SerializeField] private Light moon;
        [SerializeField] private Gradient skyColor;
        [SerializeField] private AnimationCurve sunIntensity;

        private float _timeOfDay;

        public float TimeOfDay => _timeOfDay; // 0..1
        public bool IsNight => _timeOfDay < 0.25f || _timeOfDay > 0.75f;

        private void Update()
        {
            _timeOfDay += Time.deltaTime / Mathf.Max(1f, dayLengthSeconds);
            if (_timeOfDay >= 1f) _timeOfDay -= 1f;

            if (sun != null)
            {
                sun.transform.rotation = Quaternion.Euler((_timeOfDay * 360f) - 90f, 170f, 0f);
                sun.intensity = sunIntensity != null ? sunIntensity.Evaluate(_timeOfDay) : 1f;
            }

            if (moon != null)
            {
                moon.transform.rotation = Quaternion.Euler((_timeOfDay * 360f) + 90f, 170f, 0f);
                moon.intensity = IsNight ? 0.35f : 0f;
            }
        }
    }
}
