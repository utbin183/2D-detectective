using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private LayerMask groundLayer;
    private Rigidbody2D body;
    private Animator anim;
    private BoxCollider2D boxCollider;
    private float horizontalInput;
   
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        if (horizontalInput > 0.01f)
            transform.localScale = new Vector3(3, 3, 3); 
        else if (horizontalInput < -0.01f)
            transform.localScale = new Vector3(-3, 3, 3); 

        anim.SetBool("Walk", horizontalInput != 0);
        body.linearVelocity = new Vector2(horizontalInput * speed, body.linearVelocity.y);
    }
    
}
