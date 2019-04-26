using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CommonData;

//Note when you read monster it mostly means pokemon, but due to the generalism of the code/game it will be called like this in case other collect monster game is done with this code

[System.Serializable]
public class Monster
{
    int id; //national dex number
    string name;
    string internalName;
    Type type1;
    Type type2;
    BaseStats baseStats;
    GenderRate genderRate;
    GrowthRate growthRate;
    ushort baseExp; //exp gained from defeat this kind of monster
    EV effortPoints; //ev's gained from defeating a monster of the species
    byte rareness; //	The catch rate of the species.The higher the number, the more likely a capture (0 means it cannot be caught by anything except a Master Ball).
    byte happiness; //The amount of happiness a newly caught Pokémon of the species will have. Is typically 70. 
    Dictionary<int, int> moves; //moves that all monsters of the species can learn. It's a dictionary with key being the id of the move and value being the lvl at witch the move is learned (0 means the move can only be learned when a monster evolves).
    EggGroup eggGroup;
    int stepsToHatch; //number of steps required to open the egg
    #region USED_FOR_DEX_SEARCH
    float height;
    float weight;
    CommonData.Color color; 
    Shape shape;
    string kind;
    int dexEntry;
    #endregion

    Vector3Int Abilities;   //The int of the vector are references to the monster abilities
                            //a vector3Int is choosed because monsters only can have 3 Abilities maximum (2 + hidden one) so instead of a list we use a Vector3 which has a faster acces to its values. 
    List<int> eggMoves; //only for unevolved species

    List<Evolution> evolutions; //A list of evolutions for the monster (it's a list because a monster can have multiple evolutive lines

    //TODO --> TEMA DE LA CRIANZA Y DE LA FORMA https://essentialsdocs.fandom.com/wiki/Defining_a_species
}
