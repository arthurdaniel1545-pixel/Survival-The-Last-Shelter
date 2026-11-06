#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SurvivalTheLastShelter.EditorTools
{
    public static class DemoSceneBuilder
    {
        [MenuItem("Survival/Build Demo Scene")]
        public static void Build()
        {
            Scene scene = EditorSceneManager.NewScene(NewSceneSetup.DefaultGameObjects, NewSceneMode.Single);

            GameObject existing = GameObject.Find("DemoSurvivalArea");
            if (existing != null) Object.DestroyImmediate(existing);

            GameObject root = new GameObject("DemoSurvivalArea");

            // Terrain
            GameObject terrain = Terrain.CreateTerrainGameObject(new TerrainData());
            terrain.name = "Terrain";
            terrain.transform.SetParent(root.transform, false);
            terrain.transform.localScale = new Vector3(1f, 1f, 1f);

            // Groups
            CreateGroup(root.transform, "City", new Vector3(0f, 0f, 0f));
            CreateGroup(root.transform, "Forest", new Vector3(80f, 0f, 0f));
            CreateGroup(root.transform, "Interiors", new Vector3(10f, 0f, 10f));
            CreateGroup(root.transform, "Roads", new Vector3(0f, 0f, 0f));
            CreateGroup(root.transform, "Props", new Vector3(0f, 0f, 0f));

            // Spawns
            CreateSpawn(root.transform, "PlayerSpawn", new Vector3(0f, 1f, 0f));
            CreateSpawn(root.transform, "ZombieSpawn", new Vector3(20f, 1f, 0f));
            CreateSpawn(root.transform, "MutantSpawn", new Vector3(35f, 1f, 0f));
            CreateSpawn(root.transform, "BlindCreatureSpawn", new Vector3(50f, 1f, 0f));

            // Player
            GameObject player = new GameObject("Player");
            player.transform.SetParent(root.transform, false);
            player.transform.position = new Vector3(0f, 1f, 0f);
            player.AddComponent<CharacterController>();

            // Systems
            GameObject systems = new GameObject("Systems");
            systems.transform.SetParent(root.transform, false);
            systems.AddComponent<Light>();

            EditorSceneManager.SaveScene(scene, "Assets/Scenes/SurvivalDemo.unity");
            AssetDatabase.Refresh();
            Debug.Log("Demo scene skeleton rebuilt. Manual GLB placement, colliders and validation are still required.");
        }

        private static GameObject CreateGroup(Transform parent, string name, Vector3 position)
        {
            GameObject go = new GameObject(name);
            go.transform.SetParent(parent, false);
            go.transform.position = position;
            return go;
        }

        private static GameObject CreateSpawn(Transform parent, string name, Vector3 position)
        {
            GameObject go = new GameObject(name);
            go.transform.SetParent(parent, false);
            go.transform.position = position;
            return go;
        }
    }
}
#endif
