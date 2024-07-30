using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EntranceScript : MonoBehaviour
{
    public GameManager gameManager;
    public SaveLoadManager sl;
    //public int floor = 2;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (sl && gameManager)
            {
                sl.saveGame();
                SceneManager.LoadScene(gameManager.currentFloor);
            }
        }
    }
}