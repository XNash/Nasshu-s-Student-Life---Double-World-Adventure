using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonMaster : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Start the battle
        //TurnManager.StartBattle();

    }

    // Update is called once per frame
    void Update()
    {
        // Check if the player has pressed the "End Turn" button
        if (Input.GetKeyDown(KeyCode.Space)) {
            // End the current turn


            //TurnManager.EndTurn();
        }
    }
}
