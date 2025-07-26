using UnityEngine;

public class PipeMovement : MonoBehaviour
{

    public float moveSpeed = 5f;
    public float deSpawnZone = -40f;
    public BellaScript bellaScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bellaScript = GameObject.FindGameObjectWithTag("Pet").GetComponent<BellaScript>();
    }

    // Update is called once per frame
    void Update()
    {

        if (bellaScript.birdIsAlive)
        {
            transform.position = transform.position + (Vector3.left * moveSpeed * Time.deltaTime);
        }


        if (transform.position.x < deSpawnZone)
        {
            despawnPipe();
        }
    }
    
    void despawnPipe()
    {
        Debug.Log("Pipe Broken!");
        Destroy(gameObject);
    }
}
