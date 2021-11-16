using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Statemachine : MonoBehaviour
{
    public Image Bar;
    public PlayerOnClickActions onClickActions;
    public GameObject Canvas;
    public enum ActionState
    {
        RECHARGING,
        QUEUE,
        NEXTTOSELECT,
        SELECTED,
        DEAD
    }

    public ActionState State;
    private float Cooldown = 0;
    private float MaxCooldown = 5;
    public bool isListed;
    // Start is called before the first frame update
    void Start()
    {
        State = ActionState.RECHARGING;
        Canvas.SetActive(false);
        isListed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (onClickActions.CharInQueue.Contains(this.gameObject) == true) 
        {
            isListed = true;
        }
        else
        {
            isListed = false;
        }

        switch (State)
        {
            case (ActionState.RECHARGING):
                BarRecharge();
                break;

            case (ActionState.QUEUE):
                onClickActions.CharInQueue.Add(this.gameObject);

                if (onClickActions.CharInQueue.Contains(this.gameObject)==true)
                {
                    State = ActionState.NEXTTOSELECT;
                }

                break;

            case (ActionState.NEXTTOSELECT):
                if (Canvas.activeSelf)
                {
                    State = ActionState.SELECTED;
                }

                if (onClickActions.CharInQueue.Contains(this.gameObject) == false)
                {
                    Cooldown = 0;
                    State = ActionState.RECHARGING;
                }
                break;

            case (ActionState.SELECTED):
                if (!Canvas.activeSelf)
                {
                    //Cooldown = 0;
                    RemoveList();
                    State = ActionState.RECHARGING;
                }
                break;

            case (ActionState.DEAD):

                break;
        }

    }

    void BarRecharge()
    {
        Cooldown = Cooldown + Time.deltaTime;
        float CooldownCalcolo = Cooldown / MaxCooldown;
        Bar.transform.localScale = new Vector3(Mathf.Clamp(CooldownCalcolo, 0, 1), Bar.transform.localScale.y, Bar.transform.localScale.z);
        if (Cooldown >= MaxCooldown)
        {
            State = ActionState.QUEUE;
        }
    }

    void RemoveList()
    {
        Cooldown = 0;
        onClickActions.CharInQueue.Remove(this.gameObject);
    }
}
