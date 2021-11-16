using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AsharaLoad : MonoBehaviour
{
    public NewChar ashara;

    public Text asharaName;
    public Text asharaRace;
    public Text asharaForzaT;
    public Text asharaAccuratezzaT;

    public int asharaForza;
    public int asharaAccuratezza;

    // Start is called before the first frame update
    void Start()
    {
        asharaName.text = PlayerPrefs.GetString("name");
        asharaRace.text = PlayerPrefs.GetString("race");
    }

    // Update is called once per frame
    void Update()
    {
        if(asharaRace.text == "Helbrood")
        {
            asharaForza = ashara.forza;
            asharaAccuratezza = ashara.accuratezza;
            asharaForzaT.text = asharaForza.ToString();
            asharaAccuratezzaT.text = asharaAccuratezza.ToString();
        }
    }
}
