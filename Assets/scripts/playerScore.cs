using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class playerScore : MonoBehaviour
{
    public static playerScore instance;

    public int playerscore = 0;
    public TextMeshProUGUI scoreText;

    public int winScore = 10;   
    public string winSceneName = "WinScene";  

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        UpdateScoreUI();
    }

    public void AddScore(int amount)
    {
        playerscore += amount;
        UpdateScoreUI();

        CheckWinCondition();   
    }

    void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = playerscore.ToString();
        }
    }

    void CheckWinCondition()
    {
        if (playerscore >= winScore)
        {
            SceneManager.LoadScene(winSceneName);   
        }
    }
}
