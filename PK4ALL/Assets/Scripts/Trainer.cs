using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CommonData;

public class Trainer : MonoBehaviour
{
    public ushort id;
    public string internalName;
    public string displayName;
    public byte baseMoney; //The amount of money earned from defeating a trainer of this type. The base money value is multiplied by the highest Level among all the trainer's Pokémon to produce the actual amount of money gained 
    byte battleMusic;
    byte vitoryMussicEffect;
    byte introMussicEffect; //The music that plays before the battle begins, while still talking to the trainer. 
    public Gender gender;
    public bool rematch;
    public List<Monster> monsters;
    public List<ushort> items;
    //skilllvl
    //skillcodes

}
