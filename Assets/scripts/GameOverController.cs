using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
   // public UnityEngine.UI.Text finalScoreText; // Add in inspector (UI Text) OR use TextMeshPro if you prefer

    void Start()
    {
        //int lastScore = PlayerPrefs.GetInt("LastScore", 0);

        //if (finalScoreText != null)
        //    finalScoreText.text = "Score: " + lastScore.ToString();
    }
    public string menuSceneName = "MenuScene";
    public string gameSceneName = "GameScene";
    public void OnRetryButton()
    {
        SceneManager.LoadScene(gameSceneName);
    }

    public void OnMenuButton()
    {
        SceneManager.LoadScene(menuSceneName);
    }
}
