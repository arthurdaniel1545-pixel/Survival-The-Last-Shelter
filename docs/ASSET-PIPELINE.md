# Asset acquisition and MCP setup

## Recommended remote MCP servers

The primary server is **3D Asset Server**:
- MCP endpoint: `https://3d.shep.bot/mcp`
- Public service; documentation states it is free and does not require an account or API key.
- Searches 26 asset sources and returns licence and download information.
- Documentation: https://3d.shep.bot/docs

Useful specialised sources:
- **3DAssets.dev** — `https://3dassets.dev/mcp`; searchable CC0 GLB library, no account required for search/download. https://3dassets.dev/
- **Gobkit Free 3D Assets** — `https://gobkit.com/mcp`; focused on rigged and animated low-poly GLB models. Its published repository describes the included assets as CC0. https://github.com/Ariescar/gobkit-free-assets

## Android Harness connection

Add the primary endpoint as a remote MCP server using the Harness option for **HTTP / Streamable HTTP**. Use the endpoint exactly as shown above. No API key is documented as required for the public 3D Asset Server.

If Harness offers only a local stdio process for a server, this remote endpoint will not work through that option; choose its remote HTTP option instead. Do not install a local server or run terminal commands on the phone for this setup.

The connection is not considered verified until Harness shows the server connected and its asset-search tools are visible. Do not claim a connection merely because the URL was entered.

## Asset rules for this project

Read `../skills/survival-game-assets/SKILL.md` before searching. Prefer CC0 assets, preserve licence records, and optimise models/textures for Unity Android. The first asset batch should cover the survivor, three enemy types, abandoned-city pieces, and forest pieces.

## Unity MCP limitation

Unity MCP projects such as https://github.com/CoplayDev/unity-mcp require a running Unity Editor and an installed Unity-side package. They are not a substitute for the asset-search MCP and cannot operate the Unity Editor when no Editor instance is running. Since this project is currently being prepared through Android Harness and GitHub, do not add Unity Editor MCP as if it will work without that runtime.
