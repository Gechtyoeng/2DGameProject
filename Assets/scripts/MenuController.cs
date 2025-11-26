using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public string gameSceneName = "GameScene";  
    public void OnStartButton()
    {
        SceneManager.LoadScene(gameSceneName);
    }
}
