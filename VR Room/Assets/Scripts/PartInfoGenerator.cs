/*using Assets.Scripts;
using UnityEditor;
using UnityEngine;

public class PartInfoGenerator : Editor
{
    [MenuItem("Tools/Generate and Assign Part Info")]
    public static void GenerateAndAssignPartInfo()
    {
        string savePath = "Assets/PartInfo/Nut/";

        if (!AssetDatabase.IsValidFolder(savePath))
        {
            AssetDatabase.CreateFolder("Assets/PartInfo", "Nut");
        }

        Object[] selectedPrefabs = Selection.objects;

        foreach (Object prefab in selectedPrefabs)
        {
            if (prefab is GameObject prefabGO)
            {
                // Create ScriptableObject
                var partInfo = ScriptableObject.CreateInstance<PartInfo>();
                var part = prefabGO.GetComponent<CarPart>();

                partInfo.AssembleAudioClip = null;
                partInfo.DisassembleAudioClip = null;
                partInfo.PartMesh = prefabGO.GetComponentInChildren<MeshFilter>().sharedMesh;

                string assetName = prefab.name + "_PartInfo.asset";
                string assetPath = savePath + assetName;

                AssetDatabase.CreateAsset(partInfo, assetPath);
                AssetDatabase.SaveAssets();

                // Assign ScriptableObject to prefab

                if (part != null)
                {
                    part.PartInfo = partInfo;

                    PrefabUtility.SavePrefabAsset(prefabGO);
                }

                Debug.Log($"Created and assigned PartInfo for {prefab.name}.");
            }
        }

        AssetDatabase.Refresh();
        Debug.Log("Finished generating and assigning PartInfo.");
    }
}*/