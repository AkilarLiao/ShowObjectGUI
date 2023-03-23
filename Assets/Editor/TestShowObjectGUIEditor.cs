using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(TestShowObjectGUI), true)]
public class TestShowObjectGUIEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        m_ShowMaterialGUI.UpdateObjectGUI(
            ((TestShowObjectGUI)target).m_TargetMaterial);
        m_ShowAssetsGUI.UpdateObjectGUI(
            ((TestShowObjectGUI)target).m_TargetTestData);
    }
    private ShowObjectGUI m_ShowMaterialGUI = new ShowObjectGUI();
    private ShowObjectGUI m_ShowAssetsGUI = new ShowObjectGUI();
}
