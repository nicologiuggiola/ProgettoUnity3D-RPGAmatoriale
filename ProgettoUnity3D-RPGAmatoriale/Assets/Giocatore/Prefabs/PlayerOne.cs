using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOne : MonoBehaviour
{
    public InventorySlots myInventory;
    public PlayerStatPrefab One;
    public int forza;
    public int accuratezza;
    public int costituzione;
    public int intelletto;
    public int fede;
    public int volonta;
    public int Numeropg;
    public int vita = 20;
    public Arrow oneArrow;

    public int level = 1;
    public int cLevel;
    public int aDamage;

    // Start is called before the first frame update
    void Awake ()
    {
        
        forza = One.charStats.Forza;
        accuratezza = One.charStats.Accuratezza;
        costituzione = One.charStats.Costituzione;
        intelletto = One.charStats.Intelletto;
        fede = One.charStats.Fede;
        volonta = One.charStats.Volontà;
        vita = 20 + (costituzione / 4);
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CalculateNewLevel();

        One.charStats.Forza = forza;
        One.charStats.Accuratezza = accuratezza;
        One.charStats.Costituzione = costituzione;
        One.charStats.Intelletto = intelletto;
        One.charStats.Fede = fede;
        One.charStats.Volontà = volonta;
        aDamage = Random.Range(0, 4);
        oneArrow.damage = aDamage + (forza / 6);
    }

    public void SavePlayer ()
    {
        SaveSystem.SavePlayer(this);
        myInventory.Save();
    }

    public void LoadPlayer()
    {
        PlayerOneData oneData = SaveSystem.LoadPlayer();
        myInventory.Load();

        forza = oneData.forza;
    }

    public void IncreaseForza()
    {
        level = ++level;
        forza = ++forza;
        Debug.Log(System.DateTime.Now.DayOfWeek);
    }

    public void CalculateNewLevel()
    {
        if (cLevel < level)
        {
            ++costituzione;
            vita = vita + (costituzione / 4);
            cLevel = level;
        }
    }
}
