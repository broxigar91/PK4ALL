using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class MonsterDBWindow : EditorWindow
{
    public MonsterDB monsterDB;

    private string gameDataProjectFilePath = "/StreamingAssets/monsters.json";

    [MenuItem("Tools/Monster Database Editor")]
    static void Init()
    {
        MonsterDBWindow window = GetWindow<MonsterDBWindow>();
        window.Show();
    }

    void OnGUI()
    {
        if(monsterDB != null)
        {
            SerializedObject serializedObject = new SerializedObject(this);
            SerializedProperty serializedProperty = serializedObject.FindProperty("monsterDB");
            EditorGUILayout.PropertyField(serializedProperty, true);

            serializedObject.ApplyModifiedProperties();

            if (GUILayout.Button("Save data"))
            {
                SaveGameData();
            }
        }

        if (GUILayout.Button("Load data"))
        {
            LoadGameData();
        }
    }


    private void LoadGameData()
    {
        string filePath = Application.dataPath + gameDataProjectFilePath;

        if (File.Exists(filePath))
        {
            string dataAsJson = File.ReadAllText(filePath);
            monsterDB = JsonUtility.FromJson<MonsterDB>(dataAsJson);
        }
        else
        {
            monsterDB = new MonsterDB();
        }
    }

    private void SaveGameData()
    {

        string dataAsJson = JsonUtility.ToJson(monsterDB);

        string filePath = Application.dataPath + gameDataProjectFilePath;
        File.WriteAllText(filePath, dataAsJson);

    }
}
