using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateChar : MonoBehaviour
{
    public GameObject pgone;
    public Transform parent;

    // Start is called before the first frame update
    void Start()
    {
        InstantiateChildOne();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InstantiateChildOne()
    {
        GameObject childGameObject = Instantiate(pgone, parent);
        childGameObject.name = "PGPrefs";

    }

}
