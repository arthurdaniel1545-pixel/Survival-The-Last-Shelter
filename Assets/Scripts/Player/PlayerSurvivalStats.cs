using System;
using UnityEngine;

namespace SurvivalTheLastShelter.Player
{
    [Serializable]
    public sealed class SurvivalStat
    {
        public float Current = 100f;
        public float Max = 100f;
        public float DrainPerSecond = 0f;
        public float RecoveryPerSecond = 0f;

        public float Normalized => Max <= 0f ? 0f : Mathf.Clamp01(Current / Max);

        public void Tick(float deltaTime, bool canRecover)
        {
            Current -= DrainPerSecond * deltaTime;
            if (canRecover) Current += RecoveryPerSecond * deltaTime;
            Current = Mathf.Clamp(Current, 0f, Max);
        }
    }

    [Serializable]
    public sealed class PlayerSurvivalStats
    {
        public SurvivalStat Health = new SurvivalStat { Current = 100f, Max = 100f, DrainPerSecond = 0f, RecoveryPerSecond = 0f };
        public SurvivalStat Hunger = new SurvivalStat { Current = 100f, Max = 100f, DrainPerSecond = 0.05f, RecoveryPerSecond = 0f };
        public SurvivalStat Thirst = new SurvivalStat { Current = 100f, Max = 100f, DrainPerSecond = 0.08f, RecoveryPerSecond = 0f };
        public SurvivalStat Stamina = new SurvivalStat { Current = 100f, Max = 100f, DrainPerSecond = 0f, RecoveryPerSecond = 5f };

        public void Tick(float deltaTime, bool isRunning)
        {
            Hunger.Tick(deltaTime, false);
            Thirst.Tick(deltaTime, false);

            float staminaDrain = isRunning ? 8f : 0f;
            Stamina.DrainPerSecond = staminaDrain;
            Stamina.Tick(deltaTime, !isRunning);

            // Low hunger/thirst reduce health.
            if (Hunger.Current <= 0f || Thirst.Current <= 0f)
            {
                Health.DrainPerSecond = 2f;
                Health.Tick(deltaTime, false);
            }
            else
            {
                Health.DrainPerSecond = 0f;
                Health.Tick(deltaTime, Health.Current < Health.Max);
            }
        }

        public bool IsAlive => Health.Current > 0f;

        public void ApplyWeatherExposure(SurvivalTheLastShelter.Environment.WeatherType weather, bool isNight)
        {
            float drain = 0f;
            if (weather == SurvivalTheLastShelter.Environment.WeatherType.Rain || weather == SurvivalTheLastShelter.Environment.WeatherType.Storm)
            {
                drain += 0.02f;
            }
            if (isNight)
            {
                drain += 0.01f;
            }
            Health.DrainPerSecond = Mathf.Max(Health.DrainPerSecond, drain);
        }
    }
}
