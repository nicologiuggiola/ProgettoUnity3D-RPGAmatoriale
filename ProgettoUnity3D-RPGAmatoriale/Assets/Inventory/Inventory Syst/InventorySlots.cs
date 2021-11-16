using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

[CreateAssetMenu(fileName = "New Inventory", menuName = "Set Inventory SO")]
public class InventorySlots : ScriptableObject, ISerializationCallbackReceiver
{
    public string savePath;
    private ItemDatabase database;
    public List<Slot> Contenitore = new List<Slot>();

    private void OnEnable()
    {
#if UNITY_EDITOR
        database = (ItemDatabase)AssetDatabase.LoadAssetAtPath("Assets/Resources/InvDatabase.asset", typeof(ItemDatabase));
#else
        database = Resources.Load<ItemDatabase>("InvDatabase");
#endif
    }

    public void AddItem(ItemsSO _item, int _amount)
    {
        for (int i = 0; i <Contenitore.Count; i++)
        {
            if (Contenitore[i].item == _item)
            {
                Contenitore[i].AddAmount(_amount);
                return;
            }
        }

        Contenitore.Add(new Slot(database.GetId[_item] ,_item, _amount));
    }

    public void Save()
    {
        string saveData = JsonUtility.ToJson(this, true);
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(string.Concat(Application.persistentDataPath, savePath));
        bf.Serialize(file, saveData);
        file.Close();
    }

    public void Load()
    {
        if (File.Exists(string.Concat(Application.persistentDataPath, savePath)))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(string.Concat(Application.persistentDataPath, savePath), FileMode.Open);
            JsonUtility.FromJsonOverwrite(bf.Deserialize(file).ToString(), this);
            file.Close();
        }
    }

    public void OnAfterDeserialize()
    {
        for (int i = 0; i < Contenitore.Count; i++)
        Contenitore[i].item = database.GetItem[Contenitore[i].ID];


    }

    public void OnBeforeSerialize()
    {

    }
}

[System.Serializable]
public class Slot
{
    public int ID;
    public ItemsSO item;
    public int amount;
    public Slot(int _id, ItemsSO _item, int _amount)
    {
        ID = _id;
        item = _item;
        amount = _amount;
    }

    public void AddAmount(int value)
    {
        amount += value;
    }
}
