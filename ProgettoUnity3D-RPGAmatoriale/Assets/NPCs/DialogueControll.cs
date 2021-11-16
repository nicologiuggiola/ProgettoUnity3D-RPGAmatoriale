using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueControll : MonoBehaviour
{
    public NPCDial npc;

    bool isTalking = false;

    float distance;
    float curResponseTracker = 0;

    public GameObject Player;
    public GameObject dialogueUI;

    public Text npcName;
    public Text npcDialogueBox;
    public Text playerResponse;

    // Start is called before the first frame update
    void Start()
    {
        dialogueUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if (Physics.Raycast(ray, out hitInfo))
            {
                if (hitInfo.collider.gameObject.tag == "Npc")
                {
                    distance = Vector3.Distance(Player.transform.position, this.transform.position);
                    if (distance <= 3f)
                    {
                        if(isTalking== false)
                        {
                            if (Input.GetAxis("Mouse ScrollWheel") < 0)
                            {
                                curResponseTracker++;
                                if (curResponseTracker >= npc.playerDialogue.Length - 1)
                                {
                                    curResponseTracker = npc.playerDialogue.Length - 1;
                                }
                            }

                            else if (Input.GetAxis("Mouse ScrollWheel") > 0)
                            {
                                curResponseTracker--;
                                if (curResponseTracker < 0)
                                {
                                    curResponseTracker = 0;
                                }
                            }

                            StartDialogue();

                            if (curResponseTracker == 0 && npc.playerDialogue.Length >= 0)
                            {
                                playerResponse.text = npc.playerDialogue[0];
                                if (Input.GetKeyDown(KeyCode.F))
                                {
                                    npcDialogueBox.text = npc.dialogue[1];
                                }
                            }

                            else if (curResponseTracker == 1 && npc.playerDialogue.Length >= 1)
                            {
                                playerResponse.text = npc.playerDialogue[1];
                                if (Input.GetKeyDown(KeyCode.F))
                                {
                                    npcDialogueBox.text = npc.dialogue[2];
                                }
                            }
                        }


                    }
                }
            }
        }

    }

    void StartDialogue()
    {
        isTalking = true;
        curResponseTracker = 0;
        dialogueUI.SetActive(true);
        npcName.text = npc.name;
        npcDialogueBox.text = npc.dialogue[0];
    }

}