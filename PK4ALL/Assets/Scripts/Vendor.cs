using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vendor : MonoBehaviour
{
    public ushort id;
    public List<int> items;
    ItemDatabase dataManager;

    // Start is called before the first frame update
    void Start()
    {
        dataManager = DataManager.instance.itemDB;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Sell(int item, ushort quantity)
    {
        GameManager.instance.bag.addItem(item, quantity);

        //player money decrease
    }

    public void Buy(int item, ushort quantity)
    {
        GameManager.instance.bag.withdrawItem(item, quantity);

        //player money increase
    }
}
