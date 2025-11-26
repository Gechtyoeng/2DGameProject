using UnityEngine;

public class pipeMiddle : MonoBehaviour
{
    private bool hasScored = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!hasScored && collision.CompareTag("Player"))
        {
            if (playerScore.instance != null)
            {
                playerScore.instance.AddScore(1);
            }
            hasScored = true;
        }
    }
}
