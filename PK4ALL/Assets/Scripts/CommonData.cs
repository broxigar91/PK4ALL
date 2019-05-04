using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace CommonData {

    public enum Type
    {
        BUG,
        DARK,
        DRAGON,
        ELECTRIC,
        FAIRY,
        FIGHTING,
        FIRE,
        FLYING,
        GHOST,
        GRASS,
        GROUND,
        ICE,
        NORMAL,
        POISON,
        PSYCHIC,
        ROCK,
        STEEL,
        WATER
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

    public enum ObtainMode
    {
        MET,
        EGGRECIEVED,
        TRADED,
        FATEFULENCOUNTER
    }

    public enum Languaje
    {
        UNKNOWN,
        JAPANESE,
        ENGLISH,
        FRENCH,
        ITALIAN,
        GERMAN,
        SPANISH,
        KOREAN
    }

    public enum MoveCode
    {
        //No effect and pseudo-moves

        C000, //No effect. 
        C001, //Nothing happens at all. Cannot be used if Gravity is in effect. 
        C002, //This move has no type. The user takes damage equal to 1/4 of its total HP, rounded down. This is not considered recoil damage

        //Status problems
        C003, //Puts the target to sleep. For Relic Song only, changes the user's form if the user is Meloetta and hasn't transformed. 
        C004, //Makes target drowsy, which makes it fall asleep at the end of the next round. Fails upon use if the target couldn't fall asleep immediately (even though it wouldn't), or is already drowsy. Target won't fall asleep if it already has a status problem, its ability prevents it from sleeping, or there is an uproar. 
        C005, //Poisons the target. 
        C006, //Badly poisons the target. Gen 6: Status moves have perfect accuracy when the user is Poison-type, even against semi-invulnerable targets. 
        C007, //Paralyzes the target. For Thunder Wave only, fails if the target is immune to the move's type. For Bolt Strike only, will double the power of the next Fusion Flare used this round. Gen 6: For Body Slam only, power is doubled and accuracy is perfect if the target is Minimized. (This is not an effect of the function code or its scripts.) 
        C008, //Paralyzes the target. Can hit the target even if it is in the middle of using Bounce, Fly or Sky Drop, or is under the effect of Sky Drop.During rainy weather, this attack has perfect accuracy. During sunny weather, this attack's base accuracy is 50%. 
        C009, //May paralyze the target (10%). May cause the target to flinch (10%). 
        C00A, //Burns the target. For Blue Flare only, will double the power of the next Fusion Bolt used this round. Gen 6: For Scald only, thaws the target if the move hits and the target is frozen. (This is not an effect of the function code or its scripts.) 
        C00B, //May burn the target (10%). May cause the target to flinch (10%).   
        C00C, //Freezes the target. 
        C00D, //Freezes the target. During hail weather, this attack has perfect accuracy. 
        C00E, //May freeze the target (10%). May cause the target to flinch (10%). 
        C00F, //Causes the target to flinch. 
        C010, //Causes the target to flinch. Inflicts double damage and (Gen 6) has perfect accuracy if the target is Minimized. Gen 6: Dragon Rush has effects against Minimized targets. Prior to Gen 6, it just causes the target to flinch. 
        C011, //Causes the target to flinch. Fails if the user is not asleep. 
        C012, //Causes the target to flinch. Fails if it isn't the user's first round in the battle. 
        C013, //Confuses the target. 
        C014, //May confuse the target. The probability of causing confusion increases if the user's cry is louder, but is 0% if it isn't a custom recorded cry. Gen 6: Always confuses the target. 
        C015, //Confuses the target. During rainy weather, this attack has perfect accuracy. During sunny weather, this attack's base accuracy is 50%. Hits the target even if it is in the middle of using Bounce, Fly or Sky Drop, or is under the effect of Sky Drop.
        C016, //The user attracts the target to it. Only works if the user and target are different genders (and neither is genderless), and if the target isn't already attracted to anyone. The effect ends if either the user or the target is switched out. 
        C017, //Either burns, freezes or paralyzes the target. The status inflicted is chosen at random. 
        C018, //The user is cured of burns, poison and paralysis
        C019, //All Pokémon in the user's party are cured of their permanent status problems (doesn't affect confusion, etc.). 
        C01A, //For 5 rounds (including the current round), Pokémon on the user's side cannot be given a status problem by any outside attacks or items (except held items). Status problems can still be self-inflicted. Fails if the user's side is already being affected by this effect.
        C01B, //The target gains the permanent status problem of the user (bad poisoning is passed across). If it does, the user's permanent status problem is cured. Fails if the target already has a permanent status problem, or if it can't be inflicted with the user's permanent status problem. 

        //Changes user's stat stages
        C01C, //Increases the user's Attack by 1 stage. 
        C01D, //Increases the user's Defense by 1 stage. 
        C01E, //Increases the user's Defense by 1 stage. The user curls up (making the user's Ice Ball/Rollout do double damage), even if Defense is not boosted. Curling up is not cumulative. 
        C01F, //ncreases the user's Speed by 1 stage. 
        C020, //Increases the user's Special Attack by 1 stage. 
        C021, //ncreases the user's Special Defense by 1 stage. Until the end of the next round, the power of the user's damaging Electric attacks is doubled. The effect ends if the user is switched out. 
        C022, //Increases the user's evasiveness by 1 stage. 
        C023, //Increases the user's critical hit rate by 2 stages. This effect is not cumulative with itself or certain other effects. 
        C024, //Increases the user's Attack and Defense by 1 stage each. 
        C025, //Increases the user's Attack, Defense and accuracy by 1 stage each. 
        C026, //Increases the user's Attack and Speed by 1 stage each. 
        C027, //Increases the user's Attack and Special Attack by 1 stage each. 
        C028, //Increases the user's Attack and Special Attack by 1 stage each. In sunny weather, increases them by 2 stages each instead. 
        C029, //Increases the user's Attack and accuracy by 1 stage each. 
        C02A, //Increases the user's Defense and Special Defense by 1 stage each. 
        C02B, //Increases the user's Speed, Special Attack and Special Defense by 1 stage each.

    }

    public enum DamageCategory
    {
        PHYSICAL,
        SPECIAL,
        STATUS
    }

    public enum TargetCode
    {
        SINGLE_NO_USER, //Single Pokémon other than the user 
        NO_TARGET, // No target (i.e. Counter, Metal Burst, Mirror Coat, Curse) 
        SINGLE_OPPOSING_RANDOM, //Single opposing Pokémon selected at random (i.e. Outrage, Petal Dance, 
        ALL_OPPOSING, //All opposing Pokémon
        ALL_BUT_NO_USER, //All Pokémon other than the user 
        USER,
        BOTH_SIDES, //User's partner
        USER_SIDE,
        OPPOSING_SIDE,
        USER_PARTNER,
        SINGLE_USER_SIDE,
        SINGLE_OPPOSING_SIDE,
        SINGLE_OPPOSING_DIRECTLY_OPPOSITE
    }

    public enum Pocket
    {
        ITEMS,
        MEDICINE,
        BALLS,
        TMHM,
        BERRIES,
        MAIL,
        BATTLEITEMS,
        KEYITEMS
    }

    public enum UsabilityOutsideBattle
    {
        CANNOT_USE,
        USE_ON_MONSTER_AND_DISSAPEAR,//The item can be used on a Pokémon, and disappears after use (e.g. Potions, Elixirs). The party screen will appear when using this item, allowing you to choose the Pokémon to use it on. Not for TMs and HMs, though. 
        CANNOT_USE_ON_MONSTER,//The item can be used out of battle, but it isn't used on a Pokémon (e.g. Repel, Escape Rope, usable Key Items). 
        TM,
        HM,
        USE_ON_MONSTER_AND_NOT_DISSAPEAR //The item can be used on a Pokémon (like 1), but it does not disappear after use (e.g. Poké Flute)
    }

    //put comments
    public enum UsabilityInBattle
    {
        CANNOT_USE,
        USE_ON_MONSTER_AND_DISSAPEAR,
        BALL,
        USE_ON_MONSTER_AND_NOT_DISSAPEAR,
        CAN_USE
    }

    //put comments
    public enum SpecialItems
    {
        NONE,
        MAIL,
        MAIL2,
        SNAGBALL,
        BALL,
        BERRY,
        KEYITEM,
        EVOLUTION_STONE,
        FOSSIL,
        APRICORN,
        ELEMENTAL_POWER_RAISING_GEM,
        MULCH_FOR_BERRY_PATCHES,
        MEGASTONE
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

    public enum Natures
    {
        ADAMANT,
        BASHFUL,
        BOLD,
        BRAVE,
        CALM,
        CAREFUL,
        DOCILE,
        GENTLE,
        HARDY,
        HASTY,
        IMPISH,
        JOLLY,
        LAX,
        LONELY,
        MILD,
        MODEST,
        NAIVE,
        NAUGHTY,
        QUIET,
        QUIRKY,
        RASH,
        RELAXED,
        SASSY,
        SERIOUS,
        TIMID
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

    public enum PokeballType
    {

    }

    [Serializable]
    public struct Evolution
    {
        int monsterToEvolve;
        EvolutionMethod method;
        int methodParameter; //this can be a lvl, an item, a happiness lvl...
    }

    [Serializable]
    public struct BaseStats
    {
        public byte hp;
        public byte atk;
        public byte def;
        public byte speed;
        public byte spatk;
        public byte spdef;
    }

    [Serializable]
    public struct Nature
    {
        public Natures nature;

        //MODIFIERS
        public float hp;
        public float atk;
        public float def;
        public float speed;
        public float spatk;
        public float spdef;
    }

    [Serializable]
    public struct BeautyStats
    {
        public byte beauty;
        public byte cool;
        public byte cute;
        public byte smart;
        public byte tough;
        public byte sheen;
    }

    //markings
    //ribbons

    [Serializable]
    public struct EV
    {
        public byte hp;
        public byte atk;
        public byte def;
        public byte speed;
        public byte spatk;
        public byte spdef;
    }

    [Serializable]
    public struct IV
    {
        public byte hp;
        public byte atk;
        public byte def;
        public byte speed;
        public byte spatk;
        public byte spdef;
    }


    [Serializable]
    public class IntIntDictionary : SerializableDictionary<int, int> { }

}
