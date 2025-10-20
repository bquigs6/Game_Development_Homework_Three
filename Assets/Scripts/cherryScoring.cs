using UnityEngine;

public class cherryScoring : MonoBehaviour
{
    public scoringScript scorer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //scorer.addScore();
        //add sound and then delete object?
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
