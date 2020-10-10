using UnityEngine;
using UnityEditor;
using CommonData;
using System;
using System.Collections.Generic;


public class MonsterWindow : EditorWindow
{

    CommonData.Types monsterType;

    [MenuItem("Tools/Monster")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow<MonsterWindow>();
    }

    private void OnGUI()
    {
        EditorGUILayout.BeginHorizontal();
        GUILayout.Label("Type");
        monsterType = (CommonData.Types)EditorGUILayout.EnumPopup(monsterType);
        EditorGUILayout.EndHorizontal();
    }
}
