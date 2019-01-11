using System.Collections;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    // Every enemy has a movement speed, attack damage, and an attack speed that can be set in game.
    public float MovementSpeed;
    public float Damage;
    public float AttackDuration;

    // Prevent enemies from attacking in quick succession by introducing a delay between attacks.
    private bool DamageDisabled;

    // For use with animator. We need to know what animation to play.
    private State currentState;
    private State newState;

    // Hold components on prefab
    private BoxCollider2D boxCollider;
    private Rigidbody2D rb2D;
    private Animator animator;

    // Our private instances of other classes.
    private BoardManager board;
    private EnemyHealth enemy;
    private TowerHealth tower;
    private SpawnEnemies spawn;

    // Other states need to be added here (Idle, Heavy Attack, Dying, Receiving Damage, etc.)
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

        board = BoardManager.GetInstance();
        enemy = EnemyHealth.GetInstance();
        tower = TowerHealth.GetInstance();
        spawn = SpawnEnemies.GetInstance();       
    }

    private void Update()
    {
        UpdateState();
        UpdateTransform();
    }

    // When enemy collides with one of these objects, adjust state and health appropriately.
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Tower"))
        {
            newState = State.Attacking;
        }
        if (col.gameObject.CompareTag("Axe"))
        {
            enemy.TakeDamage(board.axeDamage + (spawn.WaveNumber * 0.5f));
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
        tower.TakeDamage(Damage);
        StartCoroutine("DisableDamage");
    }

    private IEnumerator DisableDamage()
    {
        yield return new WaitForSeconds(AttackDuration);
        DamageDisabled = false;
    }
}
