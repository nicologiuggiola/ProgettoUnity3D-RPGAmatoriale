using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayInventory : MonoBehaviour
{
    public InventorySlots inventory;

    public int _X_S;
    public int _Y_S;
    public int _XSPACE;
    public int COLUMNS;
    public int _YSPACE;

    Dictionary<Slot, GameObject> itemsDisplay = new Dictionary<Slot, GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        OnDisplay();
    }

    // Update is called once per frame
    void Update()
    {
        UpDisplay();
    }

    public void OnDisplay()
    {
        for (int i = 0; i < inventory.Contenitore.Count; i++)
        {
            var obj = Instantiate(inventory.Contenitore[i].item.prefeb, Vector3.zero, Quaternion.identity, transform);
            obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
            itemsDisplay.Add(inventory.Contenitore[i], obj);
        }
    }

    public void UpDisplay()
    {
        for (int i = 0; i < inventory.Contenitore.Count; i++)
        {
            if (!itemsDisplay.ContainsKey(inventory.Contenitore[i]))
            {
                var obj = Instantiate(inventory.Contenitore[i].item.prefeb, Vector3.zero, Quaternion.identity, transform);
                obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
                itemsDisplay.Add(inventory.Contenitore[i], obj);
            }

        }
    }

    public Vector3 GetPosition(int i)
    {
        return new Vector3(_X_S + (_XSPACE * (i % COLUMNS)), _Y_S + (-_YSPACE * (i / COLUMNS)), 0f);
    }
}
