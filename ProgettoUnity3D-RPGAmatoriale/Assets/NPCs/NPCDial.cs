using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NPCDialogue", menuName = "NPC Dialogue Set")]
public class NPCDial : ScriptableObject
{
    public string name;
    [TextArea(3, 5)]
    public string[] dialogue;
    [TextArea(2, 5)]
    public string[] playerDialogue;
}
