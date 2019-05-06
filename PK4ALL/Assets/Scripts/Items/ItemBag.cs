using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ItemBag
{
    public int itemID;
    private ushort quantity;

    public ItemBag(int id, ushort quant)
    {
        itemID = id;
        quantity = quant;
    }
         
    public ushort Quantity {
        get => quantity;
        set => quantity = value;
    }
}
