using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    private int currentTurn = 0;
    private List<Character> characters = new List<Character>();

    public void StartBattle() {
        currentTurn = 0;
        // Perform any other necessary initialization steps
        
        // Call the first character's turn
        characters[currentTurn].StartTurn();
    }

    public int getCurrentTurn()
    {
        return currentTurn;
    }

    public void EndTurn() {
        // Disable input controls for the current character

        // Move to the next turn
        currentTurn++;

        // Check if the battle is over or if there are more characters to play
        if (currentTurn >= characters.Count) {
            // Battle is over, perform necessary clean-up and end the battle
        }
        else {
            // Start the turn for the next character
            characters[currentTurn].StartTurn();
        }
    }

}