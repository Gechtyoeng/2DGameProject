using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public string gameSceneName = "GameScene";
    public string menuSceneName = "MenuScene";
    public string gameOverSceneName = "GameOverScene";

    void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);

        DontDestroyOnLoad(gameObject); // keep manager across scenes if desired
    }

    public void StartGameFromMenu()
    {
        SceneManager.LoadScene(gameSceneName);
    }

    public void GameOver()
    {
        // Optionally pass data to GameOverScene via PlayerPrefs or a static variable
        PlayerPrefs.SetInt("LastScore", playerScore.instance != null ? playerScore.instance.playerscore : 0);
        PlayerPrefs.Save();

        SceneManager.LoadScene(gameOverSceneName);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(gameSceneName);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(menuSceneName);
    }
}
