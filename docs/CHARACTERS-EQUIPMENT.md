# Characters and equipment — production specification

This document defines the first character and equipment set for **Survival: The Last Shelter**. It is a content target, not a claim that models or prefabs have already been imported.

## Art direction
- Modern low-poly 3D, consistent proportions and material language.
- Post-apocalyptic survival clothing and believable improvised gear.
- Clear silhouettes at phone-screen size; readable enemy types at a distance.
- Target Android low-end hardware: modest polygon counts, shared materials, 512–1024 px textures initially.
- No ripped assets, copyrighted game characters, or unclear licences.

## Player character creation and appearance

- At the start of a new game, the player chooses a **male or female** human character.
- The character creator must support, at minimum: hairstyle, hair colour, skin tone, and eye colour. Add further compatible appearance options when practical (for example, face presets and facial hair where appropriate).
- Male and female options must use believable human proportions and the same modern low-poly art direction. Avoid blocky/toy-like bodies, square heads, and generic cube-shaped characters.
- Keep the style moderately stylised rather than photorealistic: readable facial features, clean geometry, believable anatomy, practical clothing, and restrained detail suitable for a low-end Android device.
- The survivor starts with a simple **basic outfit**. Do not spawn the player in advanced tactical gear or a full protective suit.
- Additional clothing is found as loot in the world (homes, shops, lockers, camps, storage areas and other appropriate locations). The player can equip, remove, and replace found clothing.
- Clothing appearance must visibly update on the character. Where supported, separate wearable slots should allow mixing pieces rather than forcing a complete outfit.

## Characters

| Character | Gameplay identity | Required visuals/animations |
|---|---|---|
| Player survivor | Customisable male or female human survivor; starts in a basic outfit | Idle, walk, run, turn, jump/fall/land, crouch if supported, hit, death, interact, weapon-ready |
| Common zombie | Basic close-range threat | Idle/shamble, walk, chase, attack, hit, death |
| Heavy mutant | Slow, durable, high-damage enemy | Heavy idle/walk, wind-up, slam/attack, stagger, hit, death |
| Blind sound hunter | Hunts sound rather than sight | Idle/listen, investigate, search, rapid chase, lunge/attack, stagger, death |

### Character variants
- Player: male and female body options with compatible human proportions; customisable hair style/colour, skin tone and eye colour. Keep appearance data separate from equipment data.
- Player clothing: basic starting outfit, with additional garments discovered as loot in the world. Clothing must be swappable where the rig and modular meshes support it.

- Zombie: damaged clothing, pale/decayed palette, readable hunched silhouette.
- Mutant: larger frame, asymmetrical proportions, reinforced body silhouette; avoid excessive bones.
- Blind hunter: distinctive head/face silhouette and restrained visual treatment; sound-based behaviour is implemented in code, not assumed from the model.

## Equipment catalog

### Wearable slots
- Headwear: cap, beanie, improvised helmet, protective helmet.
- Hair/face: hairstyles remain visible or are hidden appropriately by equipped headwear; optional face covering.
- Upper body: basic shirt, jacket, hoodie, reinforced vest, protective suit.
- Lower body: basic trousers, cargo trousers, protective trousers.
- Footwear: basic shoes, boots.
- Backpack: small, medium, large.
- Utility: flashlight, gas mask or respirator, medical pouch.

Clothing and wearable gear are world loot. The player begins with a modest basic outfit and can replace individual pieces as they explore. Keep cosmetic clothing distinct from armour stats where appropriate, so a visually different outfit does not automatically grant protection.

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
