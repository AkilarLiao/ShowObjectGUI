using UnityEditor;
using UnityEngine;

public class TestDataGenerator
{
    [MenuItem("MyMenu/CreateTestData")]
    static void CreateTestData()
    {
        var testData = ScriptableObject.CreateInstance<TestData>();        
        AssetDatabase.CreateAsset(testData, "Assets/TestData.asset");
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
    }
}