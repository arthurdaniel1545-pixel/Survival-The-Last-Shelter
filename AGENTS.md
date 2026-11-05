# Agent instructions — Survival: The Last Shelter

Read `README.md`, `docs/CONCEPT.md`, `docs/ROADMAP.md`, and `skills/survival-game-assets/SKILL.md` before changing project architecture or sourcing assets.

## Non-negotiable project rules
- Unity 6.3 LTS; do not switch to Godot or another engine.
- Android-first, low-end-device-aware, modern low-poly 3D.
- The initial game is offline single-player.
- The world must contain exactly 3 main cities and exactly 2 large forests. Optional POIs may be random, but never randomise away or duplicate these five required regions.
- Preserve generated world layout in the save.
- Free tools and assets only. No paid credits, subscriptions, payment methods, or pay-as-you-go.
- Never claim the game, scene, import, build, or APK is tested unless it was actually run and verified.
- Do not use the discarded repository `zombie-survival-godot.` as a base.

## Asset policy
Use the `survival-game-assets` skill for searching and importing assets. Prefer CC0. Keep licence and creator records. Reject unclear licences and ripped game assets. Optimise all models and textures for Android.

## Workflow
- Work in small, reviewable commits.
- Preserve existing user decisions and avoid unrelated rewrites.
- Before claiming an asset is integrated, verify that the actual binary asset is committed in this repository.
- If Unity Editor is unavailable, create and review source files only; explicitly say that Unity import and runtime behaviour remain untested.
