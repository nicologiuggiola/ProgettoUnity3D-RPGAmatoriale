using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SavePGS : MonoBehaviour
{
    public InputField pgunoName;
    public Text pgunoRace;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickSaveChar()
    {
        PlayerPrefs.SetString("name", pgunoName.text);
        PlayerPrefs.SetString("race", pgunoRace.text);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
