# Demo survival area — preparation

This document prepares the first explorable 3D survival area. It does not claim that a scene, prefab, or build has been tested.

## Area concept

- Abandoned suburb edge connected to a forest border.
- One drivable street with abandoned vehicles, barricades and debris.
- One explorable building with an interior.
- Irregular terrain with rocks and vegetation.
- Space for player and zombie spawns.

## Asset loading

- Models are stored as GLB under `Assets/Art/Environment/`.
- Runtime loading should use the free glTFast package (`com.unity.cloud.gltfast`) declared in `Packages/manifest.json`.
- Preserve original GLB files; do not overwrite source assets.

## World rules

- The generated world must always preserve exactly 3 main cities and exactly 2 large forests.
- The demo area is only a small slice and must not replace the required world layout.

## Unity Editor work still required

- Create the scene.
- Import and place GLB assets.
- Configure colliders, NavMesh, lighting and materials.
- Validate player movement, camera, zombie AI and performance on Moto G24.
