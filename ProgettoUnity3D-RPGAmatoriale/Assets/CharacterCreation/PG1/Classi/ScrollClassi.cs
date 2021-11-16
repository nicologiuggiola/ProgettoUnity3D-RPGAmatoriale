using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollClassi : MonoBehaviour
{
    public SelectClasses I;
    public SelectClasses II;
    public SelectClasses III;
    public SelectClasses IV;
    public SelectClasses V;
    public SelectClasses VI;
    public SelectClasses VII;
    public SelectClasses VIII;
    public Text className;
    public Text SkillUno;
    public Text SkillDue;
    public Text SkillTre;
    public Text SkillQuattro;
    public Text SkillCinque;
    public Text SkillSei;
    public PlayerStatPrefab player;
    public List<GameObject> scrollableClasses = new List<GameObject>();
    private int currentClass;
    // Start is called before the first frame update
    void Start()
    {
        ShowFirstClass();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentClass == 0)
        {
            className.text = I.name;
            SkillUno.text = I.startSkill;
            SkillDue.text = I.startSkilltwo;
            SkillTre.text = I.skillOne;
            SkillQuattro.text = I.skillTwo;
            SkillCinque.text = I.skillThree;
            SkillSei.text = I.skillFour;
        }
        else if (currentClass == 1)
        {
            className.text = II.name;
            SkillUno.text = II.startSkill;
            SkillDue.text = II.startSkilltwo;
            SkillTre.text = II.skillOne;
            SkillQuattro.text = II.skillTwo;
            SkillCinque.text = II.skillThree;
            SkillSei.text = II.skillFour;
        }
        else if (currentClass == 2)
        {
            className.text = III.name;
            SkillUno.text = III.startSkill;
            SkillDue.text = III.startSkilltwo;
            SkillTre.text = III.skillOne;
            SkillQuattro.text = III.skillTwo;
            SkillCinque.text = III.skillThree;
            SkillSei.text = III.skillFour;
        }
        else if (currentClass == 3)
        {
            className.text = IV.name;
            SkillUno.text = IV.startSkill;
            SkillDue.text = IV.startSkilltwo;
            SkillTre.text = IV.skillOne;
            SkillQuattro.text = IV.skillTwo;
            SkillCinque.text = IV.skillThree;
            SkillSei.text = IV.skillFour;
        }
        else if (currentClass == 4)
        {
            className.text = V.name;
            SkillUno.text = V.startSkill;
            SkillDue.text = V.startSkilltwo;
            SkillTre.text = V.skillOne;
            SkillQuattro.text = V.skillTwo;
            SkillCinque.text = V.skillThree;
            SkillSei.text = V.skillFour;
        }
        else if (currentClass == 5)
        {
            className.text = VI.name;
            SkillUno.text = VI.startSkill;
            SkillDue.text = VI.startSkilltwo;
            SkillTre.text = VI.skillOne;
            SkillQuattro.text = VI.skillTwo;
            SkillCinque.text = VI.skillThree;
            SkillSei.text = VI.skillFour;
        }
        else if (currentClass == 6)
        {
            className.text = VII.name;
            SkillUno.text = VII.startSkill;
            SkillDue.text = VII.startSkilltwo;
            SkillTre.text = VII.skillOne;
            SkillQuattro.text = VII.skillTwo;
            SkillCinque.text = VII.skillThree;
            SkillSei.text = VII.skillFour;
        }
        else if (currentClass == 7)
        {
            className.text = VIII.name;
            SkillUno.text = VIII.startSkill;
            SkillDue.text = VIII.startSkilltwo;
            SkillTre.text = VIII.skillOne;
            SkillQuattro.text = VIII.skillTwo;
            SkillCinque.text = VIII.skillThree;
            SkillSei.text = VIII.skillFour;
        }
    }

    void ShowFirstClass ()
    {
        scrollableClasses[currentClass].SetActive(true);
    }

    public void NextClassSelect ()
    {
        scrollableClasses[currentClass].SetActive(false);

        if (currentClass < scrollableClasses.Count -1)
        {
            ++currentClass;
        }
        else
        {
            currentClass = 0;
        }

        ShowFirstClass();
    }

    public void PrevClassSelect ()
    {
        scrollableClasses[currentClass].SetActive(false);

        if (currentClass == 0)
        {
            currentClass = (scrollableClasses.Count - 1);
        }
        else
        {
            --currentClass;
        }

        ShowFirstClass();
    }
}
