---
name: unity-survival-systems
description: Build and review Unity 6.3 LTS systems for this Android-first 3D survival sandbox, using carefully selected public game-development references.
---

# Unity survival systems skill

## Read first
Read `AGENTS.md`, `docs/CONCEPT.md`, `docs/ROADMAP.md`, and `docs/CHARACTERS-EQUIPMENT.md`. For model sourcing/import, also read `skills/survival-game-assets/SKILL.md`.

## Engine and project constraints
- Unity 6.3 LTS, C#, Android-first, offline single-player for the first release.
- Modern low-poly 3D, designed for low-end Android hardware.
- Never switch to Godot.
- World generation must preserve exactly 3 main cities and exactly 2 large forests; optional POIs may vary.
- Keep systems modular and data-driven. Prefer ScriptableObjects for item, enemy, equipment, and crafting definitions.
- Do not add paid SDKs, services, assets, subscriptions, or billing.
- Do not claim compilation, import, playtesting, or device performance without actual verification.

## Upstream references to consult (do not blindly copy)
1. `gamedev-skills/awesome-gamedev-agent-skills` — Apache-2.0 collection of portable skills. Select only Unity 6 and relevant discipline skills:
   - Unity: C# scripting, Input System, physics, animation, ScriptableObjects, NavMesh, build pipeline.
   - Disciplines: game AI, procedural generation, save systems, audio design, performance optimization, camera systems, game UI/UX, game feel, asset creation.
   - Repository: https://github.com/gamedev-skills/awesome-gamedev-agent-skills
2. `Unity-Technologies/CharacterControllerSamples` — official Unity character-controller examples. Study movement/controller patterns and sample structure; do not copy unrelated packages or assume the sample is already installed.
   - Repository: https://github.com/Unity-Technologies/CharacterControllerSamples
3. Check each upstream repository's current licence and Unity-version compatibility before copying code or files. Prefer learning/adapting patterns over vendoring whole repositories.

## Architecture rules
- Separate input, movement, health, hunger, thirst, stamina, inventory, equipment, combat, AI perception, AI decisions, world generation, and persistence.
- Use ScriptableObjects for definitions; runtime state belongs to saveable runtime data, not shared definition assets.
- Avoid giant manager classes, hidden singleton dependencies, per-frame allocations, and unnecessary Update loops.
- Use object pooling for repeated projectiles, effects, and frequently spawned entities where profiling justifies it.
- Use deterministic seeds for world generation and persist the generated layout.
- Version save data and handle missing/unknown fields safely.

## Player and character implementation
- Third-person mobile controls: left virtual stick for movement; right-side camera drag; contextual action buttons.
- Character movement must be frame-rate independent and camera-relative.
- Separate animation parameters from gameplay state. Verify actual imported rig/avatar and clip names before wiring Animator states.
- Required initial animation set: idle, walk, run, turn, jump/fall/land, hit reaction, death, interaction, and weapon-ready/attack when available.
- Provide accessible touch targets and safe-area-aware UI.

## Enemy AI
Implement enemies as explicit state machines or behaviour trees with testable transitions:
- Common zombie: patrol/wander, detect, approach, attack, search last known position, return.
- Heavy mutant: slower, tougher, telegraphed heavy attacks, recovery windows.
- Blind sound hunter: weak/no visual detection; investigate sound events by intensity and distance, then search and attack.
- Sound events include sprinting, gunshots, impacts, breaking objects, and construction. Crouching/walking should be quieter, not magically silent.
- Use NavMesh only after navigation surfaces and agent settings are configured and verified. Provide a fallback only if necessary.

## Survival, inventory, and equipment
- Health, hunger, thirst, and stamina must have clear rates, feedback, and save/load behaviour.
- Inventory items use stable IDs, stack limits, weight/slot rules, and explicit add/remove results.
- Equipment slots: head, body, backpack, primary weapon, secondary weapon, and utility.
- Protection values must be balanced and readable; equipment should not grant invulnerability.
- Crafting recipes must validate ingredients and consume them atomically.
- Persist inventory, equipped item IDs, durability, and player vitals.

## Android performance and quality gates
- Profile before optimising; establish a conservative mobile target and test on the actual Moto G24 when available.
- Prefer low-poly meshes, shared materials, mobile shaders, compressed textures, sensible LODs, limited real-time lights/shadows, and pooled effects.
- Avoid 4K textures, expensive post-processing, excessive transparent surfaces, and unnecessary physics bodies.
- Test touch controls, orientation, thermal behaviour, memory, and frame pacing on device before calling the build mobile-ready.

## Verification checklist
- Inspect changed files and diffs.
- Check references and namespaces against Unity 6.3 APIs.
- Add focused tests for world counts, save/load, inventory transactions, equipment slots, enemy state transitions, and sound-hearing rules where feasible.
- Never claim a test passed unless it was run and its result observed.
- If Unity Editor/build tooling is unavailable, commit source and documentation only and clearly report the limitation.
