using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class PokemonMove
{
    public Move move;
    public byte currentPP;
    byte ppUpUsed = 0; //max 3

    public bool PpUp(bool maxPP)
    {

        if (ppUpUsed < 3)
        {
            byte upgradesAvaliable = (byte)(3 - ppUpUsed);

            ppUpUsed += upgradesAvaliable; 
            move.totalPP += (byte)(move.totalPP * (0.2 * upgradesAvaliable));
            return true;
        }

        return false;
    }
    
}
