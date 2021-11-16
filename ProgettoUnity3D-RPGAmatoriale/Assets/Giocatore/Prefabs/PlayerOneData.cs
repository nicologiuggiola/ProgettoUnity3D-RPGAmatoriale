using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerOneData
{
    public int forza;

    public PlayerOneData (PlayerOne playerone)
    {
        forza = playerone.forza;
    }

}
