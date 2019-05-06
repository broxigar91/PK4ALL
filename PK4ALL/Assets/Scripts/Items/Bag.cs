using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CommonData;

public class Bag : MonoBehaviour
{
    public PocketListDictionary pockets;
    ushort itemLimit = 999;

    ItemDatabase itemDB;

    // Start is called before the first frame update
    void Start()
    {
        itemDB = DataManager.instance.itemDB;
    }

    
    public void addItem(int itemId, ushort quantity)
    {
        Pocket p = itemDB.getPocket(itemId);

        if (!checkItemExists(p, itemId))
            //We access to the item list in the dictionary by using the Pocket field in the item.
            pockets[p].Add(new ItemBag(itemId, quantity));
        else
        {
            //if does exist in the bag, then we add the quantity required
            ItemBag ib = pockets[p].Find(x => x.itemID == itemId);
            ib.Quantity += quantity;
            if (ib.Quantity > itemLimit)
                ib.Quantity = itemLimit;
        }
            
    }

    public void withdrawItem(int itemId, ushort quantity)
    {
        Pocket p = itemDB.getPocket(itemId);

        if(checkItemExists(p,itemId))
        {
            ItemBag ib = pockets[p].Find(x => x.itemID == itemId);

            ib.Quantity -= quantity;

            if (ib.Quantity <= 0)
                pockets[p].Remove(ib);
        }
            

    }

    public bool checkItemExists(Pocket pocket,int id)
    {
        return false;
    }


}
