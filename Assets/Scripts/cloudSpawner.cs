using UnityEngine;

public class cloudSpawner : MonoBehaviour
{
    [SerializeField] float spawnRate = 20.0f;
    float lastSpawn = 0f;
    public GameObject clouds;
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
            Instantiate(clouds, new Vector3(transform.position.x, transform.position.y, 0), transform.rotation);
        }
    }
}
