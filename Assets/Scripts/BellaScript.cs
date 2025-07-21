using UnityEngine;

public class BellaScript : MonoBehaviour
{

    public Rigidbody2D rb;
    public float flapStrength;
    public LogicSCript logic;
    public bool birdIsAlive = true;
    private Vector3 petPos;
    private deadPets dead;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicSCript>();
        dead = GameObject.FindGameObjectWithTag("Pet").GetComponent<deadPets>();
    }

    // Update is called once per frame
    void Update()
    {
        // this updates the current position of the pet
        petPos = Camera.main.WorldToViewportPoint(transform.position);

        // this will make Bella jump
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            rb.linearVelocity = Vector2.up * flapStrength;
        }

        // games over if Bella is out of the screen
        if (petPos.y > 1.1 || petPos.y < -0.1)
        {
            logic.GameOver();
            birdIsAlive = false;
            dead.outOfBounds();
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        birdIsAlive = false;
        dead.hitPole();
    }
}
