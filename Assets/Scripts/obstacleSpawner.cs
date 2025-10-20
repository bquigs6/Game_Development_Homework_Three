using UnityEngine;

public class obstacleSpawner : MonoBehaviour
{
    [SerializeField] float spawnRate = 5.0f;
    float lastSpawn = 0f;
    public GameObject spikes;
    [SerializeField] float minY = -1;
    [SerializeField] float maxY = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time - lastSpawn > spawnRate)
        {
            lastSpawn = Time.time;
            Instantiate(spikes, new Vector3(transform.position.x, transform.position.y + Random.Range(minY, maxY), 0), transform.rotation);
        }
    }
}
