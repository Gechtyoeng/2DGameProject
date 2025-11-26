using UnityEngine;

public class pipeController : MonoBehaviour
{
    public float pipeSpeed = 2f;
    public float destroyX = -12f; 

    void Update()
    {
        transform.position += Vector3.left * pipeSpeed * Time.deltaTime;

        if (transform.position.x < destroyX)
        {
            Destroy(gameObject);
        }
    }
}
