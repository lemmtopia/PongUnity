using Unity.VisualScripting;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    [SerializeField] private bool isHuman;
    [SerializeField] KeyCode keyUp, keyDown;
    [SerializeField] float moveSpeed;
    [SerializeField] float halfScreenHeight;

    public GameObject ball;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isHuman)
        {
            MoveHuman();
        }
        else
        {
            MoveAI();
        }

        if (transform.position.y > halfScreenHeight)
        {
            transform.position = new Vector3(transform.position.x, halfScreenHeight);
        }
        else if (transform.position.y < -halfScreenHeight)
        {
            transform.position = new Vector3(transform.position.x, -halfScreenHeight);
        }
    }

    private void MoveHuman()
    {
        if (Input.GetKey(keyUp))
        {
            transform.position += new Vector3(0, moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(keyDown))
        {
            transform.position -= new Vector3(0, moveSpeed * Time.deltaTime);
        }
    }

    private void MoveAI()
    {
        if (ball.transform.position.y > transform.position.y)
        {
            transform.position += new Vector3(0, moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.position -= new Vector3(0, moveSpeed * Time.deltaTime);
        }
    }
}
