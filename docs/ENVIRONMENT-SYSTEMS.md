# Environment, day/night and weather

Scripts added:

- `DayNightCycle.cs`
- `WeatherSystem.cs`

## Integration implemented in code

- `DayNightCycle` now updates ambient light intensity.
- `WeatherSystem` now handles rain and storm audio volumes.
- `PlayerSurvivalStats` now supports weather exposure drain.
- `EnemyAIController` now adjusts detection range by night and weather visibility.

## Unity Editor work still required

- Assign sun, moon, sky gradient and particle systems.
- Configure audio sources for rain, wind and thunder.
- Connect weather effects to player survival and enemy visibility.
- Validate performance on Moto G24.
- No scene, prefab or runtime test has been performed.
