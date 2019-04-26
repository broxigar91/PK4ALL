using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommonData {

    public enum Type
    {
        FIRE,
        WATER
    }

    public struct BaseStats
    {
        byte hp;
        byte atk;
        byte def;
        byte speed;
        byte spatk;
        byte spdef;
    }

    public enum GenderRate
    {
        ALWAYSMALE,
        FEMALEONEEIGHTH,
        FEMALE25PERCENT,
        FEMALE50PERCENT,
        FEMALE75PERCENT,
        FEMALESEVENEIGHTHS,
        ALWAYSFEMALE,
        GENDERLESS
    }
    
    public enum Gender
    {
        MALE,
        FEMALE, 
        GENDERLESS
    }   
    
    public enum GrowthRate
    {
        FAST,
        MEDIUM,
        SLOW,
        PARABOLIC,
        ERRATIC,
        FLUCTUATING
    }

    public struct EV
    {
        int hp;
        int atk;
        int def;
        int speed;
        int spatk;
        int spdef;
    }

    public enum EggGroup
    {
        MONSTER,
        WATER1, //sea creatures
        BUG,
        FLYING,
        FIELD,
        FAIRY,
        GRASS,
        HUMANLIKE,
        WATER3, //shellfish
        MINERAL,
        AMORPHOUS,
        WATER2, //fish
        DITTO,
        DRAGON,
        UNDISCOVERED //cannot put eggs
    }

    public enum Color
    {
        BLACK,
        BLUE,
        BROWN,
        GRAY,
        GREEN,
        PINK,
        PURPLE,
        RED,
        WHITE,
        YELLOW
    }

    public enum Shape
    {
        ONLYAHEAD,
        SERPENTLIKE,
        FISH,
        HEADANDARMS,
        HEADANDBASE,
        BIPEDALWITHTAIL,
        HEADANDLEGS,
        QUADRUPED,
        HASTWOWINGS,
        TENTACLESORMULTIPLELEGS,
        MULTIPLEFUSEDBODIES,
        HUMANOID,
        WINGEDINSECTOID,
        INSECTOID
    }

    public enum Habitat
    {
        CAVE,
        FOREST,
        GRASSLAND,
        MOUNTAIN,
        RARE, //THIS OPTION CAN BE TAKEN AS ""UNKNOWN""
        ROUGHTERRAIN,
        SEA,
        URBAN,
        WATERSEDGE
    }

    public struct Evolution
    {
        int monsterToEvolve;
        EvolutionMethod method;
        int methodParameter; //this can be a lvl, an item, a happiness lvl...
        
    }

    public enum EvolutionMethod
    {
        LEVEL,
        LEVELMALE,
        LEVELFEMALE,
        LEVELDAY,
        LEVELNIGHT,
        DAYHOLDITEM,
        NIGHTHOLDITEM,
        HASMOVE,
        BEAUTY,
        HASINPARTY,
        LEVELDARKINPARTY,
        ATTACKGREATER,
        ATKDEFEQUAL,
        DEFENSEGREATER,
        SILCOON,
        CASCOON,
        NINJASK,
        SHEDINJA,
        LEVELRAIN,
        LOCATION,
        HAPPINESS,
        HAPPINESSDAY,
        HAPPINESSNIGHT,
        HAPPINESMOVETYPE,
        ITEM,
        ITEMMALE,
        ITEMFEMALE,
        TRADEITEM,
        TRADESPECIES
    }

    public enum Nature
    {

    }

    public enum Status
    {
        HEALTHY,
        SLEEP,
        POISON,
        BURN,
        PARALYSIS,
        FROZEN
    }

}
