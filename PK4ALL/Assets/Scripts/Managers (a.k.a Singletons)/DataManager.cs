using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CommonData;

public class DataManager : MonoBehaviour
{
    public static DataManager instance;

    public ItemDatabase itemDB;
    public NatureDatabase natureDB;
    public MonsterDB monsterDB;

    // Start is called before the first frame update
    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if(instance!=this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);

        string dataPath = Application.dataPath;

        itemDB = new ItemDatabase(dataPath);
        natureDB = new NatureDatabase(dataPath);
    }
}
