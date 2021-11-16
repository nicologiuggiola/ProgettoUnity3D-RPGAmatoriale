using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CalendarioOro : MonoBehaviour
{
    public TextMeshProUGUI orologio;
    public System.TimeSpan sTime = new System.TimeSpan(0, 0, 0, 0, 0);
    public float clockSpeed = 30;
    public string format;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float milliseconds = Time.deltaTime * 1000 * clockSpeed;
        sTime += new System.TimeSpan(0, 0, 0, 0, (int)milliseconds);
        System.DateTime dateTime = System.DateTime.MinValue.Add(sTime);
        orologio.text = dateTime.ToString(@format);
    }

    public void Velox()
    {
        sTime += new System.TimeSpan(0, 0, 0);
    }
}
