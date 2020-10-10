using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CommonData;

[System.Serializable]
public class Move
{
    public int id;
    string internalName;
    public string displayName;
    public MoveCode moveCode;
    public int basePower;
    public Type type;
    public DamageCategory damageCategory;
    public byte accuracy;
    public byte totalPP;
    //additional effect chance to be done
    sbyte priority; //from -6 to 6 range
    //flags to be done
    string description;
}