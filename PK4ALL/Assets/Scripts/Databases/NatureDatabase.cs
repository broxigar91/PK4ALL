using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CommonData;
using System;
using System.IO;

[Serializable]
public struct NatureDB
{
    public List<Nature> natureDB;
}



public class NatureDatabaseController : MonoBehaviour
{

    public NatureDB db;
    
    // Start is called before the first frame update
    void Start()
    {
        string datos = File.ReadAllText(Application.dataPath + "/Resources/itemdatabase.json"); //establezco la ruta donde se encuentra el fichero json
        db = JsonUtility.FromJson<NatureDB>(datos);
    }

    public Nature getNature(Natures nat)
    {
        return db.natureDB.Find(x => x.nature == nat);
    }
}
