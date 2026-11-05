# Characters and equipment — production specification

This document defines the first character and equipment set for **Survival: The Last Shelter**. It is a content target, not a claim that models or prefabs have already been imported.

## Art direction
- Modern low-poly 3D, consistent proportions and material language.
- Post-apocalyptic survival clothing and believable improvised gear.
- Clear silhouettes at phone-screen size; readable enemy types at a distance.
- Target Android low-end hardware: modest polygon counts, shared materials, 512–1024 px textures initially.
- No ripped assets, copyrighted game characters, or unclear licences.

## Characters

| Character | Gameplay identity | Required visuals/animations |
|---|---|---|
| Player survivor | Customisable human survivor | Idle, walk, run, turn, jump/fall/land, crouch if supported, hit, death, interact, weapon-ready |
| Common zombie | Basic close-range threat | Idle/shamble, walk, chase, attack, hit, death |
| Heavy mutant | Slow, durable, high-damage enemy | Heavy idle/walk, wind-up, slam/attack, stagger, hit, death |
| Blind sound hunter | Hunts sound rather than sight | Idle/listen, investigate, search, rapid chase, lunge/attack, stagger, death |

### Character variants
- Player: neutral base body; clothing and equipment should be swappable where the rig supports it.
- Zombie: damaged clothing, pale/decayed palette, readable hunched silhouette.
- Mutant: larger frame, asymmetrical proportions, reinforced body silhouette; avoid excessive bones.
- Blind hunter: distinctive head/face silhouette and restrained visual treatment; sound-based behaviour is implemented in code, not assumed from the model.

## Equipment catalog

### Wearable slots
- Head: cap, improvised helmet, protective helmet.
- Body: basic jacket, reinforced vest, protective suit.
- Backpack: small, medium, large.
- Utility: flashlight, gas mask or respirator, medical pouch.

### Weapons
- Melee: improvised club, pipe, machete.
- Ranged: basic pistol, improvised shotgun, basic rifle.
- Weapon models must have safe, legally licensed assets; no real-world weapon instructions are part of this project.

### Survival and crafting props
- Medical: bandage, first-aid kit, medicine container.
- Food/water: canned food, bottle, water container.
- Materials: wood, stone, scrap metal, cloth, rope, components.
- Construction: hammer/tool, nails/fasteners, barricade parts.

## Gameplay data requirements
Each item definition should have a stable ID, display name, category, icon reference, stack limit, weight, optional durability, and optional crafting recipe.
Equipment definitions additionally specify slot, protection/utility stats, and model attachment point.
Runtime inventory and durability must be saved separately from ScriptableObject definitions.
Equipment must improve survivability without creating unlimited defence or invulnerability.

## Asset acquisition order
1. One rigged survivor with verified idle/walk/run clips.
2. Zombie with locomotion and attack clips.
3. Heavy mutant; if no suitable free rigged model exists, choose a static candidate and clearly mark animation work as pending.
4. Blind sound hunter; prioritise a distinct silhouette and valid licence.
5. Modular backpack, helmet, vest, clothing, and weapon models.
6. Small survival props and crafting materials.

Search 3–5 candidates per batch. Prefer CC0; accept attribution licences only when exact attribution is recorded in `Assets/ThirdParty/ASSET_CREDITS.md`. Verify file format, licence, rig, animation clips, scale, polygon count, texture size, and Android suitability before choosing.

## Current status
- This specification is committed as a production plan.
- It does not mean any character/equipment binary has been downloaded, imported, turned into a prefab, or tested.
- Record each actual asset and its licence in `Assets/ThirdParty/ASSET_CREDITS.md`.
