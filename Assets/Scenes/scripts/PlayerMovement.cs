using System.Runtime.CompilerServices;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField]private LayerMask groundLayer;
    [SerializeField] private LayerMask wallLayer;
    private Rigidbody2D body;
    private Animator anim;
        private BoxCollider2D boxCollider;
       

    }

private void Awake();
    {
    //grab references for rigidbody and animator from object
        body = GetComponent<Rigidbody2D>();
    Anim GetComponent<Animator>();
    BoxCollider = GetComponent<BoxCollider2D>();
    private float wallJumpCooldown;
    }

    private void Update()
    {
        float horizontalInput = Input GetAxis("Horizontal");
        body.linearVelocity = new Vector2(horizontalInput * speed, body.linearVelocity.y);

        //flip player when moving left-right
        if (horizontalInput > 0.01f)
            transform.localScale = Vector3.one;
        else if (horizontalInput < -0.01f)
            transform.localScale = new Vector3(-1, 1, 1);

   


    //set animator parameters
    Anim.SetBool("run", horizontalInput != 0);
        anim SetBool("grounded", isGrounded;
    if(wallJumpCooldown< 0.2f)
    {
        if (Input.GetKey(KeyCode.Space) && isGrounded)
            jump();

    }
}

private void jump()
    

{ 
      body.linearVelocity = new Vector2(body.linearVelocity.x, speed);
    Anim.SetIrigger("jump");
}

private void OncollisionEnter2D(Collision2D collision)
{
    
}

private bool isGrounded()
{
    RaycastHit2D raycastHit = Phisics2D.BoxCast(boxCollidor.bounds.center, BoxCollider.bounds.size, 0, Vector2.down, 0.1f, groundLayer);
    return raycastHit.collider != null ;
}\
private bool onWall()
{
    RaycastHit2D raycastHit = Phisics2D.BoxCast(boxCollidor.bounds.center, BoxCollider.bounds.size, 0, new Vector2 (transform.localScale.x,0),Vector2.down, 0.1f, wallLayer);
    return raycastHit.collider != null;
}