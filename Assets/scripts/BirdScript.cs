using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength = 5f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // If hit a pipe or ground, notify GameManager to end the game
        if (collision.collider.CompareTag("Obstacle") || collision.collider.CompareTag("Ground"))
        {
            GameManager.instance.GameOver();
        }
    }
}
