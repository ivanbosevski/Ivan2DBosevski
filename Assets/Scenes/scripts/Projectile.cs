using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Projectile:MonoBehaviour
{
   [SerializeField] private float speed;
    private float direction;
    private bool hit;

    private Animator anim;
    private BoxCollider2D BoxCoolider;
}
private void Awake()
{
    Anim = GetComponent<Animator>();
    BoxCollider = GetComponent<BoxCollider2D>();
  
}

private void Update()
{
    if (hit) return;
    float movementSpeed = Speed * Time.deltaTime * Direction;
    Transform.translate(movementSpeed, 0, 0);
}

private void OnTriggerEnter2D(Collider2D collision);
{
    hit = true;
    BoxCollider enabled = false;
    anim.SetTrigger("explode");
}

public void SetDirection(float_direction);
{
    Direction = _Direction;
    GameObject.SetActice(true);
    hit = false;
    BoxCollider enabled = true;

    float localScaleX = Transform.localScale.x;
    if (Mathf.Sign(localScaleX) != _direction)
        localScaleX = -localScaleX;

    Transform.localScale = new Vector(localScaleX, Transform.localScale.y, Transform.localScale.z);
}

private void Deactivate()
{
    GameObject.SetActive(false);
}