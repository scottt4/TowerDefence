using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float movementSpeed;
    private BoxCollider2D boxCollider;
    private Rigidbody2D rb2D;
    private bool obstacles;
    private State currentState;
    private State newState;
    private Animator animator;
    public float Damage;
    public float Health;
    //public float shield;
    //public int attackRange = 0f;

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
            if (currentState == State.Attacking)
            {
                //TowerHealth.GetInstance().TakeDamage(Damage);
            }
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
            Debug.Log("Enemy Attacked for " + Damage + " damage");
            TowerHealth.GetInstance().TakeDamage(Damage);
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
    }

    public void UpdateTransform()
    {
        if (currentState == State.Moving)
        {
            transform.Translate(Vector2.left * Time.deltaTime * movementSpeed, 0);
        }
    }
}
