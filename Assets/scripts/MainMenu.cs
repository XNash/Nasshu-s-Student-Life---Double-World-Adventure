using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public SaveLoadManager saveLoad;
    public void newGameSelected()
    {
        saveLoad.newGame();
        SceneManager.LoadScene(1);
    }

    public void continueGameSelected()
    {
        // Start out in town. Town scene start method will load the data
        SceneManager.LoadScene(1);
    }
}
