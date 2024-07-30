using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private TurnManager turnManager;

    private void setTurnManager()
    {
        turnManager = gameObject.GetComponent<TurnManager>();
    }

    private void Start()
    {
        turnManager = FindObjectOfType<TurnManager>();
    }

    public void StartTurn()
    {
        // Enable input controls for the character
    }


    public void EndTurn()
    {
        // Perform any necessary actions for ending the turn

        // Call the TurnManager's EndTurn method to switch to the next turn
        turnManager.EndTurn();
    }
}
