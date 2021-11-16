using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetThisClass : MonoBehaviour
{
    public SelectClasses Uno;
    public string Name;
    public string Description;
    public string StartI;
    public string StartII;
    public string SkillIII;
    public string SkillIV;
    public string SkillV;
    public string SkillVI;

    // Start is called before the first frame update
    void Start()
    {
        Name = Uno.name;
        Description = Uno.description;
        StartI = Uno.startSkill;
        StartII = Uno.startSkilltwo;
        SkillIII = Uno.skillOne;
        SkillIV = Uno.skillTwo;
        SkillV = Uno.skillThree;
        SkillVI = Uno.skillFour;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
