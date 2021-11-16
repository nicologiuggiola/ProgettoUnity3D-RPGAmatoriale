using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item SO", menuName = "Set Item SO")]
public class CreateItemSO : ItemsSO
{
    // Start is called before the first frame update
    public void Awake()
    {
        type = Types.Item;
    }
}
