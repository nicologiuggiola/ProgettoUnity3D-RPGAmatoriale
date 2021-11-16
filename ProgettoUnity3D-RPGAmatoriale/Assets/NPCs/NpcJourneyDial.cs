using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NpcJourneyDial : MonoBehaviour
{
    public NPCDial npc;

    protected bool isInQuestGiverZone = true;

    public CalendarioOro calenda;
    public GameObject dialogueUI;
    public GameObject dialoguePanelZero;

    public Text npcName;
    public Text npcDialogueBoxZero;
    public Text playerResponseUno;
    public GameObject playerRespObject;
    public GameObject playerButton;
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

    public void EventUno()
    {


        dialogueUI.SetActive(true);
        npcDialogueBoxZero.text = npc.dialogue[0];
        playerResponseUno.text = npc.playerDialogue[1];
        playerRespObject.SetActive(false);


    }

    public void EventDue()
    {
        dialogueUI.SetActive(true);
        npcDialogueBoxZero.text = npc.dialogue[2];
        playerButton.SetActive(false);
        playerResponseDue.text = npc.playerDialogue[2];
    }


    public void ButtonJourney()
    {


        SceneManager.LoadScene(3);

    }
}
