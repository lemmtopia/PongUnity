using UnityEngine;

public class PaddleController : MonoBehaviour
{
    [SerializeField] private bool isHuman;
    [SerializeField] KeyCode keyUp, keyDown;
    [SerializeField] float moveSpeed;

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
}
