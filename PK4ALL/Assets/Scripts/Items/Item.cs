using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using CommonData;

[Serializable]
public class Item 
{
    public int id;
    public string internalName;
    public string displayName;
    public string pluralDisplayName;
    public Pocket pocket;
    public int price; //The cost of the item when the player buys it from a Poké Mart. Note that when the player sells the item to a Poké Mart, it is sold for half this price (by default). If an item has a price of 0, the player cannot sell it. 
    public string description;
    public UsabilityOutsideBattle usabilityOutsideBattle;
    public UsabilityInBattle usabilityInBattle;
    public SpecialItems specialItem;
    public int tmthMove; 
}
