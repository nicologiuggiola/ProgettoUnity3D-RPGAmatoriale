using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yrotation : MonoBehaviour
{
    public Camera camera;


    public float speed = 2.0F;

    void Update()
    {

        Camera camera = GetComponent<Camera>();
        if (Input.GetKey(KeyCode.Q))
        {
            var currEulerAngles = transform.eulerAngles;
            currEulerAngles.x += speed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(currEulerAngles);
            currEulerAngles.x = Mathf.Clamp(currEulerAngles.x, -70, 70);
        }

        if (Input.GetKey(KeyCode.E))
        {
            var currEulerAngles = transform.eulerAngles;
            currEulerAngles.x -= speed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(currEulerAngles);
            currEulerAngles.x = Mathf.Clamp(currEulerAngles.x, -70, 70);
        }

    }
}
