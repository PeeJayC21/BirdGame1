using JetBrains.Annotations;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{

    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0f;
    public float heightOffSet;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {   
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0f;
        }
    }

    // function that spawns the pipes
    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffSet;
        float highestPoint = transform.position.y + heightOffSet;
        Vector3 pipeHeightRange = new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), transform.position.z);
        Instantiate(pipe, pipeHeightRange, transform.rotation);
    }
    
}
