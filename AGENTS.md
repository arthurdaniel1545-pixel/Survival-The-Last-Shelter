# Agent instructions — Survival: The Last Shelter

Read `README.md`, `docs/CONCEPT.md`, `docs/ROADMAP.md`, `docs/CHARACTERS-EQUIPMENT.md`, `skills/survival-game-assets/SKILL.md`, and `skills/unity-survival-systems/SKILL.md` before changing project architecture, implementing gameplay, or sourcing assets.

## Non-negotiable project rules
- Unity 6.3 LTS; do not switch to Godot or another engine.
- Android-first, low-end-device-aware, modern low-poly 3D. Character art must be humanoid with believable human proportions and moderately stylised detail; never use blocky/toy-like generic cube characters. Do not aim for photorealism.
- The initial game is offline single-player.
- The world must contain exactly 3 main cities and exactly 2 large forests. Optional POIs may be random, but never randomise away or duplicate these five required regions.
- Preserve generated world layout in the save.
- Player creation must offer male and female character options and customisation for hairstyle, hair colour, skin tone and eye colour.
- The survivor starts in a basic outfit. Additional clothing is found as loot in the world and can be equipped/swapped; do not give advanced gear at spawn.
- Free tools and assets only. No paid credits, subscriptions, payment methods, or pay-as-you-go.
- Never claim the game, scene, import, build, or APK is tested unless it was actually run and verified.
- Do not use the discarded repository `zombie-survival-godot.` as a base.

## Asset policy
Use `unity-survival-systems` for gameplay architecture and implementation; use `survival-game-assets` for searching and importing assets. Consult the upstream game-development skill repository and official Unity samples linked in the skills, but adapt only relevant, licence-compatible material rather than copying entire projects. Prefer CC0. Keep licence and creator records. Reject unclear licences and ripped game assets. Optimise all models and textures for Android.

## Workflow
- Work in small, reviewable commits.
- Preserve existing user decisions and avoid unrelated rewrites.
- Before claiming an asset is integrated, verify that the actual binary asset is committed in this repository.
- If Unity Editor is unavailable, create and review source files only; explicitly say that Unity import and runtime behaviour remain untested.
