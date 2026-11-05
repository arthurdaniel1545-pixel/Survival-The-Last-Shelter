# Asset candidate shortlist

Research shortlist for the first real character import. These are candidates to inspect/download, not assets already added to this repository.

## Best current leads

| Role | Candidate | Format and animation | Licence | Notes |
|---|---|---|---|---|
| Player base / humanoid | [Vuena — 8 Free Blocky Characters](https://vuena.itch.io/blocky-characters-free-sample) | FBX for Unity and GLB; 22-bone Mixamo-named rig; idle, walk, run, jump, fall, wave, cheer, dance, punch, death; 2.4k–4.6k triangles | CC0 | Includes Hero and Zombie. Toy/blocky proportions; evaluate whether art direction fits before adoption. |
| Zombie | [Atlas Hearth — Blocky Zombie Lite](https://atlashearth.itch.io/zombie-lite-free-rigged-animated-low-poly-character) | FBX; Idle, Walk, Attack; 1,056 triangles; 18-bone generic rig | Free sample; exact licence needs confirmation from included archive/page before production use | Unity import explicitly untested by creator; use only as a candidate, not a guaranteed drop-in. |
| Humanoid / enemy prototypes | [Gobkit free character packs](https://gobkit.com/freebies) | GLB; CC0; many packs with named clips such as idle, attack, dead, and some packs with walk | CC0 1.0 | Large free catalogue; inspect each character's appearance and exact clip list. Unity needs a glTF importer such as glTFast or UnityGLTF. |
| Custom survivor / monster variants | [Rollpoly](https://rollpoly.tsuyatt.com/) | Generates rigged GLB humanoids, monsters and props | CC0 1.0 | Useful for generating variants, but generated look and animation quality must be reviewed. Requires browser JavaScript/WebGL2 for preview; download can still work where supported. |

## Equipment and environment search

No wearable equipment model is approved yet. Search next for:
- modular backpack (small/medium/large);
- protective helmet and improvised helmet;
- tactical/protective vest;
- respirator/gas mask and protective suit;
- flashlight, medical pouch and tool belt;
- melee weapon props and firearms as game props;
- modular abandoned city buildings and low-poly forest kit.

For each candidate, verify the individual licence, file format, scale, polygon count, texture resolution, pivot, and whether it can be attached to the chosen character skeleton. Prefer CC0. Do not use any paid full pack or paid upgrade.

## Import compatibility warning

Unity does not import GLB/glTF natively in a standard project. For GLB candidates, evaluate a free, compatible glTF importer (for example glTFast) and verify its Unity 6.3 compatibility before adding it. Prefer the FBX option when a candidate supplies a clean Unity FBX export. Never claim a GLB/FBX imported successfully until the actual Unity Editor import has been tested.

## Selection plan

1. Compare the Vuena Hero and a Rollpoly humanoid as player candidates.
2. Compare the Vuena Zombie and Atlas Hearth Zombie Lite as zombie candidates.
3. Inspect Gobkit character packs for a larger/heavier silhouette and a creature-like enemy; if no suitable blind hunter exists, keep that role pending a custom model or a verified free monster asset.
4. Select only after visual style, licence, rig, clips and Android suitability are checked.
5. Download and commit only approved free files, then add full source/licence metadata to `Assets/ThirdParty/ASSET_CREDITS.md`.

## Status

- Research shortlist created: 5 November 2026.
- No model files have been downloaded or committed by this shortlist.
- No Unity import, prefab creation, animation retargeting, build or Moto G24 test has been performed.
