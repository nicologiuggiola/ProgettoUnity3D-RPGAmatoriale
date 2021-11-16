using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerGameInterface : MonoBehaviour
{
    public Text forzauno;
    public PlayerStatPrefab player;
    public PlayerOne One;
    public Image spriteOne;
    public Sprite art1;
    public Sprite art2;
    public Sprite art3;
    public Sprite art4;
    public int Number;

    // Start is called before the first frame update
    void Start()
    {
        Number = player.Numeropg;
    }

    // Update is called once per frame
    void Update()
    {
        forzauno.text = One.forza.ToString();

        if (Number == 1)
        {
            spriteOne.sprite = art1;
        }
        else if (Number ==2)
        {
            spriteOne.sprite = art2;
        }
    }
}
