using System.Collections;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float MovementSpeed;
    public float Damage;
    public float AttackDuration;

    private BoxCollider2D boxCollider;
    private Rigidbody2D rb2D;
    private State currentState;
    private State newState;
    private Animator animator;
    private bool DamageDisabled;

    private enum State
    {
        Attacking,
        Moving
    }

    private void Start()
    {
        animator = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
        rb2D = GetComponent<Rigidbody2D>();

        DamageDisabled = false;

        currentState = State.Moving;
        newState = currentState;
    }

    private void Update()
    {
        UpdateState();
        UpdateTransform();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Tower"))
        {
            newState = State.Attacking;
        }
    }

    private void UpdateState()
    {
        if (currentState == State.Attacking)
        {
            EnableDamage();
        }

        if (currentState != newState)
        {
            animator.StopPlayback();
            animator.Play(newState.ToString());
            currentState = newState;
        }
    }

    private void UpdateTransform()
    {
        if (currentState == State.Moving)
        {
            transform.Translate(Vector2.left * Time.deltaTime * MovementSpeed, 0);
        }
    }

    private void EnableDamage()
    {
        if (DamageDisabled == true) return;
        DamageDisabled = true;
        TowerHealth.GetInstance().TakeDamage(Damage);
        //Debug.Log("Enemy Attacked for " + Damage + " damage");
        StartCoroutine("DisableDamage");
    }

    private IEnumerator DisableDamage()
    {
        yield return new WaitForSeconds(AttackDuration);
        DamageDisabled = false;
    }
}
