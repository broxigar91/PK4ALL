using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using CommonData;
using System.IO;

[Serializable]
public struct ItemDB
{
    public List<Item> items;
}


[Serializable]
public class ItemDatabase
{
    public ItemDB db;

    public ItemDatabase(string dataPath)
    {
        string datos = File.ReadAllText(dataPath + "/Resources/items.json"); //establezco la ruta donde se encuentra el fichero json
        Debug.Log(datos);
        db = JsonUtility.FromJson<ItemDB>(datos);
    }

    //Pokcet Search filter by item id
    public Pocket getPocket(int id)
    {
        return db.items.Find(x => x.id == id).pocket;
    }
}
