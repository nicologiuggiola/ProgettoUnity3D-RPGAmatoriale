using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewChar", menuName = "Set New Char")]
public class NewChar : ScriptableObject
{
    public string name;
    public string description;
    public string race;

    public Sprite art;

    public int level;
    public int forza;
    public int accuratezza;
    public int costituzione;
    public int intelletto;
    public int fede;
    public int volontà;
}