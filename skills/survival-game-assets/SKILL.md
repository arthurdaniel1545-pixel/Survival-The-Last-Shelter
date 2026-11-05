---
name: survival-game-assets
description: Find, verify, import, optimize, and document free 3D assets for Survival: The Last Shelter in Unity 6.3 LTS.
---

# Survival: The Last Shelter — Asset workflow

## Project context
- Engine: Unity 6.3 LTS.
- Target: Android first, including low-end devices such as Moto G24 (Helio G85).
- Art direction: modern low-poly 3D, readable silhouettes, muted post-apocalyptic palette. Never use PS1/PSX, pixel art, or photorealistic high-poly assets as the default.
- First release: offline single-player.
- Required world: exactly 3 main cities and exactly 2 large forests; optional points of interest may vary.
- Budget: free only. Never enable paid plans, paid credits, subscriptions, or payment methods.

## Asset sources and MCP endpoints
Use remote HTTP MCP servers when available:
1. General asset search/download: `https://3d.shep.bot/mcp`
   - Search across multiple 3D asset sources.
   - Prefer free downloadable models and inspect each asset's individual licence.
2. Curated CC0 GLB library: `https://3dassets.dev/mcp`
   - Prefer for ready-to-use GLB props, buildings, nature, weapons, and environment pieces.
3. Rigged/animated low-poly characters: `https://gobkit.com/mcp`
   - Use for player/enemy character candidates and inspect available animation clip names.

If a server is unavailable in the Android Harness, do not pretend it is connected. Use its public web/API documentation only if accessible, and report the limitation.

## Search order
Search for assets in small batches:
1. Player survivor: low-poly humanoid, rigged, idle/walk/run.
2. Enemies: common zombie, heavy mutant, blind sound-hunter creature.
3. Environment: modular abandoned buildings, road pieces, rubble, fences, city props.
4. Nature: low-poly trees, bushes, rocks, ground/forest props.
5. Gameplay props: backpack, helmet, vest, weapons, medical supplies, food, water, crafting materials.
6. Audio: footsteps, ambience, creature sounds, attacks, UI feedback.

Do not download large packs before inspecting candidates. Prefer coherent packs with a shared visual style.

## Licence rules
- Prefer CC0 / public-domain assets.
- CC-BY and other attribution licences may be used only when the exact attribution text and source are recorded in `Assets/ThirdParty/ASSET_CREDITS.md`.
- Reject assets with unknown, non-commercial, restrictive, or unclear licences.
- Never remove creator names or licence notices.
- Do not use ripped assets from commercial games, copyrighted characters, or unauthorised uploads.
- Before importing an asset, record: asset name, creator, source URL, licence, attribution requirement, download date, file format.

## Unity import and mobile optimisation
- Prefer GLB/glTF or FBX models with documented skeletons and animation clips.
- Keep player/enemy models low-poly and use small textures (start at 512–1024 px; use 2K only when justified).
- Avoid unnecessary materials, transparent shaders, 4K textures, dense meshes, and excessive bones.
- Use shared materials and atlases where practical.
- Use LODs for large environment assets when available.
- Compress textures for Android and use mobile-friendly shaders.
- Check scale, forward axis, pivot, normals, materials, rig, and animation clips after import.
- Never assume a model is rigged just because it is humanoid.
- Keep original downloaded files and licence records separate from generated Unity prefabs.

## Safe workflow
1. Search and return 3–5 candidates with preview, format, licence, polygon/texture details if available.
2. Choose the best candidate for visual style, mobile performance, and licence.
3. Download only after confirming it is free and its licence is acceptable.
4. Add the file under a clear folder in `Assets/Art/`.
5. Add a matching entry to `Assets/ThirdParty/ASSET_CREDITS.md`.
6. Create a prefab only after import checks. Do not invent animation clip names or rig mappings.
7. If import or preview cannot be tested in Unity Editor, state that it is unverified.

## Required output for each asset batch
Report:
- What was searched and selected.
- Exact asset source and licence.
- Files added and their paths.
- Whether the Unity import/prefab was actually tested.
- Any missing animations, dependencies, or mobile-performance concerns.

## Project-specific first batch
Start with:
- One rigged player survivor with idle, walk, and run if available.
- One common zombie with locomotion animation.
- One heavy mutant candidate.
- One blind creature candidate (it may need a custom material/mesh treatment).
- A small modular abandoned-city kit.
- A small low-poly forest kit.

Do not build the whole game around placeholder primitives once suitable assets are available. Do not claim an asset is in the repository until the file itself has been committed.
