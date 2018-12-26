using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float movementSpeed;
    private BoxCollider2D boxCollider;
    private Rigidbody2D rb2D;
    private float inverseMoveTime;
    private bool obstacles;
    private State currentState;
    private State newState;
    private Animator animator;

    enum State
    {
        Attacking,
        Moving
    }

    protected virtual void Start()
    {
        animator = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
        rb2D = GetComponent<Rigidbody2D>();
        inverseMoveTime = 1f / movementSpeed;
    }

    public void Update()
    {
        CheckState();
        UpdateTransform();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Tower"))
        {
            obstacles = true;
            //take damage to tower
            //do same for rocks or obstacles
            //switch state, and thus animation
        }
        else
        {
            obstacles = false;
        }
    }

    public void CheckState()
    {
        if (obstacles)
        {
            newState = State.Attacking;
        }
        else
        {
            newState = State.Moving;
        }

        if (currentState != newState)
        {
            animator.StopPlayback();
            animator.Play(newState.ToString());
            currentState = newState;
        }
        //check range to tower, change animation depending

    }

    public void UpdateTransform()
    {      
        if (currentState == State.Moving)
        {
            transform.Translate(Vector2.left * Time.deltaTime * movementSpeed, 0);
        }
    }
}
