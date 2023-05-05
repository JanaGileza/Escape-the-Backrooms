using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Instructions : MonoBehaviour
{
    [SerializeField] string gameStartScene;
    [SerializeField] string mainMenuScene;

   public void MainMenuButton()
    {
        SceneManager.LoadScene(mainMenuScene);
    }

    public void GameButton()
    {
        SceneManager.LoadScene(gameStartScene);
    }
    
}
