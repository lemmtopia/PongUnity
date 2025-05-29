using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // get a direciton
        int dirIndex = (int)Random.RandomRange(0, 3);
        Vector2[] directions =
        {
            new Vector2(1, 1),
            new Vector2(-1, 1),
            new Vector2(1, -1),
            new Vector2(-1, -1)
        };

        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = directions[dirIndex] * moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        rb.linearVelocity *= 1.005f;
    }
}
