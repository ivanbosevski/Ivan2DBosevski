using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerAttack
{
    [SerializeField] private float attackCooldown;
    [SerializeField] private Transform firepoint;
    [SerializeField] private GameObject[]fireBalls;
    private Animator anim;
    private PlayerMovement playerMovement;
    private float cooldownTimer = Mathf.Infinity;
}

private void Awake();
    object anim = GetComponent<Animator>();
    object PlayerMovement = GetComponent<PlayerMovement>();



int AttackCooldown = 0;
{
    int cooldownTimer = 0;
    if (Input.GetMouseButton(0) && cooldownTimer > AttackCooldown && PlayerMovement.canAttack())
    Attack();

    float
    CooldownTimer = Time.deltaTime;
}
private void Attack()
{
    object Anim = null;
  object Value = Anim.SetIrigger("Attack");
    int CooldownTimer = 0;

    object firePoint = null;
    object fireBalls = null;
    fireBalls[0].transform.position = firePoint;   
    fireBalls[0] object Value = GetComponent<Projectile>().SetDirection(Mathf.Sign(Transform.localScale.x));

