using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour
{
    private InputSystem_Actions controls;
    public Rigidbody2D player;
    public scoringScript scorer;
    [SerializeField] private AudioClip sound;
    private AudioSource myAudio;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
        controls = new InputSystem_Actions();
        controls.Player.Jump.performed += Jump;
        controls.Enable();
    }

    void Jump(InputAction.CallbackContext ctx)
    {
        player.linearVelocityY = 5f;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle")) 
        {
            controls.Player.Jump.performed -= Jump;
            controls.Disable();
            SceneManager.LoadScene(0);
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        myAudio.PlayOneShot(sound);
        scorer.addScore();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -20)
        {
            SceneManager.LoadScene(0);
        }
    }
}
