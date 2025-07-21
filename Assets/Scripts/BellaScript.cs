using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    public Rigidbody2D rb;
    public float flapStrength;
    public LogicSCript logic;
    public bool birdIsAlive = true;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicSCript>();
        
    }

    // Update is called once per frame
    void Update()
    {
        // this will make Bella jump
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            rb.linearVelocity = Vector2.up * flapStrength;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        birdIsAlive = false;
    }
}
