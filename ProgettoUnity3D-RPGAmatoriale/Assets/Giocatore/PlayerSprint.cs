using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSprint : MonoBehaviour
{
    PlayerMovement PlayerMovement;
    public float speedSprint = 4f;

    void Start()
    {
        PlayerMovement = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.LeftShift))
            PlayerMovement.Speed += speedSprint;
        else if (Input.GetKeyUp(KeyCode.LeftShift))
            PlayerMovement.Speed -= speedSprint;
    }
}
