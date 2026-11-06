using UnityEngine;

namespace SurvivalTheLastShelter.Environment
{
    public enum WeatherType
    {
        Clear,
        Cloudy,
        Rain,
        Fog,
        Storm
    }

    public sealed class WeatherSystem : MonoBehaviour
    {
        [SerializeField] private WeatherType currentWeather = WeatherType.Clear;
        [SerializeField] private float transitionSeconds = 20f;
        [SerializeField] private ParticleSystem rainParticles;
        [SerializeField] private Light lightningLight;

        private WeatherType _targetWeather = WeatherType.Clear;
        private float _transitionProgress = 1f;

        public WeatherType CurrentWeather => currentWeather;

        public void SetWeather(WeatherType weather)
        {
            if (weather == currentWeather) return;
            _targetWeather = weather;
            _transitionProgress = 0f;
        }

        private void Update()
        {
            if (_transitionProgress < 1f)
            {
                _transitionProgress += Time.deltaTime / Mathf.Max(0.1f, transitionSeconds);
                if (_transitionProgress >= 1f)
                {
                    _transitionProgress = 1f;
                    currentWeather = _targetWeather;
                }
            }

            bool raining = currentWeather == WeatherType.Rain || currentWeather == WeatherType.Storm;
            if (rainParticles != null)
            {
                if (raining && !rainParticles.isPlaying) rainParticles.Play();
                if (!raining && rainParticles.isPlaying) rainParticles.Stop();
            }
        }

        public float VisibilityMultiplier
        {
            get
            {
                switch (currentWeather)
                {
                    case WeatherType.Fog: return 0.35f;
                    case WeatherType.Rain: return 0.75f;
                    case WeatherType.Storm: return 0.55f;
                    default: return 1f;
                }
            }
        }
    }
}
