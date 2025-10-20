using UnityEngine;

public class cherryMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
        if(transform.position.x < -12)
        {
            Destroy(gameObject);
        }
    }
}
