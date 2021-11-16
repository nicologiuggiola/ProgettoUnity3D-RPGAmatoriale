using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Consumable SO", menuName = "Set Consumable SO")]
public class CreateConsumable : ItemsSO
{
    public int healingValue;
    public void Awake()
    {
        type = Types.Consumable;
    }
}
