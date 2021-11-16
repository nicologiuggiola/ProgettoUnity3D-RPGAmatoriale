using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "DayNightLight", menuName = "Create DayNight")]
public class ScriptableDayNight : ScriptableObject
{
    public Gradient Ambient;
    public Gradient Direction;
    public Gradient Fog;
}
