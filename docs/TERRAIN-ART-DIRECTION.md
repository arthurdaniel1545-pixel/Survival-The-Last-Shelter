# Terrain art direction — Survival: The Last Shelter

## Approved visual direction
- Style: modern low-poly survival, moderately stylised and grounded.
- Density: balanced; readable open spaces connected to denser vegetation and built-up areas.
- Mood: abandoned post-apocalyptic world, natural muted colours, believable scale and human proportions.
- Target: Unity 6.3 LTS, Android-first, including Moto G24 / Helio G85.
- The generated concept image is a mood/composition reference only. It is not a game asset, geometry source, or a requirement to reproduce its exact layout.

## Visual rules
- Use coherent, authored-looking asset kits with consistent scale, pivots, material response and texel density.
- Terrain must have actual relief: rolling hills, shallow valleys, embankments, rock outcrops, drainage cuts and natural transitions. Do not make a flat green plane with random props.
- Use layered ground materials: dirt, dry grass, gravel, asphalt, concrete, mud and forest floor. Blend edges naturally; avoid obvious repeated stamps.
- Forests: irregular tree spacing, mixed tree heights, understory, fallen trunks, rocks and small clearings. Keep sightlines and traversable paths.
- Cities: distinct street blocks, varied building footprints/heights, sidewalks, alleys, damaged roads, walls, fences and believable abandoned props. Avoid repeating the same building or prop in obvious grids.
- **Interiors are mandatory and enterable.** Buildings must not be empty shells or inaccessible façades: provide real interior spaces that the player can walk through, with doors/entrances, floors, ceilings, room partitions and stairs where appropriate. Prioritise a varied, reusable interior kit for houses/apartments, shops, a clinic and other believable survival locations.
- Interior furnishing and loot dressing: beds, tables, chairs, sofas, shelves, kitchen units, cupboards, fridges, lamps, bathroom fixtures, office furniture, medical furniture, storage boxes, cabinets and searchable containers. Include damaged/looted variants and restrained clutter; leave clear paths for player movement.
- Interior gameplay readiness: plan sensible room scale, door widths, navigation space, collision, lighting and hiding/loot spots. Support entering and exiting without loading screens where practical; if a building needs a separate scene for mobile performance, document that clearly and preserve a smooth transition.
- Not every building needs a unique furnished interior, but each of the 3 cities must contain multiple enterable, furnished buildings. Reuse modular pieces intelligently without making every interior identical. Add a few enterable cabins/shelters as optional forest POIs.
- Transitions: outskirts, fields, woodland edges, drainage channels and roads should connect regions naturally.
- Lighting: restrained directional sun, economical shadows, subtle atmospheric depth. Avoid heavy post-processing and excessive real-time lights.
- Palette: muted greens, dusty earth, weathered concrete, faded paint and restrained rust. Keep gameplay objects readable.
- Avoid AI-looking repetition, floating props, mismatched scales, random clutter, toy-like shapes, voxel/blocky art, PS1 style and photorealistic high-poly assets.

## Mandatory world layout
- Exactly 3 main cities.
- Exactly 2 large forests.
- Additional POIs and secondary structures may vary in count.
- The five mandatory regions must remain guaranteed and persisted in the world save.
- Each mandatory region needs a distinct identity and natural connection to roads/terrain.

## Asset and performance standards
- Prefer real downloadable modular assets from the connected 3D Asset Server and Gobkit MCPs; use CC0 first.
- Verify source, creator, exact licence, format, polygon count, texture dimensions, scale, rig and dependencies before accepting.
- Never accept unclear licences or ripped commercial-game assets.
- Prefer modular kits and shared materials over many unrelated one-off assets.
- Target low-end Android: avoid 4K textures, excessive materials, dense foliage everywhere, unnecessary transparency and expensive shaders.
- Use LODs or impostors where appropriate; use GPU instancing only where compatible and verified.
- Keep original downloaded files and update Assets/ThirdParty/ASSET_CREDITS.md for every accepted asset.

## Scene assembly order
1. A small vertical-slice terrain test area with one road, one forest edge, one hill/rock formation, a few abandoned structures and at least one fully enterable, furnished building interior.
2. Verify terrain scale, collision, traversal and visual consistency.
3. Create reusable modular environment prefabs after actual Unity import checks.
4. Expand into the 3 cities and 2 forests only after the slice performs acceptably.

## Acceptance checklist
- [ ] Real assets downloaded and committed; not just a candidate list.
- [ ] Every asset has a verified compatible licence and credit entry.
- [ ] No obvious repeated/cloned placement patterns.
- [ ] Terrain has real relief and walkable collision.
- [ ] Roads and region transitions connect logically.
- [ ] At least one complete enterable interior is included in the vertical slice.
- [ ] Each of the 3 cities has multiple enterable buildings with varied, furnished interiors.
- [ ] Interior doors, floors, walls, stairs, collision, lighting and player navigation are accounted for.
- [ ] Asset scale and visual style are consistent.
- [ ] Mobile texture/material/mesh budgets are documented.
- [ ] Unity import, prefab and scene tests are explicitly marked as tested or untested.
