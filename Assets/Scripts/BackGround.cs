using UnityEngine;

public class BackGround : MonoBehaviour
{
    public BellaScript bellaScript;
    public float moveSpeed;
    private float width;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        bellaScript = GameObject.FindGameObjectWithTag("Pet").GetComponent<BellaScript>();
        width = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (!bellaScript.birdIsAlive) return;

        transform.position += moveSpeed * Time.deltaTime * Vector3.left;
        
        if (transform.position.x <= -width)
        {
            transform.position += Vector3.right * width * 2f;
        }
    }
    

}
