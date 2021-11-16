using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Equipment SO", menuName = "Set Equipment SO")]
public class CreateEquipSO : ItemsSO
{
    public int armor;
    public int maxDmg;
    public int minDmg;
    public int forza;
    public int accuratezza;
    public int costituzione;
    public int intelligenza;
    public int fede;
    public int volonta;
    public int vita;
    public int mana;

    public void Awake()
    {
        type = Types.Equipment;
    }
}
