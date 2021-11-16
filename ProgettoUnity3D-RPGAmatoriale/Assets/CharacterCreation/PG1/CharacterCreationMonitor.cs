using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterCreationMonitor : MonoBehaviour
{
    public NewChar ashara;
    public NewChar haryn;
    public NewChar jin;
    public NewChar loth;

    public GameObject pguno;
    public GameObject pgdue;
    public GameObject pgtre;
    public GameObject pgquattro;
    public PlayerStatPrefab one;

    public Image spritepg;

    public Text name;
    public Text race;
    public Text strength;
    public Text accuracy;
    public Text fortitude;
    public Text intellect;
    public Text faith;
    public Text willpower;
    public Text points;

    private const int startingPointsnum = 15;
    public int pointsnum;
    public int pgNumber;

    // Start is called before the first frame update
    void Start()
    {
        pointsnum = startingPointsnum;
        ashara.forza = 10;
        haryn.forza = 10;
    }

    // Update is called once per frame
    void Update()
    {
        points.text = pointsnum.ToString();
        one.charStats.Forza = int.Parse(strength.text);
        one.charStats.Accuratezza = int.Parse(accuracy.text);
        one.charStats.Costituzione = int.Parse(fortitude.text);
        one.charStats.Intelletto = int.Parse(intellect.text);
        one.charStats.Fede = int.Parse(faith.text);
        one.charStats.Volontà = int.Parse(willpower.text);
        one.Numeropg = pgNumber;

        if (pguno.activeInHierarchy == true)
        {
            name.text = ashara.name;
            spritepg.sprite = ashara.art;
            race.text = ashara.race;
            strength.text = ashara.forza.ToString();
            accuracy.text = ashara.accuratezza.ToString();
            fortitude.text = ashara.costituzione.ToString();
            intellect.text = ashara.intelletto.ToString();
            faith.text = ashara.fede.ToString();
            willpower.text = ashara.volontà.ToString();
            pgNumber = 1;
        }

        if (pgdue.activeInHierarchy == true)
        {
            name.text = haryn.name;
            spritepg.sprite = haryn.art;
            race.text = haryn.race;
            strength.text = haryn.forza.ToString();
            accuracy.text = haryn.accuratezza.ToString();
            fortitude.text = haryn.costituzione.ToString();
            intellect.text = haryn.intelletto.ToString();
            faith.text = haryn.fede.ToString();
            willpower.text = haryn.volontà.ToString();
            pgNumber = 2;
        }

        if (pgtre.activeInHierarchy == true)
        {
            name.text = jin.name;
            spritepg.sprite = jin.art;
            race.text = jin.race;
            strength.text = jin.forza.ToString();
            accuracy.text = jin.accuratezza.ToString();
            fortitude.text = jin.costituzione.ToString();
            intellect.text = jin.intelletto.ToString();
            faith.text = jin.fede.ToString();
            willpower.text = jin.volontà.ToString();
            pgNumber = 3;
        }

        if (pgquattro.activeInHierarchy == true)
        {
            name.text = loth.name;
            spritepg.sprite = loth.art;
            race.text = loth.race;
            strength.text = loth.forza.ToString();
            accuracy.text = loth.accuratezza.ToString();
            fortitude.text = loth.costituzione.ToString();
            intellect.text = loth.intelletto.ToString();
            faith.text = loth.fede.ToString();
            willpower.text = loth.volontà.ToString();
            pgNumber = 4;
        }
    }

    public void SetAsharaToLothActive()
    {
        ashara.forza = 10;
        haryn.forza = 10;
        pointsnum = startingPointsnum;

        if(pguno.activeInHierarchy == true)
        {
            pguno.SetActive(false);
            pgdue.SetActive(true);
            pgtre.SetActive(false);
            pgquattro.SetActive(false);
        }

        else if(pgdue.activeInHierarchy == true)
        {
            pguno.SetActive(false);
            pgdue.SetActive(false);
            pgtre.SetActive(true);
            pgquattro.SetActive(false);
        }

        else if(pgtre.activeInHierarchy == true)
        {

            pguno.SetActive(false);
            pgdue.SetActive(false);
            pgtre.SetActive(false);
            pgquattro.SetActive(true);
        }
    }

    public void BackSetLothToAsharaActive()
    {
        ashara.forza = 10;
        haryn.forza = 10;
        pointsnum = startingPointsnum;
        if (pgquattro.activeInHierarchy == true)
        {

            pguno.SetActive(false);
            pgdue.SetActive(false);
            pgtre.SetActive(true);
            pgquattro.SetActive(false);
        }

        else if (pgtre.activeInHierarchy == true)
        {

            pguno.SetActive(false);
            pgdue.SetActive(true);
            pgtre.SetActive(false);
            pgquattro.SetActive(false);
        }

        else if (pgdue.activeInHierarchy == true)
        {

            pguno.SetActive(true);
            pgdue.SetActive(false);
            pgtre.SetActive(false);
            pgquattro.SetActive(false);
        }
    }

    public void OnClickySTR()
    {
        if (pguno.activeInHierarchy == true)
        {
            if (pointsnum > 0 && ashara.forza < 20)
            {
                ashara.forza = (ashara.forza + 1);
                pointsnum--;
            }
        }

        else if (pgdue.activeInHierarchy == true)
        {
            if (pointsnum > 0 && haryn.forza < 20)
            {
                haryn.forza = (haryn.forza + 1);
                pointsnum--;
            }
        }
    }
}
