using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CommonData;

public class Pokemon : MonoBehaviour
{
    Monster species;
    public string pokemonName;
    public int lvl;
    public int currentExp;
    public int abilty;
    byte abilityIndex; //0= nartural1, 1= natural2, 2= hidden
    public Gender gender;
    public Nature nature;
    public bool isShiny;
    //form here-> left to define
    public int currentHp;

    //maybe refactor this to an struct
    #region STATS 
    public int totalHp;
    public int attack;
    public int defense;
    public int speed;
    public int spattack;
    public int spdefense;
    #endregion

    public byte currentHappiness;
    public Status currentStatus;
    public byte statusCount;
    public int currentEggSteps;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
