using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CommonData;

public class Pokemon : MonoBehaviour
{
    public Monster species;
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
    public List<PokemonMove> moves;

    PokeballType pokeballUsed;
    int heldItem;

    //mail
    EV currentEV;
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

    }
}
