using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlayerOnClickActions : MonoBehaviour
{

    float distance;

    public InventorySlots InventoryOne;
    public GameObject inventoryCanvasOne;
    public GameObject inventoryCanvasTwo;
    public GameObject inventoryCanvasThree;
    public GameObject inventoryCanvasFour;

    public Text mese;

    public GameObject Player;
    public GameObject ArrowPref;
    public GameObject ArrowPrefTwo;
    public GameObject ArrowPrefThree;
    public GameObject ArrowPrefFour;

    public GameObject Canvasone;
    public GameObject Canvastwo;
    public GameObject Canvasthree;
    public GameObject Canvasfour;

    public Camera camera;
    public AudioSource arrowaudio;
    public AudioSource meleeaudio;

    public float damage = 1;

    public List<GameObject> CharInQueue = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        inventoryCanvasOne.SetActive(false);
        inventoryCanvasTwo.SetActive(false);
        inventoryCanvasThree.SetActive(false);
        inventoryCanvasFour.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (CharInQueue.Count > 0)
        {

            CharInQueue[0].transform.FindChild("Canvas").gameObject.SetActive(true);

          if (Input.GetMouseButtonDown(0) && !IsPointerOverUIElement())
          {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if (Physics.Raycast(ray, out hitInfo))
            {

                if (hitInfo.collider.gameObject.tag == "Enemy")
                {
                    distance = Vector3.Distance(Player.transform.position, hitInfo.collider.transform.position);
                    if (distance >= 3.1f) 
                    {
                        SelectCharRanged();
                        CharInQueue[0].transform.FindChild("Canvas").gameObject.SetActive(false);
                        CharInQueue.RemoveAt(0);
                    }

                    if (distance <= 3f)
                    {
                        SelectCharMelee();
                        
                    }
                }

                if (hitInfo.collider.gameObject.tag == "Npc")
                {
                    distance = Vector3.Distance(Player.transform.position, hitInfo.collider.transform.position);
                    if(distance <= 3f)
                    {
                            hitInfo.collider.gameObject.GetComponent<DialogueWindowControll>().StartDialogue();
                        StartDialogue();
                    }
                }

                if (hitInfo.collider.gameObject.tag == "Carrozza")
                {
                    distance = Vector3.Distance(Player.transform.position, hitInfo.collider.transform.position);
                    if (distance <= 3f && mese.text == "January")
                    {
                            hitInfo.collider.gameObject.GetComponent<NpcJourneyDial>().EventUno();
                    }
                    else if (distance <= 3f && mese.text == "February")
                    {
                            hitInfo.collider.gameObject.GetComponent<NpcJourneyDial>().EventDue();
                    }
                }

                if (hitInfo.collider.gameObject.tag == "Lootable")
                {
                    distance = Vector3.Distance(Player.transform.position, hitInfo.collider.transform.position);
                    if (distance <= 3f)
                    {
                            var item = hitInfo.collider.gameObject.GetComponent<ItemScript>();
                            if (item)
                            {
                                InventoryOne.AddItem(item.item, 1);
                                Destroy(hitInfo.collider.gameObject);
                            }
                    }
                }
              
            }
          }
        }
        ArrowPref.transform.position = Player.transform.position + transform.forward;
        ArrowPref.transform.forward = camera.transform.forward;

        ArrowPrefTwo.transform.position = Player.transform.position + transform.forward;
        ArrowPrefTwo.transform.forward = camera.transform.forward;

        ArrowPrefThree.transform.position = Player.transform.position + transform.forward;
        ArrowPrefThree.transform.forward = camera.transform.forward;

        ArrowPrefFour.transform.position = Player.transform.position + transform.forward;
        ArrowPrefFour.transform.forward = camera.transform.forward;
    }

    void StartDialogue()
    {
        Debug.Log("HI!");
    }

    void SelectCharRanged()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        if (Physics.Raycast(ray, out hitInfo))
        {
            if (hitInfo.collider.gameObject.tag == "Enemy")
            {
                distance = Vector3.Distance(Player.transform.position, hitInfo.collider.transform.position);
                if (distance >= 3.1f)
                {
                    if (Canvasone.active == true)
                    {
                        Instantiate(ArrowPref);
                        Debug.Log("ARROW!");
                        PlayArrow();
                    }
                    else if (Canvastwo.active == true)
                    {
                        Instantiate(ArrowPrefTwo);
                        Debug.Log("ARROW!");
                        PlayArrow();
                    }
                    else if (Canvasthree.active == true)
                    {
                        Instantiate(ArrowPrefThree);
                        Debug.Log("ARROW!");
                        PlayArrow();
                    }
                    else if (Canvasfour.active == true)
                    {
                        Instantiate(ArrowPrefFour);
                        Debug.Log("ARROW!");
                        PlayArrow();
                    }
                }
            }
        }
    }

    void SelectCharMelee()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;

        if (Physics.Raycast(ray, out hitInfo))
        {
            if (hitInfo.collider.gameObject.tag == "Enemy")
            {
                distance = Vector3.Distance(Player.transform.position, hitInfo.collider.transform.position);
                if (distance <= 3f)
                {
                    hitInfo.collider.gameObject.GetComponent<EnemyLF>().TakeDamage(damage);
                    PlayMelee();

                    CharInQueue[0].transform.FindChild("Canvas").gameObject.SetActive(false);
                    //CharInQueue.RemoveAt(0);
                }
            }
        Debug.Log("SWORD!");
        }
    }

    public void PlayArrow()
    {
        arrowaudio.Play();
    }

    public void PlayMelee()
    {
        meleeaudio.Play();
    }

    public static bool IsPointerOverUIElement()
    {
        return IsPointerOverUIElement(GetEventSystemRaycastResults());
    }
    ///Returns 'true' if we touched or hovering on Unity UI element.
    public static bool IsPointerOverUIElement(List<RaycastResult> eventSystemRaysastResults)
    {
        for (int index = 0; index < eventSystemRaysastResults.Count; index++)
        {
            RaycastResult curRaysastResult = eventSystemRaysastResults[index];
            if (curRaysastResult.gameObject.layer == LayerMask.NameToLayer("UI"))
                return true;
        }
        return false;
    }
    ///Gets all event systen raycast results of current mouse or touch position.
    static List<RaycastResult> GetEventSystemRaycastResults()
    {
        PointerEventData eventData = new PointerEventData(EventSystem.current);
        eventData.position = Input.mousePosition;
        List<RaycastResult> raysastResults = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventData, raysastResults);
        return raysastResults;
    }

    public void OpenInventory()
    {
        if (Canvasone.active == true)
        {
            inventoryCanvasOne.SetActive(true);
            inventoryCanvasTwo.SetActive(false);
            inventoryCanvasThree.SetActive(false);
            inventoryCanvasFour.SetActive(false);
        }
    }

    public void CloseInventory()
    {
        inventoryCanvasOne.SetActive(false);
    }

    private void OnApplicationQuit()
    {
        InventoryOne.Contenitore.Clear();
    }

}