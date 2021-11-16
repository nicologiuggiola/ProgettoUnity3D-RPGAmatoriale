using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueWindowControll : MonoBehaviour
{
    public NPCDial npc;

    bool isTalking = false;

    float distance;

    public GameObject Player;
    public GameObject dialogueUI;
    public GameObject dialoguePanelZero;
    public GameObject dialoguePanelUno;
    public GameObject dialoguePanelDue;

    public Text npcName;
    public Text npcDialogueBoxZero;
    public Text npcDialogueBoxUno;
    public Text npcDialogueBoxDue;
    public Text playerResponseUno;
    public Text playerResponseDue;

    // Start is called before the first frame update
    void Start()
    {
        dialogueUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartDialogue()
    {
        isTalking = true;
        dialogueUI.SetActive(true);
        npcName.text = npc.name;
        npcDialogueBoxZero.text = npc.dialogue[0];
        playerResponseUno.text = npc.playerDialogue[0];
        playerResponseDue.text = npc.playerDialogue[1];
        dialoguePanelZero.SetActive(true);
        dialoguePanelUno.SetActive(false);
        dialoguePanelDue.SetActive(false);
    }

    public void EndDialogue()
    {
        isTalking = false;
        dialogueUI.SetActive(false);
    }

    public void ButtonDialogueUno()
    {
        npcDialogueBoxUno.text = npc.dialogue [1];
        dialoguePanelZero.SetActive(false);
        dialoguePanelUno.SetActive(true);
        dialoguePanelDue.SetActive(false);
    }

    public void ButtonDialogueDue()
    {
        npcDialogueBoxDue.text = npc.dialogue[2];
        dialoguePanelZero.SetActive(false);
        dialoguePanelUno.SetActive(false);
        dialoguePanelDue.SetActive(true);
    }
}