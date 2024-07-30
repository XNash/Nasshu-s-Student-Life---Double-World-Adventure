using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalBack : MonoBehaviour
{
    public GameManager gameManager;
    public SaveLoadManager sl;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (sl && gameManager)
            {
                sl.saveGame();
                SceneManager.LoadScene(1);
            }
        }
    }
}
