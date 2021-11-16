using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroPlayer : MonoBehaviour
{
    private GameObject[] players;
    private GameObject[] controller;
    private GameObject[] ui;
    private GameObject[] eventsControl;

    void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    void Update()
    {
        players = GameObject.FindGameObjectsWithTag("Player");
        if (players.Length > 1)
        {
            Destroy(players[0]);
        }

        controller = GameObject.FindGameObjectsWithTag("Controller");
        if (controller.Length > 1)
        {
            Destroy(controller[0]);
        }

        ui = GameObject.FindGameObjectsWithTag("UI");
        if (ui.Length > 1)
        {
            Destroy(ui[0]);
        }

        eventsControl = GameObject.FindGameObjectsWithTag("Events");
        if (eventsControl.Length > 1)
        {
            Destroy(eventsControl[0]);
        }

        eventsControl = GameObject.FindGameObjectsWithTag("Sun");
        if (eventsControl.Length > 1)
        {
            Destroy(eventsControl[0]);
        }
    }
}
