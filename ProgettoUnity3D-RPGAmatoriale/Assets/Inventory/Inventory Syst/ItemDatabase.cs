using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Inventory Database", menuName = "Set Item Database")]
public class ItemDatabase : ScriptableObject, ISerializationCallbackReceiver
{
    public ItemsSO[] Items;
    public Dictionary<ItemsSO, int> GetId = new Dictionary<ItemsSO, int>();
    public Dictionary<int, ItemsSO> GetItem = new Dictionary<int, ItemsSO>();

    public void OnAfterDeserialize()
    {
        GetId = new Dictionary<ItemsSO, int>();
        GetItem = new Dictionary<int, ItemsSO>();
        for (int i = 0; i < Items.Length; i++)
        {
            GetId.Add(Items[i], i);
            GetItem.Add(i, Items[i]);
        }

    }


    public void OnBeforeSerialize()
    {
        
    }
}
