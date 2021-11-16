using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Types
{
    Equipment,
    Consumable,
    Quest_Item,
    Item
}

public abstract class ItemsSO : ScriptableObject
{
    public GameObject prefeb;
    public Types type;

    [TextArea(15, 20)]
    public string description;
}
