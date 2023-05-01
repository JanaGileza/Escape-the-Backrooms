using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public static SceneLoader Instance;

    // Awake is called when the script instance is being loaded (only once, before Start())
    void Awake()
    {
        Instance = this;
    }

    public void LoadScene(Scenes scene)
    {
        SceneManager.LoadScene(scene.ToString());
    }
}

public enum Scenes
{
    MainMenu,
    Instructions,
    Game,
    GameOver,
    GameWin
}
