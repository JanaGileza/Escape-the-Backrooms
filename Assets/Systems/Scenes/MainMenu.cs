using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] string gameStartScene;
    [SerializeField] string instructionsScene;
    [SerializeField] string creditsScene;


    public void PlayButton()
    {
        SceneManager.LoadScene(gameStartScene);
    }

    public void ExitGameButton()
    {
        Application.Quit();
    }

    public void InstructionsButton()
    {
        SceneManager.LoadScene(instructionsScene);
    }

    public void CreditsButton()
    {
        SceneManager.LoadScene(creditsScene);
    }
}
