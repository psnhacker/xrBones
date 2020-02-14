using UnityEngine;
using UnityEditor;

public class XrayModelImporter : EditorWindow
{
    [MenuItem("X-Ray Plugin/Open x-ray Importer")]
    public static void ShowWindow()
    {
        GetWindow<XrayModelImporter>(false, "Bone Helper", true);
    }
    float angle = 120f;
    bool value = false;
    void OnGUI()
    {
        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.BeginVertical("box");
        angle = EditorGUILayout.FloatField("Angle", angle);
        value = EditorGUILayout.Toggle("Foot correct", value);
        if (GUILayout.Button("Fix bones", GUILayout.Height(25)))
        {
            XrBonesHumanoidFix xrBones = new XrBonesHumanoidFix();
            xrBones.StartFix(value, angle);
        }
        EditorGUILayout.EndVertical();
        EditorGUILayout.EndHorizontal();
    }
}
