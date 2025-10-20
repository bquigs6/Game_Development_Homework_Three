using UnityEngine;

public class fireSpawner : MonoBehaviour
{
    [SerializeField] float spawnRate = 5.0f;
    float lastSpawn = 0f;
    public GameObject fire;
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
            Instantiate(fire, new Vector3(transform.position.x, transform.position.y, 0), transform.rotation);
        }
    }
}
