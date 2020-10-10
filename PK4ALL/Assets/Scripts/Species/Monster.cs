using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CommonData;

[System.Serializable]
public class Monster
{
    public Specie species;
    public string pokemonName;
    public int lvl;
    int maxlvl = 100;
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

    //moves
    public List<MonsterMove> moves;

    public PokeballType pokeballUsed;
    public int heldItem;

    //mail
    public EV currentEV;
    public IV currentIV;
    byte pokerus;
    bool fused; //only for kyurem

    int trainerID;
    bool foreing;

    #region OBTAINATION INFO
    ObtainMode obtainMode;
    int obtainMap;
    int obtainLvl;
    int hatchedMap;
    string obtainText;
    #endregion

    Languaje languaje;
    

    // Start is called before the first frame update
    void Start()
    {
        CalcStats();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Heal(int hpToRestore)
    {
        currentHp += hpToRestore;

        if (currentHp > totalHp)
            currentHp = totalHp;
    }

    /*Recalculates the Pokémon's stats (total HP, Attack, Defense, etc.).

      Used when creating a Pokémon or egg, 
      when an egg hatches, 
      when a Pokémon's level/species/nature/gender/shininess changes, 
      when an EV-modifying item is used, and when a Pokémon's form changes. 
     */
    public void CalcStats()
    {
        totalHp = CalcHp();
        attack = CalcStat(species.baseStats.atk,currentIV.atk,currentEV.atk, nature.atk);
        defense = CalcStat(species.baseStats.def, currentIV.def, currentEV.def, nature.def);
        speed = CalcStat(species.baseStats.speed, currentIV.speed, currentEV.speed, nature.speed);
        spattack = CalcStat(species.baseStats.spatk, currentIV.spatk, currentEV.spatk, nature.spatk);
        spdefense = CalcStat(species.baseStats.spdef, currentIV.spdef, currentEV.spdef, nature.spdef);
    }

    public int CalcHp()
    {
        int baseHp = species.baseStats.hp;

        if (baseHp == 1)
            return 1;

        return Mathf.FloorToInt((baseHp * 2 + currentIV.hp + Mathf.FloorToInt(currentEV.hp / 4)) * lvl / 100) + lvl + 10;
    }

    public int CalcStat(int baseStat, int iv, int ev, float natureModifier)
    {

        return Mathf.FloorToInt((Mathf.FloorToInt((2 * baseStat + iv + Mathf.FloorToInt(ev / 4)) * lvl / 100) + 5) * natureModifier);
    }
}
