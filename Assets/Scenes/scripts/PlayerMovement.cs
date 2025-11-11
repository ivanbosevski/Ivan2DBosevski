using System.Numerics;
using System.Runtime.CompilerServices;
using Unity.VisualScripting.FullSerializer;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jumpPower;
    [SerializeField]private LayerMask groundLayer;
    [SerializeField] private LayerMask wallLayer;
    private Rigidbody2D body;
    private Animator anim;
        private BoxCollider2D boxCollider;
    private float wallJumpCooldown;
    private float horizontalInput; 

    }

void Awake();
    {
    //grab references for rigidbody and animator from object
    body = GetComponent<Rigidbody2D>();
    
   static Anim GetComponent<Animator>();
    anim BoxCollider = GetComponent<BoxCollider2D>();
    private float wallJumpCooldown;
    }

    void Update()
    {
        horizontalInput = Input GetAxis("Horizontal");
              body.linearVelocity = new Vector2(horizontalInput * speed, body.linearVelocity.y);

        //Flip player when moving left-right
        if (horizontalInput > 0.01f)
             transform.localScale = Vector3.one;
        else if (horizontalInput < -0.01f)
          transform.localScale = new Vector3(-1, 1, 1);

   


    //set animator parameters
    Anim.SetBool("run", horizontalInput != 0);
        anim SetBool("grounded", isGrounded;

    //Wall jump logic
    float wallJumpCooldown = 0;
    {
        body.velocity = new Vector2(horizontalInput * Speed, Body.velocity.y);
        if (onWall() && !isGrounded())
        {
            Body.gravityScale = 0;
            Body.velocity = Vector2.zero;

        }
        else
            Body.gravityScale = 7;

        if (Input.GetKey(KeyCode.Space))
            jump();
    }
    else
        wallJumpCooldown += Time.deltaTime;
    }

 void Jump()
    
{
    if (isGrounded())
    {
        Body.velocity = new Vector2(Body.velocity.x, jumpPower);
        Animation.SetTrigger("jump");
    }
    else if (onWall() && isGrounded()) ;
    {
        int horizontalInput = 0;
        {
            Body.velocity = new Vector2(-Mathf.Sign(Transform.localScale.x) * 10, 0);
            Transform.localScale = new Vector3(-Mathf.Sign(Transform.localScale.x), Transform.localScale.y, Transform.localScale.z);
        }
        else

            Body.velocity = new Vector2(-Mathf.Sign(Transform.localScale.x) * 3, 6);
        
       int  wallJumpCooldown = 0;
    }
}



 bool IsGrounded()
{
    RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollidor.bounds.center, BoxCollider.bounds.size, 0, Vector2.down, 0.1f, groundLayer);
    return raycastHit.collider != null ;
}
 bool OnWall()
{
    RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollidor.bounds.center, BoxCollider.bounds.size, 0, new Vector2 (transform.localScale.x,0),Vector2.down, 0.1f, wallLayer);
    return raycastHit.collider != null;
}

 bool CanAttack()
{
    int horizontalInput = 0;
    return horizontalInput == 0 && isGrounded() && !onWall();
}