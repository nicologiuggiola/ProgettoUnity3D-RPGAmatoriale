using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterCreationMonitorTwo : MonoBehaviour
{
    public NewChar ashara2;
    public NewChar haryn2;
    public NewChar jin2;
    public NewChar loth2;

    public GameObject pguno;
    public GameObject pgdue;
    public GameObject pgtre;
    public GameObject pgquattro;
    public NewTwo two;

    public Image spritepg;

    public Text name;
    public Text race;
    public Text strength;
    public Text accuracy;
    public Text fortitude;
    public Text intellect;
    public Text faith;
    public Text willpower;
    public Text points2;

    private const int startingPointsnum2 = 15;
    public int pointsnum2;

    // Start is called before the first frame update
    void Start()
    {
        pointsnum2 = startingPointsnum2;
        ashara2.forza = 10;
        haryn2.forza = 10;
    }

    // Update is called once per frame
    void Update()
    {
        points2.text = pointsnum2.ToString();
        two.charTwoStats.Forza = int.Parse(strength.text);

        if (pguno.activeInHierarchy == true)
        {
            name.text = ashara2.name;
            spritepg.sprite = ashara2.art;
            race.text = ashara2.race;
            strength.text = ashara2.forza.ToString();
            accuracy.text = ashara2.accuratezza.ToString();
            fortitude.text = ashara2.costituzione.ToString();
            intellect.text = ashara2.intelletto.ToString();
            faith.text = ashara2.fede.ToString();
            willpower.text = ashara2.volontà.ToString();
        }

        if (pgdue.activeInHierarchy == true)
        {
            name.text = haryn2.name;
            spritepg.sprite = haryn2.art;
            race.text = haryn2.race;
            strength.text = haryn2.forza.ToString();
            accuracy.text = haryn2.accuratezza.ToString();
            fortitude.text = haryn2.costituzione.ToString();
            intellect.text = haryn2.intelletto.ToString();
            faith.text = haryn2.fede.ToString();
            willpower.text = haryn2.volontà.ToString();
        }

        if (pgtre.activeInHierarchy == true)
        {
            name.text = jin2.name;
            spritepg.sprite = jin2.art;
            race.text = jin2.race;
            strength.text = jin2.forza.ToString();
            accuracy.text = jin2.accuratezza.ToString();
            fortitude.text = jin2.costituzione.ToString();
            intellect.text = jin2.intelletto.ToString();
            faith.text = jin2.fede.ToString();
            willpower.text = jin2.volontà.ToString();
        }

        if (pgquattro.activeInHierarchy == true)
        {
            name.text = loth2.name;
            spritepg.sprite = loth2.art;
            race.text = loth2.race;
            strength.text = loth2.forza.ToString();
            accuracy.text = loth2.accuratezza.ToString();
            fortitude.text = loth2.costituzione.ToString();
            intellect.text = loth2.intelletto.ToString();
            faith.text = loth2.fede.ToString();
            willpower.text = loth2.volontà.ToString();
        }
    }

    public void SetAsharaToLothActive()
    {
        ashara2.forza = 10;
        haryn2.forza = 10;
        pointsnum2 = startingPointsnum2;

        if (pguno.activeInHierarchy == true)
        {
            pguno.SetActive(false);
            pgdue.SetActive(true);
            pgtre.SetActive(false);
            pgquattro.SetActive(false);
        }

        else if (pgdue.activeInHierarchy == true)
        {
            pguno.SetActive(false);
            pgdue.SetActive(false);
            pgtre.SetActive(true);
            pgquattro.SetActive(false);
        }

        else if (pgtre.activeInHierarchy == true)
        {

            pguno.SetActive(false);
            pgdue.SetActive(false);
            pgtre.SetActive(false);
            pgquattro.SetActive(true);
        }
    }

    public void BackSetLothToAsharaActive()
    {
        ashara2.forza = 10;
        haryn2.forza = 10;
        pointsnum2 = startingPointsnum2;
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
            if (pointsnum2 > 0 && ashara2.forza < 20)
            {
                ashara2.forza = (ashara2.forza + 1);
                pointsnum2 --;
            }
        }

        else if (pgdue.activeInHierarchy == true)
        {
            if (pointsnum2 > 0 && haryn2.forza < 20)
            {
                haryn2.forza = (haryn2.forza + 1);
                pointsnum2 --;
            }
        }
    }
}
