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

            GameObject root = new GameObject("DemoSurvivalArea");
            CreateEmpty(root.transform, "City", new Vector3(0f, 0f, 0f));
            CreateEmpty(root.transform, "Forest", new Vector3(80f, 0f, 0f));
            CreateEmpty(root.transform, "PlayerSpawn", new Vector3(0f, 1f, 0f));
            CreateEmpty(root.transform, "ZombieSpawn", new Vector3(20f, 1f, 0f));
            CreateEmpty(root.transform, "MutantSpawn", new Vector3(35f, 1f, 0f));
            CreateEmpty(root.transform, "BlindCreatureSpawn", new Vector3(50f, 1f, 0f));

            EditorSceneManager.SaveScene(scene, "Assets/Scenes/SurvivalDemo.unity");
            AssetDatabase.Refresh();
            Debug.Log("Demo scene skeleton created. Manual GLB placement and validation are still required.");
        }

        private static GameObject CreateEmpty(Transform parent, string name, Vector3 position)
        {
            GameObject go = new GameObject(name);
            go.transform.SetParent(parent, false);
            go.transform.position = position;
            return go;
        }
    }
}
#endif
