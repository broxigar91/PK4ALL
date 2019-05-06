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


[Serializable]
public class NatureDatabase
{
    public NatureDB db;
    
    
    public NatureDatabase(string dataPath)
    {
        string datos = File.ReadAllText( dataPath + "/Resources/natures.json"); //establezco la ruta donde se encuentra el fichero json
        Debug.Log(datos);
        db = JsonUtility.FromJson<NatureDB>(datos);
    }
       
    public Nature getNature(Natures nat)
    {
        return db.natureDB.Find(x => x.nature == nat);
    }
}
